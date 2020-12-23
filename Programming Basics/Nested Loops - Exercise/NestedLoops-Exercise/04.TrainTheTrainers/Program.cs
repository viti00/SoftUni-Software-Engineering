using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double gradeSum = 0.0;
            double totalSum = 0.0;
            int averageGradeSum = 0;
            while (presentationName != "Finish")
            {
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                }
                averageGradeSum++;
                double averageGrade = gradeSum / n;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                gradeSum -= gradeSum;
                totalSum += averageGrade;
                presentationName = Console.ReadLine();
            }
            double final = totalSum / averageGradeSum;
            Console.WriteLine($"Student's final assessment is {final:f2}.");
        }
    }
}
