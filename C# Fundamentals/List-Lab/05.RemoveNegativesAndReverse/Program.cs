using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = PrintNumbers();
            for (int i = 0; i < numbers.Count; i++)
            {
                int n = numbers[i];
                if (n < 0)
                {
                    numbers.Remove(n);
                    i--;
                }
            }
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> PrintNumbers()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            return numbers;
        }
    }
}
