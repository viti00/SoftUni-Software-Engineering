using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Contracts
{
    public interface ISpy : ISoldier
    {
        public int CodeNumber { get; }
    }
}
