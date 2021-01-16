using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int NumberToAdd = int.Parse(tokens[1]);
                        numbers.Add(NumberToAdd);
                        break;
                    case "Remove":
                        int NumberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(NumberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int NumberToInsert = int.Parse(tokens[1]);
                        int IndexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(IndexToInsert, NumberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
