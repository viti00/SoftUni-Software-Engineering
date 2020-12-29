using System;

namespace _03.BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                population += population / 10 * 2;
                if (i % 5 == 0)
                {
                    population -= population / 50 * 5;
                }
                population -= population / 20 * 2;
            }
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
