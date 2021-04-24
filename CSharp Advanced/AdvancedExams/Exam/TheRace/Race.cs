using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheRace
{
    public class Race
    {
        List<Racer> racers;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return racers.Count; } }

        public void Add(Racer racer)
        {
            if (racers.Count < Capacity)
            {
                racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = racers.FirstOrDefault(p => p.Name == name);
            if (racer == null)
            {
                return false;
            }
            racers.Remove(racer);
            return true;
        }

        public Racer GetOldestRacer()
        {
            return racers.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            Racer racer = racers.FirstOrDefault(p => p.Name == name);
            return racer;
        }

        public Racer GetFastestRacer()
        {
            return racers.OrderByDescending(p => p.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");

            for (int i = 0; i < racers.Count - 1; i++)
            {
                sb.AppendLine(racers[i].ToString());
            }
            sb.Append(racers[racers.Count - 1]);

            return sb.ToString();
        }

    }
}
