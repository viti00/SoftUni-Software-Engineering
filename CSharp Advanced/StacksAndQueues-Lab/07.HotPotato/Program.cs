using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split();
            int rounds = int.Parse(Console.ReadLine());
            Queue<string> playerNames = new Queue<string>();
            int counter = rounds;
            for (int i = 0; i < players.Length; i++)
            {
                playerNames.Enqueue(players[i]);
            }

            while (playerNames.Count != 1)
            {
                while (counter != 1)
                {
                    string player = playerNames.Dequeue();
                    playerNames.Enqueue(player);
                    counter--;
                }
                Console.WriteLine($"Removed {playerNames.Dequeue()}");
                counter = rounds;
            }
            Console.WriteLine($"Last is {playerNames.Peek()}");
        }
    }
}
