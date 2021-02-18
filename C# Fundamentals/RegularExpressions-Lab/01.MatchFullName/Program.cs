using System;
using System.Text.RegularExpressions;

namespace MatchFullNames1
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            Regex matches = new Regex(regex);
            var matchNames = matches.Matches(input);
            foreach (Match item in matchNames)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
