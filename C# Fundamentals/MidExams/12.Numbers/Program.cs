using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            List<int> newList = new List<int>();
            double sum = numbers.Sum();
            double averageSum = sum / numbers.Count;
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageSum)
                {
                    newList.Add(numbers[i]);
                    if (newList.Count == 5)
                    {
                        break;
                    }
                }
            }
            if (newList.Count == 0)
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
