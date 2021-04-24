using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> players;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            players = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return players.Count; } }

        public void AddPlayer (Player player)
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
            }
        }

        public bool RemovePlayer (string name)
        {
            Player player = players.FirstOrDefault(p => p.Name == name);
            if (player == null)
            {
                return false;
            }
            players.Remove(player);
            return true;
        }

        public void PromotePlayer(string name)
        {
            Player player = players.FirstOrDefault(p => p.Name == name);

            if(player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = players.FirstOrDefault(p => p.Name == name);

            if(player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string cs)
        {
            List<Player> playersInClass = players.FindAll(p => p.Class == cs);
            Player[] playersInCs = new Player[playersInClass.Count];
            for (int i = 0; i < playersInClass.Count; i++)
            {
                playersInCs[i] = playersInClass[i];
                players.Remove(playersInClass[i]);
            }

            return playersInCs;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            for (int i = 0; i < players.Count - 1; i++)
            {
                sb.AppendLine(players[i].ToString());
            }
            sb.Append(players[players.Count - 1]);

            return sb.ToString();
        }
    }
}
