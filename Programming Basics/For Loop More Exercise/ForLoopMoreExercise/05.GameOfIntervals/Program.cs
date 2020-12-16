using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double move = double.Parse(Console.ReadLine());
            double points = 0.0;
            double totalPoint = 0.0;
            double numCount = 0.0;
            double numCount1 = 0.0;
            double numCount2 = 0.0;
            double numCount3 = 0.0;
            double numCount4 = 0.0;
            double numCount5 = 0.0;
            for (int i = 1; i <= move; i++)
            {
                double nums = double.Parse(Console.ReadLine());
                if (nums < 0 || nums > 50)
                {
                    numCount5++;
                    points /= 2;
                }
                else if (nums >= 0 && nums <= 9)
                {
                    numCount++;
                    points += nums * 0.2;
                }
                else if (nums >= 10 && nums <= 19)
                {
                    numCount1++;
                    points += nums * 0.3;
                }
                else if (nums >= 20 && nums <= 29)
                {
                    numCount2++;
                    points += nums * 0.4;
                }
                else if (nums >= 30 && nums <= 39)
                {
                    numCount3++;
                    points += 50;
                }
                else if (nums >= 40 && nums <= 50)
                {
                    numCount4++;
                    points += 100;
                }
            }
            totalPoint = points;
            double p = numCount / move * 100;
            double p1 = numCount1 / move * 100;
            double p2 = numCount2 / move * 100;
            double p3 = numCount3 / move * 100;
            double p4 = numCount4 / move * 100;
            double p5 = numCount5 / move * 100;
            Console.WriteLine($"{totalPoint:f2}");
            Console.WriteLine($"From 0 to 9: {p:f2}%");
            Console.WriteLine($"From 10 to 19: {p1:F}%");
            Console.WriteLine($"From 20 to 29: {p2:f2}%");
            Console.WriteLine($"From 30 to 39: {p3:F2}%");
            Console.WriteLine($"From 40 to 50: {p4:f2}%");
            Console.WriteLine($"Invalid numbers: {p5:f2}%");
        }
    }
}
