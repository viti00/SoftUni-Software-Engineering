using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiRegex = @"(\*\*|::)(?<emoji>[A-Z][a-z]{2,})(\1)";
            string coolThresholdRegex = @"\d";
            string input = Console.ReadLine();
            var matchesDigit = Regex.Matches(input, coolThresholdRegex);
            int threshold = 1;
            int result = 0;
            foreach (Match matches in matchesDigit)
            {
                threshold *= int.Parse(matches.ToString());
            }
            var matcheEmoji = Regex.Matches(input, emojiRegex);
            List<string> emoji = new List<string>();
            Dictionary<string, int> emojiCool = new Dictionary<string, int>();
            foreach (Match matches in matcheEmoji)
            {
                emoji.Add(matches.Value);
            }
            foreach (var item in emoji)
            {
                foreach (var ch in item)
                {
                    if (ch != ':' && ch != '*')
                    {
                        int position = (int)ch;
                        result += position;
                    }
                }
                if (emojiCool.ContainsKey(item))
                {
                    emojiCool[item] = result;
                }
                else
                {
                    emojiCool.Add(item, result);
                }
                result = 0;
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiCool.Count} emojis found in the text. The cool ones are:");
            foreach (var item in emojiCool)
            {
                if (item.Value > threshold)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
