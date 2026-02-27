namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine($"{number} is a prime number.");
                return;
            }

            for (int i = 2; i < number; i++)
            {
                if( number % i == 0)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                    return;
                }
            }
            Console.WriteLine($"{number} is a prime number.");
        }
    }
}
