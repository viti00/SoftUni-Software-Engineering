using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());
            double dogFoodNeed = days * dog;
            double catFoodNeed = days * cat;
            double turtleFoodNeed = (days * turtle) / 1000;
            double totalFood = dogFoodNeed + catFoodNeed + turtleFoodNeed;
            string output = "";
            if (totalFood <= food)
            {
                double more = food - totalFood;
                output = $"{Math.Floor(more)} kilos of food left.";
            }
            else
            {
                double needed = totalFood - food;
                output = $"{(double)Math.Ceiling(needed)} more kilos of food are needed.";
            }
            Console.WriteLine(output);
        }
    }
}
