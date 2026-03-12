namespace Array_Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = null;
            int choice;

            do
            {
                Console.WriteLine("\n----- BANK MENU -----");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Name: ");
                        string? name = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Account Type (Savings/Current): ");
                        string? type = Console.ReadLine();

                        acc = new Account(name, balance, type);

                        Console.WriteLine("Account created successfully.");
                        Console.WriteLine("Account Number: " + acc.GetAccountNumber());
                        break;

                    case 2:
                        if (acc != null)
                            Console.WriteLine("Balance: " + acc.GetBalance());
                        else
                            Console.WriteLine("Create account first.");
                        break;

                    case 3:
                        if (acc != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            double dep = Convert.ToDouble(Console.ReadLine());
                            acc.Deposit(dep);
                        }
                        else
                            Console.WriteLine("Create account first.");
                        break;

                    case 4:
                        if (acc != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            double wd = Convert.ToDouble(Console.ReadLine());
                            acc.Withdraw(wd);
                        }
                        else
                            Console.WriteLine("Create account first.");
                        break;

                    case 5:
                        Console.WriteLine("Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
