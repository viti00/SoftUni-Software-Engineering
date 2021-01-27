using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> targets = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();


        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] commandInput = input.Split().ToArray();

            string command = commandInput[0];
            int index = int.Parse(commandInput[1]);

            if (command == "Shoot")
            {
                int power = int.Parse(commandInput[2]);

                if (index >= 0 && index < targets.Count)
                {
                    targets[index] -= power;

                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }
            }
            else if (command == "Add")
            {
                int value = int.Parse(commandInput[2]);

                if (index >= 0 && index < input.Length)
                {
                    targets.Insert(index, value);
                }
                else
                {
                    Console.WriteLine("Invalid placement!");
                }
            }
            else if (command == "Strike")
            {
                int radius = int.Parse(commandInput[2]);

                if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                {
                    targets.RemoveRange(index - radius, radius * 2 + 1);
                }
                else
                {
                    Console.WriteLine($"Strike missed!");
                }
            }
        }

        Console.WriteLine(string.Join("|", targets));

    }
}