using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Accounts
{
    internal class Account
    {
        private string accountNumber;
        private string name;
        private double balance;
        private string accountType;

        // Constructor
        public Account(string name, double balance, string accountType)
        {
            this.accountNumber = GenerateAccountNumber();
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;
        }

        // Random Account Number Generator
        private string GenerateAccountNumber()
        {
            Random r = new Random();
            long number = r.NextInt64(1000000000, 9999999999);
            return "IDBI" + number;
        }

        // Getters
        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetName()
        {
            return name;
        }

        public double GetBalance()
        {
            return balance;
        }

        public string GetAccountType()
        {
            return accountType;
        }

        // Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAccountType(string type)
        {
            this.accountType = type;
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if ((balance - amount) >= 500)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Minimum balance of 500 must be maintained.");
            }
        }
    }
}
