using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLTW1._5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Bitmap check = new Bitmap(Properties.Resources.Check);
        Bitmap clear = new Bitmap(Properties.Resources.asfalt_light);
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.pictureBox9.Image = check;
            this.pictureBox10.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox12.Image = clear;
            this.pictureBox13.Image = clear;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.pictureBox10.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox12.Image = clear;
            this.pictureBox13.Image = clear;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.pictureBox11.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox12.Image = clear;
            this.pictureBox13.Image = clear;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.pictureBox12.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox13.Image = clear;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.pictureBox13.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox12.Image = clear;

        }
    }
}
