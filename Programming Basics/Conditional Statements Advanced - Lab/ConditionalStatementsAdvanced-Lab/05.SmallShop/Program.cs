using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    price = count * 0.50;
                }
                else if (town == "Plovdiv")
                {
                    price = count * 0.40;
                }
                else if (town == "Varna")
                {
                    price = count * 0.45;
                }
            }
            if (product == "water")
            {
                if (town == "Sofia")
                {
                    price = count * 0.80;
                }
                else if (town == "Plovdiv")
                {
                    price = count * 0.70;
                }
                else if (town == "Varna")
                {
                    price = count * 0.70;
                }
            }
            if (product == "beer")
            {
                if (town == "Sofia")
                {
                    price = count * 1.20;
                }
                else if (town == "Plovdiv")
                {
                    price = count * 1.15;
                }
                else if (town == "Varna")
                {
                    price = count * 1.10;
                }
            }
            if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    price = count * 1.45;
                }
                else if (town == "Plovdiv")
                {
                    price = count * 1.30;
                }
                else if (town == "Varna")
                {
                    price = count * 1.35;
                }
            }
            if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    price = count * 1.60;
                }
                else if (town == "Plovdiv")
                {
                    price = count * 1.50;
                }
                else if (town == "Varna")
                {
                    price = count * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
