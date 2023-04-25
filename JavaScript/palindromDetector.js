const readline = require('readline');

const programeConsole = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function isPalindrome(inputString) {
  inputString = inputString.toLowerCase();
  
  return inputString === inputString.split('').reverse().join('');
}

programeConsole.question('Enter a word to check: ', (input) => {
  if (isPalindrome(input)) {
    console.log(`"${input}" is a palindrome word.`);
  } else {
    console.log(`"${input}" is not a palindrome word.`);
  }
  
  programeConsole.close();
});
