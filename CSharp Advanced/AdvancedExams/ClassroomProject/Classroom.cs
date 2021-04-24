using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }


        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return "No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

            if (student == null)
            {
                return "Student not found";
            }
            students.Remove(student);
            return $"Dismissed student {firstName} {lastName}";
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder result = new StringBuilder();
            List<Student> student = students.FindAll(p => p.Subject == subject);

            if (student.Count == 0)
            {
                return "No students enrolled for the subject";
            }
            result.AppendLine($"Subject: {subject}");
            result.AppendLine("Students:");
            for (int i = 0; i < student.Count - 1; i++)
            {
                result.AppendLine($"{student[0].FirstName} {student[0].LastName}");
            }
            result.Append($"{student[student.Count - 1].FirstName} {student[student.Count - 1].LastName}");

            return result.ToString();
        }

        public int GetStudentsCount()
        {
            return students.Count();
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
            return student;
        }
    }
}
