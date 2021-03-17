using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] temp = command.Split(", ");

                string market = temp[0];
                string product = temp[1];
                double price = double.Parse(temp[2]);

                if (!products.ContainsKey(market))
                {
                    products.Add(market, new Dictionary<string, double>());
                }

                if (!products[market].ContainsKey(product))
                {
                    products[market].Add(product, price);
                }
                command = Console.ReadLine();
            }

            foreach (var market in products.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{market.Key}->");
                foreach (var product in market.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
