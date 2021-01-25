using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int lastPosition = 0;
            while (command != "Love!")
            {
                string[] temp = command.Split();
                int index = 0;
                if (temp[0] == "Jump")
                {
                    index = int.Parse(temp[1]);
                }
                while (index > 0)
                {
                    lastPosition++;
                    if (lastPosition >= neighborhood.Count)
                    {
                        lastPosition = 0;
                        break;
                    }
                    index--;
                }
                if (neighborhood[lastPosition] == 0)
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }
                else
                {
                    neighborhood[lastPosition] -= 2;
                    if (neighborhood[lastPosition] == 0)
                    {
                        Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            int failed = 0;
            if (neighborhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                for (int i = 0; i < neighborhood.Count; i++)
                {
                    if (neighborhood[i] > 0)
                    {
                        failed++;
                    }
                }
                Console.WriteLine($"Cupid has failed {failed} places.");
            }
        }
    }
}
