using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _11.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            int travelPoints = 0;
            string result = "";
            List<string> matched = new List<string>();
            foreach (Match match in matches)
            {
                matched.Add(match.Value);
            }
            List<string> destinations = new List<string>();
            foreach (var item in matched)
            {
                foreach (var ch in item)
                {
                    if (ch != '=' && ch != '/')
                    {
                        result += ch;
                    }
                }
                destinations.Add(result);
                travelPoints += result.Length;
                result = "";
            }
            Console.Write("Destinations: ");
            Console.Write(string.Join(", ", destinations));
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
