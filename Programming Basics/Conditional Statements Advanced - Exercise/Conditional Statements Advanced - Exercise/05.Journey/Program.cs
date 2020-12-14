using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destiny = "";
            string holiday = "";
            double price = 0.0;
            if (buget <= 100)
            {
                destiny = "Bulgaria";
                if (season == "summer")
                {
                    holiday = "Camp";
                    price = buget * 0.30;
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    price = buget * 0.70;
                }
            }
            else if (buget <= 1000)
            {
                destiny = "Balkans";
                if (season == "summer")
                {
                    holiday = "Camp";
                    price = buget * 0.40;
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    price = buget * 0.80;
                }
            }
            else if (buget > 1000)
            {
                destiny = "Europe";
                holiday = "Hotel";
                price = buget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destiny}");
            Console.WriteLine($"{holiday} - {price:F2}");
        }
    }
}
