using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int orderedSets = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (fruit)
            {
                case "Watermelon":
                    switch (set)
                    {
                        case "small":
                            price = 56 * 2;
                            break;
                        case "big":
                            price = 28.7 * 5;
                            break;
                    }
                    break;
                case "Mango":
                    switch (set)
                    {
                        case "small":
                            price = 36.66 * 2;
                            break;
                        case "big":
                            price = 19.6 * 5;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (set)
                    {
                        case "small":
                            price = 42.1 * 2;
                            break;
                        case "big":
                            price = 24.8 * 5;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (set)
                    {
                        case "small":
                            price = 20 * 2;
                            break;
                        case "big":
                            price = 15.2 * 5;
                            break;
                    }
                    break;
            }

            price *= orderedSets;

            if (price >= 400 && price <= 1000)
            {
                price -= price * 0.15;
            }
            else if (price > 1000)
            {
                price -= price * 0.5;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
