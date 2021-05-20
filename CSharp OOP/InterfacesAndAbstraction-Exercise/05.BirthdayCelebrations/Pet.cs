using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
        public string Birthdate { get; private set; }

        public string Name { get=> name; set=> name = value; }
    }
}
