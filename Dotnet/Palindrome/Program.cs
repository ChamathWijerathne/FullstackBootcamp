class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a word to check: ");
        char[] input = (Console.ReadLine()).ToCharArray();
        var word = new String(input);
        Array.Reverse(input);
        String reversedWord = new String(input);
        Console.WriteLine();
        if(word.Equals(reversedWord))
            Console.WriteLine("{0} is a palindrome word.", word);
        else
            Console.WriteLine("{0} is not a palindrome word.", word);
    }
}