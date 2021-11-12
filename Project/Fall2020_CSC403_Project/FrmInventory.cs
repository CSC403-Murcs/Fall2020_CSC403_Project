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
using System.Collections;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {

        public static FrmInventory instance = null;
        public Item selectedItem;
        private Player player;

        public FrmInventory(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        public static FrmInventory GetInstance(Player player)
        {
            instance = new FrmInventory(player);
            return instance;
        }

        // Equip button
        private void button1_Click(object sender, EventArgs e)
        {
            string itemType = selectedItem.Type();
            Skill skill = player.Skills[itemType];

            switch (itemType) {
                case "Health":
                    // Increase the health of the player
                    if (Health.BackColor == Color.Green)
                    {
                        player.AlterHealth(3);
                        Health.BackColor = Color.FromArgb(153, 180, 209);
                        Health.BackgroundImage = null;
                    }
                    break;
                case "Melee":
                    // Increase melee by +2
                    if (Power.BackColor == Color.Green)
                    {
                        skill.Bonus += 2;
                        Power.BackColor = Color.FromArgb(153, 180, 209);
                        Power.BackgroundImage = null;
                    }
                    break;
                case "Magic":
                    // Increase magic by +2
                    if (Intelligence.BackColor == Color.Green)
                    {
                        skill.Bonus += 4;
                        Intelligence.BackColor = Color.FromArgb(153, 180, 209);
                        Intelligence.BackgroundImage = null;
                    }
                    break;
            }
        }

        // Health Item
        // FIX: Turn the next three functions into one function
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem = new Item("Health");
        }

        // Magic Item
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem = new Item("Magic");
        }

        // Melee Item
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem = new Item("Melee");
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
