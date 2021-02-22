using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            string regexName = @"(?<name>[A-Za-z])";
            string regexDistance = @"(?<distance>[0-9])";
            string name = "";
            int distance = 0;
            Dictionary<string, int> playerInformations = new Dictionary<string, int>();
            while (input != "end of race")
            {
                MatchCollection matchedChar = Regex.Matches(input, regexName);
                MatchCollection matchedDistance = Regex.Matches(input, regexDistance);
                foreach (Match chars in matchedChar)
                {
                    name += chars;
                }
                foreach (Match item in matchedDistance)
                {
                    distance += int.Parse(item.Value);
                }
                if (names.Contains(name))
                {
                    if (playerInformations.ContainsKey(name))
                    {
                        playerInformations[name] += distance;
                    }
                    else
                    {
                        playerInformations.Add(name, distance);
                    }
                }
                distance = 0;
                name = "";
                input = Console.ReadLine();
            }
            string[] temp = { "1st", "2nd", "3rd" };
            int t = 0;
            foreach (var item in playerInformations.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{temp[t]} place: {item.Key}");
                t++;
                if (t == 3)
                {
                    break;
                }
            }
        }
    }
}
