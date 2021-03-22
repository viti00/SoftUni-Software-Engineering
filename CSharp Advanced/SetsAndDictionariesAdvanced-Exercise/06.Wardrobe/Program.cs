using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ");

                string colors = command[0];
                string[] temp = command[1].Split(",");

                if (!wardrobe.ContainsKey(colors))
                {
                    wardrobe.Add(colors, new Dictionary<string, int>());
                }

                for (int j = 0; j < temp.Length; j++)
                {
                    string clothes = temp[j];

                    if (!wardrobe[colors].ContainsKey(clothes))
                    {
                        wardrobe[colors].Add(clothes, 0);
                    }
                    wardrobe[colors][clothes]++;
                }
            }

            string[] commandFind = Console.ReadLine().Split();

            string color = commandFind[0];
            string wear = commandFind[1];

            foreach (var clothes in wardrobe)
            {
                Console.WriteLine($"{clothes.Key} clothes:");
                foreach (var type in clothes.Value)
                {
                    if (clothes.Key == color && wear == type.Key)
                    {
                        Console.WriteLine($"* {type.Key} - {type.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {type.Key} - {type.Value}");
                }
            }
        }
    }
}
