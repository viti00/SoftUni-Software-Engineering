using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[starSTAR]";
            int n = int.Parse(Console.ReadLine());
            int position = 0;
            string result = "";
            List<string> info = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection match = Regex.Matches(input, regex);
                int count = match.Count;
                foreach (var ch in input)
                {
                    position = (int)ch - count;
                    result += Convert.ToChar(position);

                }
                info.Add(result);
                result = "";


            }
            string pattern = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<attack_type>[AD])!([^@\-!:>])*->(?<soldier_count>[0-9]+)";
            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>
            {
                ["Attacked"] = new List<string>(),
                ["Destroyed"] = new List<string>(),
            };

            foreach (var item in info)
            {
                var matched = Regex.Matches(item, pattern);
                foreach (Match match in matched)
                {
                    var name = match.Groups["planet"].Value;
                    var type = match.Groups["attack_type"].Value;
                    if (type == "A")
                    {
                        planets["Attacked"].Add(name);
                    }
                    else
                    {
                        planets["Destroyed"].Add(name);
                    }

                }
            }
            foreach (var item in planets)
            {
                Console.WriteLine($"{item.Key} planets: {item.Value.Count}");
                foreach (var kvp in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {kvp}");
                }

            }
        }
    }
}
