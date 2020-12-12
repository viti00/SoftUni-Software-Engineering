using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double rangeInMeters = double.Parse(Console.ReadLine());
            double rangeInSecondsPerMeters = double.Parse(Console.ReadLine());

            double distanceTime = rangeInMeters * rangeInSecondsPerMeters;
            double resistanceTime = Math.Floor((rangeInMeters / 15)) * 12.5;
            double resultTime = distanceTime + resistanceTime;

            if (resultTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {resultTime:f2} seconds.");
            }
            else
            {
                double needTime = resultTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
        }
    }
}
