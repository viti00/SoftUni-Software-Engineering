using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> costumers = new Queue<string>();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (costumers.Count != 0)
                    {
                        Console.WriteLine(costumers.Dequeue());
                    }
                }
                else
                {
                    costumers.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{costumers.Count} people remaining.");
        }
    }
}
