namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeFacade game = new TicTacToeFacade();

            while (true)
            {
                game.DisplayBoard();

                Console.WriteLine("Enter row and column (0-2): ");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                game.MakeMove(row, col);
            }
        }
    }
}
