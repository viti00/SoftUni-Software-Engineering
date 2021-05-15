using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double skillLevel;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            skillLevel = CalculateSkillLevel();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{value.GetType()} should be between 0 and 100.");
                }
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{value.GetType()} should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{value.GetType()} should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{value.GetType()} should be between 0 and 100.");
                }
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{value.GetType()} should be between 0 and 100.");
                }
                this.shooting = value;
            }
        }

        public double CalculateSkillLevel()
        {
            double skillLevel = (Endurance + Sprint + Dribble + Passing + Shooting) / 5;

            return skillLevel;
        }
    }
}
