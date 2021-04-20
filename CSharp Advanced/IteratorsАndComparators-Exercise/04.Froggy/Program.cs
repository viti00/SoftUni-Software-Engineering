using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lake<int> lakeStones = new Lake<int>();
            int[] stones = Console.ReadLine()
                                  .Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            List<int> evenStone = new List<int>();
            List<int> oddStone = new List<int>();

            for (int i = 0; i < stones.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenStone.Add(stones[i]);
                }
                else
                {
                    oddStone.Add(stones[i]);
                }
            }

            lakeStones.JumpEven(evenStone);
            lakeStones.JumpOdd(oddStone);

            Console.WriteLine(lakeStones);
        }
    }
}
