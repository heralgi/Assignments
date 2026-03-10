namespace Planet_Gravity_Enum
{
    enum Planet
    {
        MERCURY,
        VENUS,
        EARTH,
        MARS,
        JUPITER,
        SATURN,
        URANUS,
        NEPTUNE
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight on Earth (kg): ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nWeight on different planets:");

            foreach (Planet planet in Enum.GetValues(typeof(Planet)))
            {
                double gravity = GetGravity(planet);
                double weightOnPlanet = earthWeight * gravity;

                Console.WriteLine($"{planet}: {weightOnPlanet:F2} kg");
            }
        }

        static double GetGravity(Planet planet)
        {
            switch (planet)
            {
                case Planet.MERCURY: return 0.38;
                case Planet.VENUS: return 0.91;
                case Planet.EARTH: return 1.0;
                case Planet.MARS: return 0.38;
                case Planet.JUPITER: return 2.34;
                case Planet.SATURN: return 1.06;
                case Planet.URANUS: return 0.92;
                case Planet.NEPTUNE: return 1.19;
                default: return 1.0;
            }
        }
    }
}
