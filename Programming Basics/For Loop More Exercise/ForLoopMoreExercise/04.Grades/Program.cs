using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double gradeSum = 0.0;
            double gradeSum1 = 0.0;
            double gradeSum2 = 0.0;
            double gradeSum3 = 0.0;
            double gradeSum4 = 0.0;
            int studentCount = 0;
            int studentCount1 = 0;
            int studentCount2 = 0;
            int studentCount3 = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;
                if (grade < 3.00)
                {
                    gradeSum1 += grade;
                    studentCount++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    gradeSum2 += grade;
                    studentCount1++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    gradeSum3 += grade;
                    studentCount2++;
                }
                else if (grade >= 5.00)
                {
                    gradeSum4 += grade;
                    studentCount3++;
                }
            }
            double fail = studentCount / students * 100;
            double half = studentCount1 / students * 100;
            double good = studentCount2 / students * 100;
            double top = studentCount3 / students * 100;
            double averageGrade = gradeSum / students;
            Console.WriteLine($"Top students: {top:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {half:F2}%");
            Console.WriteLine($"Fail: {fail:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
