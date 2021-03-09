using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int maxSum = int.MinValue;
            string topCordinates = "";
            string bottomCordinates = "";

            for (int row = 0; row < rows - 1; row++)
            {
                int currSum = 0;
                for (int col = 0; col < cols - 1; col++)
                {
                    currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        topCordinates = $"{matrix[row, col]} {matrix[row, col + 1]}";
                        bottomCordinates = $"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}";
                    }
                }
            }
            Console.WriteLine(topCordinates);
            Console.WriteLine(bottomCordinates);
            Console.WriteLine(maxSum);
        }
    }
}
