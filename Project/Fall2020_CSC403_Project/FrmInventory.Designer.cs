namespace Fall2020_CSC403_Project
{
    partial class FrmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Equip = new System.Windows.Forms.Button();
            this.Health = new System.Windows.Forms.PictureBox();
            this.Intelligence = new System.Windows.Forms.PictureBox();
            this.Power = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.SuspendLayout();
            // 
            // Equip
            // 
            this.Equip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Equip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Equip.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equip.ForeColor = System.Drawing.Color.Red;
            this.Equip.Location = new System.Drawing.Point(248, 306);
            this.Equip.Margin = new System.Windows.Forms.Padding(2);
            this.Equip.Name = "Equip";
            this.Equip.Size = new System.Drawing.Size(122, 47);
            this.Equip.TabIndex = 0;
            this.Equip.Text = "USE";
            this.Equip.UseVisualStyleBackColor = false;
            this.Equip.Click += new System.EventHandler(this.button1_Click);
            // 
            // Health
            // 
            this.Health.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Health.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Health.Location = new System.Drawing.Point(72, 54);
            this.Health.Margin = new System.Windows.Forms.Padding(2);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(90, 82);
            this.Health.TabIndex = 1;
            this.Health.TabStop = false;
            this.Health.Click += new System.EventHandler(this.health_Click);
            // 
            // Intelligence
            // 
            this.Intelligence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Intelligence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Intelligence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Intelligence.Location = new System.Drawing.Point(448, 54);
            this.Intelligence.Margin = new System.Windows.Forms.Padding(2);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(90, 82);
            this.Intelligence.TabIndex = 2;
            this.Intelligence.TabStop = false;
            this.Intelligence.Click += new System.EventHandler(this.magic_Click);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Power.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Power.Location = new System.Drawing.Point(264, 54);
            this.Power.Margin = new System.Windows.Forms.Padding(2);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(90, 82);
            this.Power.TabIndex = 3;
            this.Power.TabStop = false;
            this.Power.Click += new System.EventHandler(this.melee_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(460, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Magic";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(276, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Melee";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(86, 139);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Health";
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.Equip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.Health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Equip;
        private System.Windows.Forms.PictureBox Health;
        private System.Windows.Forms.PictureBox Intelligence;
        private System.Windows.Forms.PictureBox Power;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}