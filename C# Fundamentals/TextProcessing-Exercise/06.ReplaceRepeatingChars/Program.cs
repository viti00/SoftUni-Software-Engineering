using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();
            for (int i = 0; i < text.Count - 1; i++)
            {
                char curr = text[i];
                char next = text[i + 1];
                if (curr == next)
                {
                    text.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
