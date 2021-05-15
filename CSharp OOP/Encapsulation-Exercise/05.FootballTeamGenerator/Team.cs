using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        private double raiting;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
            Raiting = raiting;
        }

        public double Raiting
        {
            get => raiting;
            private set
            {
                value = CalculateTeamRaiting(this.Name);
                raiting = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public void Add(string name, Player player)
        {
            players.Add(player);
        }

        public void Remove(string teamName, string playerName)
        {
            Player player = players.FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                Console.WriteLine($"Player {playerName} is not in {teamName} team.");
            }
            else
            {
                players.Remove(player);
            }
        }

        private double CalculateTeamRaiting(string teamName)
        {
            double totalRaiting = 0;
            foreach (var player in players)
            {
                double currPlayerRaiting = player.CalculateSkillLevel();
                totalRaiting += currPlayerRaiting;
            }

            totalRaiting = totalRaiting / players.Count;

            return Math.Round(totalRaiting);
        }
    }
}
