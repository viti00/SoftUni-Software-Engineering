using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        

        public BaseHero(string type, string name)
        {
            Type = type;
            Name = name;
            Power = 0;
        }

        public string Type { get; set; }
        

        public string Name { get; set; }

        public int Power { get; set; }
        public abstract string CastAbility();
    }
}
