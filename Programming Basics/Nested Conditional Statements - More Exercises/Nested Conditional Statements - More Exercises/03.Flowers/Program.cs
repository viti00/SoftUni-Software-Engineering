using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNo = Console.ReadLine();
            int totalFlowers = hrizantemi + rozi + laleta;
            double price = 0;
            double finalPrice = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                double priceForSeason = (hrizantemi * 2.00) + (rozi * 4.10) + (laleta * 2.50);
                price = priceForSeason;
                if (holidayOrNo == "Y")
                {
                    price = price + (price * 0.15);
                    finalPrice = price + 2;
                }
                if (laleta > 7 && season == "Spring")
                {
                    price = price - (price * 0.05);
                    finalPrice = price + 2;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                double priceForSeason = (hrizantemi * 3.75) + (rozi * 4.50) + (laleta * 4.15);
                price = priceForSeason;
                if (holidayOrNo == "Y")
                {
                    price = price + (price * 0.15);
                    finalPrice = price + 2;
                }
                if (rozi >= 10 && season == "Winter")
                {
                    price = price - (price * 0.1);
                    finalPrice = price + 2;
                }
            }
            if (totalFlowers > 20)
            {
                price = price - (price * 0.2);
                finalPrice = price + 2;
                Console.WriteLine($"{finalPrice:F2}");
            }
            else
            {
                finalPrice = price + 2;
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}
