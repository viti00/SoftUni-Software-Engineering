using _07.Military.Contracts;
using _07.Military.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs { get => repairs.AsReadOnly(); }

        public void AddRepairs(IRepair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (var repair in this.repairs)
            {
                builder.AppendLine(repair.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
