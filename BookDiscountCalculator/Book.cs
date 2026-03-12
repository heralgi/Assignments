using System;
using System.Collections.Generic;
using System.Text;

namespace BookDiscountCalculator
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestseller { get; set; }

        public Book(string title, string author, double price, bool isBestseller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestseller = isBestseller;
        }

        public double CalculateDiscountedPrice()
        {
            double finalPrice = Price;

            // 10% discount for bestseller
            if (IsBestseller)
            {
                finalPrice -= finalPrice * 0.10;
            }

            // Additional 5% discount if price > 500
            if (Price > 500)
            {
                finalPrice -= finalPrice * 0.05;
            }

            return finalPrice;
        }
    }
}
