using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            int numburOfDays = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int corrugations = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            //calculation
            double cakePrice = 45;
            double corrugationsPrice = 5.80;
            double pancakesPrice = 3.20;
            double totalSumDay = (cakes * cakePrice + corrugations * corrugationsPrice + pancakes * pancakesPrice) * cooks;
            double totalSumCompaing = ((cakes * cakePrice + corrugations * corrugationsPrice + pancakes * pancakesPrice) * cooks) * numburOfDays;
            double netSum = totalSumCompaing - totalSumCompaing / 8;
            // read output
            Console.WriteLine(netSum);
        }
    }
}
