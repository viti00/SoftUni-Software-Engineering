using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];
            HashSet<int> nLenght = new HashSet<int>();
            HashSet<int> mLenght = new HashSet<int>();

            for (int i = 1; i <= n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                nLenght.Add(element);
            }

            for (int i = 1; i <= m; i++)
            {
                int element = int.Parse(Console.ReadLine());
                mLenght.Add(element);
            }

            foreach (var element in nLenght)
            {
                if (nLenght.Contains(element) && mLenght.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
