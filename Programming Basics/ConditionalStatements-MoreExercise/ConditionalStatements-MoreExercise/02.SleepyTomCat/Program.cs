using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            double workDays = 365 - freeDays;
            double realTimeForPlay = (workDays * 63) + (freeDays * 127);
            double hours = 0.0;
            double minutes = 0.0;
            if (realTimeForPlay > 30000)
            {
                double nadNormata = realTimeForPlay - 30000;
                hours = Math.Truncate(nadNormata / 60);
                minutes = nadNormata % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (realTimeForPlay <= 30000)
            {
                double podNormata = 30000 - realTimeForPlay;
                hours = Math.Truncate(podNormata / 60);
                minutes = podNormata % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
