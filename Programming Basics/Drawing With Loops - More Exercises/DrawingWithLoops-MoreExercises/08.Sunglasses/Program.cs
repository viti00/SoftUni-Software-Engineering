using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write("*");
                for (int col = 1; col <= n * 2 - 2; col++)
                {
                    if (row == 1 || row == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                Console.Write("*");
                if (n % 2 == 0)
                {
                    if (row == n / 2)
                    {
                        for (int i = 1; i <= n * 5 - n * 4; i++)
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= n * 5 - n * 4; i++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else if (n % 2 == 1)
                {
                    if (row == n / 2 + 1)
                    {
                        for (int i = 1; i <= n * 5 - n * 4; i++)
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= n * 5 - n * 4; i++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("*");
                for (int col = 1; col <= n * 2 - 2; col++)
                {
                    if (row == 1 || row == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
