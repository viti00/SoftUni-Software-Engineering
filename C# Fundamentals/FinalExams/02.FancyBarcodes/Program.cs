using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5.FancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            int n = int.Parse(Console.ReadLine());
            string curr = "";
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, regex))
                {
                    var matches = Regex.Matches(input, regex);
                    foreach (Match item in matches)
                    {
                        curr = item.Value;
                    }
                    foreach (var ch in curr)
                    {
                        if (char.IsDigit(ch))
                        {
                            result += ch.ToString();
                        }
                    }
                    if (result == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {result}");
                    }
                    result = "";
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
