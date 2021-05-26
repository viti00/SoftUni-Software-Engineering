using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.10;

        public override string ProducingSound()
        {
            return "Squeak";
        }

        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                Throw(food);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{Weight + WeightPerFood * FoodEaten}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
