using System;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string[] splited = words.Split();
            for (int i = splited.Length - 1; i >= 0; i--)
            {
                Console.Write(splited[i] + " ");
            }
        }
    }
}
