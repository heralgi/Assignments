namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int length = input.Length;
            Console.WriteLine(length);
            string output = "";

            for (int i = length-1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine($"Reverse of {input} is {output}.");
        }
    }
}
