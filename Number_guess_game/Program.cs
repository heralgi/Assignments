namespace Number_guess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Number Game");
            Console.WriteLine("OR Press 'q' to quit." );

            while (true)
            {
                int numberToGuess = new Random().Next(1, 101);
                Console.WriteLine("Enter a number between 1 to 100.");
                int attempts = 0;
                while (true)
                {
                    string? input = Console.ReadLine();
                    if (input == "q") return;
                    if (int.TryParse(input, out int guess))
                    {
                        if (guess < numberToGuess)
                        {
                            Console.WriteLine("Guessed number is too low.");
                        }
                        if (guess > numberToGuess)
                        {
                            Console.WriteLine("Guessed number is too high.");
                        }
                        if (guess == numberToGuess)
                        {
                            Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                            Console.WriteLine("Press n if you want to play again.");
                            string? playAgain = Console.ReadLine();
                            if (playAgain == "n") break;
                            else return;
                        }
                    }
                    attempts++;
                }
            }
        }
    }
}
