using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int money = 0;
            List<int> cordinates = new List<int>(FindPlayer(n, matrix));
            int playerRow = cordinates[0];
            int playerCol = cordinates[1];

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "left":
                        matrix[playerRow, playerCol] = '-';
                        playerCol = playerCol - 1;
                        if(CheckIndexes(playerRow, playerCol, n))
                        {
                            PrintLose(n, matrix, money);
                            return;
                        }
                        Moves(ref playerRow, ref playerCol, matrix, ref money, n);
                        matrix[playerRow, playerCol] = 'S';
                        if(money >= 50)
                        {
                            PrintWin(n, matrix, money);
                            return;
                        }
                        break;
                    case "right":
                        matrix[playerRow, playerCol] = '-';
                        playerCol = playerCol + 1;
                        if (CheckIndexes(playerRow, playerCol, n))
                        {
                            PrintLose(n, matrix, money);
                            return;
                        }
                        Moves(ref playerRow, ref playerCol, matrix, ref money, n);
                        matrix[playerRow, playerCol] = 'S';
                        if (money >= 50)
                        {
                            PrintWin(n, matrix, money);
                            return;
                        }
                        break;
                    case "up":
                        matrix[playerRow, playerCol] = '-';
                        playerRow = playerRow - 1;
                        if (CheckIndexes(playerRow, playerCol, n))
                        {
                            PrintLose(n, matrix, money);
                            return;
                        }
                        Moves(ref playerRow, ref playerCol, matrix, ref money, n);
                        matrix[playerRow, playerCol] = 'S';
                        if (money >= 50)
                        {
                            PrintWin(n, matrix, money);
                            return;
                        }
                        break;
                    case "down":
                        matrix[playerRow, playerCol] = '-';
                        playerRow = playerRow + 1;
                        if (CheckIndexes(playerRow, playerCol, n))
                        {
                            PrintLose(n, matrix, money);
                            return;
                        }
                        Moves(ref playerRow, ref playerCol, matrix, ref money, n);
                        matrix[playerRow, playerCol] = 'S';
                        if (money >= 50)
                        {
                            PrintWin(n, matrix, money);
                            return;
                        }
                        break;
                }
            }

        }
        static void Moves( ref int playerRow,ref int playerCol, char[,] matrix, ref int money, int n)
        {
            
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                money += int.Parse(matrix[playerRow, playerCol].ToString());
            }
            else if (matrix[playerRow,playerCol] == 'O')
            {
                matrix[playerRow, playerCol] = '-';
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if(matrix[row, col] == 'O')
                        {
                            playerRow = row;
                            playerCol = col;
                            matrix[playerRow, playerCol] = 'S';
                        }
                    }
                }
            }
        }
        static List<int> FindPlayer(int n, char[,] matrix)
        {
            List<int> cordinates = new List<int>();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        cordinates.Add(row);
                        cordinates.Add(col);
                        return cordinates;
                    }
                }
            }
            return cordinates;
        }

        static bool CheckIndexes(int playerRow, int playerCol, int n)
        {
            if (playerRow < 0 || playerRow >= n || playerCol < 0 || playerCol >= n)
            {
                return true;
            }
            return false;
        }
        static void PrintLose(int n, char[,] matrix, int money)
        {
            Console.WriteLine("Bad news, you are out of the bakery.");
            Console.WriteLine($"Money: {money}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void PrintWin(int n, char[,] matrix, int money)
        {
            Console.WriteLine("Good news! You succeeded in collecting enough money!");
            Console.WriteLine($"Money: {money}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
