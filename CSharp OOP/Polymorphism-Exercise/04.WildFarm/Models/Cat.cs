using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string bread) 
            : base(name, weight, livingRegion, bread)
        {
        }

        protected override double WeightPerFood => 0.30;

        public override string ProducingSound()
        {
            return "Meow";
        }

        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Meat))
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
