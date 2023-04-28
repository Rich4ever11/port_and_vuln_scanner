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
        public string scanPreformed { get; set; }

        public ScanLoader()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = scanPreformed;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
