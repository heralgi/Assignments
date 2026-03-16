namespace PIG_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int totalScore = 0;
            int turnCount = 0;

            while (totalScore < 20)
            {
                turnCount++;
                int turnScore = 0;
                bool turnOver = false;

                Console.WriteLine($"\n--- Turn {turnCount} ---");

                while (!turnOver)
                {
                    Console.WriteLine("Press R to Roll or H to Hold:");
                    char choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                    if (choice == 'R')
                    {
                        int roll = dice.Next(1, 7);
                        Console.WriteLine("You rolled: " + roll);

                        if (roll == 1)
                        {
                            Console.WriteLine("Rolled a 1! Turn over. No points earned.");
                            turnScore = 0;
                            turnOver = true;
                        }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine("Turn Score: " + turnScore);
                        }
                    }
                    else if (choice == 'H')
                    {
                        totalScore += turnScore;
                        Console.WriteLine("You held.");
                        Console.WriteLine("Total Score: " + totalScore);
                        turnOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
            }

            Console.WriteLine("\nYou reached 20 points!");
            Console.WriteLine("Total Turns Taken: " + turnCount);
        }
    }
}
