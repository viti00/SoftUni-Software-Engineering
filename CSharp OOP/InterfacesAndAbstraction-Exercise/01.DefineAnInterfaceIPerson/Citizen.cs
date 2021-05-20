using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }
    }
}
