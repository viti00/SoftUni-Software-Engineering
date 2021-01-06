using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volumeOfKeg = 0.0;
            double max = double.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volumeOfKeg = Math.PI * (radius * radius) * height;
                if (volumeOfKeg > max)
                {
                    max = volumeOfKeg;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
