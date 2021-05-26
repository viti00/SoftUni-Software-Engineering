using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.40;

        public override string ProducingSound()
        {
            return "Woof!";
        }

        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if(type != nameof(Meat))
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
