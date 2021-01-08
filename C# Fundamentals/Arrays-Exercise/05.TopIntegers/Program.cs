using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isBigger = true;
            for (int i = 0; i < values.Length; i++)
            {
                int currentElement = values[i];
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] >= currentElement)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currentElement + " ");
                }
                isBigger = true;
            }
        }
    }
}
