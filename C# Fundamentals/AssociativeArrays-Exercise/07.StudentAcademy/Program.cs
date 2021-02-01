using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            Dictionary<string, double> averageGrade = new Dictionary<string, double>();
            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }
                else
                {
                    grades.Add(name, new List<double> { grade });
                }
            }
            foreach (var item in grades)
            {
                averageGrade.Add(item.Key, item.Value.Average());
            }
            foreach (var item in averageGrade.OrderByDescending(x => x.Value).Where(x => x.Value >= 4.50))
            {

                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
