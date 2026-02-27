namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            int final = 1;
            for (int i = number; i > 0; i--)
            {
                final *= i;
            }

            Console.WriteLine($"Factorial of {number} is {final}");
        }
    }
}
