using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private readonly List<Character> party;
		private readonly Stack<Item> pool;

		public WarController()
		{
			party = new List<Character>();
			pool = new Stack<Item>();
		}

		public string JoinParty(string[] args)
		{
			string type = args[0];
			string name = args[1];
			Character character;

			switch (type)
            {
				case "Warrior":
					character = new Warrior(name);
					break;
				case "Priest":
					character = new Priest(name);
					break;
				default:
					throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType), type);
            }
			party.Add(character);
			return string.Format(SuccessMessages.JoinParty, name);

		}

		public string AddItemToPool(string[] args)
		{
			string typeItem = args[0];
			Item item;
            switch (typeItem)
            {
				case "FirePotion":
					item = new FirePotion();
					break;
				case "HealthPotion":
					item = new HealthPoint();
					break;
				default:
					throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, typeItem));
            }
			pool.Push(item);
			return string.Format(SuccessMessages.AddItemToPool, typeItem);
		}

		public string PickUpItem(string[] args)
		{
			string name = args[0];
			Character character = party.FirstOrDefault(c => c.Name == name);
			if (character == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, name));
            }
			if (pool.Count == 0)
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }
			Item item = pool.Pop();
			string nameItem = GetType(item);
			character.Bag.AddItem(item);
			return string.Format(SuccessMessages.PickUpItem, name, nameItem);
		}

		public string UseItem(string[] args)
		{
			string name = args[0];
			string itemName = args[1];
			Character character = party.FirstOrDefault(c => c.Name == name);
			if (character == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, name));
			}

			character.Bag.GetItem(itemName);

			return string.Format(SuccessMessages.UsedItem, name, itemName);
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();
            foreach (var character in party.OrderByDescending(c=>c.IsAlive == true).ThenByDescending(c=>c.Health))
            {
				string result = GetAliveOrDead(character.IsAlive);
				sb.AppendLine(string.Format(SuccessMessages.CharacterStats, character.Name,
					character.Health, character.BaseHealth, character.Armor, character.BaseArmor, result));
            }

			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string reciverName = args[1];

			Warrior attacker = (Warrior)party.FirstOrDefault(c => c.Name == attackerName);
			Character reciver = party.FirstOrDefault(c => c.Name == reciverName);
			if (attacker == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackerName));
            }
			if (reciver == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, reciverName));
			}

			if (!attacker.IsAlive)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), attackerName);
            }
			if (!reciver.IsAlive)
            {
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
			attacker.Attack(reciver);
			
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(string.Format(SuccessMessages.AttackCharacter, attackerName, reciverName, attacker.AbilityPoints,
				reciverName, reciver.Health, reciver.BaseHealth, reciver.Armor, reciver.BaseArmor));
			if ( reciver.Health <= 0)
            {
				sb.Append(string.Format(SuccessMessages.AttackKillsCharacter, reciverName));
            }

			return sb.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string reciverName = args[1];
			

			Priest healer =(Priest)party.FirstOrDefault(c => c.Name == healerName);
			Character reciver = party.FirstOrDefault(c => c.Name == reciverName);
			if (healer == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healerName));
			}
			if (reciver == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, reciverName));
			}

			if (!healer.IsAlive)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, healerName));
            }

			healer.Heal(reciver);

			return string.Format(SuccessMessages.HealCharacter, healerName, reciverName,
				healer.AbilityPoints, reciverName, reciver.Health);
		}

		static string GetAliveOrDead(bool IsAlive)
		{
			string result = "";
			if (IsAlive)
			{
				result = "Alive";
			}
			else
			{
				result = "Dead";
			}
			return result;
		}
		static string GetType(Item item)
        {
			string name = item.GetType().Name;

			return name;
        }
	}
	
}
