using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> datas = new Dictionary<string, List<string>>();
            while (command != "end")
            {
                string[] temp = command.Split(" : ");
                string course = temp[0];
                string name = temp[1];
                if (datas.ContainsKey(course))
                {
                    datas[course].Add(name);
                }
                else
                {
                    datas.Add(course, new List<string> { name });
                }
                command = Console.ReadLine();
            }
            foreach (var currCourse in datas.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{currCourse.Key}: {currCourse.Value.Count}");
                foreach (var item in currCourse.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
