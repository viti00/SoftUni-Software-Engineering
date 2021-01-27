using System;
using System.ComponentModel;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeCapacity = int.Parse(Console.ReadLine());
            int secondEmployeeCapacity = int.Parse(Console.ReadLine());
            int thirdEmployeeCapacity = int.Parse(Console.ReadLine());
            int questions = int.Parse(Console.ReadLine());
            int hourCounter = 0;
            int totalCapacity = firstEmployeeCapacity + secondEmployeeCapacity + thirdEmployeeCapacity;
            while (questions > 0)
            {

                hourCounter++;
                if (hourCounter % 4 == 0)
                {
                    continue;
                }
                questions -= totalCapacity;

            }
            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
