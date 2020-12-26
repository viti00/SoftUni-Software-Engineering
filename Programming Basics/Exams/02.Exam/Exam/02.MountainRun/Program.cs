using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timesForMInSec = double.Parse(Console.ReadLine());
            double time = distanceInM * timesForMInSec;
            double delay = Math.Floor(distanceInM / 50) * 30;
            double totalTime = time + delay;
            if (totalTime < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
            else
            {
                double fail = totalTime - recordInSec;
                Console.WriteLine($"No! He was {fail:F2} seconds slower.");
            }
        }
    }
}
