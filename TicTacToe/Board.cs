using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Board
    {
        private char[,] grid = new char[3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = '-';
        }

        public bool PlaceMark(int row, int col, char mark)
        {
            if (grid[row, col] == '-')
            {
                grid[row, col] = mark;
                return true;
            }
            return false;
        }

        public char[,] GetGrid() => grid;
    }
}
