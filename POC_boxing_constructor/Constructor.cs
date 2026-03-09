using System;
using System.Collections.Generic;
using System.Text;

namespace POC_boxing_constructor
{
    using System;

    class Person
    {
        public string Name;
        public double Height; // meters
        public double Weight; // kg

        // Constructor 1 (default)
        public Person() : this("Unknown", 0, 0)
        {
        }

        // Constructor 2 (name only)
        public Person(string name) : this(name, 0, 0)
        {
        }

        // Constructor 3 (full constructor)
        public Person(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public double CalculateBMI()
        {
            if (Height == 0) return 0;
            return Weight / (Height * Height);
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"BMI: {CalculateBMI():F2}");
            Console.WriteLine();
        }
    }
}
