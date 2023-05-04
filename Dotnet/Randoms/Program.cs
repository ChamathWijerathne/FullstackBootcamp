// See https://aka.ms/new-console-template for more information
int[] myArray = new int[15];
Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(50);
}

foreach(int number in myArray)
{
    Console.WriteLine(number);
}