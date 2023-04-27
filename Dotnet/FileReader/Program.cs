StreamReader reader = new StreamReader("file.txt");

// Read each line of the file and calculate the total
string line;
int count = 0;
while ((line = reader.ReadLine()) != null)
{
    count += int.Parse(line);
}

// Close the file
reader.Close();

Console.WriteLine(count);
