using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            int asciiCodeFirstSymbol = (int)firstSymbol;
            int asciiCodeSecondSymbol = (int)secondSymbol;

            string text = Console.ReadLine();
            int sum = 0;
            foreach (var ch in text)
            {
                if (ch > asciiCodeFirstSymbol && ch < asciiCodeSecondSymbol)
                {
                    sum += ch;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
