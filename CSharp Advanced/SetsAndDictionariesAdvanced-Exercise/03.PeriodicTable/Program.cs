using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalElements.Add(elements[j]);
                }
            }

            foreach (var element in chemicalElements)
            {
                Console.Write(element + " ");
            }
        }
    }
}
