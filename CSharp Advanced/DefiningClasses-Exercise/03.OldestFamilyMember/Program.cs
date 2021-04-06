using System;
using System.Collections.Generic;

namespace _03.OldestFamilyMember
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            List<int> ages = new List<int>();
            Family family = new Family();

            for (int i = 1; i <= n; i++)
            {
                string datas = Console.ReadLine();
                string[] splitted = datas.Split();

                string name = splitted[0];
                int age = int.Parse(splitted[1]);

                Person person = new Person(name, age);
                names.Add(name);
                ages.Add(age);

                family.AddMember(person.Name, person.Age);
            }

            Console.WriteLine(family.GetOldestMember(names, ages));
        }
    }
}
