using System;
using System.Text;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int snakeRow = -1;
            int snakeCol = -1;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row,col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            int foodQuantity = 0;

            while(foodQuantity < 10)
            {
                string movement = Console.ReadLine();
                matrix[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(snakeRow, movement);
                snakeCol = MoveCol(snakeCol, movement);
                if (CheckIndexes(snakeRow, snakeCol, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[snakeRow, snakeCol] == '*')
                {
                    foodQuantity++;
                }
                else if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row,col] == 'B')
                            {
                                snakeRow = row;
                                snakeCol = col;
                            }
                        }
                    }
                }

                matrix[snakeRow, snakeCol] = 'S';
            }

            if (foodQuantity >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");
            Console.WriteLine(PrintMatrix(matrix, n));
        }
        static int MoveRow(int snakeRow, string movement)
        {
            if (movement == "up")
            {
                snakeRow = snakeRow - 1;
                return snakeRow;
            }
            else if (movement == "down")
            {
                snakeRow = snakeRow + 1;
                return snakeRow;
            }
            return snakeRow;
        }

        static int MoveCol(int snakeCol, string movement)
        {
            if (movement == "left")
            {
                snakeCol = snakeCol - 1;
                return snakeCol;
            }
            else if (movement == "right")
            {
                snakeCol = snakeCol + 1;
                return snakeCol;
            }
            return snakeCol;
        }

        static bool CheckIndexes(int row, int col, int n)
        {
            return row < 0 || row >= n || col < 0 || col >= n;
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
