using System;

namespace Fall2020_CSC403_Project.code
{
	public enum EnemyType
	{
		ENEMY_TYPE_NONE,
		ENEMY_TYPE_MELEE,
		ENEMY_TYPE_RANGED,
		ENEMY_TYPE_MAGIC
	};

	public enum AttackType
	{
		ATTACK_TYPE_NONE,
		ATTACK_TYPE_MELEE,
		ATTACK_TYPE_RANGED,
		ATTACK_TYPE_MAGIC
	};

	public static class Defs
	{
		public const string SKILL_MELEE = "Melee";
		public const string SKILL_RANGED = "Ranged";
		public const string SKILL_MAGIC = "Magic";
		public const string SKILL_HP = "Health";

		public static string AttackTypeToString(AttackType t)
		{
			switch (t)
			{
				case AttackType.ATTACK_TYPE_NONE:
					return "None";
				case AttackType.ATTACK_TYPE_MELEE:
					return "Melee";
				case AttackType.ATTACK_TYPE_RANGED:
					return "Ranged";
				case AttackType.ATTACK_TYPE_MAGIC:
					return "Magic";
				default:
					return "None";
			}
		}

		public const double RESPAWN_TIME = 10.0;
	}

	public static class Helpers
	{
		private static readonly Random _r = new Random();
		// Better random number
		public static int Random(int min, int max)
		{
			return _r.Next(min, max);
		}
	}
}
