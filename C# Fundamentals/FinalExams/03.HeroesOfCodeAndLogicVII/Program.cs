using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _6.HeroOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heros = new Dictionary<string, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                string heroData = Console.ReadLine();
                string[] temp = heroData.Split();
                string name = temp[0];
                int hp = int.Parse(temp[1]);
                int mp = int.Parse(temp[2]);
                heros.Add(name, new List<int> { hp, mp });
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command.Split(" - ");
                string instruction = token[0];
                string name = "";
                switch (instruction)
                {
                    case "CastSpell":
                        name = token[1];
                        int manaNeded = int.Parse(token[2]);
                        string spellName = token[3];
                        if (heros[name][1] >= manaNeded)
                        {
                            heros[name][1] -= manaNeded;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {heros[name][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        name = token[1];
                        int dmg = int.Parse(token[2]);
                        string attacker = token[3];
                        heros[name][0] -= dmg;
                        if (heros[name][0] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {dmg} HP by {attacker} and now has {heros[name][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            heros.Remove(name);
                        }
                        break;
                    case "Recharge":
                        name = token[1];
                        int mp = int.Parse(token[2]);
                        int currMp = heros[name][1];
                        heros[name][1] += mp;
                        if (heros[name][1] > 200)
                        {
                            int rechargedMp = 200 - currMp;
                            heros[name][1] = 200;
                            Console.WriteLine($"{name} recharged for {rechargedMp} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} recharged for {mp} MP!");
                        }
                        break;
                    case "Heal":
                        name = token[1];
                        int hp = int.Parse(token[2]);
                        int currHp = heros[name][0];
                        heros[name][0] += hp;
                        if (heros[name][0] > 100)
                        {
                            int healedHp = 100 - currHp;
                            heros[name][0] = 100;
                            Console.WriteLine($"{name} healed for {healedHp} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} healed for {hp} HP!");
                        }

                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in heros.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" HP: {item.Value[0]}");
                Console.WriteLine($" MP: {item.Value[1]}");
            }
        }
    }
}
