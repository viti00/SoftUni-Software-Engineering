using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
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
                for (int col = 0; col < elements.Length; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                var temp = command.Split();
                string cmd = temp[0];
                int row = int.Parse(temp[1]);
                int col = int.Parse(temp[2]);
                int value = int.Parse(temp[3]);

                switch (cmd)
                {
                    case "Add":
                        if (row >= 0 && col >= 0 && row < n && col < n)
                        {
                            matrix[row, col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (row >= 0 && col >= 0 && row < n && col < n)
                        {
                            matrix[row, col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

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
