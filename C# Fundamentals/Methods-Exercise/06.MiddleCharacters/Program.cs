using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(PrintMiddle(word));
        }
        static string PrintMiddle(string word)
        {
            int lenght = word.Length;
            string result = string.Empty;
            if (lenght % 2 == 1)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2 - 1].ToString() + word[word.Length / 2].ToString();
            }
            return result;
        }
    }
}
