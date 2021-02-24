using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _8.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#])(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            string wordOne = "";
            string wordTwo = "";
            List<string> words = new List<string>();
            List<string> mirrorWords = new List<string>();
            if (Regex.IsMatch(input, pattern))
            {
                var matches = Regex.Matches(input, pattern);
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match item in matches)
                {
                    words.Add(item.Value);
                }
                int curr = 0;
                foreach (var item in words)
                {
                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        if (item[i] != '@' && item[i] != '#')
                        {
                            wordOne += item[i];
                        }
                        curr = i;
                    }
                    for (int j = item.Length - 1; j >= curr; j--)
                    {
                        if (item[j] != '@' && item[j] != '#')
                        {
                            wordTwo += item[j];
                        }
                    }
                    string reversed = "";
                    for (int i = wordTwo.Length - 1; i >= 0; i--)
                    {
                        reversed += wordTwo[i];
                    }
                    if (wordOne == wordTwo)
                    {
                        mirrorWords.Add(wordOne);
                        mirrorWords.Add(reversed);
                    }
                    wordOne = "";
                    wordTwo = "";
                    reversed = "";
                }
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    for (int i = 0; i < mirrorWords.Count - 2; i += 2)
                    {
                        Console.Write($"{mirrorWords[i]} <=> {mirrorWords[i + 1]}" + ", ");
                    }
                    Console.WriteLine($"{mirrorWords[mirrorWords.Count - 2]} <=> {mirrorWords[mirrorWords.Count - 1]}");
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
