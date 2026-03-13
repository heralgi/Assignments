namespace BankGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // Create two accounts with random starting balances
            BankAccount acc1 = new BankAccount("Player1", rand.Next(1000, 5000));
            BankAccount acc2 = new BankAccount("Player2", rand.Next(1000, 5000));

            Console.WriteLine("Starting Balances:");
            Console.WriteLine($"{acc1.AccountHolder}: {acc1.Balance}");
            Console.WriteLine($"{acc2.AccountHolder}: {acc2.Balance}");

            // 3 rounds
            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"\n--- Round {round} ---");

                PlayTurn(acc1);
                PlayTurn(acc2);
            }

            Console.WriteLine("\nFinal Balances:");
            Console.WriteLine($"{acc1.AccountHolder}: {acc1.Balance}");
            Console.WriteLine($"{acc2.AccountHolder}: {acc2.Balance}");

            // Winner
            if (acc1.Balance > acc2.Balance)
                Console.WriteLine($"Winner: {acc1.AccountHolder}");
            else if (acc2.Balance > acc1.Balance)
                Console.WriteLine($"Winner: {acc2.AccountHolder}");
            else
                Console.WriteLine("It's a tie!");
        }
        static void PlayTurn(BankAccount account)
        {
            Console.WriteLine($"\n{account.AccountHolder}'s Turn");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (choice == 1)
                account.Deposit(amount);
            else if (choice == 2)
                account.Withdraw(amount);
            else
                Console.WriteLine("Invalid choice.");
        }
    }
}
