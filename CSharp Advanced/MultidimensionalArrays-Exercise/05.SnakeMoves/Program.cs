using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            string direction = "right";

            Queue<char> snakeElements = new Queue<char>();
            foreach (var item in snake)
            {
                snakeElements.Enqueue(item);
            }

            for (int row = 0; row < rows; row++)
            {
                if (direction == "right")
                {
                    for (int col = 0; col < cols; col++)
                    {
                        char currElement = snakeElements.Dequeue();
                        matrix[row, col] = currElement;
                        snakeElements.Enqueue(currElement);
                    }
                    direction = "left";
                }
                else if (direction == "left")
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        char currElement = snakeElements.Dequeue();
                        matrix[row, col] = currElement;
                        snakeElements.Enqueue(currElement);
                    }
                    direction = "right";
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
