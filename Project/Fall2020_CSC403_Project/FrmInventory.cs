using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {

        public static FrmInventory instance = null;
        public Item selectedItem = new Item("Health");
        public Item pickedItem = new Item("Health");
        private Player player;
        private int health_counter = 0;
        private int intelligence_counter = 0;
        private int power_counter = 0;

        public FrmInventory(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        public static FrmInventory GetInstance(Player player)
        {
            if (instance == null) {
                instance = new FrmInventory(player);
            }
            //instance.Setup();
            return instance;
        }

        // Equip button
        private void button1_Click(object sender, EventArgs e)
        {
            string itemType = selectedItem.getType();

            // TODO: make sure to change the itemType to what you pass to the switch
            Skill skill = player.Skills[itemType];

            switch (itemType) {
                case "Health":
                    // Increase the health of the player
                    if (Health.BackColor == Color.Green)
                    {
                        player.AlterHealth(3);
                        Health.BackColor = Color.Red;
                    }
                    break;
                case "Melee":
                    // Increase melee by +2
                    if (Power.BackColor == Color.Green) {
                        skill.Bonus += 2;
                        Power.BackColor = Color.Red;
                    }
                    break;
                case "Magic":
                    // Increase magic by +2
                    if (Intelligence.BackColor == Color.Green) {
                        skill.Bonus += 4;
                        Intelligence.BackColor = Color.Red;
                    }
                    break;
            }
        }

        // Health Item
        // FIX: Turn the next three functions into one function
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Health");
        }

        // Melee Item
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Melee");
        }

        // Magic Item
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Magic");
        }

        public void AddLoot(Image loot, string type){
            if(type == "Health"){
                // How to add a picture to each one of the loot?
                Health.BackgroundImage = loot;
                Health.BackColor = Color.Green;
                Health.Refresh();
            }
            else if(type == "Melee"){
                Power.BackgroundImage = loot;
                Power.BackColor = Color.Green;
                Power.Refresh();
            }
            else if(type == "Magic"){
                Intelligence.BackgroundImage = loot;
                Intelligence.BackColor = Color.Green;
                Intelligence.Refresh();
            }
        }
    }
}
