using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
struct targetMachine
{
    public string targetStatus;
    public string targetName;
    public string targetIpAddress;
    public List<string> openPorts;
}


namespace PortScanner
{
    public partial class portScanner : Form
    {
        IDictionary<string, targetMachine> targetMachineDictionary = new Dictionary<string, targetMachine>();

        public portScanner()
        {
            InitializeComponent();
            Font LargeFont = new Font("Arial", 10);
            scanButton.Font = LargeFont;
        }

        private bool checkValidIPAddress(string ipAddress)
        {
            //Converts the ipAddress to a list 
            string[] list = ipAddress.Split(".");
            //Checks if the length of the list is not 4 (meaning that it does not fit the format of n.n.n.n)
            if (list.Length != 4)
            {
                return false;
            }
            //if the list has 4 items in it then we loop through each item and make sure that the number is not under 0 or over 255
            for (int i = 0; i < list.Length; i++)
            {
                int value = 0;
                bool result = int.TryParse(list[i], out value);
                if (result == false)
                {
                    return false;
                }
                if (value < 0 || value > 255)
                {
                    return false;
                }
            }
            // if the function does not return early than it returns true meaning it is a valid IP Address
            return true;
        }

        private IPAddress obtainIpAddress(string value)
        {
            IPAddress iPAddress = null;
            //Checks if the value is a valid IP Address
            if (checkValidIPAddress(value))
            {
                iPAddress = IPAddress.Parse(value);
                return iPAddress;
            }
            //Assumes the string is a URL and tries to obtain the host
            try
            {
                    IPHostEntry ipHostInfo = Dns.GetHostEntry(value);
                    System.Console.WriteLine(ipHostInfo.AddressList);
                    foreach (IPAddress ipAddress1 in ipHostInfo.AddressList)
                        Console.Write(ipAddress1 + " ");
                    iPAddress = ipHostInfo.AddressList[0];
                    return iPAddress;
            }
            // Manage of Socket's Exceptions
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error);
                return iPAddress;
            }
        }
   
        private int scanPort(IPAddress ipAddress,int port)
            {
                //Initilization of variables
                TcpClient tcpClient = new TcpClient();
                if (ipAddress == IPAddress.IPv6None)
                {
                    System.Console.WriteLine("IP Address Not Found");
                    return 0;
                }
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                    if (tcpClient.ConnectAsync(ipEndPoint).Wait(1000))
                    {
                        System.Console.WriteLine("[+] Connection Complete - Port is " + (port).ToString() + " Open");
                        return port;
                    }
                    else
                    {
                        return 0;
                    }
                }
                // Manage of Socket's Exceptions
                catch (ArgumentNullException)
                {
                    return 0;
                }
                catch (SocketException)
                {
                    return 0;
                }
                catch (Exception)
                {
                    return 0;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = obtainIpAddress(ipAddressTextBox.Text);
            if (ipAddress == null)
            {
                string messageBoxText = "Please enter a valid IP-Address";
                string caption = "Invalid IP Address";
                DialogResult result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    ipAddressTextBox.Text = "";
                }
            } else
            {

                targetMachine newMachine = new targetMachine();
                newMachine.targetStatus = "Open";
                newMachine.targetName = ipAddressTextBox.Text;
                newMachine.targetIpAddress = ipAddress.ToString();
                newMachine.openPorts = new List<string>();

                ScanLoader frm2 = new ScanLoader();
                frm2.loadingIterator = (int)portSpanOne.Value;
                frm2.loadingFinal = (int)portSpanTwo.Value;
                frm2.Show();
                Thread[] connectionThreads = { };
                var result = Parallel.For((int)(portSpanOne.Value), (int)(portSpanTwo.Value), (i, state) =>
                {
                    frm2.loadingIterator = i;
                    int foundPort = scanPort(ipAddress, i);
                    if (foundPort != 0)
                    {
                        newMachine.openPorts.Add(foundPort + "");
                    }
                });
                frm2.Close();
                this.targetMachineDictionary.Add(newMachine.targetName, newMachine);
                dataGridView1.Rows.Add(newMachine.targetStatus, newMachine.targetName, newMachine.targetIpAddress);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (portSpanOne.Value > portSpanTwo.Value)
            {
                string messageBoxText = "Please enter a valid starting port";
                string caption = "Invalid Start Port";
                DialogResult result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    portSpanOne.Value = 1;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            string targetCellName = dgv.CurrentRow.Cells[1].Value.ToString();
            foreach (string port in targetMachineDictionary[targetCellName].openPorts)
            {
                //string service = obtainPortService(int.Parse(port));
                string[] row = new string[] { port, "Service Not Found" };
                dataGridView2.Rows.Add(row);
            }
                    
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void portSpanTwo_ValueChanged(object sender, EventArgs e)
        {
            if (portSpanTwo.Value < portSpanOne.Value)
            {
                string messageBoxText = "Please enter a valid ending port";
                string caption = "Invalid End Port";
                DialogResult result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    portSpanTwo.Value = portSpanOne.Value;
                }
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}