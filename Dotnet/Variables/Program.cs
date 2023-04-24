internal partial class Program
{
    private static void Main(string[] args)
    {
        var number = 123;
        var message = "Hello!";
        var numbers = new List<int> {1, 2, 3, 4};
        numbers.Add(5);
        //numbers.Remove(1);
        Console.WriteLine(number);
        Console.WriteLine(message);
        foreach(var i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}