namespace FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> calculateDiscount = price =>
            {
                if (price > 1000)
                {
                    return price * 0.15;
                }
                else
                {
                    return price * 0.05;
                }
            };

            Func<double, double, double> calculateFinalPrice = (price, discount) =>
            {
                return price - discount;
            };

            Console.WriteLine("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double discount = calculateDiscount(price);
            double finalPrice = calculateFinalPrice(price, discount);

            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Final Price: {finalPrice}");

        }
    }
}
