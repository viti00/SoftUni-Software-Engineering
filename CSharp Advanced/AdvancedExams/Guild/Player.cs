using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public Player(string name, string cs)
        {
            Name = name;
            Class = cs;
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank = "Trial";
        public string Description = "n/a";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.Append($"Description: { Description}");
            return sb.ToString();
        }
    }
}
