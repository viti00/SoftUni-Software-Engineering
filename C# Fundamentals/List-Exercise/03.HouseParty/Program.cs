using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int comandsNumber = int.Parse(Console.ReadLine());
            List<string> goingToParty = new List<string>();
            for (int i = 1; i <= comandsNumber; i++)
            {
                string names = Console.ReadLine();
                string[] tokens = names.Split();

                if (tokens.Length == 3)
                {
                    if (goingToParty.Contains(tokens[0]))
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    else
                    {
                        goingToParty.Add(tokens[0]);
                    }
                }

                else if (tokens.Length == 4)
                {
                    if (goingToParty.Contains(tokens[0]))
                    {
                        goingToParty.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }

            }
            for (int i = 0; i < goingToParty.Count; i++)
            {
                string currElement = goingToParty[i];
                Console.WriteLine(currElement);
            }
        }
    }
}
