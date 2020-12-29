using System;

namespace _01.BeehiveDeffense
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int hp = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());
            while (hp > 0 || bees > 0)
            {
                bees -= attack;
                hp -= bees * 5;
                if (bees < 100)
                {
                    if (bees <= 0)
                    {
                        bees = 0;
                        break;
                    }
                    break;
                }
                if (hp <= 0)
                {
                    hp = 0;
                    break;
                }
            }
            if (hp > 0)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
            }
            else if (bees > 0)
            {
                Console.WriteLine($"Beehive won! Bees left {bees}.");
            }
        }
    }
}
