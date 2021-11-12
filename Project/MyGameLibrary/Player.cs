using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      AttackEvent += GainExperience;
    }

    private void GainExperience(string skillType, int damage)
    {
      // Gain experience depending on the type of skill used
      int exp = damage * 4;
      Skills[skillType].AddExperience(exp);

      // Globally increment health exp
      int hpexp = damage;
      Skills[Defs.SKILL_HP].AddExperience(hpexp);
    }
    }
}
