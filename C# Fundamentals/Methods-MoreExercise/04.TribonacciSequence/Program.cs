using System;
using System.Collections.Generic;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            CheckNumInSequence(num);
        }
        static void CheckNumInSequence(int num)
        {
            List<int> sequence = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int currLoopPosition = i;
                int currSequencePosition = sequence.Count - 1;
                if (i == 0)
                {
                    sequence.Add(1);
                }
                else
                {
                    sequence.Add(Sum(currSequencePosition, currLoopPosition, sequence));
                }
            }
            PrintSequence(sequence);
        }
        static void PrintSequence(List<int> sequence)
        {
            foreach (var item in sequence)
            {
                Console.Write($"{item}" + " ");
            }
        }
        static int Sum(int currSequencePosition, int currLoopPosition, List<int> sequence)
        {
            int sum = 0;
            for (int j = currSequencePosition; j >= currLoopPosition - 3; j--)
            {
                if (j >= 0)
                {
                    sum += sequence[j];
                }
            }
            return sum;
        }
    }
}
