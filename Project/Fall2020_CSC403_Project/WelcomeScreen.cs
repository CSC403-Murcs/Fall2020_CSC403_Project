using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
	public partial class WelcomeScreen : Form
	{
		public int hardMode { get; set; }
		SoundPlayer mysound;
		bool opened;
		public IntroAnnimation Anim;
		public WelcomeScreen()
		{
			InitializeComponent();
			mysound = new SoundPlayer(Resources.dark_domination);
			mysound.Play();
			this.FormClosed += OnFormClosed;
		}

		private void WelcomeScreen_Load(object sender, EventArgs e)
		{

		}
		private void leaderboardButton_Quit(object sender, EventArgs e)
		{

		}

		private void playButton_Click(object sender, EventArgs e)
		{
            if (checkBox1.Checked)
            {
				hardMode = 2;
            }
            else
            {
				hardMode = 1;
            }
			FrmLevel frm = new FrmLevel(hardMode);
			frm.Show();
			GameInstructions gi = new GameInstructions();
			gi.Show();
			frm.FormClosed += frm.OnFormClosed;
			frm.Anim = Anim;
			opened = true;
			Close();
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
            // If the form is closed and there's no level to load, stop it
			if (!opened)
			{
				mysound.Stop();
				mysound.Dispose();
				Anim.Close();
			}
		}
	}
}
