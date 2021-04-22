using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> first = new Queue<int>(firstBox);
            Stack<int> second = new Stack<int>(secondBox);

            List<int> sums = new List<int>();

            while(first.Count != 0 && second.Count != 0)
            {
                int sum = first.Peek() + second.Peek();
                if (sum % 2 == 0)
                {
                    sums.Add(sum);
                    first.Dequeue();
                    second.Pop();
                }
                else
                {
                    int item = second.Pop();
                    first.Enqueue(item);
                }
            }

            if (first.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (second.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int finalSum = sums.Sum();

            if (finalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {finalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {finalSum}");
            }
        }
    }
}
