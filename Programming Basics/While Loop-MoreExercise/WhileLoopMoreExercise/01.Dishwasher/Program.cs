using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());
            bottlesDetergent *= 750;
            string numberOfContainers = string.Empty;
            int containers = 0;
            int counter = 0;
            int numberOfDishesWashed = 0;
            int numberOfPotsWashed = 0;

            while (true)
            {
                numberOfContainers = Console.ReadLine();
                if (numberOfContainers == "End")
                {
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    containers = int.Parse(numberOfContainers);
                    numberOfPotsWashed += containers;
                    bottlesDetergent -= containers * 15;
                }
                else
                {
                    containers = int.Parse(numberOfContainers);
                    numberOfDishesWashed += containers;
                    bottlesDetergent -= containers * 5;
                }
                if (bottlesDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesDetergent)} ml. more necessary!");
                    return;
                }
            }
            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{numberOfDishesWashed} dishes and {numberOfPotsWashed} pots were washed.");
            Console.WriteLine($"Leftover detergent {bottlesDetergent} ml.");
        }
    }
}
