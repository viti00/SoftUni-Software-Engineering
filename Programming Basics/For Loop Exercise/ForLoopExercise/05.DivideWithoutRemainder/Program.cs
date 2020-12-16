using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double numCount1 = 0.0;
            double numCount2 = 0.0;
            double numCount3 = 0.0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    numCount1++;
                    p1 = numCount1 / n * 100;
                }
                if (num % 3 == 0)
                {
                    numCount2++;
                    p2 = numCount2 / n * 100;
                }
                if (num % 4 == 0)
                {
                    numCount3++;
                    p3 = numCount3 / n * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
