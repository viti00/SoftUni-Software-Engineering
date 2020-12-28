using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int counter = 0;
            string product = Console.ReadLine();
            double totalPrice = 0;
            while (product != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    price = price / 2;
                }
                if (budged - price >= 0)
                {
                    budged -= price;
                    totalPrice += price;
                }
                else
                {
                    double needed = price - budged;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {needed:F2} leva!");
                    return;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"You bought {counter} products for {totalPrice:F2} leva.");
        }
    }
}
