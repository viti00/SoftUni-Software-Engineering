using System;
using System.Text;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    if (input[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();
            int flowers = 0;

            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';
                beeRow = MoveRow(beeRow, command);
                beeCol = MoveCol(beeCol, command);
                if (CheckIndexes(beeRow, beeCol, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (matrix[beeRow, beeCol] == 'f')
                {
                    flowers++;
                }
                else if (matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(beeRow, command);
                    beeCol = MoveCol(beeCol, command);

                    if (CheckIndexes(beeRow, beeCol, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers++;
                    }
                }
                matrix[beeRow, beeCol] = 'B';
                command = Console.ReadLine();
            }

            if (flowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                int needed = 5 - flowers;
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {needed} flowers more");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        static bool CheckIndexes(int beeRow, int beeCol, int n)
        {
            return beeRow < 0 || beeRow >= n || beeCol < 0 || beeCol >= n;
        }

        static int MoveRow(int row, string command)
        {
            if (command == "up")
            {
                return row - 1;
            }
            else if (command == "down")
            {
                return row + 1;
            }
            return row;
        }

        static int MoveCol(int col, string command)
        {
            if (command == "left")
            {
                return col - 1;
            }
            else if (command == "right")
            {
                return col + 1;
            }

            return col;
        }
    }
}
