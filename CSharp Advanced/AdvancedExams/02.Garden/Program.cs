using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = field[0];
            int cols = field[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            List<int> plantFlowers = new List<int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Bloom Bloom Plow")
                {
                    matrix = MultiplyFlowers(rows, cols, matrix, plantFlowers);
                    break;
                }
                else
                {
                    string[] splitted = command.Split();
                    plantFlowers = GetPlantFlowers(splitted, rows, cols, plantFlowers);

                }
            }
            StringBuilder sb = new StringBuilder( GetMatrix(rows, cols, matrix).ToString());
            Console.WriteLine(sb);
        }
        static List<int> GetPlantFlowers(string[] splitted, int rows, int cols, List<int> plantFlowers)
        {

            int row = int.Parse(splitted[0]);
            int col = int.Parse(splitted[1]);
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                plantFlowers.Add(row);
                plantFlowers.Add(col);
                return plantFlowers;
            }

            Console.WriteLine("Invalid coordinates.");
            return null;
        }

        static int[,] MultiplyFlowers(int rows, int cols, int[,] matrix, List<int> plantFlowers)
        {
            while (plantFlowers.Count != 0)
            {
                int row = plantFlowers[0];
                int col = plantFlowers[1];
                int currRow = row;
                int currCol = col;

                matrix[currRow, currCol]++;
                while (currRow > 0)
                {
                    matrix[currRow - 1, currCol]++;
                    currRow--;
                }
                currRow = row;
                currCol = col;
                while (currRow < rows - 1)
                {
                    matrix[currRow + 1, currCol]++;
                    currRow++;
                }
                currRow = row;
                currCol = col;
                while (currCol > 0)
                {
                    matrix[currRow, currCol - 1]++;
                    currCol--;
                }
                currRow = row;
                currCol = col;
                while (currCol < cols - 1)
                {
                    matrix[currRow, currCol + 1]++;
                    currCol++;
                }
                plantFlowers.RemoveAt(0);
                plantFlowers.RemoveAt(0);
            }
            return matrix;
        }

        static StringBuilder GetMatrix(int rows, int cols, int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb;
        }
    }
}
