using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine()
                                     .Split()
                                     .ToArray();
            // n is number of rotation (first number goes at the end)
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string elementToRotate = values[0];

                for (int j = 1; j < values.Length; j++)
                {
                    string curentElemnt = values[j];
                    values[j - 1] = curentElemnt;
                }
                values[values.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(" ", values));
        }
    }
}
