using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace PortScanner
{
    public partial class ScanLoader : Form
    {
        public int loadingIterator { get; set; }
        public int loadingFinal { get; set; }

        public ScanLoader()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("HELLO WORDL");
            /*
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 1000; // 1000 ms is one second
            myTimer.Start();
            */
        }

            /*
        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            progressBar1.Value = (int)((double)loadingIterator / loadingFinal * 100);
            label3.Text = progressBar1.Value + "%";
            System.Diagnostics.Debug.WriteLine(label3.Text);

        }
           */


        private void Form2_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
