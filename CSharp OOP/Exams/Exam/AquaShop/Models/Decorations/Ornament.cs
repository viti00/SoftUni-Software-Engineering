using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        public const int constantComfort = 1;
        public const decimal constantPrice = 5m;

        public Ornament() 
            : base(constantComfort, constantPrice)
        {
        }
    }
}
