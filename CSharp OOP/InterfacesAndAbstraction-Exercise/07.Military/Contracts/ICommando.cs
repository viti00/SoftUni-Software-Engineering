using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMisssion(IMission mission);
    }
}
