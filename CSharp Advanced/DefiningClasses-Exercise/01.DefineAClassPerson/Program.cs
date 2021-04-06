using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = Console.ReadLine();
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"{person.Name} is {person.Age} years old");
        }
    }
}
