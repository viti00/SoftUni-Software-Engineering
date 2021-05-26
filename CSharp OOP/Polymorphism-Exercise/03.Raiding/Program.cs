using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            BaseHero hero;

            while(n != count)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type)
                {
                    case "Druid":
                        hero = new Druid(type, name);
                        heroes.Add(hero);
                        count++;
                        break;
                    case "Paladin":
                        hero = new Paladin(type, name);
                        heroes.Add(hero);
                        count++;
                        break;
                    case "Rogue":
                        hero = new Rogue(type, name);
                        heroes.Add(hero);
                        count++;
                        break;
                    case "Warrior":
                        hero = new Warrior(type, name);
                        heroes.Add(hero);
                        count++;
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }

            }
            int bossPower = int.Parse(Console.ReadLine());
            int sumPower = 0;
            foreach (var h in heroes)
            {
                sumPower += h.Power;
                Console.WriteLine(h.CastAbility());
            }

            if (sumPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
