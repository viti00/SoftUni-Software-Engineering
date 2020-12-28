using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double fuelPrice = fuel * 2.10;
            double totalPrice = fuelPrice + 100;

            double finalPrice = 0;
            if (day == "Saturday")
            {
                finalPrice = totalPrice - totalPrice * 0.1;
            }
            else if (day == "Sunday")
            {
                finalPrice = totalPrice - totalPrice * 0.2;
            }

            if (budget >= finalPrice)
            {
                double more = budget - finalPrice;
                Console.WriteLine($"Safari time! Money left: {more:F2} lv.");
            }
            else
            {
                double needed = finalPrice - budget;
                Console.WriteLine($"Not enough money! Money needed: {needed:F2} lv.");
            }
        }
    }
}
