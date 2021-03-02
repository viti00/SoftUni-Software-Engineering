using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->").ToArray();
                string plant = input[0];
                double rarity = double.Parse(input[1]);
                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new List<double>());
                    plants[plant].Add(rarity);
                }
                else
                {
                    plants[plant][0] = rarity;
                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exhibition")
                {
                    break;
                }
                string[] command = input.Split(new char[] { '-', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                string plant = command[1];
                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (command[0] == "Rate")
                {

                    double rating = double.Parse(command[2]);

                    plants[plant].Add(rating);
                }
                else if (command[0] == "Update")
                {
                    double rarity = double.Parse(command[2]);

                    plants[plant][0] = rarity;

                }
                else if (command[0] == "Reset")
                {
                    plants[plant].RemoveRange(1, plants[plant].Count - 1);

                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            foreach (var item in plants)
            {

                double rarity = item.Value[0];

                item.Value.RemoveAt(0);

                int count = item.Value.Count;

                double sum = item.Value.Sum();

                if (sum != 0)
                {
                    sum /= count;
                }
                item.Value.Clear();
                item.Value.Add(rarity);
                item.Value.Add(sum);

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {(int)item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
