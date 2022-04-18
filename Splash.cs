using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Card_Trick
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        //Use timer class
        Timer tmr;
        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval
            tmr.Interval = 5000;
            //starts the timer
            tmr.Start();
            tmr.Tick += Tmr_Tick;
        }
        void Tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            //display Main_Trick form
            pbxMain_Trick startTrick = new pbxMain_Trick();
            startTrick.Show();
            //hide this form
            this.Hide();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
