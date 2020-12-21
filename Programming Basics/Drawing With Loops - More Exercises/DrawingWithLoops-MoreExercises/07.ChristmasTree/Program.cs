using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                if (row == 0)
                {
                    Console.Write(" |");
                }
                else
                {
                    for (int i = 0; i < row; i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" |");
                }
                Console.Write(" ");
                if (row == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < row; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
