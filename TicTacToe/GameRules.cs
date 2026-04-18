using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class GameRules
    {
        public bool CheckWin(char[,] grid, char mark)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0] == mark && grid[i, 1] == mark && grid[i, 2] == mark)
                    return true;

                if (grid[0, i] == mark && grid[1, i] == mark && grid[2, i] == mark)
                    return true;
            }

            if (grid[0, 0] == mark && grid[1, 1] == mark && grid[2, 2] == mark)
                return true;

            if (grid[0, 2] == mark && grid[1, 1] == mark && grid[2, 0] == mark)
                return true;

            return false;
        }
    }
}
