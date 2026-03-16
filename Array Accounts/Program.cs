namespace Array_Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[5];
            int choice;

            do
            {
                Console.WriteLine("Available Accounts:");
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i] != null)
                        Console.WriteLine("Account Number: " + accounts[i].GetAccountNumber() + ", Name: " + accounts[i].GetName());
                }
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

                        for (int i = 0;i < accounts.Length; i++)
                        {
                            if (accounts[i] == null)
                            {
                                Account account = new Account(name, balance, type);
                                accounts[i] = account;
                                Console.WriteLine("Account created successfully.");
                                Console.WriteLine("Account Number: " + account.GetAccountNumber());
                                break;
                            }
                            if(i >= 4) {
                                Console.WriteLine("Reached Account Limits.");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Choose Account: ");
                        int index = 1;
                        foreach (var account in accounts)
                        {
                            if (account != null)
                                Console.WriteLine($"{index}. {account.GetAccountNumber()}");
                            index++;
                        }
                        int.TryParse(Console.ReadLine(), out int choice1);
                        if(choice != null && (choice1 < 5 && choice1 > 0))
                        {
                            Console.WriteLine($"Balance: {accounts[choice1 - 1].GetBalance()}");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Choose Account: ");
                        int index1 = 1;
                        foreach (var account in accounts)
                        {
                            if (account != null)
                                Console.WriteLine($"{index1}. {account.GetAccountNumber()}");
                            index1++;
                        }
                        int.TryParse(Console.ReadLine(), out int choice2);
                        if (choice2 != null && (choice2 < 5 && choice2 > 0))
                        {
                            Console.Write("Enter amount to deposit: ");
                            double dep = Convert.ToDouble(Console.ReadLine());
                            accounts[choice2 - 1].Deposit(dep);
                        }

                        break;

                    case 4:
                        Console.WriteLine("Choose Account: ");
                        int index2 = 1;
                        foreach (var account in accounts)
                        {
                            if (account != null)
                                Console.WriteLine($"{index2}. {account.GetAccountNumber()}");
                            index2++;
                        }
                        int.TryParse(Console.ReadLine(), out int choice3);
                        if (choice3 != null && (choice3 < 5 && choice3 > 0))
                        {
                            Console.Write("Enter amount to deposit: ");
                            double dep = Convert.ToDouble(Console.ReadLine());
                            accounts[choice3 - 1].Withdraw(dep);
                        }
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
