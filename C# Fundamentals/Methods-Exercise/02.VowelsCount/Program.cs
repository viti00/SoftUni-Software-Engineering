using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            VowelsCount(word);

        }
        static void VowelsCount(string word)
        {
            char[] letter = word.ToArray();
            int counter = 0;
            foreach (char item in letter)
            {
                if (item == 'a' || item == 'o' || item == 'u' || item == 'e' || item == 'i'
                    || item == 'A' || item == 'O' || item == 'U' || item == 'E' || item == 'I')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
