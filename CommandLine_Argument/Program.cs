namespace CommandLine_Argument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (string arg in args)
            {
                int.TryParse(arg, out int value);
                sum += value;
                if (max < value)
                {
                    max = value;
                }
                if(min > value)
                {
                    min = value;
                }
            }

            int avg = sum / args.Length;
            
            Console.WriteLine("{0,-22}: {1}","Count of Arguments", args.Length);
            Console.WriteLine("{0,-22}: {1}", "Sum of Arguments", sum);
            Console.WriteLine("{0,-22}: {1}", "Average of Arguments",avg);
            Console.WriteLine("{0,-22}: {1}", "Max of Arguments", max);
            Console.WriteLine("{0,-22}: {1}", "Min of Arguments", min);
        }
    }
}
