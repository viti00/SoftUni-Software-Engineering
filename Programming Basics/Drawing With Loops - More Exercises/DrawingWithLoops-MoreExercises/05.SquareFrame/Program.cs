using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+" + " ");
                }
                else
                {
                    Console.Write("|" + " ");
                }
                for (int j = 1; j <= n; j++)
                {
                    if (j > 1 && j < n)
                    {
                        Console.Write("-" + " ");
                    }
                    else if (j == n && i == 1 || j == n && i == n)
                    {
                        Console.Write("+");
                    }
                    else if (j == n && i > 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
