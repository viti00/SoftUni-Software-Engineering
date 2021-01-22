using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderedByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<Person> articles = new List<Person>();
            while (data != "End")
            {
                string[] temp = data.Split();
                var article = new Person(temp[0], temp[1], int.Parse(temp[2]));
                articles.Add(article);
                data = Console.ReadLine();
            }
            articles = articles.OrderBy(X => X.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }
            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
