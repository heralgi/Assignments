namespace For_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Colors = {"Red", "Green", "Blue", "Yellow", "Pink" };

            Console.WriteLine("Printing using for loop.");
            for (int i = 0; i < Colors.Length; i++)
            {
                Console.WriteLine(Colors[i]);
            }

            Console.WriteLine("Printing using foreach loop.");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
