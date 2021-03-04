using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassed = int.Parse(Console.ReadLine());
            Queue<string> waiting = new Queue<string>();
            int counter = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 1; i <= numberOfPassed; i++)
                    {
                        if (waiting.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{waiting.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    waiting.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
