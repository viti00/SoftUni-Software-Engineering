using System;

namespace _5.Digit_letter_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digit = "";
            string letter = "";
            string otherSymbols = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    letter += text[i];
                }
                else
                {
                    otherSymbols += text[i];
                }
            }
            Console.WriteLine($"{digit}");
            Console.WriteLine($"{letter}");
            Console.WriteLine($"{otherSymbols}");
        }
    }
}
