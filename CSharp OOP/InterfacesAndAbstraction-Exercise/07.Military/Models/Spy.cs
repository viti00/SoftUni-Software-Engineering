using _07.Military.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Military.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .Append($"Code Number: {CodeNumber}");

            return builder.ToString();
        }
    }
}
