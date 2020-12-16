using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double busPrice = 0.0;
            double truckPrice = 0.0;
            double trainPrice = 0.0;
            double cargo = 0.0;
            double cargoSum = 0.0;
            double cargoSum1 = 0.0;
            double cargoSum2 = 0.0;
            for (double i = 1; i <= n; i++)
            {
                double tons = double.Parse(Console.ReadLine());
                cargo += tons;
                if (tons <= 3)
                {
                    cargoSum += tons;
                    busPrice = cargoSum * 200;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    cargoSum1 += tons;
                    truckPrice = cargoSum1 * 175;
                }
                else if (tons >= 12)
                {
                    cargoSum2 += tons;
                    trainPrice = cargoSum2 * 120;
                }
            }
            double averageTons = (busPrice + truckPrice + trainPrice) / cargo;
            double autobus = cargoSum / cargo * 100;
            double truck = cargoSum1 / cargo * 100;
            double train = cargoSum2 / cargo * 100;

            Console.WriteLine($"{averageTons:f2}");
            Console.WriteLine($"{autobus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
