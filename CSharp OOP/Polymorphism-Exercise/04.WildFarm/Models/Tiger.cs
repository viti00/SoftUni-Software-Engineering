using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string bread) 
            : base(name, weight, livingRegion, bread)
        {
        }

        protected override double WeightPerFood => 1.00;

        public override string ProducingSound()
        {
            return "ROAR!!!";
        }

        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{Bread}, {Weight + WeightPerFood * FoodEaten}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
