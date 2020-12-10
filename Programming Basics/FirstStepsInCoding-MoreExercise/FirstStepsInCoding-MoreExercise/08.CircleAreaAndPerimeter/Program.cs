using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            //calculation
            double calculatedArea = Math.PI * (r * r);
            double calculatedPerimeter = 2 * Math.PI * r;
            Console.WriteLine($"{calculatedArea:F2}");
            Console.WriteLine($"{calculatedPerimeter:F2}");
        }
    }
}
