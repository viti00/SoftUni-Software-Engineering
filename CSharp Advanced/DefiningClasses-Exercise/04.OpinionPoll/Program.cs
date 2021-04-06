using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> datas = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split();

                string name = splitted[0];
                int age = int.Parse(splitted[1]);

                Person person = new Person(name, age);

                datas.Add(person.Name, person.Age);
            }

            foreach (var person in datas.OrderBy(x=>x.Key).Where(x=>x.Value > 30))
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }

        }
    }
}
