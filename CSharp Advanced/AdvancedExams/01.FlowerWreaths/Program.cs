using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] roses = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Stack<int> stackLilies = new Stack<int>(lilies);

            Queue<int> queueRoses = new Queue<int>(roses);

            int wreathsCount = 0;
            List<int> storedSum = new List<int>();

            while (stackLilies.Count != 0 && queueRoses.Count != 0)
            {
                if (stackLilies.Peek() + queueRoses.Peek() == 15)
                {
                    wreathsCount++;
                    stackLilies.Pop();
                    queueRoses.Dequeue();
                }
                else if (stackLilies.Peek() + queueRoses.Peek() > 15)
                {
                    int result = stackLilies.Pop() - 2;
                    stackLilies.Push(result);
                }
                else if (stackLilies.Peek() + queueRoses.Peek() < 15)
                {
                    storedSum.Add(stackLilies.Pop() + queueRoses.Dequeue());
                }
            }

            if (storedSum.Count > 0)
            {
                int sum = storedSum.Sum();
                int moreWreaths = sum / 15;
                wreathsCount += moreWreaths;
            }

            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                int needed = 5 - wreathsCount;
                Console.WriteLine($"You didn't make it, you need {needed} wreaths more!");
            }
        }
    }
}
