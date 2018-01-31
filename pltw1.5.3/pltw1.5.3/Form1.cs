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
        }
        
        public void searchBox(object sender, MouseEventArgs e) {
            //Uri search = new Uri(textBox1.Text);
            //webBrowser1.Url = search;
            webBrowser1.Navigate("http://www.google.com");
            //HtmlDocument doc = webBrowser1.Document;
            //HtmlElement elem = doc.GetElementById("q");
            
        }

    }
}
