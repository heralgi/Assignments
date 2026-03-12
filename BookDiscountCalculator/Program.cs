namespace BookDiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is this a Bestseller? (true/false): ");
            bool isBestseller = Convert.ToBoolean(Console.ReadLine());

            Book book = new Book(title, author, price, isBestseller);

            double discountedPrice = book.CalculateDiscountedPrice();

            Console.WriteLine("\nBook Details");
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Original Price: " + book.Price);
            Console.WriteLine("Discounted Price: " + discountedPrice);
        }
    }
}
