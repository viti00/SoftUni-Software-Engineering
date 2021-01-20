using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] date = Console.ReadLine().Split();
                if (date[0] == "end")
                {
                    break;
                }
                string firstName = date[0];
                string lastName = date[1];
                int age = int.Parse(date[2]);
                string town = date[3];
                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.BornTown = town;

                students.Add(student);
            }
            string cityName = Console.ReadLine();
            foreach (Student town in students)
            {
                if (town.BornTown == cityName)
                {
                    Console.WriteLine($"{town.FirstName} {town.LastName} is {town.Age} years old.");
                }
            }

        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string BornTown { get; set; }
        }
    }
}
