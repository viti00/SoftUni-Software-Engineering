using System;

namespace _04.ExamRetention
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double seasonCount = double.Parse(Console.ReadLine());
            double exam1 = 0.0;
            double exam2 = 0.0;
            double produljili = 0.0;
            double prezapisali = 0.0;
            double total = 0.0;
            for (int i = 1; i <= seasonCount; i++)
            {
                exam1 = studentCount * 90 / 100;
                exam2 = Math.Ceiling(exam1) * 90 / 100;
                produljili = Math.Ceiling(exam2) * 80 / 100;
                if (i % 3 == 0)
                {
                    prezapisali = Math.Ceiling(produljili) * 15 / 100;
                }
                else
                {
                    prezapisali = Math.Ceiling(produljili) * 5 / 100;
                }
                total = produljili + Math.Ceiling(prezapisali);
                exam1 = 0;
                exam2 = 0;
                studentCount = Math.Ceiling(total);
            }
            Console.WriteLine($"Students: {studentCount}"); Console.WriteLine("Hello World!");
        }
    }
}
