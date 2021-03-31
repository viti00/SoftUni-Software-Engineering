using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] indexes = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int startIndex = indexes[0];
            int endIndex = indexes[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateNumbers = (s, e) =>
            {
                List<int> newNumbers = new List<int>();
                for (int i = s; i <= e; i++)
                {
                    newNumbers.Add(i);
                }
                return newNumbers;
            };

            List<int> numbers = generateNumbers(startIndex, endIndex);

            Predicate<int> predicate = n => true;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Func<List<int>, Predicate<int>, List<int>> FindEvenOrOdd = (numbers, predicate) =>
            {
                List<int> evenOrOdd = new List<int>();
                foreach (int num in numbers)
                {
                    if (predicate(num) == true)
                    {
                        evenOrOdd.Add(num);
                    }
                }
                return evenOrOdd;
            };
            List<int> evenOrOdd = FindEvenOrOdd(numbers, predicate);
            Console.WriteLine(string.Join(" ", evenOrOdd));
        }
    }
}
