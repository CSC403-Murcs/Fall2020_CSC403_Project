﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

<<<<<<< HEAD
namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    public FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
    }

    // Starting boss battle
    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      // Setting up the sounds for the boss battle
      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    // instantiating the battle ground for the boss fights
    public static FrmBattle GetInstance(Enemy enemy) {
      //deleted the if statement here because it was causing the game to crash if you engaged more than one enemy --Redmann
      instance = new FrmBattle();
      instance.enemy = enemy;
      instance.Setup();
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      // Changing the player and enemy health bar width to show health has changed
      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    // This game is on the easy mode
    private void btnAttack_Click(object sender, EventArgs e) {
      // decrease the health of the enemy by (-4 * 2(stength))
      player.OnAttack(-4);

      // if enemy is alive
      if (enemy.Health > 0) {

        // decrease the health of the player by (-2 * 2(stength))
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();

      // if one of them is dead then end the combat
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        Close();
      }
    }

    // Apply damage to the enemy
    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    // Apply damage to the player
    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    // This *probably* stops the battleground UI
    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
=======
namespace Fall2020_CSC403_Project
{
	public partial class FrmBattle : Form
	{
		public static FrmBattle instance = null;
		private Enemy enemy;
		private Player player;

		private FrmBattle()
		{
			InitializeComponent();
			player = Game.player;
		}

		public void Setup()
		{
			// update for this enemy
			picEnemy.BackgroundImage = enemy.Img;
			picEnemy.Refresh();
			BackColor = enemy.Color;
			picBossBattle.Visible = false;

			// Observer pattern
			enemy.AttackEvent += PlayerDamage;
			player.AttackEvent += EnemyDamage;

			// show health
			UpdateHealthBars();
		}

		// Starting boss battle
		public void SetupForBossBattle()
		{
			picBossBattle.Location = Point.Empty;
			picBossBattle.Size = ClientSize;
			picBossBattle.Visible = true;

			// Setting up the sounds for the boss battle
			SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
			simpleSound.Play();

			tmrFinalBattle.Enabled = true;
		}

		// instantiating the battle ground for the boss fights
		public static FrmBattle GetInstance(Enemy enemy)
		{
			if (instance == null)
			{
				instance = new FrmBattle();
				instance.enemy = enemy;
				instance.Setup();
			}
			return instance;
		}

		private void UpdateHealthBars()
		{
			float playerHealthPer = player.Health / (float)player.MaxHealth;
			float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

			// Changing the player and enemy health bar width to show health has changed
			const int MAX_HEALTHBAR_WIDTH = 226;
			lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
			lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

			lblPlayerHealthFull.Text = player.Health.ToString();
			lblEnemyHealthFull.Text = enemy.Health.ToString();
		}

		private void btnUseItem_Click(object sender, EventArgs e)
		{
			// TODO; Parsa
		}

		private void btnAttack_ClickMelee(object sender, EventArgs e)
		{
			btnAttack_Click(AttackType.ATTACK_TYPE_MELEE, sender, e);
		}

		private void btnAttack_ClickRanged(object sender, EventArgs e)
		{
			btnAttack_Click(AttackType.ATTACK_TYPE_RANGED, sender, e);
		}

		private void btnAttack_ClickMagic(object sender, EventArgs e)
		{
			btnAttack_Click(AttackType.ATTACK_TYPE_MAGIC, sender, e);
		}

		// This game is on the easy mode
		private void btnAttack_Click(AttackType atktype, object sender, EventArgs e)
		{
			player.OnAttack(Defs.AttackTypeToString(atktype));

			// if enemy is alive
			if (enemy.Health > 0)
			{

				enemy.OnAttack(Defs.AttackTypeToString(atktype));
			}

			UpdateHealthBars();

			// if one of them is dead then end the combat
			if (player.Health <= 0 || enemy.Health <= 0)
			{
				instance = null;
				Close();
			}
		}

		// Apply damage to the enemy
		private void EnemyDamage(string skillType, int amount)
		{
			//			Console.WriteLine("Enemy hurt {0}", amount);
			enemy.Damage(amount);
		}

		// Apply damage to the player
		private void PlayerDamage(string skillType, int amount)
		{
			//      Console.WriteLine("Player hurt {0}", amount);
			player.Damage(amount);
		}

		// This *probably* stops the battleground UI
		private void tmrFinalBattle_Tick(object sender, EventArgs e)
		{
			picBossBattle.Visible = false;
			tmrFinalBattle.Enabled = false;
		}
	}
>>>>>>> 76dc90f31f884141712d37acb195627f34b39c02
}
