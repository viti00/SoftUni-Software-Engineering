using System;

namespace CharMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (words[0].Length < words[1].Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }
            int total = CharMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }
        public static int CharMultiplier(string longest, string shortest)
        {
            int sum = 0;
            for (int i = 0; i < shortest.Length; i++)
            {
                int multiply = shortest[i] * longest[i];
                sum += multiply;
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }
            return sum;
        }
    }
}
