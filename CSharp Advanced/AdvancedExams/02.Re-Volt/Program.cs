using System;
using System.Text;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            while (commandCount != 0)
            {
                string movement = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';
                playerRow = MoveRow(playerRow, movement);
                playerCol = MoveCol(playerCol, movement);

                if (CheckIndexes(playerRow, playerCol, n))
                {
                    playerRow = ChangeRow(playerRow, movement, n);
                    playerCol = ChangeCol(playerCol, movement, n);
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerRow = MoveRow(playerRow, movement);
                    playerCol = MoveCol(playerCol, movement);
                    if (CheckIndexes(playerRow, playerCol, n))
                    {
                        playerRow = ChangeRow(playerRow, movement, n);
                        playerCol = ChangeCol(playerCol, movement, n);
                    }
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerRow = MoveRowBackwards(playerRow, movement);
                    playerCol = MoveColBackwards(playerCol, movement);
                   
                }
                else if (matrix[playerRow, playerCol] == 'F')
                {
                    commandCount--;
                    break;
                }
                commandCount--;
                matrix[playerRow, playerCol] = 'f';
            }
            if (matrix[playerRow,playerCol] == 'F' && commandCount >= 0)
            {
                matrix[playerRow, playerCol] = 'f';
                Console.WriteLine("Player won!");
            }
            else if (commandCount == 0 && matrix[playerRow,playerCol] != 'F')
            {
                Console.WriteLine("Player lost!");
            }
            Console.WriteLine(PrintMatrix(matrix, n));
        }

        static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                row = row - 1;
                return row;
            }
            else if (movement == "down")
            {
                row = row + 1;
                return row;
            }
            return row;
        }

        static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                col = col - 1;
                return col;
            }
            else if (movement == "right")
            {
                col = col + 1;
                return col;
            }
            return col;
        }

        static bool CheckIndexes(int row, int col, int n)
        {
            return row < 0 || row >= n || col < 0 || col >= n;
        }

        static int ChangeRow(int row, string movement, int n)
        {
            if (movement == "up")
            {
                row = n - 1;
                return row;
            }
            else if (movement == "down")
            {
                row = 0;
                return row;
            }
            return row;
        }

        static int ChangeCol(int col, string movement, int n)
        {
            if (movement == "right")
            {
                col = 0;
                return col;
            }
            else if (movement == "left")
            {
                col = n - 1;
                return col;
            }
            return col;
        }

        static int MoveRowBackwards(int row, string movement)
        {
            if (movement == "up")
            {
                row = row + 1;
                return row;
            }
            else if (movement == "down")
            {
                row = row - 1;
                return row;
            }
            return row;
        }

        static int MoveColBackwards(int col, string movement)
        {
            if (movement == "right")
            {
                col = col - 1;
                return col;
            }
            if (movement == "left")
            {
                col = col + 1;
                return col;
            }

            return col;
        }

        static string PrintMatrix(char[,] matrix, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    sb.Append(matrix[row, col]);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
