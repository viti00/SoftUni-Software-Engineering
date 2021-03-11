using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splited = command.Split();
                if (splited[0] == "swap" && splited.Length == 5)
                {
                    int row1 = int.Parse(splited[1]);
                    int col1 = int.Parse(splited[2]);
                    int row2 = int.Parse(splited[3]);
                    int col2 = int.Parse(splited[4]);

                    if (row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols
                        && row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols)
                    {
                        string firstElement = matrix[row1, col1];
                        string secondElement = matrix[row2, col2];

                        matrix[row1, col1] = secondElement;
                        matrix[row2, col2] = firstElement;
                        PrintMatrix(matrix, rows, cols);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }
        static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
