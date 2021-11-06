using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    Inventory inventory;
    public int noticeThreshold = 13;

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      AttackEvent += GainExperience;
      this.inventory = new Inventory();
    }

    // Enable the player to add items to the inventory
    public void addItemToInventory(Item item){
      inventory.addItem(item);
    }
    
    // Enable the player to remove an item from the inventory
    public void removeItemFromInventory(Item item){
      
    }

    public override int EquipmentBonus(Skill skill)
    {
      return 0;
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

    // Enable the player to use an item from the inventory
    public void useItemFromInventory(Item item){

    }

    public void sneak() { 
        noticeThreshold = 17;
    }

  }
}
