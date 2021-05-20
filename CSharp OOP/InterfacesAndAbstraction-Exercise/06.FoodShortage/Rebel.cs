using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Rebel : IBuyer
    {
        
        private int age;
        private string group;

        public Rebel(string name, int age, string group )
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public int Food { get; private set; }
        public string Name { get ; private set ; }
        public int Age { get=>age; set => age= value; }
        public string Group { get => group; set => group = value;}

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
