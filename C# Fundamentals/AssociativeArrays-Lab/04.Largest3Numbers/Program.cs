using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            if (sorted.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{sorted[i]}" + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", sorted));
            }
        }
    }
}
