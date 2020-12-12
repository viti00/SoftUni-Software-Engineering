using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            double totalGrapes = X * Y;
            double wine = (totalGrapes * 0.40) / 2.5;
            if (wine < Z)
            {
                double needed = Z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needed)} liters wine needed.");
            }
            else if (wine >= Z)
            {
                double more = wine - Z;
                double vinoZaRabotnik = more / workersCount;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{(int)Math.Ceiling(more)} liters left -> {(int)Math.Ceiling(vinoZaRabotnik)} liters per person.");
            }
        }
    }
}
