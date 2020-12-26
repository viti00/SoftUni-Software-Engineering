using System;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string input = "";
            double spaceCounter = 0.0;
            double third = 0.0;
            double bagCounter = 0.0;
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                bagCounter++;
                if (bagCounter % 3 == 0)
                {
                    third += double.Parse(input) * 0.1;
                }
                spaceCounter += double.Parse(input) + third;
                third = 0;
                if (spaceCounter > capacity)
                {
                    bagCounter--;
                    break;
                }
            }
            if (spaceCounter <= capacity)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {bagCounter} suitcases loaded.");
            }
            else
            {
                Console.WriteLine($"No more space!");
                Console.WriteLine($"Statistic: {bagCounter} suitcases loaded.");
            }
        }
    }
}
