﻿
namespace Fall2020_CSC403_Project
{
    partial class GameOver
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
            this.gameOver = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuitGame
            // 
            this.gameOver.Location = new System.Drawing.Point(286, 247);
            this.gameOver.Name = "QuitGame";
            this.gameOver.Size = new System.Drawing.Size(240, 71);
            this.gameOver.TabIndex = 0;
            this.gameOver.Text = "Quit Game";
            this.gameOver.UseVisualStyleBackColor = true;
            this.gameOver.Click += new System.EventHandler(this.gameOver_click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(360, 80);
            this.Title.Name = "label1";
            this.Title.Size = new System.Drawing.Size(93, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "You Lost! ";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.gameOver);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameOver;
        private System.Windows.Forms.Label Title;
    }
}