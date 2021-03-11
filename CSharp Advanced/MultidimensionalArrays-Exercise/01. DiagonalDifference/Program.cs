using System;
using System.Linq;

namespace _01.DiagonalDifference
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

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }
            int position = n - 1;
            for (int row = 0; row < n; row++)
            {
                secondaryDiagonalSum += matrix[row, position];
                position--;
            }

            double subtract = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(subtract);
        }
    }
}
