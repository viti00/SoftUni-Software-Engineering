using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> listElements = new List<double>();
            for (int i = 1; i <= n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                listElements.Add(element);
            }

            var value = double.Parse(Console.ReadLine());

            Console.WriteLine(Compare(listElements, value));
        }

        public static int Compare<T>(List<T> elements, T value) 
            where T : IComparable<T>
        {
            int counter = 0;
            foreach (var item in elements)
            {
                if (item.CompareTo(value) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
