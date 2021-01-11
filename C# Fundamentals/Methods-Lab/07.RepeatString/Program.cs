using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(word, n));
        }
        private static string RepeatString(string word, int counter)
        {
            string result = " ";
            for (int i = 1; i <= counter; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
