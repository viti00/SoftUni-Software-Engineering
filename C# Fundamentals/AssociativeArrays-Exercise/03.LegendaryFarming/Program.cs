using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            string materials = "";
            int quantity = 0;
            bool hasToBreak = false;
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else if (i % 2 == 1)
                    {
                        materials = input[i].ToLower();
                        if (materials == "shards" || materials == "fragments" || materials == "motes")
                        {
                            keyMaterials[materials] += quantity;
                            if (keyMaterials[materials] >= 250)
                            {
                                keyMaterials[materials] -= 250;
                                if (materials == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                }
                                else if (materials == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                }
                                else if (materials == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                }
                                hasToBreak = true;
                                break;
                            }
                        }
                        else
                        {
                            if (junkMaterials.ContainsKey(materials))
                            {
                                junkMaterials[materials] += quantity;
                            }
                            else
                            {
                                junkMaterials.Add(materials, quantity);
                            }
                        }
                    }

                }
                if (hasToBreak)
                {
                    break;
                }
            }
            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
