using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> cordinates = Console.ReadLine()
                .Split(new char[] { ',',' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            char[,] matrix = new char[n, n];

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            int destroyedShipsh = 0;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if(input[col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (input[col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            while(firstPlayerShips != 0 
                && secondPlayerShips != 0 
                && cordinates.Count != 0)
            {
                int row = cordinates[0];
                int col = cordinates[1];
                if (CheckIndexes(row, col, n))
                {
                    if(matrix[row, col] == '#')
                    {
                        Explode(row, col, matrix, n, ref firstPlayerShips, ref secondPlayerShips, ref destroyedShipsh);
                        matrix[row, col] = 'X';
                    }
                    else if (matrix[row,col] == '>')
                    {
                        secondPlayerShips--;
                        destroyedShipsh++;
                        matrix[row, col] = 'X';
                    }
                    else if (matrix[row,col] == '<')
                    {
                        firstPlayerShips--;
                        destroyedShipsh++;
                        matrix[row, col] = 'X';
                    }
                }
                cordinates.RemoveAt(0);
                cordinates.RemoveAt(0);

            }
            if (firstPlayerShips > 0 && secondPlayerShips == 0)
            {
                Console.WriteLine($"Player One has won the game! {destroyedShipsh} ships have been sunk in the battle.");
            }
            else if (secondPlayerShips > 0 && firstPlayerShips == 0)
            {
                Console.WriteLine($"Player Two has won the game! {destroyedShipsh} ships have been sunk in the battle.");
            }
            else if (firstPlayerShips > 0 && secondPlayerShips > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }
        }

        static bool CheckIndexes(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }

        static void Explode(int row, int col, char[,] matrix, int n, 
            ref int firstShips, ref int secondShips, ref int destroyed)
        {
            if(col - 1 >= 0)
            {
                if (matrix[row,col -1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row, col - 1] = 'X';
                }
                else if(matrix[row,col - 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row, col - 1] = 'X';
                }
                
            }
            if(row - 1 >= 0 && col - 1 >= 0)
            {
                if (matrix[row-1,col-1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row - 1, col - 1] = 'X';
                }
                else if (matrix[row - 1, col - 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row - 1, col - 1] = 'X';
                }
                
            }
            if (row - 1 >= 0)
            {
                if (matrix[row-1,col] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row - 1, col] = 'X';
                }
                else if (matrix[row - 1, col] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row - 1, col] = 'X';
                }
                
            }
            if (row - 1 >= 0 && col + 1 < n)
            {
                if (matrix[row - 1, col + 1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row - 1, col + 1] = 'X';
                }
                else if (matrix[row - 1, col + 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row - 1, col + 1] = 'X';
                }
                
            }
            if (col + 1 < n)
            {
                if (matrix[row, col + 1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row, col + 1] = 'X';
                }
                else if (matrix[row, col + 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row, col + 1] = 'X';
                }
                
            }
            if (row + 1 < n && col + 1 < n)
            {
                if (matrix[row + 1, col + 1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row + 1, col + 1] = 'X';
                }
                else if (matrix[row + 1, col + 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row + 1, col + 1] = 'X';
                }
                
            }
            if (row + 1 < n)
            {
                if (matrix[row + 1, col] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row + 1, col] = 'X';
                }
                else if (matrix[row + 1, col] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row + 1, col] = 'X';
                }
                
            }
            if (row + 1 < n && col - 1 >= 0)
            {
                if(matrix[row + 1, col - 1] == '<')
                {
                    firstShips--;
                    destroyed++;
                    matrix[row + 1, col - 1] = 'X';
                }
                else if (matrix[row + 1, col - 1] == '>')
                {
                    secondShips--;
                    destroyed++;
                    matrix[row + 1, col - 1] = 'X';
                }
                
            }
        }
    }
}
