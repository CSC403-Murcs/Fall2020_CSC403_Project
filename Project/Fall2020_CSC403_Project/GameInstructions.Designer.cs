
namespace Fall2020_CSC403_Project
{
    partial class GameInstructions
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
            this.Intructions1 = new System.Windows.Forms.Label();
            this.Instructions2 = new System.Windows.Forms.Label();
            this.Instructions3 = new System.Windows.Forms.Label();
            this.Instructions4 = new System.Windows.Forms.Label();
            this.Instructions5 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Instructions6 = new System.Windows.Forms.Label();
            this.Instructions7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.Intructions1.AutoSize = true;
            this.Intructions1.Location = new System.Drawing.Point(26, 20);
            this.Intructions1.Name = "label1";
            this.Intructions1.Size = new System.Drawing.Size(64, 13);
            this.Intructions1.TabIndex = 0;
            this.Intructions1.Text = "Instructions:";
            // 
            // label2
            // 
            this.Instructions2.AutoSize = true;
            this.Instructions2.Location = new System.Drawing.Point(26, 141);
            this.Instructions2.Name = "label2";
            this.Instructions2.Size = new System.Drawing.Size(271, 13);
            this.Instructions2.TabIndex = 1;
            this.Instructions2.Text = "One point is awarded per battle victory. 5 points to win. A final boss will appear once a score of 5 is achieved. Win by beating the final boss Chester";
            // 
            // label3
            // 
            this.Instructions3.AutoSize = true;
            this.Instructions3.Location = new System.Drawing.Point(26, 187);
            this.Instructions3.Name = "label3";
            this.Instructions3.Size = new System.Drawing.Size(198, 13);
            this.Instructions3.TabIndex = 2;
            this.Instructions3.Text = "Losing all of your health is GAME OVER.";
            // 
            // label4
            // 
            this.Instructions4.AutoSize = true;
            this.Instructions4.Location = new System.Drawing.Point(26, 235);
            this.Instructions4.Name = "label4";
            this.Instructions4.Size = new System.Drawing.Size(274, 13);
            this.Instructions4.TabIndex = 3;
            this.Instructions4.Text = "Placement on leaderboards is determined by fastest time.";
            // 
            // label5
            // 
            this.Instructions5.AutoSize = true;
            this.Instructions5.Location = new System.Drawing.Point(26, 279);
            this.Instructions5.Name = "label5";
            this.Instructions5.Size = new System.Drawing.Size(177, 13);
            this.Instructions5.TabIndex = 4;
            this.Instructions5.Text = "Speaking of time, Yours has started!";
            // 
            // button1
            // 
            this.Confirm.Location = new System.Drawing.Point(285, 304);
            this.Confirm.Name = "button1";
            this.Confirm.Size = new System.Drawing.Size(232, 67);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "Okay.";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_click);
            // 
            // label6
            // 
            this.Instructions6.AutoSize = true;
            this.Instructions6.Location = new System.Drawing.Point(26, 56);
            this.Instructions6.Name = "label6";
            this.Instructions6.Size = new System.Drawing.Size(160, 13);
            this.Instructions6.TabIndex = 6;
            this.Instructions6.Text = "Use arrow keys to move around.";
            // 
            // label7
            // 
            this.Instructions7.AutoSize = true;
            this.Instructions7.Location = new System.Drawing.Point(26, 99);
            this.Instructions7.Name = "label7";
            this.Instructions7.Size = new System.Drawing.Size(143, 13);
            this.Instructions7.TabIndex = 7;
            this.Instructions7.Text = "Pressing \"i\" opens inventory.";
            // 
            // GameInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Instructions7);
            this.Controls.Add(this.Instructions6);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Instructions5);
            this.Controls.Add(this.Instructions4);
            this.Controls.Add(this.Instructions3);
            this.Controls.Add(this.Instructions2);
            this.Controls.Add(this.Intructions1);
            this.Name = "GameInstructions";
            this.Text = "GameInstructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Intructions1;
        private System.Windows.Forms.Label Instructions2;
        private System.Windows.Forms.Label Instructions3;
        private System.Windows.Forms.Label Instructions4;
        private System.Windows.Forms.Label Instructions5;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Instructions6;
        private System.Windows.Forms.Label Instructions7;
    }
}