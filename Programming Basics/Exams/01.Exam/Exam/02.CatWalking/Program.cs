using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            double totalTime = minutes * times;
            double burnCalories = totalTime * 5;
            double averageCalories = calories * 0.5;
            if (burnCalories >= averageCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCalories}.");
            }
        }
    }
}
