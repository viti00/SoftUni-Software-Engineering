using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            Stack<string> reverse = new Stack<string>();
            for (int i = 0; i < words.Length; i++)
            {
                reverse.Push(words[i].ToString());
            }
            while (reverse.Count != 0)
            {
                Console.Write(reverse.Pop());
            }
        }
    }
}
