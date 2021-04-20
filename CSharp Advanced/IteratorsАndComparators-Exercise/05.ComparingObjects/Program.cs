using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                int age = int.Parse(splitted[1]);
                string town = splitted[2];

                Person person = new Person(name, age, town);

                persons.Add(person);

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Person people = persons[index];

            int matchCounter = 0;
            int nonMatchCpunter = 0;

            foreach (var man in persons)
            {
                if (man.CompareTo(people) == 0)
                {
                    matchCounter++;
                }
                else
                {
                    nonMatchCpunter++;
                }
            }

            if (matchCounter > 1)
            {
                Console.WriteLine($"{matchCounter} {nonMatchCpunter} {persons.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
