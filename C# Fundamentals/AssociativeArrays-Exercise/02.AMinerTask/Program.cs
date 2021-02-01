using System;
using System.Collections.Generic;

namespace _2.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            long quantities = long.Parse(Console.ReadLine());
            Dictionary<string, long> products = new Dictionary<string, long>();
            while (true)
            {
                if (products.ContainsKey(product))
                {
                    products[product] += quantities;
                }
                else
                {
                    products.Add(product, quantities);
                }
                product = Console.ReadLine();
                if (product == "stop")
                {
                    break;
                }
                quantities = long.Parse(Console.ReadLine());
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
