using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinances
{
    public class IncomeOrExpence
    {
        public IncomeOrExpence(string id,string name, string type, string date, string value, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Date = date;
            Value = value;
            Description = description;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Date { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }


    }
}
