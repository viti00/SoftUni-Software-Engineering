using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string text = Console.ReadLine();
            string result = "";
            int curr = 0;
            while (text != "find")
            {
                foreach (var ch in text)
                {
                    if (curr == keys.Length)
                    {
                        curr = 0;
                    }
                    for (int i = curr; i < keys.Length;)
                    {
                        int position = ch - keys[i];
                        result += Convert.ToChar(position);
                        curr++;
                        break;
                    }
                }
                int materialFirstIndex = result.IndexOf("&");
                int materialLastIndex = result.LastIndexOf("&");

                int cordinateFirstIndex = result.IndexOf("<");
                int cordinateLastIndex = result.IndexOf(">");

                string material = result
                    .Substring(materialFirstIndex + 1, materialLastIndex - materialFirstIndex - 1);
                string cordinate = result
                    .Substring(cordinateFirstIndex + 1, cordinateLastIndex - cordinateFirstIndex - 1);
                Console.WriteLine($"Found {material} at {cordinate}");
                result = "";
                curr = 0;
                text = Console.ReadLine();
            }
        }
    }
}
