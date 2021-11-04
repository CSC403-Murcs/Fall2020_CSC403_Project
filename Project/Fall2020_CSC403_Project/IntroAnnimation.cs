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
    public partial class IntroAnnimation : Form
    {
        public IntroAnnimation()
        {
            SoundPlayer dplayer = new SoundPlayer(Resources.coin_sound);
            dplayer.Play();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;

                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Hide();
                WelcomeScreen fm = new WelcomeScreen();
                fm.Show();
            }
        }

        private void IntroAnnimation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
