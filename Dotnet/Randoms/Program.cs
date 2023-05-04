// See https://aka.ms/new-console-template for more information
int[] randoms = new int[15];
Random random = new Random();
for (int i = 0; i < randoms.Length; i++)
{
    randoms[i] = random.Next(50);
}

Array.Sort(randoms);

foreach (int number in randoms)
{
    if (number > 20)
    {
        Console.Write(number + " ");
    }
}
Console.WriteLine();

Console.WriteLine("---------From LINQ---------");

IEnumerable<int> myQuery = from number in randoms where number > 20 select number;

foreach(int number in myQuery)
    Console.Write(number + " ");