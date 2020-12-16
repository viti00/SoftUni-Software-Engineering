using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double numCount1 = 0;
            double numCount2 = 0;
            double numCount3 = 0;
            double numCount4 = 0;
            double numCount5 = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (double i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    numCount1++;
                    p1 = numCount1 / n * 100;
                }
                else if (num >= 200 && num <= 399)
                {
                    numCount2++;
                    p2 = numCount2 / n * 100;
                }
                else if (num >= 400 && num <= 599)
                {
                    numCount3++;
                    p3 = numCount3 / n * 100;
                }
                else if (num >= 600 && num <= 799)
                {
                    numCount4++;
                    p4 = numCount4 / n * 100;
                }
                else if (num >= 800)
                {
                    numCount5++;
                    p5 = numCount5 / n * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
