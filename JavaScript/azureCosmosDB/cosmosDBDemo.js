const { CosmosClient } = require('@azure/cosmos');

const endpoint = '';
const key = '';

const databaseName = 'movieWorld';
const containerName = `movies`;
const partitionKeyPath = ['/categoryId']

const cosmosClient = new CosmosClient({ endpoint, key });

const movie = {
    "title": "A Walk to Remember",
    "genre": {
      "name": "Romantic"
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


cosmoDemo();

async function main() {
    // Add a document
    const addedMovie = await addMovie(movie);
    console.log('Added movie:', addedMovie);
}

main().catch((error) => {
    console.error(error);
    process.exit(1);
  });