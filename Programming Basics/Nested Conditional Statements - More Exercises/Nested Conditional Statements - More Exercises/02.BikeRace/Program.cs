using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();
            double pricejr = 0.0;
            double pricesr = 0.0;
            switch (race)
            {
                case "trail":
                    pricejr = juniors * 5.50;
                    pricesr = seniors * 7;
                    break;
                case "cross-country":
                    pricejr = juniors * 8;
                    pricesr = seniors * 9.50;
                    break;
                case "downhill":
                    pricejr = juniors * 12.25;
                    pricesr = seniors * 13.75;
                    break;
                case "road":
                    pricejr = juniors * 20;
                    pricesr = seniors * 21.50;
                    break;
            }
            if (race == "cross-country" && juniors + seniors >= 50)
            {
                double discountJr = 8 * 0.25;
                double discountSr = 9.50 * 0.25;
                pricejr = juniors * (8 - discountJr);
                pricesr = seniors * (9.50 - discountSr);
            }
            double totalPrice = pricejr + pricesr;
            double costs = totalPrice * 0.05;
            double donation = totalPrice - costs;
            Console.WriteLine($"{donation:F2}");
        }
    }
}
