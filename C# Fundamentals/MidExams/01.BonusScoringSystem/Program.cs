using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studens = int.Parse(Console.ReadLine());
            decimal lectures = decimal.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            decimal max = decimal.MinValue;
            decimal totalBonus = 0;
            decimal bestAttendances = 0;
            for (int i = 1; i <= studens; i++)
            {
                decimal attendances = decimal.Parse(Console.ReadLine());
                totalBonus = attendances / lectures * (5 + bonus);
                if (max <= totalBonus)
                {
                    max = totalBonus;
                    bestAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {bestAttendances} lectures.");
        }
    }
}
