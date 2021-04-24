using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] plates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> listPlates = new List<int>(plates);

            Stack<int> stackOrcs = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] orcs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                if (listPlates.Count == 0)
                {
                    break;
                }

                stackOrcs = new Stack<int>(orcs);
                if (i % 3 == 0)
                {
                    int newLine = int.Parse(Console.ReadLine());
                    listPlates.Add(newLine);
                }

                while(listPlates.Count != 0 && stackOrcs.Count != 0)
                {
                    if (listPlates[0] > stackOrcs.Peek())
                    {
                        listPlates[0] -= stackOrcs.Pop();
                    }
                    else if (listPlates[0] < stackOrcs.Peek())
                    {
                        int result = stackOrcs.Pop() - listPlates[0];
                        stackOrcs.Push(result);
                        listPlates.RemoveAt(0);
                    }
                    else if (listPlates[0] == stackOrcs.Peek())
                    {
                        listPlates.RemoveAt(0);
                        stackOrcs.Pop();
                    }
                }
                
            }


            if (listPlates.Count > 0 && stackOrcs.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                if (listPlates.Count > 0)
                {
                    Console.Write("Plates left: ");
                    Console.WriteLine(string.Join(", ", listPlates));
                }
            }
            else if (stackOrcs.Count > 0 && listPlates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                if (stackOrcs.Count > 0)
                {
                    Console.Write("Orcs left: ");
                    Console.WriteLine(string.Join(", ",stackOrcs));
                }
            }
        }
    }
}
