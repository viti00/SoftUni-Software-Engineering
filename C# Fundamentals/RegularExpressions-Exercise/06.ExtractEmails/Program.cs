using System;
using System.Text.RegularExpressions;

namespace EmailExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^|\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";
            string input = Console.ReadLine();
            var matched = Regex.Matches(input, pattern);
            foreach (Match match in matched)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
