using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = rowData[col];
                }
            }

            int removedKnightCounts = 0;

            while (true)
            {
                int maxAttackedKnightCount = 0;
                int knightRow = -1;
                int knightCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = board[row, col];
                        if (symbol != 'K')
                        {
                            continue;
                        }
                        int count = GetCountAttackedKnight(board, row, col);
                        if (count > maxAttackedKnightCount)
                        {
                            maxAttackedKnightCount = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
                if (maxAttackedKnightCount == 0)
                {
                    break;
                }
                board[knightRow, knightCol] = 'О';
                removedKnightCounts++;
            }
            Console.WriteLine(removedKnightCounts);
        }
        private static int GetCountAttackedKnight(char[,] board, int row, int col)
        {
            int count = 0;

            if (ContainstKnight(board, row - 2, col - 1))
            {
                count++;
            }
            if (ContainstKnight(board, row - 2, col + 1))
            {
                count++;
            }
            if (ContainstKnight(board, row - 1, col + 2))
            {
                count++;
            }
            if (ContainstKnight(board, row - 1, col - 2))
            {
                count++;
            }
            if (ContainstKnight(board, row + 1, col + 2))
            {
                count++;
            }
            if (ContainstKnight(board, row + 1, col - 2))
            {
                count++;
            }
            if (ContainstKnight(board, row + 2, col - 1))
            {
                count++;
            }
            if (ContainstKnight(board, row + 2, col + 1))
            {
                count++;
            }
            return count;
        }
        private static bool ContainstKnight(char[,] board, int row, int col)
        {
            if (!IsValidCell(row, col, board.GetLength(0)))
            {
                return false;
            }
            return board[row, col] == 'K';
        }
        private static bool IsValidCell(int row, int col, int lengh)
        {
            return row >= 0 && row < lengh && col >= 0 && col < lengh;
        }
    }
}
