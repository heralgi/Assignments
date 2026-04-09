using System.Text.Json;
using System.Collections;

namespace AccountSerialAndDeserialization
{
    internal class Program
    {
        static List<Account> account = new List<Account>();
        static string filePath = "./accounts.txt";
        static void Main(string[] args)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach(string line in lines)
                {
                    Account acc = JsonSerializer.Deserialize<Account>(line);
                    account.Add(acc);
                }
            }
            while (true)
            {
                Console.WriteLine("1.Create an Account.\n2.View Balance.\n3.Deposite.\n4.Withdraw.\n5.Exit.");
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        Console.WriteLine(account.Count);
                        CreateAccount();
                    } else if (choice == 2)
                    {
                        ViewBalance();
                    } else if (choice == 3)
                    {
                        Deposite();
                    } else if (choice == 4)
                    {
                        WithDraw();
                    } else if (choice == 5)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        static void CreateAccount()
        {
             Console.WriteLine("Enter Name :");
             string name = Console.ReadLine();
             if (name == null)
             {
                 return;
             }

             Console.WriteLine("Enter Initial Balance :");
             int.TryParse(Console.ReadLine(), out int balance);
             if (balance == null)
             {
                 return;
             }

             Console.WriteLine("Enter Tpye :");
             string type = Console.ReadLine();
             if(type == null)
             {
                 return;
             }
             Account acc = new Account(name, balance, type);
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath,$"{JsonSerializer.Serialize(acc)}\n");
            }
             account.Add(acc);
        }
        static void ViewBalance()
        {
            if(account.Count == 0)
            {
                Console.WriteLine("\nNo Accounts to dispaly.");
                return;
            }
            Console.WriteLine("Choose Account:");
            for (int i=0; i<account.Count; i++)
            {
                Console.WriteLine($"{i+1}.{account[i].Name}.");
            }
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine($"Balance is {JsonSerializer.Serialize(account[choice - 1])}");
            }
        }
        static void Deposite()
        {
            if (account.Count == 0)
            {
                Console.WriteLine("\nNo Accounts.");
                return;
            }
            Console.WriteLine("Choose Account:");
            for (int i = 0; i < account.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{account[i].Name}.");
            }
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Enter Amount to Deposite: ");
                if(int.TryParse(Console.ReadLine(),out int amount))
                {
                    account[choice - 1].Balance += amount;
                }
            }
        }
        static void WithDraw()
        {
            if (account.Count == 0)
            {
                Console.WriteLine("\nNo Accounts.");
                return;
            }
            Console.WriteLine("Choose Account:");
            for (int i = 0; i < account.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{account[i].Name}.");
            }
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Enter Amount to Withdraw: ");
                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    account[choice - 1].Balance -= amount;
                }
            }
        }
    }
}
