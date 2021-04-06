using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person person = new Person();
            Console.WriteLine($"{person.Name} is {person.Age} years old");

            
            Person personWithAge = new Person(age);
            personWithAge.Age = age;
            Console.WriteLine($"{personWithAge.Name} is {personWithAge.Age} years old");

            Person personNameAndAge = new Person(name, age);
            personNameAndAge.Name = name;
            personNameAndAge.Age = age;
            Console.WriteLine($"{personNameAndAge.Name} is {personNameAndAge.Age} years old");

        }
    }
}
