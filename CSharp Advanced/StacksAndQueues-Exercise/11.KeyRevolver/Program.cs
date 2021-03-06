using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace keyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int costOfBullets = int.Parse(Console.ReadLine());

            int revolverSize = int.Parse(Console.ReadLine());

            int[] tokensbullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(tokensbullets);
            int[] tokensLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> locks = new Stack<int>(tokensLocks.Reverse());
            int bounty = int.Parse(Console.ReadLine());
            int count = 0;
            int startBullets = bullets.Count;

            while (bullets.Count != 0 && locks.Count != 0)
            {
                int bullet = bullets.Pop();
                int currentlock = locks.Pop();
                count++;
                if (bullet <= currentlock)
                {
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                    locks.Push(currentlock);
                }

                if (bullets.Count == 0)
                {
                    break;
                }
                if (count == revolverSize)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int bulletsLeft = bullets.Count;
                int money = bounty - (costOfBullets * (startBullets - bulletsLeft));
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${money}");
            }
        }
    }
}