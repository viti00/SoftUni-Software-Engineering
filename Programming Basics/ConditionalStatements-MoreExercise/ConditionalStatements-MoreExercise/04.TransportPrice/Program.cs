using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double startTaxi = 0.70;
            double dayTaxi = 0.79;
            double nightTaxi = 0.90;
            double bus = 0.09;
            double train = 0.06;
            double output = 0.0;

            if (km < 20 && dayTime == "day")
            {
                output = startTaxi + (dayTaxi * km);
            }
            else if (km < 20 && dayTime == "night")
            {
                output = startTaxi + (nightTaxi * km);
            }
            else if (km >= 20 && km < 100)
            {
                output = km * bus;
            }
            else
            {
                output = km * train;
            }
            Console.WriteLine($"{output:F2}");
        }
    }
}
