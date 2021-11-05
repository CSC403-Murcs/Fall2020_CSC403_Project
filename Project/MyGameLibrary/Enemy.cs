using System;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
	/// <summary>
	/// This is the class for an enemy
	/// </summary>
	public class Enemy : BattleCharacter
	{
		/// <summary>
		/// THis is the image for an enemy
		/// </summary>
		public Image Img { get; set; }

		/// <summary>
		/// this is the background color for the fight form for this enemy
		/// </summary>
		public Color Color { get; set; }

		public EnemyType Type { get; private set; }
		public Respawner Respawner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="initPos">this is the initial position of the enemy</param>
		/// <param name="collider">this is the collider for the enemy</param>
		public Enemy(Vector2 initPos, Collider collider, Player player) : base(initPos, collider)
		{
			Type = (EnemyType)Helpers.Random((int)EnemyType.ENEMY_TYPE_MELEE, ((int)EnemyType.ENEMY_TYPE_MAGIC) + 1);
			string skillToSet = "";
			switch (Type)
			{
				case EnemyType.ENEMY_TYPE_MELEE:
					Color = Color.FromArgb(255, 255, 0, 0);
					skillToSet = Defs.SKILL_MELEE;
					break;
				case EnemyType.ENEMY_TYPE_RANGED:
					Color = Color.FromArgb(255, 0, 255, 0);
					skillToSet = Defs.SKILL_RANGED;
					break;
				case EnemyType.ENEMY_TYPE_MAGIC:
					Color = Color.FromArgb(255, 0, 0, 255);
					skillToSet = Defs.SKILL_MAGIC;
					break;
				default:
					break;
			}

			// Calculate a good tolerance for the player depending on their level
			int highestLevel = player.HighestSkillLevel();
			int valToSet = Helpers.Random(highestLevel - 3, highestLevel + 1);

			// Clamp it
			if (valToSet < 1)
			{
				valToSet = 1;
			}

			// Set the skill to the one we just calculated
			Skills[skillToSet].SetLevel(valToSet);

			// Calculate maxhealth
			int maxHealth = Helpers.Random(player.MaxHealth/3, player.MaxHealth+1);
			SetMaxHealth(maxHealth);

//			CombatImage = new System.Drawing.Bitmap(Defs.EnemyTypeToImg(Type));
//			Graphics graphics = Graphics.FromImage(CombatImage);
//			graphics.DrawString(CombatLevel.ToString(), new Font("Arial", 12), Brushes.White, new Point(0, 0));
		}

		public override void Die()
		{
			if (Respawner != null)
			{
				Respawner.SetRespawn();
			}
		}
	}
}
