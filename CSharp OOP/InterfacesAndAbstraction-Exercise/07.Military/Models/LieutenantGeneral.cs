using _07.Military.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates { get => privates.AsReadOnly(); }

        public void AddPrivates(IPrivate @private)
        {
            privates.Add(@private);
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var current in this.privates)
            {
                builder.AppendLine("  " + current.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
