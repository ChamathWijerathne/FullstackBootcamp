class Program
{
    private static void Main(string[] args)
    {
        // select the randoom number
        var random = new Random();
        var number = random.Next(1,20);
        Console.WriteLine(number);

        // player has 3 attempts
        for(var i = 0; i < 3; i++) 
        {
            Console.Write(string.Format("Prediction Attempt {0}: ", i + 1));
            var input = int.Parse(Console.ReadLine());

            // check the guess
            if(number == input)
            {
                Console.WriteLine("You Won!");
                return;
            }
            else if(number > input)
                Console.WriteLine("The number is grater than {0}.", input);
            else
                Console.WriteLine("The number is less than {0}.", input);
        }
        Console.WriteLine("You Lost!");
    }
}