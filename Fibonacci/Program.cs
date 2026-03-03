namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 8 Fibonacci numbers.");
            int Fibonacci = 1;
            int temp = 0;

            Console.WriteLine(0);
            while (Fibonacci <= 13)
            {
                Fibonacci += temp;
                Console.WriteLine(Fibonacci);
                temp = Fibonacci;
            }
        }
    }
}
