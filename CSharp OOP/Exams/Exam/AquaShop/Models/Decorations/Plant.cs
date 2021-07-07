using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        public const int constantComfort = 5;
        public const decimal constantPrice = 10m;

        public Plant() 
            : base(constantComfort, constantPrice)
        {
        }
    }
}
