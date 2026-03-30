using System;
using System.Collections.Generic;
using System.Text;

namespace POCCollecionAndPolymorphism
{
    internal class Manager: Employee
    {
        double TA = 0.5;
        double DA = 0.4;

        public override double CalculateMonthly()
        {
            return BasicSalary + (BasicSalary * TA) + (BasicSalary * DA);
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
