using System;

namespace _03.ExamPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();
            double koef = 0.0;
            double total = 0.0;
            if (course == "Basics")
            {
                if (task == 1)
                {
                    koef = points * 0.08;
                    total = koef - (koef * 0.2);
                }
                else if (task == 2)
                {
                    koef = points * 0.09;
                    total = koef;
                }
                else if (task == 3)
                {
                    koef = points * 0.09;
                    total = koef;
                }
                else if (task == 4)
                {
                    koef = points * 0.1;
                    total = koef;
                }
            }
            else if (course == "Fundamentals")
            {
                if (task == 1)
                {
                    koef = points * 0.11;
                    total = koef;
                }
                else if (task == 2)
                {
                    koef = points * 0.11;
                    total = koef;
                }
                else if (task == 3)
                {
                    koef = points * 0.12;
                    total = koef;
                }
                else if (task == 4)
                {
                    koef = points * 0.13;
                    total = koef;
                }
            }
            else if (course == "Advanced")
            {
                if (task == 1)
                {
                    koef = points * 0.14;
                    total = koef + (koef * 0.2);
                }
                else if (task == 2)
                {
                    koef = points * 0.14;
                    total = koef + (koef * 0.2);
                }
                else if (task == 3)
                {
                    koef = points * 0.15;
                    total = koef + (koef * 0.2);
                }
                else if (task == 4)
                {
                    koef = points * 0.16;
                    total = koef + (koef * 0.2);
                }
            }
            Console.WriteLine($"Total points: {total:F2}");
        }
    }
}
