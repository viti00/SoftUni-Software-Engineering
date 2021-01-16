using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = SingleLine();
            Console.WriteLine(string.Join(" ", SumPairs(list)));
        }
        static List<int> SumPairs(List<int> number)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < number.Count / 2; i++)
            {
                result.Add(number[i] + number[number.Count - i - 1]);
            }
            if (number.Count % 2 == 1)
            {
                result.Add(number[number.Count / 2]);
            }
            return result;
        }
        static List<int> SingleLine()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            return list;
        }
    }
}
