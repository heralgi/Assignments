namespace InOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In Out Params Example
            float salary, hra, tax;
            string category;

            float salaryInHand = outParamDemo("John Doe", out hra, out tax, 60000f, out category);
            Console.WriteLine($"John Doe, hra {hra}, tax {tax}, category {category}, salary in hand {salaryInHand}");

            salaryInHand = outParamDemo("John Doe", out hra, out tax, 0f, out category);
            Console.WriteLine($"John Doe, hra {hra}, tax {tax}, category {category}, salary in hand {salaryInHand}");

            // TryParse Example
            Console.WriteLine();
            string input = "123";
            int number;

            bool success = int.TryParse(input, out number);

            if (success)
                Console.WriteLine("Converted value: " + number);
            else
                Console.WriteLine("Invalid number");

            // Params Example
            Console.WriteLine();
            Console.WriteLine(AddNumbers(10, 20));
            Console.WriteLine(AddNumbers(10, 20, 30));
            Console.WriteLine(AddNumbers(10, 20, 30, 40));

            // Params in Console.WriteLine
            string name = "Murugesh";
            int age = 22;

            Console.WriteLine("\nName: {0}, Age: {1}", name, age);
        }

        public static float outParamDemo(in string name, out float hra, out float tax, float salary, out string category)
        {
            if (salary > 0)
            {
                hra = salary * 0.1f;
                if (salary >= 50000f)
                {
                    tax = salary * 0.2f;
                    category = "Manager";
                    return (salary - tax - hra);
                }
                category = "Staff";
                tax = salary * 0.1f;
                return (salary - tax - hra);
            }

            category = "Invalid";
            hra = 0;
            tax = 0;
            return salary;
        }

        static int AddNumbers(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
                sum += n;

            return sum;
        }
    }
}
