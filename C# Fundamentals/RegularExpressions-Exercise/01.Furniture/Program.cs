using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @">>(?<product>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";
            double totalPrice = 0;
            var items = new List<string>();
            while (input != "Purchase")
            {
                MatchCollection matched = Regex.Matches(input, regex);
                foreach (Match match in matched)
                {
                    var name = match.Groups["product"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = double.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                    items.Add(name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
