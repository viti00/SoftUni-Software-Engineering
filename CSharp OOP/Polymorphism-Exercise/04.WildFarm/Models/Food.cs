using _04.WildFarm.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models
{
    public abstract class Food : IFood
    {
        public Food( int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
