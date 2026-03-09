namespace Functions_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fees = { 4000, 5000, 6000, 7000, 11000 };
            int[] DiscountedFess = Program.GetDiscountedFees(fees);


            for (int i = 0; i < DiscountedFess.Length; i++)
            {
                Console.WriteLine(DiscountedFess[i]);
            }
        }
        static int[] GetDiscountedFees(int[] fees)
        {

            int[] DiscountFees = new int[fees.Length];

            for (int i = 0; i < fees.Length; i++)
            {
                if (fees[i] < 5000)
                {
                    Console.WriteLine("Student id: {0} is Paying below 5000.", i);
                }
                if (fees[i] > 10000)
                {
                    Console.WriteLine("Student id: {0} is Paying above 10000.", i);
                }
                else if (fees[i] >= 7000)
                {
                    DiscountFees[i] = fees[i];
                }
            }
            return DiscountFees;
        }
    }
}
