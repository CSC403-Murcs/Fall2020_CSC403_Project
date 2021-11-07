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
        private SoundPlayer SoundPlayer;
        public IntroAnnimation()
        {
            SoundPlayer = new SoundPlayer(Resources.coin_sound);
            SoundPlayer.Play();
            InitializeComponent();
            this.FormClosed += OnFormClosed;
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
                WelcomeScreen fm = new WelcomeScreen();
                fm.Show();
                fm.Anim = this;
                Hide();
            }
        }

        private void IntroAnnimation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            SoundPlayer.Stop();
            SoundPlayer.Dispose();
        }
    }
}
