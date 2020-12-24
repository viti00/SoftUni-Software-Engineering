using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            int foodInGr = foodInKg * 1000;
            string input = "";
            double gramCounter = 0.0;
            while (input != "Adopted")
            {
                input = Console.ReadLine();
                if (input == "Adopted")
                {
                    break;
                }
                gramCounter += int.Parse(input);
            }
            if (gramCounter <= foodInGr)
            {
                double more = foodInGr - gramCounter;
                Console.WriteLine($"Food is enough! Leftovers: {more} grams.");
            }
            else
            {
                double needed = gramCounter - foodInGr;
                Console.WriteLine($"Food is not enough. You need {needed} grams more.");
            }
        }
    }
}
