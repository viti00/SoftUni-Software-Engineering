using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1Counter = 0;
            double p2Counter = 0;
            double p3Counter = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1Counter++;
                }
                if (num % 3 == 0)
                {
                    p2Counter++;
                }
                if (num % 4 == 0)
                {
                    p3Counter++;
                }
            }
            double p1Percent = (p1Counter / n) * 100;
            double p2Percent = (p2Counter / n) * 100;
            double p3Percent = (p3Counter / n) * 100;

            Console.WriteLine($"{p1Percent:F2}%");
            Console.WriteLine($"{p2Percent:F2}%");
            Console.WriteLine($"{p3Percent:F2}%");
        }
    }
}
