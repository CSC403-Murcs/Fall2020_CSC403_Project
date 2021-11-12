namespace Fall2020_CSC403_Project.code
{
	public class Skill
	{
		public string Name { get; private set; }
		public int Level { get; private set; }
		// CurrentLevel only exists because of HP, this way it can be reduced and changed
		// without ruining the actual HP level
		public int CurrentLevel { get; private set; }
		public int MaxLevel { get; private set; }
		public int Experience { get; private set; }
		public int MaxExperience { get; private set; }
		public int Bonus { get; set; }

		static int CalcExp(int level)
		{
			return (int)System.Math.Sqrt((float)level) * 20;
		}
		public Skill(string name)
		{
			Name = name;
			Level = 1;
			CurrentLevel = 1;
			MaxLevel = 99;
			Experience = 0;
			Bonus = 0;
			MaxExperience = CalcExp(Level);
		}

		public void AddExperience(int exp)
		{
			if (Level == MaxLevel)
			{
				return;
			}

			Experience += exp;
			while (Experience > MaxExperience)
			{
				LevelUp();
				Experience -= MaxExperience;
			}
		}

		private void LevelUp()
		{
			Level++;
			CurrentLevel++;
			MaxExperience = CalcExp(Level);
		}

		public void SetLevel(int level)
		{
			Level = level;
			CurrentLevel = level;
			MaxExperience = CalcExp(Level);
		}
		public void SetCurrentLevel(int level)
		{
			CurrentLevel = level;
		}
	}
}