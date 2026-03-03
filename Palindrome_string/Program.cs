namespace Palindrome_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check Palindrome.");
            string? input = Console.ReadLine();

            if(input == null)
            {
                Console.WriteLine("Invalid number.");
            }
            if(input.Length == 1)
            {
                Console.WriteLine($"{input} is a Palindrome.");
            }
            if(input.Length % 2 == 0)
            {
                Console.WriteLine($"{input} is not a Palindrome.");
                return;
            }
            else
            {
                int mid = input.Length / 2;
                for (int i = mid, j = mid; i > 0; i--, j++)
                {
                    if (input[i-1] != input[j + 1])
                    {
                        Console.WriteLine($"{input} is not a Palindrome.");
                        return;
                    }
                }
                Console.WriteLine($"{input} is a Palindrome.");
            }
        }
    }
}
