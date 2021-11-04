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

        public FrmInventory(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        public void Setup()
        {
            // update for this enemy
            Health.BackgroundImage = pickedItem.Img;
            Health.Refresh();
            // BackColor = enemy.Color;
            // picBossBattle.Visible = false;

            // Observer pattern
            //enemy.AttackEvent += PlayerDamage;
            //player.AttackEvent += EnemyDamage;

            // show health
            //UpdateHealthBars();
        }

        public static FrmInventory GetInstance(Player player)
        {
            
            if (instance == null)
            {
                instance = new FrmInventory(player);
                //instance.Setup();
            }
            return instance;
        }

        // Equip button
        private void button1_Click(object sender, EventArgs e)
        {
            string itemType = selectedItem.getType();

            switch (itemType) {
                case "Health":
                    // Increase the health of the player
                    player.SetMaxHealth(30);
                    break;
                case "Power":
                    // Increase the damage of the player
                    break;
                case "Intelligence":
                    // Increase the intelligence of the player
                    break;
            }
        }

        // Health Item
        // FIX: Turn the next three functions into one function
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Health");

            // FIX: Change colors on the second click
            int counter = 0;
            if (counter == 0)
            {
                Health.BackColor = Color.Red;
                counter += 1;
            }
            else
            {
                Health.BackColor = Color.Green;
                counter -= 1;
            }
        }

        // Power Item
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Power");

            // FIX: Change colors on the second click
            int counter = 0;
            if (counter == 0)
            {
                Health.BackColor = Color.Red;
                counter += 1;
            }
            else
            {
                Health.BackColor = Color.Green;
                counter -= 1;
            }
        }

        // Intelligence Item
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Decalring what item the user selects
            this.selectedItem.setType("Intelligence");

            // FIX: Change colors on the second click
            int counter = 0;
            if (counter == 0)
            {
                Health.BackColor = Color.Red;
                counter += 1;
            }
            else
            {
                Health.BackColor = Color.Green;
                counter -= 1;
            }
        }

        public void AddLoot(Image loot, string type){
            if(type == "Health"){
                // How to add a picture to each one of the loot?
                Health.BackgroundImage = loot;
                Health.Refresh();
            }
            else if(type == "Power"){
                Power.BackgroundImage = loot;
                Power.Refresh();
            }
            else if(type == "Intelligence"){
                Intelligence.BackgroundImage = loot;
                Intelligence.Refresh();
            }
        }
    }
}
