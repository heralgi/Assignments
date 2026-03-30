namespace POCCollecionAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.POC of Dictionary, HashSet and List.\n2.Employee (Polymorphism).");
            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {
                    POCCollection();
                }
                else if (choice == 2)
                {
                    EmployeeHandler();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void POCCollection()
        {
            List<string> names = new List<string>();

            // Add items
            names.Add("Murgesh");
            names.Add("Ravi");
            names.Add("Murgesh"); // Duplicate allowed

            // Iterate
            Console.WriteLine("List:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            HashSet<string> uniqueNames = new HashSet<string>();

            uniqueNames.Add("Kiran");
            uniqueNames.Add("Ravi");
            uniqueNames.Add("Kiran");

            Console.WriteLine("HashSet:");
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }

            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Add key-value pairs
            employees.Add(1, "Karthik");
            employees.Add(2, "Ravi");

            // Access value using key
            Console.WriteLine("Employee with ID 1: " + employees[1]);

            // Iterate
            Console.WriteLine("Dictionary:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
            }


        }

        static void EmployeeHandler()
        {
            Console.WriteLine("Choose Employee Type:\n1.Manager\n2.Developer\n3.Tester");
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    Manager manager = new Manager();
                    manager.ReadDetails();
                    manager.Display();
                    break;
                case 2:
                    Developer developer = new Developer();
                    developer.ReadDetails();
                    developer.Display();
                    break;
                case 3:
                    Employee tester = new Tester();
                    tester.ReadDetails();
                    tester.Display();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
