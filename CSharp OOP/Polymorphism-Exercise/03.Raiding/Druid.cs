using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string type, string name) 
            : base(type, name)
        {
            Power = 80;
        }

        

        public override string CastAbility()
        {
            return $"{Type} - {Name} healed for {Power}";
        }
    }
}
