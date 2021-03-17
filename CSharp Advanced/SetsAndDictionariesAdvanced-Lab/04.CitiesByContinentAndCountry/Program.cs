using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> information = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 1; i <= n; i++)
            {
                string[] datas = Console.ReadLine().Split();

                string continent = datas[0];
                string country = datas[1];
                string city = datas[2];

                if (!information.ContainsKey(continent))
                {
                    information.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!information[continent].ContainsKey(country))
                {
                    information[continent].Add(country, new List<string>());
                }
                information[continent][country].Add(city);
            }

            foreach (var continent in information)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    Console.Write(string.Join(", ", country.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
