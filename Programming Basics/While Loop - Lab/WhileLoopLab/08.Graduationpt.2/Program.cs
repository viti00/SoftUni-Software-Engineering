using System;

namespace _08.Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0.0;
            int excludet = 0;
            while (grades <= 12)
            {
                double rating = double.Parse(Console.ReadLine());
                if (rating >= 4.00)
                {
                    grades++;
                    sum += rating;
                }
                else if (rating < 4.00)
                {
                    excludet++;
                    if (excludet > 1)
                    {
                        break;
                    }
                }
            }
            double averageSum = sum / 12;
            if (grades == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageSum:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grades} grade");
            }
        }
    }
}
