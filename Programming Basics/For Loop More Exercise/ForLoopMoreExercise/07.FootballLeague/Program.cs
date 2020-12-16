using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
            double p = 0.0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    fansA++;
                    p = fansA / fans * 100;
                }
                else if (sector == "B")
                {
                    fansB++;
                    p1 = fansB / fans * 100;
                }
                else if (sector == "V")
                {
                    fansV++;
                    p2 = fansV / fans * 100;
                }
                else if (sector == "G")
                {
                    fansG++;
                    p3 = fansG / fans * 100;
                }
            }
            double p4 = fans / capacity * 100;
            Console.WriteLine($"{p:f2}%");
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
        }
    }
}
