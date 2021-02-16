using System;
using System.Collections.Generic;

namespace MorseTraslate
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> morseTranslator = new Dictionary<char, string>();
            char dot = '.';
            char dash = '-';
            morseTranslator.Add('A', string.Concat(dot, dash));
            morseTranslator.Add('B', string.Concat(dash, dot, dot, dot));
            morseTranslator.Add('C', string.Concat(dash, dot, dash, dot));
            morseTranslator.Add('D', string.Concat(dash, dot, dot));
            morseTranslator.Add('E', dot.ToString());
            morseTranslator.Add('F', string.Concat(dot, dot, dash, dot));
            morseTranslator.Add('G', string.Concat(dash, dash, dot));
            morseTranslator.Add('H', string.Concat(dot, dot, dot, dot));
            morseTranslator.Add('I', string.Concat(dot, dot));
            morseTranslator.Add('J', string.Concat(dot, dash, dash, dash));
            morseTranslator.Add('K', string.Concat(dash, dot, dash));
            morseTranslator.Add('L', string.Concat(dot, dash, dot, dot));
            morseTranslator.Add('M', string.Concat(dash, dash));
            morseTranslator.Add('N', string.Concat(dash, dot));
            morseTranslator.Add('O', string.Concat(dash, dash, dash));
            morseTranslator.Add('P', string.Concat(dot, dash, dash, dot));
            morseTranslator.Add('Q', string.Concat(dash, dash, dot, dash));
            morseTranslator.Add('R', string.Concat(dot, dash, dot));
            morseTranslator.Add('S', string.Concat(dot, dot, dot));
            morseTranslator.Add('T', dash.ToString());
            morseTranslator.Add('U', string.Concat(dot, dot, dash));
            morseTranslator.Add('V', string.Concat(dot, dot, dot, dash));
            morseTranslator.Add('W', string.Concat(dot, dash, dash));
            morseTranslator.Add('X', string.Concat(dash, dot, dot, dash));
            morseTranslator.Add('Y', string.Concat(dash, dot, dash, dash));
            morseTranslator.Add('Z', string.Concat(dash, dash, dot, dot));

            morseTranslator.Add(' ', "|");

            //numbers
            morseTranslator.Add('1', string.Concat(dot, dash, dash, dash, dash));
            morseTranslator.Add('2', string.Concat(dot, dot, dash, dash, dash));
            morseTranslator.Add('3', string.Concat(dot, dot, dot, dash, dash));
            morseTranslator.Add('4', string.Concat(dot, dot, dot, dot, dash));
            morseTranslator.Add('5', string.Concat(dot, dot, dot, dot, dot));
            morseTranslator.Add('6', string.Concat(dash, dot, dot, dot, dot));
            morseTranslator.Add('7', string.Concat(dash, dash, dot, dot, dot));
            morseTranslator.Add('8', string.Concat(dash, dash, dash, dot, dot));
            morseTranslator.Add('9', string.Concat(dash, dash, dash, dash, dot));
            morseTranslator.Add('0', string.Concat(dash, dash, dash, dash, dash));

            string[] morseCode = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in morseCode)
            {
                foreach (var kvp in morseTranslator)
                {
                    if (item == kvp.Value)
                    {
                        Console.Write($"{kvp.Key}");
                        break;
                    }
                }
            }
        }
    }
}
