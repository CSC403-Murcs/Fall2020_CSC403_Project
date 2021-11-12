using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class VictoryScreen : Form
    {
        public IntroAnnimation Anim;
        private TimeSpan t;
        public VictoryScreen(TimeSpan t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void displayTime_Tick(object sender, EventArgs e)
        {
            finalTime.Text = "Final Time: " + t.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anim.Close();
        }
    }
}
