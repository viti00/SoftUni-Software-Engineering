using _04.WildFarm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Fctories
{
    public static class FoodFactory 
    {
        public static Food Create(string[] args)
        {
            string type = args[0];

            switch (type)
            {
                case nameof(Vegetable):
                    return new Vegetable(int.Parse(args[1]));
                case nameof(Fruit):
                    return new Fruit(int.Parse(args[1]));
                case nameof(Meat):
                    return new Meat(int.Parse(args[1]));
                case nameof(Seeds):
                    return new Seeds(int.Parse(args[1]));
                default:
                    throw new ArgumentException($"{type} is not a valid Food");
            }
        }
    }
}
