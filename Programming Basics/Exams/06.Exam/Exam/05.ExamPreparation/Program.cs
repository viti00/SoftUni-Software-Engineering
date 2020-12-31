using System;

namespace _05.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int tasks = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int taskCount = 0;
            int questionCount = 0;
            int newStudent = 0;
            while (energy > 0 || studentCount > 10)
            {
                taskCount += tasks;
                energy += 2 * tasks;
                studentCount -= tasks;
                questionCount = studentCount * 2;
                energy -= 3 * questionCount;
                if (studentCount < 10)
                {
                    Console.WriteLine($"The students are too few!");
                    Console.WriteLine($"Problems solved: {taskCount}");
                    break;
                }
                if (energy <= 0)
                {
                    Console.WriteLine($"The trainer is too tired!");
                    Console.WriteLine($"Questions asked: {questionCount}");
                    break;
                }
                if (studentCount >= 10)
                {
                    newStudent = studentCount / 10;
                }
                studentCount += newStudent;
                questionCount = 0;
            }
        }
    }
}
