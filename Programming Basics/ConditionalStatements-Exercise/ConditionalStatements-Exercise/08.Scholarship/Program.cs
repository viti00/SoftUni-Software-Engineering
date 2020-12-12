using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double greatSuccess = 0;

            if (income < minimumWage && averageSuccess > 4.5)
            {
                socialScholarship = minimumWage * 0.35;
            }
            if (averageSuccess >= 5.5)
            {
                greatSuccess = averageSuccess * 25;
            }
            if (socialScholarship.Equals(0) && greatSuccess.Equals(0))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > greatSuccess)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(greatSuccess)} BGN");
            }
        }
    }
}
