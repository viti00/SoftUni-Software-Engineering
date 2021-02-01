using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string productName = string.Empty;
            double productPrice = 0;
            int count = 0;
            Dictionary<string, double> products = new Dictionary<string, double>();
            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            while (data != "buy")
            {
                string[] temp = data.Split();
                productName = temp[0];
                productPrice = double.Parse(temp[1]);
                count = int.Parse(temp[2]);
                if (products.ContainsKey(productName))
                {
                    products[productName] += count;
                }
                else
                {
                    products.Add(productName, count);
                }
                if (productPrices.ContainsKey(productName))
                {
                    productPrices[productName] = products[productName] * productPrice;
                }
                else
                {
                    productPrices.Add(productName, products[productName] * productPrice);
                }
                data = Console.ReadLine();
            }
            foreach (var item in productPrices)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

    }
}
