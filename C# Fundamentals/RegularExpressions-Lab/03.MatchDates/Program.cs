using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection dates =
                Regex.Matches(input, @"\b(?<day>[0-3][0-9])(?:(-)|(.)|(\/))(?<month>[A-Z][a-z]{2})(\1|\2|\3)(?<year>[0-9]{4})\b");

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
