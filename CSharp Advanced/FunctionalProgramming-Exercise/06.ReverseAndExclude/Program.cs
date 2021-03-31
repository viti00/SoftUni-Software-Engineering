using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> checkNumber = x => x % n != 0;

            Func<List<int>, Predicate<int>, List<int>> reverseAndRemove = (numbers, checkNumber) =>
            {
                List<int> reversedAndRemoved = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (checkNumber(numbers[i]))
                    {
                        reversedAndRemoved.Add(numbers[i]);
                    }
                }
                return reversedAndRemoved;
            };

            List<int> result = reverseAndRemove(numbers, checkNumber);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
