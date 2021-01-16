using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = ReadFirstInput();
            List<int> secondList = ReadSecondInput();
            Console.WriteLine(string.Join(" ", MergeLists(firstList, secondList)));

        }
        static List<int> ReadFirstInput()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            return firstList;
        }
        static List<int> ReadSecondInput()
        {
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            return secondList;
        }
        static List<int> MergeLists(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);
            List<int> merged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    merged.Add(first[i]);

                }
                if (second.Count > i)
                {
                    merged.Add(second[i]);
                }

            }
            return merged;
        }
    }
}
