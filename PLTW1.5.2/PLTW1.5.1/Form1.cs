using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLTW1._5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            
            pictureBox1.MouseDoubleClick += new MouseEventHandler(pickPic);
            button1.MouseClick += new MouseEventHandler(helpMenu);
            button2.MouseClick += new MouseEventHandler(helpMenuClose);
            button7.MouseClick += new MouseEventHandler(applyText);
            pic = (Bitmap)pictureBox1.Image;
            trackBar1.Scroll += new EventHandler(textSize);
            
            trackBar1.Minimum = 14;
            trackBar1.Maximum = 48;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 5;
            trackBar1.SmallChange = 1;
            label5.Text = label5.Text + trackBar1.Value;
        }
        Bitmap pic;
        System.IO.StreamReader sr;
        public void pickPic(Object sender, MouseEventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                try
                {
                    pic = new Bitmap(openFileDialog1.FileName, true);
                    pictureBox1.Image = pic;
                }
                catch (Exception)
                {

                    MessageBox.Show("The file you chose was not an image!");

                }
                
                sr.Close();
            }

            
        }

        public void helpMenu(object sender, MouseEventArgs e) {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            button4.Enabled = true;
            button4.Visible = true;
            button5.Enabled = true;
            button5.Visible = true;
            button6.Enabled = true;
            button6.Visible = true;
            label1.Enabled = true;
            label1.Visible = true;
            pictureBox2.BringToFront();
            label1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
            button6.BringToFront();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button7.Enabled = false;

            button3.MouseClick += new MouseEventHandler(English);
            button4.MouseClick += new MouseEventHandler(Spanish);
            button5.MouseClick += new MouseEventHandler(German);
            button6.MouseClick += new MouseEventHandler(Russian);

            trackBar1.Enabled = false;
        }
        string lbl5txt;
        public void textSize(object sender, EventArgs e) {
            switch (language)
            {
                default:

                    lbl5txt = "Text Size: ";
                    break;
                case 1:

                    lbl5txt = "Text Size: ";
                    break;
                case 2:

                    lbl5txt = "Tamano del texto: ";
                    break;
                case 3:

                    lbl5txt = "Textgröße: ";
                    break;
                case 4:

                    lbl5txt = "Размер текста: ";
                    break;
            }
                    label5.Text = lbl5txt + trackBar1.Value;
            tb1 = trackBar1.Value;
            tb2 = trackBar1.Value;
        }
        public void helpMenuClose(object sender, MouseEventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Visible = false;
            button2.Visible = false;
            pictureBox2.Enabled = false;
            label1.Enabled = false;
            label1.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = false;
            button6.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button7.Enabled = true;
            trackBar1.Enabled = true;
        }
        public int language;
        public void English(object sender, MouseEventArgs e) {
            language = 1;
            languageSwitch();
        }
        public void Spanish(object sender, MouseEventArgs e)
        {
            language = 2;
            languageSwitch();
        }
        public void German(object sender, MouseEventArgs e)
        {
            language = 3;
            languageSwitch();
        }
        public void Russian(object sender, MouseEventArgs e)
        {
            language = 4;
            languageSwitch();
        }
        public void languageSwitch() {
            switch (language)
            {
                default:
                    button1.Text = "Help";
                    button3.Text = "English";
                    button4.Text = "Spanish";
                    button5.Text = "German";
                    button6.Text = "Russian";
                    label1.Text = "Language";
                    label2.Text = "Top Text";
                    label3.Text = "Bottom Text";
                    button7.Text = "Apply";
                    label5.Text = "Text Size: " + trackBar1.Value;
                    label4.Text = "Double-click to change image";
                    checkBox1.Text = "Text Black?";
                    break;
                case 1:
                    button1.Text = "Help";
                    button3.Text = "English";
                    button4.Text = "Spanish";
                    button5.Text = "German";
                    button6.Text = "Russian";
                    label1.Text = "Language";
                    label2.Text = "Top Text";
                    label3.Text = "Bottom Text";
                    button7.Text = "Apply";
                    label5.Text = "Text Size: " + trackBar1.Value;
                    label4.Text = "Double-click to change image";
                    checkBox1.Text = "Text Black?";
                    break;
                case 2:
                    button1.Text = "Ayuda";
                    button3.Text = "Inglés";
                    button4.Text = "Español";
                    button5.Text = "Alemán";
                    button6.Text = "Ruso";
                    label1.Text = "Idioma";
                    label2.Text = "Texto superior";
                    label3.Text = "Texto inferior";
                    button7.Text = "Aplicar";
                    label5.Text = "Tamano del texto: " + trackBar1.Value;
                    label4.Text = "Haz doble clic para cambiar la imagen";
                    checkBox1.Text = "Texto negro?";
                    break;
                case 3:
                    button1.Text = "Hilfe";
                    button3.Text = "Englisch";
                    button4.Text = "Spanisch";
                    button5.Text = "Deutsche";
                    button6.Text = "Russisch";
                    label1.Text = "Sprache";
                    label2.Text = "Top-text";
                    label3.Text = "Fußzeile";
                    button7.Text = "Sich bewerben";
                    label5.Text = "Textgröße: " + trackBar1.Value;
                    label4.Text = "Doppelklicken, um das Bild zu ändern";
                    checkBox1.Text = "Text Schwarz?";
                    break;
                case 4:
                    button1.Text = "Помогите";
                    button3.Text = "английский";
                    button4.Text = "испанский";
                    button5.Text = "Немецкий";
                    button6.Text = "русский";
                    label1.Text = "язык";
                    label2.Text = "Заголовок";
                    label3.Text = "Нижний текст";
                    button7.Text = "Подать заявление";
                    label5.Text = "Размер текста: " + trackBar1.Value;
                    label4.Text = "Дважды щелкните, чтобы изменить изображение.";
                    checkBox1.Text = "Текст Черный?";
                    break;


            }
        }
        Graphics g;
        RectangleF top = new RectangleF(5, 3, 650, 150);
        RectangleF bottom = new RectangleF(5, 225, 650, 150);
        Bitmap pic2;
        Pen penn;
        Brush b1;
        Brush b2;
        float tb1 = 14;
        float tb2 = 14;
        public void applyText(object sender, MouseEventArgs e) {
            b1 = Brushes.White;
            b2 = Brushes.Black;
            Brush b3;
            if (checkBox1.Checked) {
                b3 = b2;
            }
            else {
                b3 = b1;
            }
            pic2 = (Bitmap)pictureBox1.Image;
            g = Graphics.FromImage(pic);
           
            g.DrawString(textBox1.Text, new Font("Microsoft Sans Serif", tb1), b3, top);
            g.DrawString(textBox2.Text, new Font("Microsoft Sans Serif", tb2), b3, bottom);
            g.Flush();

            pictureBox1.Image = pic;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
