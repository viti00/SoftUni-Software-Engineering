using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                if (i == 1)
                {
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");

                    }
                    Console.WriteLine();
                }
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                if (i == 1)
                {
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
