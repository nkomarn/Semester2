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
            pictureBox2.MouseDown += new MouseEventHandler(pictureBox2_MouseDown);
            pictureBox2.MouseUp += new MouseEventHandler(pictureBox2_MouseUp);
            pictureBox2.MouseMove += new MouseEventHandler(pictureBox2_MouseMove);
            g = pictureBox2.CreateGraphics();
            pictureBox12.Image = check;
            pictureBox21.Image = item8;
            square = true;
        }
        Graphics g;
        SolidBrush brush;
        private bool draw;
        bool square;
        bool circle;
        int value = 10;
        private Color colorBrush = Color.Black;

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            brush = new SolidBrush(colorBrush);

            if (square)
            {
                g.FillRectangle(brush, e.X - value/2, e.Y - value / 2, value, value);
            }
            if (circle)
            {
                g.FillEllipse(brush, e.X - value / 2, e.Y - value / 2, value, value);
            }

            draw = true;

        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {


                brush = new SolidBrush(colorBrush);
                if (square)
                {
                    g.FillRectangle(brush, e.X - value / 2, e.Y - value / 2, value, value);
                }
                if (circle)
                {
                    g.FillEllipse(brush, e.X - value / 2, e.Y - value / 2, value, value);
                }

            }
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
            value = 3;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.pictureBox11.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox12.Image = clear;
            this.pictureBox13.Image = clear;
            value = 6;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.pictureBox12.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox13.Image = clear;
            value = 10;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.pictureBox13.Image = check;
            this.pictureBox9.Image = clear;
            this.pictureBox10.Image = clear;
            this.pictureBox11.Image = clear;
            this.pictureBox12.Image = clear;
            value = 15;
        }



        Bitmap item1 = new Bitmap(Properties.Resources.CropClicked);
        Bitmap item2 = new Bitmap(Properties.Resources.SelectionClicked);
        Bitmap item3 = new Bitmap(Properties.Resources.HandClicked);
        Bitmap item4 = new Bitmap(Properties.Resources.TextClicked);
        Bitmap item5 = new Bitmap(Properties.Resources.BucketClicked);
        Bitmap item6 = new Bitmap(Properties.Resources.CanClicked);
        Bitmap item7 = new Bitmap(Properties.Resources.WideBrushClicked);
        Bitmap item8 = new Bitmap(Properties.Resources.PencilClicked);
        Bitmap item9 = new Bitmap(Properties.Resources.LineClicked);
        Bitmap item10 = new Bitmap(Properties.Resources.EraserClicked);
        Bitmap item11 = new Bitmap(Properties.Resources.BoxClicked);
        Bitmap item12 = new Bitmap(Properties.Resources.FilledBoxClicked);
        Bitmap item13 = new Bitmap(Properties.Resources.CircleClicked);
        Bitmap item14 = new Bitmap(Properties.Resources.FilledCircleClicked);
        Bitmap item15 = new Bitmap(Properties.Resources.OvalClicked);
        Bitmap item16 = new Bitmap(Properties.Resources.FilledOvalClicked);
        Bitmap item17 = new Bitmap(Properties.Resources.Bean);
        Bitmap item18 = new Bitmap(Properties.Resources.BeanFilled);
        Bitmap item19 = new Bitmap(Properties.Resources.CustomClicked);
        Bitmap item20 = new Bitmap(Properties.Resources.FilledCustomClicked);

        Bitmap Whiteitem1 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_0cCJ3GYWb6u8);
        Bitmap Whiteitem2 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_9QaajIWdcDfsVT);
        Bitmap Whiteitem3 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_iHack40vjznk);
        Bitmap Whiteitem4 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_nDa2SSMU6F9SQR7B);
        Bitmap Whiteitem5 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_pr6Os4WIqSgjr8S);
        Bitmap Whiteitem6 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_5WsYnTu20mjMjCBs);
        Bitmap Whiteitem7 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_hIqb3z2TJSd1kx8y);
        Bitmap Whiteitem8 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_DvqHg3Ncwu9ei9);
        Bitmap Whiteitem9 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_xWCsaa21ZwTl3nk);
        Bitmap Whiteitem10 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_q9FAd0VAHhxo);
        Bitmap Whiteitem11 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_QaLfwWehAAaXD9g);
        Bitmap Whiteitem12 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_0zEcR5EqlWP);
        Bitmap Whiteitem13 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_JwhLhqZA3T);
        Bitmap Whiteitem14 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_lBPW3W0edHw4Gv);
        Bitmap Whiteitem15 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_frfovbkMHasI);
        Bitmap Whiteitem16 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_znyOwKf0cuE);
        Bitmap Whiteitem17 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_NPLUXucTgcW);
        Bitmap Whiteitem18 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_JjMkjGaB0az);
        Bitmap Whiteitem19 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_zYEv7SvBR4Fd);
        Bitmap Whiteitem20 = new Bitmap(Properties.Resources.imgonline_com_ua_Negative_uYFgu4Owoz7e);
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = item1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = item2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = item3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = item4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = item5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = item6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = item7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = item8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
            square = true;
            colorBrush = Color.Black;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = item9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = item10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
            colorBrush = Color.White;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = item11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
            square = true;
            circle = false;
            colorBrush = Color.Black;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = item12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = item13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = item14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = item15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
            circle = true;
            square = false;
            colorBrush = Color.Black;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = item16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = item17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = item18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = item19;
            pictureBox33.Image = Whiteitem20;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Whiteitem1;
            pictureBox15.Image = Whiteitem2;
            pictureBox16.Image = Whiteitem3;
            pictureBox17.Image = Whiteitem4;
            pictureBox18.Image = Whiteitem5;
            pictureBox19.Image = Whiteitem6;
            pictureBox20.Image = Whiteitem7;
            pictureBox21.Image = Whiteitem8;
            pictureBox22.Image = Whiteitem9;
            pictureBox23.Image = Whiteitem10;
            pictureBox24.Image = Whiteitem11;
            pictureBox25.Image = Whiteitem12;
            pictureBox26.Image = Whiteitem13;
            pictureBox27.Image = Whiteitem14;
            pictureBox28.Image = Whiteitem15;
            pictureBox29.Image = Whiteitem16;
            pictureBox30.Image = Whiteitem17;
            pictureBox31.Image = Whiteitem18;
            pictureBox32.Image = Whiteitem19;
            pictureBox33.Image = item20;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
