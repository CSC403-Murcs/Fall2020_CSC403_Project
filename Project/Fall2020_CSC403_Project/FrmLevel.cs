// Game environment
// First and only level 

using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project {
  public partial class xs : Form {
    private Player player;

    private Respawner[] respawners;

//    private Enemy enemyPoisonPacket;
//    private Enemy bossKoolaid;
//    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmInventory frmInventory;
    public SoundPlayer backgroundsound;
    public IntroAnnimation Anim;
    private bool sneaking = false;

    public xs() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 15;

      // For creating new UI elements, initialize a picturebox in designer 
      // create padding for it using the createcollider function in this file
      // make sure the position of the player is set to the picturebox
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

      respawners = new Respawner[3];
			respawners[0] = new Respawner(picBossKoolAid, new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), player));
			respawners[1] = new Respawner(picEnemyPoisonPacket, new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), player));
			respawners[2] = new Respawner(picEnemyCheeto, new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), player));

      respawners[0].SetColor(Color.Red);
      respawners[1].SetColor(Color.Green);
      respawners[2].SetColor(Color.FromArgb(255, 245, 161));

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;

      this.frmInventory = FrmInventory.GetInstance(player);
    }

    // put the character *under* the picturebox
    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    // Create a padding for the picturebox/character
    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    // Stops the player from moving
    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    // keeps track of the time spent in the game
    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();
      
      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      // If you hit a character, you got beef
      // Because you have to initialize a new character for each enemy,
      // , you have to pass each one separately to the functions
      // Singleton design pattern
      int idx = HitAChar(player, respawners);
      if (idx != -1) {
        Fight(respawners[idx].Enemy);
      }

      UpdateRespawners();

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    // Method for stopping you from hitting a wall
    private bool HitAWall(Character character) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (character.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private int HitAChar(Player you, Respawner[] other) {
      for (int i = 0; i < other.Length; i++) {
        // Enemy already dead
        if (!other[i].IsActive) {
          continue;
        }
        if (other[i].Collider.notices(you)) { 
          return i;        
        }
        if (you.Collider.Intersects(other[i].Enemy.Collider)) {
          return i;
        }
      }
      return -1;
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();

      // Initialize an instance of the battleground with the enemy you got close with
      frmBattle = FrmBattle.GetInstance(enemy);

      // Showing that loot drops after enemy dies
      // if enemy health is zero
      // enemy drops loot -> enemy.dropLoot() -> random item 
      // show the item on the ground

      frmBattle.Show();
      // there's something wrong with this if statement

      if (enemy.GetHealth() != 0) {
        Color color = enemy.Color;
        if(color == Color.Red){
            FinalBossLoot.Visible = true;
        }
        else if(color == Color.Green){
            KoolLoot.Visible = true;
        }
        else if(color == Color.FromArgb(255, 245, 161)){
            CheetoLoot.Visible = true;
        }
      }
    
      // KoolAid man
      if (enemy == respawners[0].Enemy) {
        frmBattle.SetupForBossBattle();
      }
    }

    // Registering the key you press
    // This is where we can add additional keys to interact with
    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;
        
        case Keys.I:
          Open(player);
          break;

        // If the player hits E when they are close to loot
        // that Item replaces one of the buttons in the inventory
        case Keys.K:
          player.sneak(sneaking);
          sneaking = true;
          break;

        case Keys.J:
          player.standUp(sneaking);
          sneaking=false;
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

    private void Open(Player player)
    {
        // Initialize an instance of the battleground with the enemy you got close with
        this.frmInventory = FrmInventory.GetInstance(player);

        // FIX: User should be able to open the inventory as many times as possible
        this.frmInventory.Show();
    }


        // Click on loot, get the loot!
        private void CheetoLoot_Click(object sender, EventArgs e)
        {
          // Change the image of each loot
            frmInventory.AddLoot(CheetoLoot.BackgroundImage, "Health");
            CheetoLoot.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInventory.AddLoot(KoolLoot.BackgroundImage, "Melee");
            KoolLoot.Visible = false;
        }

        private void FinalBossLoot_Click(object sender, EventArgs e)
        {
            frmInventory.AddLoot(FinalBossLoot.BackgroundImage, "Magic");
            FinalBossLoot.Visible = false;

        }

        private void inGameScore_update_Tick(object sender, EventArgs e)
        {
            lblInGameScore.Text = "Score: " + player.playerScore.ToString();
            Console.WriteLine(player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_RANGED)));
            Console.WriteLine(" " + player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_MAGIC)));
            ;
        }

        private void health_update_Tick(object sender, EventArgs e)
        {
            InGameHealth.Text = "Health: " + player.Health;
        }

        private void melee_update_tick_Tick(object sender, EventArgs e)
        {
        
            Console.WriteLine(player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_MELEE)));

            InGamePower.Text = "Melee: " + player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_MELEE)).ToString();
        }

        private void ranged_update_Tick(object sender, EventArgs e)
        {
            InGameRanged.Text = "Ranged: " + player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_RANGED)).ToString();
        }

        // Some comment
        private void magic_update_Tick_1(object sender, EventArgs e)
        {
            InGameMagic.Text = "Magic: " + player.AttackStrength(Defs.AttackTypeToString(AttackType.ATTACK_TYPE_MAGIC)).ToString();
        }
      private void UpdateRespawners() {
        for (int i = 0; i < respawners.Length; i++) {
          respawners[i].Update();
        }
      }
      public void OnFormClosed(object sender, FormClosedEventArgs e) {
            // Stop the timers
            tmrPlayerMove.Stop();
            tmrUpdateInGameTime.Stop();
            inGameScore_update.Stop();
            tmrPlayerMove.Dispose();
            tmrUpdateInGameTime.Dispose();
            inGameScore_update.Dispose();

            if (Anim != null)
            {
                Anim.Close();
            }
      }
    }
}
