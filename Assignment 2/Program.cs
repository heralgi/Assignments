namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            int length = input.Length;
            double final = 0;
            for (int i = 0; i < length; i++)
            {
                double curr = (int)Math.Pow((double)char.GetNumericValue(input[i]), (double)length);
                final += curr;
            }
            if (final == Convert.ToInt32(input))
            {
                Console.WriteLine($"{final} is Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{final} is not Armstrong number.");
            }
        }
    }
}
