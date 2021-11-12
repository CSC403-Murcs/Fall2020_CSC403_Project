
namespace Fall2020_CSC403_Project
{
    partial class VictoryScreen
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.finalTime = new System.Windows.Forms.Label();
            this.displayTime = new System.Windows.Forms.Timer(this.components);
            this.gameQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(262, 82);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(234, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Congratulations! You Won!";
            // 
            // finalTime
            // 
            this.finalTime.AutoSize = true;
            this.finalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTime.Location = new System.Drawing.Point(291, 133);
            this.finalTime.Name = "finalTime";
            this.finalTime.Size = new System.Drawing.Size(89, 20);
            this.finalTime.TabIndex = 1;
            this.finalTime.Text = "Final Time: ";
            // 
            // displayTime
            // 
            this.displayTime.Enabled = true;
            this.displayTime.Tick += new System.EventHandler(this.displayTime_Tick);
            // 
            // button1
            // 
            this.gameQuit.Location = new System.Drawing.Point(295, 242);
            this.gameQuit.Name = "button1";
            this.gameQuit.Size = new System.Drawing.Size(169, 35);
            this.gameQuit.TabIndex = 2;
            this.gameQuit.Text = "Quit Game";
            this.gameQuit.UseVisualStyleBackColor = true;
            this.gameQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // VictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameQuit);
            this.Controls.Add(this.finalTime);
            this.Controls.Add(this.Title);
            this.Name = "VictoryScreen";
            this.Text = "VictoryScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label finalTime;
        private System.Windows.Forms.Timer displayTime;
        private System.Windows.Forms.Button gameQuit;
    }
}