using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string type, string name) 
            : base(type, name)
        {
            Power = 100;
        }

      
        public override string CastAbility()
        {
            return $"{Type} - {Name} hit for {Power} damage";
        }
    }
}
