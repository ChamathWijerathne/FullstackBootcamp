const fs = require('fs');

// file path
const filePath = 'D:/Bootcamp/JavaScript/node.txt';

// read the content
fs.readFile(filePath, 'utf8', (err, text) => {
  if (err) {
    console.error(err);
    return;
  }
  
  // display the content of the file
  console.log(text);
});