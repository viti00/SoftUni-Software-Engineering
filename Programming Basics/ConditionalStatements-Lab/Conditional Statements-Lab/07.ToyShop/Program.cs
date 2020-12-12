using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int speakToysNum = int.Parse(Console.ReadLine());
            int bearsNum = int.Parse(Console.ReadLine());
            int minionsNum = int.Parse(Console.ReadLine());
            int trucksNum = int.Parse(Console.ReadLine());
            double toysPrice = puzzleNum * 2.60 + speakToysNum * 3 + bearsNum * 4.10 + minionsNum * 8.20 + trucksNum * 2;
            double toysNum = puzzleNum + speakToysNum + bearsNum + minionsNum + trucksNum;
            double priceAfterDiscount = 0;
            if (toysNum >= 50)
            {
                priceAfterDiscount = toysPrice - (toysPrice * 0.25);
            }
            else
            {
                priceAfterDiscount = toysPrice;
            }
            double rent = priceAfterDiscount * 0.10;
            double profit = priceAfterDiscount - rent;
            if (profit - travelPrice >= 0)
            {
                double more = profit - travelPrice;
                Console.WriteLine($"Yes! {more:F2} lv left.");
            }
            else if (travelPrice - profit > 0)
            {
                double needed = travelPrice - profit;
                Console.WriteLine($"Not enough money! {needed:F2} lv needed.");
            }
        }
    }
}
