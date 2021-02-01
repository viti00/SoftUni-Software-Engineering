using System;
using System.Collections.Generic;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<char, int> word = new Dictionary<char, int>();
            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char n = item[i];
                    if (word.ContainsKey(n))
                    {
                        word[n]++;
                    }
                    else
                    {
                        word.Add(n, 1);
                    }
                }
            }
            foreach (var item in word)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
