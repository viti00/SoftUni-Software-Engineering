using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string[] cordinates = Console.ReadLine().Split();
            for (int i = 0; i < cordinates.Length; i++)
            {
                string[] temp = cordinates[i].Split(",");

                int row1 = int.Parse(temp[0]);
                int col1 = int.Parse(temp[1]);

                if (matrix[row1, col1] > 0)
                {
                    int currPower = matrix[row1, col1];
                    matrix[row1, col1] = 0;
                    if (row1 - 1 >= 0 && col1 - 1 >= 0)
                    {
                        if (matrix[row1 - 1, col1 - 1] > 0)
                        {
                            matrix[row1 - 1, col1 - 1] -= currPower;
                        }

                    }
                    if (row1 - 1 >= 0 && col1 >= 0)
                    {
                        if (matrix[row1 - 1, col1] > 0)
                        {
                            matrix[row1 - 1, col1] -= currPower;
                        }
                    }
                    if (row1 - 1 >= 0 && col1 + 1 < n)
                    {
                        if (matrix[row1 - 1, col1 + 1] > 0)
                        {
                            matrix[row1 - 1, col1 + 1] -= currPower;
                        }

                    }
                    if (row1 >= 0 && col1 + 1 < n)
                    {
                        if (matrix[row1, col1 + 1] > 0)
                        {
                            matrix[row1, col1 + 1] -= currPower;
                        }

                    }
                    if (row1 + 1 < n && col1 + 1 < n)
                    {
                        if (matrix[row1 + 1, col1 + 1] > 0)
                        {
                            matrix[row1 + 1, col1 + 1] -= currPower;
                        }
                    }
                    if (row1 + 1 < n && col1 >= 0)
                    {
                        if (matrix[row1 + 1, col1] > 0)
                        {
                            matrix[row1 + 1, col1] -= currPower;
                        }

                    }
                    if (row1 + 1 < n && col1 - 1 >= 0)
                    {
                        if (matrix[row1 + 1, col1 - 1] > 0)
                        {
                            matrix[row1 + 1, col1 - 1] -= currPower;
                        }

                    }
                    if (row1 >= 0 && col1 - 1 >= 0)
                    {
                        if (matrix[row1, col1 - 1] > 0)
                        {
                            matrix[row1, col1 - 1] -= currPower;
                        }

                    }
                }
            }
            int aliveSum = 0;
            int aliveCounter = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveSum += item;
                    aliveCounter++;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCounter}");
            Console.WriteLine($"Sum: {aliveSum}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
