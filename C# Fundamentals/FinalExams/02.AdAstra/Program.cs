using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _14.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([|#])(?<product>[A-Za-z ]+)\1(?<day>[0][1-9]|[1-2][0-9]|[3][0-1])\/(?<month>[0][1-9]|[1][0-2])\/(?<year>\d{2})\1(?<calories>\d+)\1";
            string input = Console.ReadLine();
            int totalCalories = 0;
            Dictionary<string, List<string>> products = new Dictionary<string, List<string>>();
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalCalories += calories;
            }
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["product"].Value}, Best before: {match.Groups["day"].Value}/{match.Groups["month"].Value}/{match.Groups["year"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
