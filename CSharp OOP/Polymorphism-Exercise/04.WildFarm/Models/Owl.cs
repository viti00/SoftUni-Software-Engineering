using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.25;

        public override string ProducingSound()
        {
            return $"Hoot Hoot";
        }

        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if(type != nameof(Meat))
            {
                Throw(food);
            }

        }
    }
}
