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
    public partial class Reveal : Form
    {
        public const string imagePath = @"C:\Users\jason\Documents\Courses\MSSA\MCAD1\Projects\21-Card AI Trick\WinForms App\21 Card Trick\Resources\";
        public Reveal()
        {
            InitializeComponent();
        }

        public void FinalReveal(string cardName)
        {
            Bitmap reveal = new Bitmap(imagePath + cardName + ".png");
            pbxReveal.Image = reveal;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FinalReveal("cardName");
        }
    }
}
