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
            this.Equip.ForeColor = System.Drawing.Color.Red;
            this.Equip.Location = new System.Drawing.Point(475, 598);
            this.Equip.Name = "Equip";
            this.Equip.Size = new System.Drawing.Size(245, 91);
            this.Equip.TabIndex = 0;
            this.Equip.Text = "Equip";
            this.Equip.UseVisualStyleBackColor = false;
            this.Equip.Click += new System.EventHandler(this.button1_Click);
            // 
            // Health
            // 
            this.Health.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Health.Location = new System.Drawing.Point(145, 104);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(181, 157);
            this.Health.TabIndex = 1;
            this.Health.TabStop = false;
            this.Health.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Intelligence
            // 
            this.Intelligence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Intelligence.Location = new System.Drawing.Point(896, 104);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(181, 157);
            this.Intelligence.TabIndex = 2;
            this.Intelligence.TabStop = false;
            this.Intelligence.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Power.Location = new System.Drawing.Point(501, 104);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(181, 157);
            this.Power.TabIndex = 3;
            this.Power.TabStop = false;
            this.Power.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(919, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Intelligence";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Power";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Health";
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1203, 737);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.Equip);
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