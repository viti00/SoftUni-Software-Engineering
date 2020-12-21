using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2; row++)
                {
                    for (int col = 1; col <= n / 2 - row; col++)
                    {
                        Console.Write("-");
                        counter++;
                    }
                    if (row == 1)
                    {
                        Console.Write("**");
                        counter += 2;
                        for (int i = 1; i <= (n - 2) / 2; i++)
                        {
                            Console.Write("-");
                            counter++;
                        }
                        counter = 0;
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 1; i <= row * 2; i++)
                        {
                            Console.Write("*");
                            counter++;
                        }
                        for (int i = 1; i <= n - counter; i++)
                        {
                            Console.Write("-");
                        }
                        counter = 0;
                        Console.WriteLine();
                    }
                }

            }
            else
            {
                for (int row = 1; row <= n / 2 + 1; row++)
                {
                    for (int col = 1; col <= n / 2 + 1 - row; col++)
                    {
                        Console.Write("-");
                        counter++;
                    }
                    if (row == 1)
                    {
                        Console.Write("*");
                        counter++;
                        for (int i = 1; i <= (n - 1) / 2; i++)
                        {
                            Console.Write("-");
                            counter++;
                        }
                        counter = 0;
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 1; i <= row * 2 - 1; i++)
                        {
                            Console.Write("*");
                            counter++;
                        }
                        for (int i = 1; i <= n - counter; i++)
                        {
                            Console.Write("-");
                        }
                        counter = 0;
                        Console.WriteLine();
                    }
                }
            }
            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col == 1 || col == n)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
