namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(), out int input);
            bool reversed = false;
            int output = 0;

            while (input > 0)
            {
                if (output == 0) 
                {
                    output = input % 10;
                }
                else
                {
                    output *= 10;
                    output += input % 10;
                }
                
                input = input / 10;
            }
            Console.WriteLine($"Reverse is {output}.");
        }
    }
}
