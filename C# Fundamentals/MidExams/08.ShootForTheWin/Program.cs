using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();
            int shootCounter = 0;
            int counter = -1;
            while (command != "End")
            {
                int temp = int.Parse(command);
                while (temp >= 0 && temp < targets.Length)
                {
                    if (targets[temp] == -1)
                    {
                        break;
                    }
                    else
                    {
                        foreach (int element in targets)
                        {
                            counter++;
                            if (element != -1 && temp != counter)
                            {
                                if (element <= targets[temp])
                                {
                                    targets[counter] += targets[temp];
                                }
                                else if (element > targets[temp])
                                {
                                    targets[counter] -= targets[temp];
                                }
                            }
                        }
                        counter = -1;
                        shootCounter++;
                        targets[temp] = -1;
                        break;
                    }

                }
                command = Console.ReadLine();
            }
            Console.Write($"Shot targets: {shootCounter} -> ");
            Console.Write(string.Join(" ", targets));
        }
    }
}
