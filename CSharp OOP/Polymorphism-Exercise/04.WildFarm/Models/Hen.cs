using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.35;

        public override string ProducingSound()
        {
            return $"Cluck";
        }

        public override void ValidateFood(Food food)
        {
            
        }
    }
}
