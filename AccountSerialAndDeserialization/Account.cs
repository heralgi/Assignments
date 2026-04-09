using System;
using System.Collections.Generic;
using System.Text;

namespace AccountSerialAndDeserialization
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }

        public Account(string name, int balance, string type)
        {
            Name = name;
            Balance = balance;
            Type = type;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void WithDraw(int amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount.");
            }
        }
    }
}
