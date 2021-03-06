using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();
            int counter = 0;
            string command = Console.ReadLine();
            while (command != "END")
            {
                int green = greenLightDuration;
                int free = freeWindowDuration;
                if (command == "green")
                {
                    while (green > 0 && carsQueue.Count != 0)
                    {
                        string firstCar = carsQueue.Dequeue();
                        green -= firstCar.Length;
                        if (green >= 0)
                        {
                            counter++;
                        }

                        else
                        {
                            free += green;

                            if (free < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstCar} was hit at" +
                                    $" {firstCar[firstCar.Length + free]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                       $"{counter} total cars passed the crossroads.");
        }
    }
}
