using System;
using System.Collections.Generic;
using System.Text;

namespace POCCollecionAndPolymorphism
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double TotalSalary { get; set; }

        public Employee() { }
        public Employee(int id, string name, double basicSalary)
        {
            Id = id;
            Name = name;
            BasicSalary = basicSalary;
            TotalSalary = BasicSalary;
        }

        public void ReadDetails()
        {
            Console.WriteLine("Enter Tester Employee details:\nId");
            int.TryParse(Console.ReadLine(), out int id);
            if (id == null)
            {
                Console.WriteLine("Invalid ID.");
                return;
            }
            this.Id = id;

            Console.WriteLine("\nName");
            string name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Invalid name.");
                return;
            }
            this.Name = name;

            Console.WriteLine("\nBasic Salary.");
            int.TryParse(Console.ReadLine(), out int bSalary);
            if (bSalary == null)
            {
                Console.WriteLine("Invalid Salary.");
                return;
            }
            this.BasicSalary = bSalary;
        }

        public abstract double CalculateMonthly();
        public abstract void Display();

    }
}
