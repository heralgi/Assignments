using System;
using System.Collections.Generic;
using System.Text;

namespace BankGame
{
    internal class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        // Constructor
        public BankAccount(string holder, double balance)
        {
            AccountHolder = holder;
            Balance = balance;
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{AccountHolder} deposited {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine($"{AccountHolder} cannot withdraw {amount}. Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{AccountHolder} withdrew {amount}. New Balance: {Balance}");
            }
        }
    }
}
