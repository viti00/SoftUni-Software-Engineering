using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                                               .Split(" ")
                                               .ToArray();
                string indexZeroElement = currentArray[0];
                string indexOneElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = indexZeroElement;
                    secondArr[i] = indexOneElement;
                }
                else if (i % 2 == 1)
                {
                    firstArr[i] = indexOneElement;
                    secondArr[i] = indexZeroElement;
                }
            }
            Console.Write(string.Join(" ", firstArr));
            Console.WriteLine();
            Console.Write(string.Join(" ", secondArr));
        }
    }
}
