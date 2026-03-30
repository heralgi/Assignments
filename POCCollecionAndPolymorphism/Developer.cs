using System;
using System.Collections.Generic;
using System.Text;

namespace POCCollecionAndPolymorphism
{
    internal class Developer: Employee
    {
        double PA = 0.4;

        public Developer() { }

        public override double CalculateMonthly()
        {
            return BasicSalary + (BasicSalary * PA);
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
