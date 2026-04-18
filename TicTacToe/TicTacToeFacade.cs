using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class TicTacToeFacade
    {
        private Board board;
        private GameRules rules;
        private PlayerManager playerManager;

        public TicTacToeFacade()
        {
            board = new Board();
            rules = new GameRules();
            playerManager = new PlayerManager();
        }

        public void DisplayBoard()
        {
            var grid = board.GetGrid();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MakeMove(int row, int col)
        {
            char player = playerManager.GetCurrentPlayer();

            if (!board.PlaceMark(row, col, player))
            {
                Console.WriteLine("Invalid move! Try again.");
                return;
            }

            if (rules.CheckWin(board.GetGrid(), player))
            {
                Console.WriteLine($"Player {player} wins!");
                DisplayBoard();
                Environment.Exit(0);
            }

            playerManager.SwitchPlayer();
        }
    }
}
