using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            PrintPrice(product, count);
        }
        static void PrintPrice(string product, int count)
        {
            double price = 0.0;
            double totalPrice = 0.0;
            switch (product)
            {

                case "coffee":
                    price = 1.50;
                    totalPrice = count * price;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "water":
                    price = 1.00;
                    totalPrice = count * price;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "coke":
                    price = 1.40;
                    totalPrice = count * price;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "snacks":
                    price = 2.00;
                    totalPrice = count * price;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
            }
        }
    }
}
