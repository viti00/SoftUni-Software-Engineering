using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepairs(IRepair repair);
    }
}
