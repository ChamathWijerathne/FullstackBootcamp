const readline = require('readline');
const programeConsole = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const secretNumber = Math.floor(Math.random() * 20 +1);
console.log(secretNumber);
let guessCount = 0;

function askUserForGuess() {
  programeConsole.question('Guess a number between 1 and 20: ', (answer) => {
    const guess = parseInt(answer);
    if (isNaN(guess)) {
      console.log('Please enter a valid number.');
      askUserForGuess();
    } else {
      guessCount++;
      if (guess === secretNumber) {
        console.log('You Won!');
        programeConsole.close();
      } else if (guessCount >= 3){
        console.log('You lost!');
        programeConsole.close();
      }else if (guess < secretNumber) {
        console.log(`The number is grater than "${guess}".`);
        askUserForGuess();
      } else {
        console.log(`The number is less than "${guess}".`);
        askUserForGuess();
      }
    }
  });
}

askUserForGuess();
