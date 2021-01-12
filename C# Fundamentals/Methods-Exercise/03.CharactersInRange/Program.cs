using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintCharInRange(first, second);
        }
        static void PrintCharInRange(char first, char second)
        {

            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    char result = (char)i;
                    Console.Write(result + " ");
                }
            }
            else if (first > second)
            {
                for (int i = second + 1; i < first; i++)
                {
                    char result = (char)i;
                    Console.Write(result + " ");
                }
            }

        }
    }
}
