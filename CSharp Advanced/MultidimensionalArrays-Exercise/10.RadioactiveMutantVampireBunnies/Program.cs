using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;

namespace Problem10RadioactiveMutantVampireBunnies
{
    public static class DebugExtensions
    {
        public static string Test2D(this Array source, int pad = 10)
        {
            var result = "";
            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                    result += source.GetValue(i, j).ToString().PadLeft(pad);
                result += "\n";
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            char[,] lair = new char[rows, columns];

            int currentRow = 0;
            int currentColumn = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < columns; col++)
                {
                    if (symbols[col] == 'P')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }

                    lair[row, col] = symbols[col];
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();

            bool isDead = false;
            bool wentOut = false;

            for (int i = 0; i < directions.Length; i++)
            {
                char currentDirection = directions[i];

                if (!isDead && !wentOut)
                {
                    if (currentDirection == 'L')
                    {
                        if (IsInside(lair, currentRow, currentColumn - 1))
                        {
                            lair[currentRow, currentColumn] = '.';
                            currentColumn -= 1;

                            if (lair[currentRow, currentColumn] == 'B')
                            {
                                isDead = true;
                            }
                            else
                            {
                                lair[currentRow, currentColumn] = 'P';
                            }
                        }
                        else
                        {
                            wentOut = true;
                            lair[currentRow, currentColumn] = '.';
                        }
                    }
                    else if (currentDirection == 'R')
                    {
                        if (IsInside(lair, currentRow, currentColumn + 1))
                        {
                            lair[currentRow, currentColumn] = '.';
                            currentColumn += 1;

                            if (lair[currentRow, currentColumn] == 'B')
                            {
                                isDead = true;
                            }
                            else
                            {
                                lair[currentRow, currentColumn] = 'P';
                            }
                        }
                        else
                        {
                            wentOut = true;
                            lair[currentRow, currentColumn] = '.';
                        }
                    }
                    else if (currentDirection == 'U')
                    {
                        if (IsInside(lair, currentRow - 1, currentColumn))
                        {
                            lair[currentRow, currentColumn] = '.';
                            currentRow -= 1;

                            if (lair[currentRow, currentColumn] == 'B')
                            {
                                isDead = true;
                            }
                            else
                            {
                                lair[currentRow, currentColumn] = 'P';
                            }
                        }
                        else
                        {
                            wentOut = true;
                            lair[currentRow, currentColumn] = '.';
                        }
                    }
                    else if (currentDirection == 'D')
                    {
                        if (IsInside(lair, currentRow + 1, currentColumn))
                        {
                            lair[currentRow, currentColumn] = '.';
                            currentRow += 1;

                            if (lair[currentRow, currentColumn] == 'B')
                            {
                                isDead = true;
                            }
                            else
                            {
                                lair[currentRow, currentColumn] = 'P';
                            }
                        }
                        else
                        {
                            wentOut = true;
                            lair[currentRow, currentColumn] = '.';
                        }
                    }

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            if (lair[row, col] == 'B')
                            {
                                if (IsInside(lair, row, col - 1))
                                {
                                    if (lair[row, col - 1] == 'P')
                                    {
                                        isDead = true;
                                    }

                                    if (lair[row, col - 1] != 'B')
                                    {
                                        lair[row, col - 1] = 'C';
                                    }
                                }

                                if (IsInside(lair, row, col + 1))
                                {
                                    if (lair[row, col + 1] == 'P')
                                    {
                                        isDead = true;
                                    }

                                    if (lair[row, col + 1] != 'B')
                                    {
                                        lair[row, col + 1] = 'C';
                                    }
                                }

                                if (IsInside(lair, row - 1, col))
                                {
                                    if (lair[row - 1, col] == 'P')
                                    {
                                        isDead = true;
                                    }

                                    if (lair[row - 1, col] != 'B')
                                    {
                                        lair[row - 1, col] = 'C';
                                    }
                                }

                                if (IsInside(lair, row + 1, col))
                                {
                                    if (lair[row + 1, col] == 'P')
                                    {
                                        isDead = true;
                                    }

                                    if (lair[row + 1, col] != 'B')
                                    {
                                        lair[row + 1, col] = 'C';
                                    }
                                }
                            }
                        }
                    }

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            if (lair[row, col] == 'C')
                            {
                                lair[row, col] = 'B';
                            }
                        }
                    }
                }
            }

            PrintMatrix(lair);

            if (isDead)
            {
                Console.WriteLine($"dead: {currentRow} {currentColumn}");
            }
            else
            {
                Console.WriteLine($"won: {currentRow} {currentColumn}");
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                            && col >= 0 && col < matrix.GetLength(1);
        }


    }
}