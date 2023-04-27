using System;
public class FileHandler
{
    const string filename = @"D:\ChamathGit\Bootcamp\Dotnet\PredictNumber\HighScores.csv";

    public void RecordPlayerScore(int numberOfAttempts)
    {
        Console.WriteLine("Please enter your name for heigh score table: ");
        string name = Console.ReadLine();

        string csvLine = numberOfAttempts + ";"+ name + System.Environment.NewLine;
        File.AppendAllText(filename, csvLine);
    }

    public void DisplayHighScoreList()
    {
        

        string[] lines = File.ReadAllLines(filename);
        Array.Sort(lines);

        int counter = 1;
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            int numberOfGuess = int.Parse(parts[0]);
            string playerName = parts[1];

            Console.WriteLine($"Position {counter}: {playerName}, number of guesses: {numberOfGuess}.");
            counter++;
        }
    }
}