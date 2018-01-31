using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5._3PLTW
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 5;
            trackBar1.SmallChange = 1;
            pictureBox1.MouseClick += new MouseEventHandler(draw);
            button1.MouseClick += new MouseEventHandler(rectangle);
            button2.MouseClick += new MouseEventHandler(circle);
            button4.MouseClick += new MouseEventHandler(clear);
        }
        float type;
        public void rectangle(object sender, MouseEventArgs e) {
            type = 1;
        }
        public void circle(object sender, MouseEventArgs e)
        {
            type = 2;
        }
        
        public void draw(object sender, MouseEventArgs e) {
            float value = trackBar1.Value;
            switch (type) {
                case 1:
                    g.FillRectangle(Brushes.Black, e.X, e.Y, value, value);
                    break;
                case 2:
                    g.FillEllipse(Brushes.Black, e.X, e.Y, value, value);
                    break;
                default:
                    g.FillEllipse(Brushes.Black, e.X, e.Y, value, value);
                    break;
            }
        }
        public void clear(object sender, MouseEventArgs e) {
            g.Clear(Color.White);
        }
    }
}
