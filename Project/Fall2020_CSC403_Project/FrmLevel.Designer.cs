﻿// The GUI initializer for the game envrionment/level

namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.lblInGameScore = new System.Windows.Forms.Label();
            this.inGameScore_update = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplayBoss = new System.Windows.Forms.Timer(this.components);
            this.picChesterCheetah = new System.Windows.Forms.PictureBox();
            this.picWall14 = new System.Windows.Forms.PictureBox();
            this.picWall13 = new System.Windows.Forms.PictureBox();
            this.FinalBossLoot = new System.Windows.Forms.PictureBox();
            this.KoolLoot = new System.Windows.Forms.PictureBox();
            this.CheetoLoot = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.InGameMagic = new System.Windows.Forms.Label();
            this.InGameRanged = new System.Windows.Forms.Label();
            this.InGameMelee = new System.Windows.Forms.Label();
            this.InGameHealth = new System.Windows.Forms.Label();
            this.health_update = new System.Windows.Forms.Timer(this.components);
            this.melee_update = new System.Windows.Forms.Timer(this.components);
            this.ranged_update = new System.Windows.Forms.Timer(this.components);
            this.magic_update = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picChesterCheetah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBossLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoolLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheetoLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // lblInGameScore
            // 
            this.lblInGameScore.AutoSize = true;
            this.lblInGameScore.BackColor = System.Drawing.Color.Black;
            this.lblInGameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameScore.ForeColor = System.Drawing.Color.White;
            this.lblInGameScore.Location = new System.Drawing.Point(12, 37);
            this.lblInGameScore.Name = "lblInGameScore";
            this.lblInGameScore.Size = new System.Drawing.Size(64, 18);
            this.lblInGameScore.TabIndex = 18;
            this.lblInGameScore.Text = "Score: 0";
            // 
            // inGameScore_update
            // 
            this.inGameScore_update.Enabled = true;
            this.inGameScore_update.Tick += new System.EventHandler(this.inGameScore_update_Tick);
            // 
            // tmrDisplayBoss
            // 
            this.tmrDisplayBoss.Enabled = true;
            this.tmrDisplayBoss.Tick += new System.EventHandler(this.tmrDisplayBoss_Tick);
            // 
            // picChesterCheetah
            // 
            this.picChesterCheetah.BackColor = System.Drawing.Color.Transparent;
            this.picChesterCheetah.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picChesterCheetah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChesterCheetah.Location = new System.Drawing.Point(506, 98);
            this.picChesterCheetah.Margin = new System.Windows.Forms.Padding(2);
            this.picChesterCheetah.Name = "picChesterCheetah";
            this.picChesterCheetah.Size = new System.Drawing.Size(115, 155);
            this.picChesterCheetah.TabIndex = 23;
            this.picChesterCheetah.TabStop = false;
            this.picChesterCheetah.Visible = false;
            // 
            // picWall14
            // 
            this.picWall14.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall14.Location = new System.Drawing.Point(1175, 2);
            this.picWall14.Name = "picWall14";
            this.picWall14.Size = new System.Drawing.Size(48, 325);
            this.picWall14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall14.TabIndex = 22;
            this.picWall14.TabStop = false;
            // 
            // picWall13
            // 
            this.picWall13.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall13.Location = new System.Drawing.Point(1020, 1);
            this.picWall13.Name = "picWall13";
            this.picWall13.Size = new System.Drawing.Size(154, 66);
            this.picWall13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall13.TabIndex = 21;
            this.picWall13.TabStop = false;
            // 
            // FinalBossLoot
            // 
            this.FinalBossLoot.BackColor = System.Drawing.Color.Transparent;
            this.FinalBossLoot.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Intelligence;
            this.FinalBossLoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FinalBossLoot.Location = new System.Drawing.Point(950, 263);
            this.FinalBossLoot.Name = "FinalBossLoot";
            this.FinalBossLoot.Size = new System.Drawing.Size(60, 65);
            this.FinalBossLoot.TabIndex = 20;
            this.FinalBossLoot.TabStop = false;
            this.FinalBossLoot.Visible = false;
            this.FinalBossLoot.Click += new System.EventHandler(this.FinalBossLoot_Click);
            // 
            // KoolLoot
            // 
            this.KoolLoot.BackColor = System.Drawing.Color.Transparent;
            this.KoolLoot.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Power;
            this.KoolLoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KoolLoot.Location = new System.Drawing.Point(177, 179);
            this.KoolLoot.Name = "KoolLoot";
            this.KoolLoot.Size = new System.Drawing.Size(47, 57);
            this.KoolLoot.TabIndex = 19;
            this.KoolLoot.TabStop = false;
            this.KoolLoot.Visible = false;
            this.KoolLoot.Click += new System.EventHandler(this.KoolLoot_Click);
            // 
            // CheetoLoot
            // 
            this.CheetoLoot.BackColor = System.Drawing.Color.Transparent;
            this.CheetoLoot.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.health;
            this.CheetoLoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheetoLoot.Image = global::Fall2020_CSC403_Project.Properties.Resources.health;
            this.CheetoLoot.Location = new System.Drawing.Point(798, 498);
            this.CheetoLoot.Name = "CheetoLoot";
            this.CheetoLoot.Size = new System.Drawing.Size(60, 56);
            this.CheetoLoot.TabIndex = 18;
            this.CheetoLoot.TabStop = false;
            this.CheetoLoot.Visible = false;
            this.CheetoLoot.Click += new System.EventHandler(this.CheetoLoot_Click);
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Margin = new System.Windows.Forms.Padding(6);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Margin = new System.Windows.Forms.Padding(6);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 274);
            this.picWall8.Margin = new System.Windows.Forms.Padding(6);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Margin = new System.Windows.Forms.Padding(6);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Margin = new System.Windows.Forms.Padding(6);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Margin = new System.Windows.Forms.Padding(6);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(653, 89);
            this.picWall10.Margin = new System.Windows.Forms.Padding(6);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(266, 154);
            this.picWall9.Margin = new System.Windows.Forms.Padding(6);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Margin = new System.Windows.Forms.Padding(6);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Margin = new System.Windows.Forms.Padding(6);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Margin = new System.Windows.Forms.Padding(6);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Margin = new System.Windows.Forms.Padding(6);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(6);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(6);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Margin = new System.Windows.Forms.Padding(6);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(6);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // InGameMagic
            // 
            this.InGameMagic.AutoSize = true;
            this.InGameMagic.BackColor = System.Drawing.Color.Black;
            this.InGameMagic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InGameMagic.ForeColor = System.Drawing.Color.White;
            this.InGameMagic.Location = new System.Drawing.Point(320, 656);
            this.InGameMagic.Name = "InGameMagic";
            this.InGameMagic.Size = new System.Drawing.Size(64, 18);
            this.InGameMagic.TabIndex = 23;
            this.InGameMagic.Text = "Magic: 0";
            // 
            // InGameRanged
            // 
            this.InGameRanged.AutoSize = true;
            this.InGameRanged.BackColor = System.Drawing.Color.Black;
            this.InGameRanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InGameRanged.ForeColor = System.Drawing.Color.White;
            this.InGameRanged.Location = new System.Drawing.Point(241, 656);
            this.InGameRanged.Name = "InGameRanged";
            this.InGameRanged.Size = new System.Drawing.Size(75, 18);
            this.InGameRanged.TabIndex = 24;
            this.InGameRanged.Text = "Ranged: 0";
            // 
            // InGameMelee
            // 
            this.InGameMelee.AutoSize = true;
            this.InGameMelee.BackColor = System.Drawing.Color.Black;
            this.InGameMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InGameMelee.ForeColor = System.Drawing.Color.White;
            this.InGameMelee.Location = new System.Drawing.Point(161, 656);
            this.InGameMelee.Name = "InGameMelee";
            this.InGameMelee.Size = new System.Drawing.Size(64, 18);
            this.InGameMelee.TabIndex = 25;
            this.InGameMelee.Text = "Melee: 0";
            // 
            // InGameHealth
            // 
            this.InGameHealth.AutoSize = true;
            this.InGameHealth.BackColor = System.Drawing.Color.Black;
            this.InGameHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InGameHealth.ForeColor = System.Drawing.Color.White;
            this.InGameHealth.Location = new System.Drawing.Point(80, 656);
            this.InGameHealth.Name = "InGameHealth";
            this.InGameHealth.Size = new System.Drawing.Size(66, 18);
            this.InGameHealth.TabIndex = 26;
            this.InGameHealth.Text = "Health: 0";
            // 
            // health_update
            // 
            this.health_update.Enabled = true;
            this.health_update.Tick += new System.EventHandler(this.health_update_Tick);
            // 
            // melee_update
            // 
            this.melee_update.Enabled = true;
            this.melee_update.Tick += new System.EventHandler(this.melee_update_Tick);
            // 
            // ranged_update
            // 
            this.ranged_update.Enabled = true;
            this.ranged_update.Tick += new System.EventHandler(this.ranged_update_Tick);
            // 
            // magic_update
            // 
            this.magic_update.Enabled = true;
            this.magic_update.Tick += new System.EventHandler(this.magic_update_Tick);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 332);
            this.Controls.Add(this.picChesterCheetah);
            this.Controls.Add(this.InGameHealth);
            this.Controls.Add(this.InGameMelee);
            this.Controls.Add(this.InGameRanged);
            this.Controls.Add(this.InGameMagic);
            this.Controls.Add(this.picWall14);
            this.Controls.Add(this.picWall13);
            this.Controls.Add(this.FinalBossLoot);
            this.Controls.Add(this.KoolLoot);
            this.Controls.Add(this.CheetoLoot);
            this.Controls.Add(this.lblInGameScore);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picChesterCheetah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBossLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoolLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheetoLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;

        private System.Windows.Forms.PictureBox CheetoLoot;
        private System.Windows.Forms.PictureBox KoolLoot;
        private System.Windows.Forms.PictureBox FinalBossLoot;

        private System.Windows.Forms.Label lblInGameScore;
        private System.Windows.Forms.Timer inGameScore_update;
        private System.Windows.Forms.PictureBox picWall13;
        private System.Windows.Forms.PictureBox picWall14;

        private System.Windows.Forms.PictureBox picChesterCheetah;
        private System.Windows.Forms.Timer tmrDisplayBoss;

        private System.Windows.Forms.Label InGameMagic;
        private System.Windows.Forms.Label InGameRanged;
        private System.Windows.Forms.Label InGameMelee;
        private System.Windows.Forms.Label InGameHealth;
        private System.Windows.Forms.Timer health_update;
        private System.Windows.Forms.Timer melee_update;
        private System.Windows.Forms.Timer ranged_update;
        private System.Windows.Forms.Timer magic_update;
    }
}

