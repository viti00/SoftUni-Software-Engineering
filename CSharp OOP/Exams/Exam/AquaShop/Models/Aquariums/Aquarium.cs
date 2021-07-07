using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int currentCpacity = 0;
        private readonly List<IDecoration> decorations;
        private readonly Dictionary<string, IFish> fishByName;



        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            decorations = new List<IDecoration>();
            fishByName = new Dictionary<string, IFish>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort
        {
            get
            {
                return decorations.Sum(d => d.Comfort);
            }
        }

        public ICollection<IDecoration> Decorations => decorations;

        public ICollection<IFish> Fish => fishByName.Values.ToList();

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (currentCpacity + 1 > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            currentCpacity++;
            fishByName.Add(fish.Name, fish);
        }

        public void Feed()
        {
            foreach (var fish in fishByName.Values)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} ({this.GetType().Name}):");
            if (fishByName.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", fishByName.Keys)}");
            }

            sb.AppendLine($"Decorations: {decorations.Count}");
            sb.Append($"Comfort: {Comfort}");

            return sb.ToString();
        }

        public bool RemoveFish(IFish fish)
        {
            return fishByName.Remove(fish.Name);
        }
    }
}
