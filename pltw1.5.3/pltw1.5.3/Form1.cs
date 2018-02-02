using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pltw1._5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.MouseClick += new MouseEventHandler(searchBox);
            button2.MouseClick += new MouseEventHandler(backward);
            button3.MouseClick += new MouseEventHandler(forward);
            button4.MouseClick += new MouseEventHandler(home);
            
        }
        
        public void searchBox(object sender, MouseEventArgs e) {
            string url = textBox1.Text.Trim();
            webBrowser1.Navigate(url);
            
        }
        public void forward(object sender, MouseEventArgs e) {
            if (webBrowser1.CanGoForward) {
                webBrowser1.GoForward();
            }
        }
        public void backward(object sender, MouseEventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }
        public void home(object sender, MouseEventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
