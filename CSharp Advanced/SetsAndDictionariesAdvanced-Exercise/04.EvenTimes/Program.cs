using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> evenTimes = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenTimes.ContainsKey(number))
                {
                    evenTimes.Add(number, 0);
                }
                evenTimes[number]++;
            }

            foreach (var number in evenTimes)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
