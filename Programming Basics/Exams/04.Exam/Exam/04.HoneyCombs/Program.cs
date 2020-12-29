using System;

namespace _04.HoneyCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());
            double honeyCombs = bees * flowers * 0.21;
            double fullHoneyCombs = honeyCombs / 100;
            double ostatuk = honeyCombs % 100;
            Console.WriteLine($"{Math.Floor(fullHoneyCombs)} honeycombs filled.");
            Console.WriteLine($"{ostatuk:f2} grams of honey left.");
        }
    }
}
