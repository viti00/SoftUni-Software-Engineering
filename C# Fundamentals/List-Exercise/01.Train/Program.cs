using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                string[] token = comand.Split();
                if (token[0] == "Add")
                {
                    int numToAdd = int.Parse(token[1]);
                    wagons.Add(numToAdd);
                }
                else
                {
                    int passengers = int.Parse(token[0]);
                    int currNum = 0;
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        currNum = wagons[i];
                        if (currNum + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.Write(string.Join(" ", wagons));
        }
    }
}
