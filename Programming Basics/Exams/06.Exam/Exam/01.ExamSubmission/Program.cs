using System;

namespace _01.ExamSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int taskCount = int.Parse(Console.ReadLine());
            double submissions = taskCount * 2.8;
            double total = studentCount * Math.Ceiling(submissions);
            double bonusSSubmissions = studentCount * (taskCount / 3);
            double totalSubmissions = bonusSSubmissions + total;
            double needed = totalSubmissions / 10;
            double totalNeeded = 5 * Math.Ceiling(needed);
            Console.WriteLine($"{totalNeeded} KB needed");
            Console.WriteLine($"{totalSubmissions} submissions");
        }
    }
}
