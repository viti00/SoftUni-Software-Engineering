using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private  int size = 3;

        public FreshwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
            
        }
        public override int Size => this.size;

        public override void Eat()
        {
            this.size += 3;
        }
    }
}
