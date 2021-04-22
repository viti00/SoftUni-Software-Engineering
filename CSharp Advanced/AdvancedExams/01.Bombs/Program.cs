using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombsEfect = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bombsCasing = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> efects = new Queue<int>(bombsEfect);

            Stack<int> casing = new Stack<int>(bombsCasing);

            Dictionary<string, int> bombs = new Dictionary<string, int>();

            bombs.Add("Cherry", 0);
            bombs.Add("Datura", 0);
            bombs.Add("Smoke Decoy", 0);

            while(efects.Count != 0 && casing.Count != 0)
            {
                int sum = efects.Peek() + casing.Peek();
                switch (sum)
                {
                    case 40:
                        bombs["Datura"]++;
                        efects.Dequeue();
                        casing.Pop();
                        break;
                    case 60:
                        bombs["Cherry"]++;
                        efects.Dequeue();
                        casing.Pop();
                        break;
                    case 120:
                        bombs["Smoke Decoy"]++;
                        efects.Dequeue();
                        casing.Pop();
                        break;
                    default:
                        int newValue = casing.Pop() - 5;
                        casing.Push(newValue);
                        break;
                }
                if (bombs["Datura"] >= 3 && bombs["Cherry"] >= 3 && bombs["Smoke Decoy"] >= 3)
                {
                    break;
                }
            }
            if (bombs["Datura"] >= 3 && bombs["Cherry"] >= 3 && bombs["Smoke Decoy"] >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if(efects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.Write("Bomb Effects: ");
                Console.WriteLine(string.Join(", ", efects));
            }

            if (casing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.Write("Bomb Casings: ");
                Console.WriteLine(string.Join(", ", casing));
            }

            foreach (var item in bombs.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} Bombs: {item.Value}");
            }

        }
    }
}
