using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string type, string name) 
            : base(type, name)
        {
            Power = 100;
        }
       
        public override string CastAbility()
        {
            return $"{Type} - {Name} healed for {Power}";
        }
    }
}
