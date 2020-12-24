using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double biscuit = 0.0;
            double dog = 0.0;
            double cat = 0.0;
            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    biscuit += (dogFood + catFood) * 0.1;
                }
                dog += dogFood;
                cat += catFood;
            }
            double totalFood = dog + cat;
            double foodPercent = (totalFood / food) * 100;
            double dogFoodPercent = dog / totalFood * 100;
            double catFoodPercent = cat / totalFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
            Console.WriteLine($"{ foodPercent:F2}% of the food has been eaten.");
            Console.WriteLine($"{ dogFoodPercent:F2}% eaten from the dog.");
            Console.WriteLine($"{catFoodPercent:F2}% eaten from the cat.");
        }
    }
}
