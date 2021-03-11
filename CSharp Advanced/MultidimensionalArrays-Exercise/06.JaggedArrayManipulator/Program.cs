using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] elements = Console.ReadLine().Split().Select(double.Parse).ToArray();
                int cols = elements.Length;
                matrix[row] = new double[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = elements[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;

                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                string[] splited = command.Split();
                string function = splited[0];

                switch (function)
                {
                    case "Add":
                        int row = int.Parse(splited[1]);
                        int col = int.Parse(splited[2]);
                        int value = int.Parse(splited[3]);

                        if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        int rowToSub = int.Parse(splited[1]);
                        int colToSub = int.Parse(splited[2]);
                        int valueToSub = int.Parse(splited[3]);
                        if (rowToSub >= 0 && rowToSub < rows && colToSub >= 0 && colToSub < matrix[rowToSub].Length)
                        {
                            matrix[rowToSub][colToSub] -= valueToSub;
                        }

                        break;
                    case "End":
                        for (int rowToPrint = 0; rowToPrint < rows; rowToPrint++)
                        {
                            for (int colToPrint = 0; colToPrint < matrix[rowToPrint].Length; colToPrint++)
                            {
                                Console.Write(matrix[rowToPrint][colToPrint] + " ");
                            }
                            Console.WriteLine();
                        }
                        return;
                }
            }
        }
    }
}
