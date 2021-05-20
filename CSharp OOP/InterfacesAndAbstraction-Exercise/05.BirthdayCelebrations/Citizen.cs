using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get => name; set => name = value; }

        public int Age { get => age; set => age = value; }

        public string Id { get; private set;}

        public string Birthdate { get; private set;} 
    }
}
