using System;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double bagage20KgPrice = double.Parse(Console.ReadLine());
            double bagageKg = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int bagageCount = int.Parse(Console.ReadLine());
            double bagagePrice = 0.0;
            double bagagePriceAfterFee = 0.0;
            if (bagageKg < 10)
            {
                bagagePrice = bagage20KgPrice * 0.2;
            }
            else if (bagageKg >= 10 && bagageKg <= 20)
            {
                bagagePrice = bagage20KgPrice * 0.5;
            }
            else if (bagageKg > 20)
            {
                bagagePrice = bagage20KgPrice;
            }
            if (daysToTravel > 30)
            {
                bagagePriceAfterFee = bagagePrice + (bagagePrice * 0.1);
            }
            else if (daysToTravel >= 7 && daysToTravel <= 30)
            {
                bagagePriceAfterFee = bagagePrice + (bagagePrice * 0.15);
            }
            else if (daysToTravel < 7)
            {
                bagagePriceAfterFee = bagagePrice + (bagagePrice * 0.4);
            }
            double finalPrice = bagagePriceAfterFee * bagageCount;
            Console.WriteLine($"The total price of bags is: {finalPrice:F2} lv.");
        }
    }
}
