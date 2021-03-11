using System;
using System.Collections.Generic;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            string[,] matrix = new string[n, n];
            Queue<string> command = new Queue<string>();

            for (int i = 0; i < commands.Length; i++)
            {
                command.Enqueue(commands[i]);
            }
            int coalCounter = 0;
            int rowPosition = 0;
            int colPosition = 0;
            for (int row = 0; row < n; row++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];

                    if (elements[col] == "c")
                    {
                        coalCounter++;
                    }
                    else if (elements[col] == "s")
                    {
                        rowPosition = row;
                        colPosition = col;
                    }
                }
            }

            while (command.Count > 0)
            {
                string currCmd = command.Dequeue();
                if (currCmd == "up" && rowPosition - 1 >= 0)
                {
                    rowPosition--;
                }
                else if (currCmd == "right" && colPosition + 1 < n)
                {
                    colPosition++;
                }
                else if (currCmd == "down" && rowPosition + 1 < n)
                {
                    rowPosition++;
                }
                else if (currCmd == "left" && colPosition - 1 >= 0)
                {
                    colPosition--;
                }

                if (matrix[rowPosition, colPosition] == "e")
                {
                    Console.WriteLine($"Game over! ({rowPosition}, {colPosition})");
                    return;
                }
                else if (matrix[rowPosition, colPosition] == "c")
                {
                    coalCounter--;
                    matrix[rowPosition, colPosition] = "*";
                    if (coalCounter == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({rowPosition}, {colPosition})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{coalCounter} coals left. ({rowPosition}, {colPosition})");
        }
    }
}
