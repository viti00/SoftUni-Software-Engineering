using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string contest = Console.ReadLine();
            Dictionary<string, string> passwords = new Dictionary<string, string>();

            while (contest != "end of contests")
            {
                string[] temp = contest.Split(":");
                string courseName = temp[0];
                string password = temp[1];

                if (!passwords.ContainsKey(courseName))
                {
                    passwords.Add(courseName, password);
                }
                contest = Console.ReadLine();
            }

            string submission = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> courseData = new Dictionary<string, Dictionary<string, int>>();

            while (submission != "end of submissions")
            {
                string[] token = submission.Split("=>");
                string courseName = token[0];
                string password = token[1];
                string studentName = token[2];
                int points = int.Parse(token[3]);
                if (passwords.ContainsKey(courseName) && passwords[courseName] == password)
                {

                    if (courseData.ContainsKey(studentName))
                    {
                        if (courseData[studentName].ContainsKey(courseName))
                        {
                            if (courseData[studentName][courseName] < points)
                            {
                                courseData[studentName][courseName] = points;
                            }
                        }
                        else
                        {
                            courseData[studentName].Add(courseName, points);
                        }
                    }
                    else
                    {
                        courseData.Add(studentName, new Dictionary<string, int> { { courseName, points } });
                    }
                }
                submission = Console.ReadLine();
            }
            int sum = int.MinValue;
            string bestCandidat = "";
            foreach (var student in courseData)
            {
                int currSum = student.Value.Values.Sum();
                if (currSum > sum)
                {
                    sum = currSum;
                    bestCandidat = student.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidat} with total {sum} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in courseData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var courses in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {courses.Key} -> {courses.Value}");
                }
            }
        }
    }
}
