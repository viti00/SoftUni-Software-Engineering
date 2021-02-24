using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string cities = Console.ReadLine();
            Dictionary<string, List<int>> citiesInfo = new Dictionary<string, List<int>>();
            while (cities != "Sail")
            {
                string[] temp = cities.Split("||");
                string cityName = temp[0];
                int population = int.Parse(temp[1]);
                int gold = int.Parse(temp[2]);
                if (citiesInfo.ContainsKey(cityName))
                {
                    citiesInfo[cityName][0] += population;
                    citiesInfo[cityName][1] += gold;
                }
                else
                {
                    citiesInfo.Add(cityName, new List<int> { population, gold });
                }
                cities = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command.Split("=>");
                string commandType = token[0];
                switch (commandType)
                {
                    case "Plunder":
                        string cityName = token[1];
                        int killedPeoples = int.Parse(token[2]);
                        int stolenGold = int.Parse(token[3]);
                        if (citiesInfo.ContainsKey(cityName))
                        {
                            citiesInfo[cityName][0] -= killedPeoples;
                            citiesInfo[cityName][1] -= stolenGold;
                        }
                        Console.WriteLine($"{cityName} plundered! {stolenGold} gold stolen, {killedPeoples} citizens killed.");
                        if (citiesInfo[cityName][0] <= 0 || citiesInfo[cityName][1] <= 0)
                        {
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                            citiesInfo.Remove(cityName);
                        }
                        break;
                    case "Prosper":
                        string city = token[1];
                        int gold = int.Parse(token[2]);
                        if (citiesInfo.ContainsKey(city))
                        {
                            if (gold < 0)
                            {
                                Console.WriteLine("Gold added cannot be a negative number!");
                            }
                            else
                            {

                                citiesInfo[city][1] += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {citiesInfo[city][1]} gold.");
                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ahoy, Captain! There are {citiesInfo.Count} wealthy settlements to go to:");
            foreach (var item in citiesInfo.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
            }
        }
    }
}
