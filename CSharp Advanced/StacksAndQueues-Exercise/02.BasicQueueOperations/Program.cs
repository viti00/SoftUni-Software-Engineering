using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            Queue<int> numbers = new Queue<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(nums[i]);
            }

            for (int i = 1; i <= s; i++)
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine(numbers.Count);
                    return;
                }
                numbers.Dequeue();
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine(numbers.Count);
                return;
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
