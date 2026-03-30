using System;
using System.Collections.Generic;
using System.Text;

namespace POCCollecionAndPolymorphism
{
    internal class Tester: Employee
    {
        double Perks = 0.3;

        public Tester() : base() { }

        public override double CalculateMonthly()
        {
            return BasicSalary + (BasicSalary * Perks);
        }
        public override void Display()
        {
            Console.WriteLine("Employee details:");
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Monthly Salary: {CalculateMonthly()}");
            Console.WriteLine($"Employee CTC: {CalculateMonthly() * 12}");
        }
    }
}
