const { BlobServiceClient, StorageSharedKeyCredential } = require("@azure/storage-blob");
const fs = require('fs');

// Enter your storage account name and shared key
const account = 'fullstack2023';
const accountKey = '';
const containerName = 'saranen';
const blobName = 'Chamath';
const filePath = 'D:/ChamathGit/Bootcamp/JavaScript/AzureBlobUplode/uploadFile.txt';


// Use StorageSharedKeyCredential with storage account and account key
// StorageSharedKeyCredential is only available in Node.js runtime, not in browsers
const sharedKeyCredential = new StorageSharedKeyCredential(account, accountKey);
const blobServiceClient = new BlobServiceClient(
    `https://${account}.blob.core.windows.net`,
    sharedKeyCredential
);

const containerClient = blobServiceClient.getContainerClient(containerName);

// Create a new block blob
const blockBlobClient = containerClient.getBlockBlobClient(blobName);

// Upload the blob from a local file
// const fileStream = fs.createReadStream(filePath);
// const result = blockBlobClient.uploadStream(fileStream);

// console.log(`Blob "${blobName}" has been uploaded to container "${containerName}".`);
// console.log(`ETag: ${result.etag}`);

//Get a List of blobs from a container
async function listBlobs() {
let i = 1;
  for await (const blob of containerClient.listBlobsFlat()) {
    console.log(`${i++}: ${blob.name}`);
  }
}

//listBlobs();

async function downloadBlob() {
const blobClient = containerClient.getBlobClient(blobName);

const localFilePath = 'D:/ChamathGit/Bootcamp/JavaScript/AzureBlobUplode';
await blobClient.downloadToFile(localFilePath);
}

downloadBlob();