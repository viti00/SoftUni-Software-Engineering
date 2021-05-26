using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string type, string name) : base(type, name)
        {
            Power = 80;
        }

       
        public override string CastAbility()
        {
            return $"{Type} - {Name} hit for {Power} damage";
        }
    }
}
