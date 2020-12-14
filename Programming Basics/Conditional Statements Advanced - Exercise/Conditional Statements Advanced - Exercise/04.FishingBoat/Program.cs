using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisher = int.Parse(Console.ReadLine());
            double spring = 3000;
            double summer = 4200;
            double autumn = 4200;
            double winter = 2600;
            double price = 0.0;
            string output = "";
            if (season == "Spring")
            {
                if (fisher <= 6)
                {
                    price = spring - (spring * 0.1);
                }
                else if (fisher >= 7 && fisher <= 11)
                {
                    price = spring - (spring * 0.15);
                }
                else if (fisher >= 12)
                {
                    price = spring - (spring * 0.25);
                }
            }
            else if (season == "Summer")
            {
                if (fisher <= 6)
                {
                    price = summer - (summer * 0.1);
                }
                else if (fisher >= 7 && fisher <= 11)
                {
                    price = summer - (summer * 0.15);
                }
                else if (fisher >= 12)
                {
                    price = summer - (summer * 0.25);
                }
            }
            else if (season == "Autumn")
            {
                if (fisher <= 6)
                {
                    price = autumn - (autumn * 0.1);
                }
                else if (fisher >= 7 && fisher <= 11)
                {
                    price = autumn - (autumn * 0.15);
                }
                else if (fisher >= 12)
                {
                    price = autumn - (autumn * 0.25);
                }
            }
            else if (season == "Winter")
            {
                if (fisher <= 6)
                {
                    price = winter - (winter * 0.1);
                }
                else if (fisher >= 7 && fisher <= 11)
                {
                    price = winter - (winter * 0.15);
                }
                else if (fisher >= 12)
                {
                    price = winter - (winter * 0.25);
                }
            }
            double totalPrice = 0.0;
            if (fisher % 2 == 0)
            {
                if (season == "Spring" || season == "Summer" || season == "Winter")
                {
                    totalPrice = price - (price * 0.05);
                }
                else
                {
                    totalPrice = price;
                }
            }
            else if (fisher % 2 != 0)
            {
                totalPrice = price;
            }
            if (buget >= totalPrice)
            {
                double more = buget - totalPrice;
                output = $"Yes! You have {more:F2} leva left.";
            }
            else if (buget < totalPrice)
            {
                double needed = totalPrice - buget;
                output = $"Not enough money! You need {needed:F2} leva.";
            }
            Console.WriteLine(output);
        }
    }
}
