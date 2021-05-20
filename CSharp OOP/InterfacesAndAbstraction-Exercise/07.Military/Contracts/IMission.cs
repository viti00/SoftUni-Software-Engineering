using _07.Military.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        string State { get; }

        void CompleteMission();
    }
}
