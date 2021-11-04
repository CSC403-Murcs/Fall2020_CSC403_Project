// This class is the superclass of enemy and player classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
	public class BattleCharacter : Character
	{
		// Walk over the health skill to keep everyone sane
		// This way we can use the same code that's provide but wrap over the health skill
		public int Health
		{
			get
			{
				return Skills[Defs.SKILL_HP].CurrentLevel;
			}
			private set
			{
				Skills[Defs.SKILL_HP].SetCurrentLevel(value);
			}
		}
		public int MaxHealth
		{
			get
			{
				return Skills[Defs.SKILL_HP].Level;
			}
			private set
			{
				Skills[Defs.SKILL_HP].SetLevel(value);
			}
		}

		public Dictionary<string, Skill> Skills { get; private set; }

		// ???? wtf is this?
		// This is the variable for dynamically be applied to the health of the enemy or player
		// dumb as shit
		public event Action<string, int> AttackEvent;

		public Image CombatImage { get; protected set; }

		// Combat level is the highest skill level + a calculated max health bonus
		public int CombatLevel
		{
			get
			{
				return HighestSkillLevel() + MaxHealth / 5;
			}
		}

		public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider)
		{
			Skills = new Dictionary<string, Skill>();
			AddSkill(new Skill(Defs.SKILL_MELEE));
			AddSkill(new Skill(Defs.SKILL_RANGED));
			AddSkill(new Skill(Defs.SKILL_MAGIC));
			AddSkill(new Skill(Defs.SKILL_HP));

			// Default health to 20, will be changed later
			SetMaxHealth(20);
		}

		public void OnAttack(string skillType)
		{
			int maxhit = AttackStrength(skillType);

			// Add in randomness, in some cases the attack can miss
			// maxhit +1 because of inclusion
			int damage = Helpers.Random(0, maxhit + 1);
			AttackEvent(skillType, damage);
		}

		// Wrap over a much more well-worded function
		public void AlterHealth(int amount)
		{
			if (amount < 0)
			{
				Damage(-amount);
			}
			else
			{
				Heal(amount);
			}
		}
		// Subtract health from the character
		public void Damage(int amount)
		{
//			Console.WriteLine("Health before: {0}", Health);
			Health -= amount;
//			Console.WriteLine("Health after: {0}", Health);
			if (Health < 0)
			{
				Health = 0;
				// Die();
			}
		}
		// Add health to the character
		public void Heal(int amount)
		{
			Health += amount;
			if (Health > MaxHealth)
			{
				Health = MaxHealth;
			}
		}
		public void FullyHeal()
		{
			Health = MaxHealth;
		}
		public void SetMaxHealth(int amount)
		{
			MaxHealth = amount;
		}

		public int GetHealth(){
			return Health;
		}

		private void AddSkill(Skill skill)
		{
			Skills.Add(skill.Name, skill);
		}

		public int HighestSkillLevel()
		{
			int highest = 0;
			foreach (var item in Skills)
			{
				// Skip health because it's special
				if (item.Key == Defs.SKILL_HP)
				{
					continue;
				}
				if (highest < item.Value.Level)
					highest = item.Value.Level;
			}
			return highest;
		}

		public int AttackStrength(string skillType)
		{
			int currLevel = Skills[skillType].Level / 4 + 1;
			int bonus = EquipmentBonus(Skills[skillType]);

			// Level 1 skills need a little nudge
			int additive = 1;
			return currLevel + bonus + additive;
		}

		private void SetSkill(string skill, int level)
		{
			Skills[skill].SetLevel(level);
		}

		// To be overridden by the Player class
		public virtual int EquipmentBonus(Skill skill)
		{
			return 0;
		}
	}
}
