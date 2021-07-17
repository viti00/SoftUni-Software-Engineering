using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
        // TODO: Implement the rest of the class.

        public Character(string name, double health, double armor, double abilityPoints, IBag bag)
        {
            Name = name;
            BaseHealth = health;
            Health = BaseHealth;
            BaseArmor = armor;
            Armor = BaseArmor;
            AbilityPoints = abilityPoints;
            Bag = bag;
        }

		public bool IsAlive { get; set; } = true;
        public string Name
        {
			get => this.name;
			private set
            {
				if (string.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
				this.name = value;
            }
        }

        public double BaseHealth { get; private set; }

        public double Health { get; set; }
        public double BaseArmor { get; private set; }

        public double Armor { get; set; }
        public double AbilityPoints { get; private set; }

        public IBag Bag { get; private set; }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}

        public void TakeDamage (double hitPoints)
        {
            if (IsAlive)
            {
                if (Armor - hitPoints < 0)
                {
                    hitPoints -= Armor;
                    Armor = 0;
                    if (Health - hitPoints < 0)
                    {
                        Health = 0;
                        IsAlive = false;
                    }
                    else
                    {
                        Health -= hitPoints;
                    }
                }
                else
                {
                    Armor -= hitPoints;
                }
            }
        }
        public void UseItem(Item item)
        {
            if (IsAlive)
            {
                item.AffectCharacter(this);
            }
        }
	}
}