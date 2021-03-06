using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesValues);

            int rackCounter = 1;
            int currCapacity = rackCapacity;
            while (clothes.Count != 0)
            {
                if (currCapacity - clothes.Peek() >= 0)
                {
                    currCapacity -= clothes.Pop();
                }
                else
                {
                    currCapacity = rackCapacity;
                    rackCounter++;
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
