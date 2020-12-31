using System;

namespace _06.ExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsSum = 0.0;
            double pointTo100 = 0.0;
            double grade = 0.0;
            double point = 0.0;
            while (name != "Midnight")
            {
                for (int i = 1; i <= 6; i++)
                {
                    point = double.Parse(Console.ReadLine());
                    if (point < 0)
                    {
                        Console.WriteLine($"{name} was cheating!");
                        break;
                    }
                    pointsSum += point;
                }
                pointTo100 = pointsSum / 600 * 100;
                grade = Math.Floor(pointTo100) * 0.06;
                if (grade < 3.00 && point >= 0)
                {
                    Console.WriteLine($"{name} - 2.00");
                }
                else if (grade < 5.00 && grade > 3.00 && point >= 0)
                {
                    Console.WriteLine($"{name} - {grade:F2}");
                }
                else if (grade > 5.00 && point >= 0)
                {
                    Console.WriteLine($"===================");
                    Console.WriteLine($"|   CERTIFICATE   |");
                    Console.WriteLine($"|    {grade:F2}/6.00    |");
                    Console.WriteLine($"===================");
                    Console.WriteLine($"Issued to {name}");
                }
                pointsSum = 0;
                name = Console.ReadLine();
            }
        }
    }
}
