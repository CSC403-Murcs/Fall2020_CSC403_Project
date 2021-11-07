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
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			FrmLevel frm = new FrmLevel();
			frm.Show();
			frm.FormClosed += frm.OnFormClosed;
			frm.Anim = Anim;
			opened = true;
			Close();
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FrmLevel());
		}

		private void button4_Click(object sender, EventArgs e)
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
