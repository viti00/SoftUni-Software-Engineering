using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            Func<int, List<int>> getSequence = endIndex =>
            {
                List<int> sequence = new List<int>();
                for (int i = 1; i <= endIndex; i++)
                {
                    sequence.Add(i);
                }
                return sequence;
            };

            List<int> sequence = getSequence(endIndex);

            Predicate<int> predicate = num =>
            {
                int counter = 0;
                for (int i = 0; i < dividers.Length; i++)
                {
                    if (num % dividers[i] == 0)
                    {
                        counter++;
                    }
                }
                if (counter == dividers.Length)
                {
                    return true;
                }
                return false;
            };

            Func<List<int>, Predicate<int>, List<int>> getCorrectNumbers = (sequence, predicate) =>
            {
                List<int> correctNumbes = new List<int>();

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (predicate(sequence[i]) == true)
                    {
                        correctNumbes.Add(sequence[i]);
                    }
                }

                return correctNumbes;
            };

            List<int> correctNumbers = getCorrectNumbers(sequence, predicate);

            Console.WriteLine(string.Join(" ", correctNumbers));
        }
    }
}
