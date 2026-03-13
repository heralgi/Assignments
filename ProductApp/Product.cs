using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        // Constructor
        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        // Method to calculate price after discount
        public double GetPriceAfterDiscount()
        {
            double discountAmount = Price * DiscountPercentage / 100;
            return Price - discountAmount;
        }

        // Method to display details
        public void Display()
        {
            Console.WriteLine($"Product Id: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Actual Price: {Price}");
            Console.WriteLine($"Discount %: {DiscountPercentage}");
            Console.WriteLine($"Price After Discount: {GetPriceAfterDiscount()}");
            Console.WriteLine("-----------------------------");
        }
    }
}
