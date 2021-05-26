using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Feline : Animal
    {
        protected Feline(string name, double weight, string livingRegion, string bread) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
            Bread = bread;
        }

        protected string LivingRegion { get; private set; }
        protected string Bread { get; private set; }
    }
}
