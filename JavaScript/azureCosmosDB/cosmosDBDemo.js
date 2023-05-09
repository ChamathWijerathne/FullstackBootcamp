const { CosmosClient } = require('@azure/cosmos');

const endpoint = ' https://fullstackbootcamp.documents.azure.com:443/';
const key = '';

const databaseName = 'movieWorld';
const containerName = `movies`;
const partitionKeyPath = ['/categoryId']

const cosmosClient = new CosmosClient({ endpoint, key });

const movie = {
    "title": "The Hangover part III",
    "genre": {
      "name": "Comedy"
    },
    "dailyRentalRate": 60,
    "numberInStock": 100
  };

// Creates a database if doesn't exist
async function cosmoDemo() {
    const { database } = await cosmosClient.databases.createIfNotExists({ id: databaseName });
    console.log(`${database.id} database ready`);
    const { container } = await database.containers.createIfNotExists({
        id: containerName,
        partitionKey: {
            paths: partitionKeyPath
        }
    });
        console.log(`${container.id} container ready`);
}

async function addMovie(movie) {
    const container = cosmosClient.database(databaseName).container(containerName);
    const { resource } = await container.items.create(movie);
    return resource;
  }

  async function getMovie(id) {
    const container = cosmosClient.database(databaseName).container(containerName);
    const { resource } = await container.item(id).read();
    return resource;
  }

  async function getAllMovies() {
    const querySpec = {
        query: "select * from movies"
    };
    const container = cosmosClient.database(databaseName).container(containerName);
    const { resources } = await container.items.query(querySpec).fetchAll();
    return resources;
  }

  async function deleteMovie(id) {
    const container = cosmosClient.database(databaseName).container(containerName);
    const { statusCode } = await container.item(id).delete();
    console.log(`${statusCode==204 ? `Item deleted` : `Item not deleted`}`);
  }


cosmoDemo();

async function main() {
    
    const addedMovie = await addMovie(movie);
    const movieList = await getAllMovies();
    const movieDetails = await getMovie(addedMovie.id);
    console.log('Added movie:', addedMovie);
    console.log('Movie Details:', movieDetails);
    console.log('Movie list: ', movieList)
    deleteMovie('b43e67cf-6047-4a96-b241-7e0adab01c92');
}

main().catch((error) => {
    console.error(error);
    process.exit(1);
  });
