namespace For_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string my_name = "MURUGESH";

            Console.WriteLine("Printing using for loop.");
            for(int i = 0; i < my_name.Length; i++)
            {
                Console.Write(my_name[i]);
            }

            Console.WriteLine("\nPrinting using While loop.");
            int count = 0;
            while (true)
            {
                if (count == my_name.Length) break;
                Console.Write(my_name[count]);
                count++;
            }
        }
    }
}
