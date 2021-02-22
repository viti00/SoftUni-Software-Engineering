using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            SortedDictionary<string, Dictionary<decimal, decimal>> dataDemons = new SortedDictionary<string, Dictionary<decimal, decimal>>();
            foreach (var demon in input)
            {
                decimal health = 0;
                decimal damage = 0;
                string patternDigits = @"[+-]?[\d+\.]*[\d]+";
                var regDigits = new Regex(patternDigits);
                MatchCollection matchDigits = regDigits.Matches(demon);
                if (matchDigits.Count > 0)
                {
                    foreach (Match digit in matchDigits)
                    {
                        string temp = digit.ToString();
                        decimal num = decimal.Parse(temp);
                        damage += num;
                    }
                }
                string patternChars = @"[A-Za-z]*[^\d\.\+\-\*\/\s]+";
                var regChars = new Regex(patternChars);
                MatchCollection matchChar = regChars.Matches(demon);
                if (matchChar.Count > 0)
                {
                    foreach (Match letters in matchChar)
                    {
                        string temp = letters.ToString();
                        foreach (var ch in temp)
                        {
                            health += (int)ch;
                        }
                    }
                }

                string patternSign = @"[*\|/]";
                var regsigns = new Regex(patternSign);
                MatchCollection matchSigns = regsigns.Matches(demon);
                if (matchSigns.Count > 0)
                {
                    foreach (Match sign in matchSigns)
                    {
                        string c = sign.ToString();
                        if (c == "/")
                        {
                            damage /= 2;
                        }
                        else if (c == "*")
                        {
                            damage *= 2;
                        }
                    }
                }
                var inner = new Dictionary<decimal, decimal>();
                inner.Add(health, damage);
                dataDemons.Add(demon, inner);

            }
            foreach (var item in dataDemons)
            {
                Console.Write("{0} - ", item.Key);
                foreach (var i in item.Value)
                {
                    Console.WriteLine("{0} health, {1:f2} damage", i.Key, i.Value);
                }
            }
        }

    }
}