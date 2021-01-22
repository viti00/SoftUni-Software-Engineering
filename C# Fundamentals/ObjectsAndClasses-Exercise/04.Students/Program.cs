using System;
using System.Collections.Generic;
using System.Linq;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> student = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string[] temp = data.Split();
                var students = new Student(temp[0], temp[1], double.Parse(temp[2]));
                student.Add(students);
            }
            student = student.OrderBy(X => X.Grade).ToList();
            student.Reverse();
            Console.WriteLine(string.Join(Environment.NewLine, student));
        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
