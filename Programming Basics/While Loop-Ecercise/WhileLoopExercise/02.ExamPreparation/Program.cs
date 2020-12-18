using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedCountGrade = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemCount = 0;
            double sum = 0;
            string lastProblem = "";
            bool isFailed = true;
            while (failedTimes < failedCountGrade)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                sum += grade;
                solvedProblemCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedCountGrade} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sum / solvedProblemCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
