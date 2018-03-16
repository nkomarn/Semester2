using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static bool on = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (on == false)
            {
                on = true;
            }
            else
            {
                on = false;
            }
            BackgroundWorker bgWorker;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(run);

            bgWorker.RunWorkerAsync();

        }


        private void run(object sender, EventArgs e)
        {
            while (on)
            {
                
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Windows\System32\cmd.exe";
                
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                Process proc = new Process();
                proc.StartInfo = startInfo;
                proc.Start();
                // // // // // // // // / // /System.Threading.Thread.Sleep(1);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            on = false;
        }
    }
}

