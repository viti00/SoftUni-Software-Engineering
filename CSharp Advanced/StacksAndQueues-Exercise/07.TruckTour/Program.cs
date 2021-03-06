using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();

            for (int i = 1; i <= n; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                bool isSuccsesfull = true;
                int currFuel = 0;
                for (int j = 1; j <= n; j++)
                {
                    int[] pumpData = pumpsData.Dequeue().Split().Select(int.Parse).ToArray();
                    pumpsData.Enqueue(string.Join(" ", pumpData));
                    currFuel += pumpData[0];

                    currFuel -= pumpData[1];
                    if (currFuel < 0)
                    {
                        isSuccsesfull = false;
                    }
                }
                if (isSuccsesfull == true)
                {
                    index = i;
                    break;
                }
                pumpsData.Enqueue(pumpsData.Dequeue());

            }
            Console.WriteLine(index);
        }
    }
}
