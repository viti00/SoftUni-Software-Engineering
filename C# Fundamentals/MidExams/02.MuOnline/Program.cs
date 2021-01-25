using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();
            int playerHp = 100;
            int bitcoins = 0;
            int amount = 0;
            int currBitcoins = 0;
            int roomsCounter = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                var item = rooms[i].Split(" ");
                var comand = int.Parse(item[1]);
                if (item[0] == "potion")
                {
                    if (playerHp >= 100)
                    {
                        playerHp = 100;
                    }
                    if (playerHp + comand >= 100)
                    {
                        amount = 100 - playerHp;
                        playerHp = 100;
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {playerHp} hp.");
                    }
                    else if (playerHp + comand < 100)
                    {
                        amount = comand;
                        playerHp += comand;
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {playerHp} hp.");
                    }
                    roomsCounter++;
                }
                else if (item[0] == "chest")
                {
                    bitcoins += comand;
                    currBitcoins = comand;
                    Console.WriteLine($"You found {currBitcoins} bitcoins.");
                    roomsCounter++;
                }
                else if (item[0] != "potion" && item[0] != "chest")
                {
                    if (playerHp > comand)
                    {
                        playerHp -= comand;
                        Console.WriteLine($"You slayed {item[0]}.");
                        roomsCounter++;
                    }
                    else if (playerHp <= comand)
                    {
                        roomsCounter++;
                        playerHp = comand - playerHp;
                        Console.WriteLine($"You died! Killed by {item[0]}.");
                        Console.WriteLine($"Best room: {roomsCounter}");
                        break;
                    }

                }
            }
            if (playerHp > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {playerHp}");
            }
        }
    }
}
