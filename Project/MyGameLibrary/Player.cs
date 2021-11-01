﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    Inventory inventory;

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      this.inventory = new Inventory();

    }

    // Enable the player to add items to the inventory
    public void addItemToInventory(Item item){
      inventory.addItem(item);
    }
    
    // Enable the player to remove an item from the inventory
    public void removeItemFromInventory(Item item){

    }

    // Enable the player to use an item from the inventory
    public void useItemFromInventory(Item item){

    }

  }
}
