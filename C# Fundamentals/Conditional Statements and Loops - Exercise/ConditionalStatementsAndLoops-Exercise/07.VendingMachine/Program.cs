using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalCoins = 0.0;
            double nutsPrice = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;
            double change = 0.0;
            while (input != "Start")
            {
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    totalCoins += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                switch (product)
                {
                    case "Nuts":
                        if (totalCoins >= nutsPrice)
                        {
                            totalCoins -= nutsPrice;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else if (totalCoins < nutsPrice)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalCoins >= water)
                        {
                            totalCoins -= water;
                            Console.WriteLine($"Purchased water");
                        }
                        else if (totalCoins < nutsPrice)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalCoins >= crisps)
                        {
                            totalCoins -= crisps;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else if (totalCoins < nutsPrice)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalCoins >= soda)
                        {
                            totalCoins -= soda;
                            Console.WriteLine($"Purchased soda");
                        }
                        else if (totalCoins < nutsPrice)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalCoins >= coke)
                        {
                            totalCoins -= coke;
                            Console.WriteLine($"Purchased coke");
                        }
                        else if (totalCoins < nutsPrice)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                }
                product = Console.ReadLine();
            }
            change = totalCoins;
            Console.WriteLine($"Change: {change:f2}");
        }
    }
}
