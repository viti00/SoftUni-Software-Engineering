﻿using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0.0;
            double priceAfterDiscount = 0.0;
            if (sex == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        price = 42;
                        break;
                    case "Boxing":
                        price = 41;
                        break;
                    case "Yoga":
                        price = 45;
                        break;
                    case "Zumba":
                        price = 34;
                        break;
                    case "Dances":
                        price = 51;
                        break;
                    case "Pilates":
                        price = 39;
                        break;
                }
            }
            else if (sex == "f")
            {
                switch (sport)
                {
                    case "Gym":
                        price = 35;
                        break;
                    case "Boxing":
                        price = 37;
                        break;
                    case "Yoga":
                        price = 42;
                        break;
                    case "Zumba":
                        price = 31;
                        break;
                    case "Dances":
                        price = 53;
                        break;
                    case "Pilates":
                        price = 37;
                        break;
                }
            }
            if (age <= 19)
            {
                priceAfterDiscount = price - (price * 0.2);
            }
            else
            {
                priceAfterDiscount = price;
            }
            if (priceAfterDiscount <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double neededMoney = priceAfterDiscount - money;
                Console.WriteLine($"You don't have enough money! You need ${neededMoney:f2} more.");
            }
        }
    }
}
