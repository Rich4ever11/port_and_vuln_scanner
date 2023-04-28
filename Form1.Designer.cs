namespace PortScanner
{
    partial class portScanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portScanner));
            this.scanButton = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.portSpanTwo = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.portSpanOne = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autonomousSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reverseDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchCVE = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.portSpanTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portSpanOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.AccessibleDescription = "Scans the ports of the target placed into the below textbox";
            this.scanButton.AccessibleName = "Port Scan Button";
            this.scanButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scanButton.Image = ((System.Drawing.Image)(resources.GetObject("scanButton.Image")));
            this.scanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scanButton.Location = new System.Drawing.Point(12, 29);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(178, 73);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan Target";
            this.scanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scanButton.UseVisualStyleBackColor = false;
            this.scanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(12, 117);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(306, 31);
            this.ipAddressTextBox.TabIndex = 2;
            this.ipAddressTextBox.Text = "127.0.0.1";
            // 
            // portSpanTwo
            // 
            this.portSpanTwo.Location = new System.Drawing.Point(424, 117);
            this.portSpanTwo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portSpanTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portSpanTwo.Name = "portSpanTwo";
            this.portSpanTwo.Size = new System.Drawing.Size(103, 31);
            this.portSpanTwo.TabIndex = 4;
            this.portSpanTwo.Value = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.portSpanTwo.ValueChanged += new System.EventHandler(this.portSpanTwo_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // portSpanOne
            // 
            this.portSpanOne.Location = new System.Drawing.Point(324, 117);
            this.portSpanOne.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portSpanOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portSpanOne.Name = "portSpanOne";
            this.portSpanOne.Size = new System.Drawing.Size(94, 31);
            this.portSpanOne.TabIndex = 9;
            this.portSpanOne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portSpanOne.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active,
            this.nameColumn,
            this.iPAddressColumn,
            this.continent,
            this.country,
            this.regionName,
            this.city,
            this.district,
            this.zip,
            this.latitude,
            this.longitude,
            this.timezone,
            this.isp,
            this.org,
            this.autonomousSystem,
            this.asname,
            this.reverseDNS,
            this.mobile,
            this.proxy,
            this.hosting});
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(515, 531);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Active
            // 
            this.Active.HeaderText = "Status";
            this.Active.MinimumWidth = 8;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 150;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 8;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 150;
            // 
            // iPAddressColumn
            // 
            this.iPAddressColumn.HeaderText = "IP Address";
            this.iPAddressColumn.MinimumWidth = 8;
            this.iPAddressColumn.Name = "iPAddressColumn";
            this.iPAddressColumn.ReadOnly = true;
            this.iPAddressColumn.Width = 150;
            // 
            // continent
            // 
            this.continent.HeaderText = "Continent";
            this.continent.MinimumWidth = 8;
            this.continent.Name = "continent";
            this.continent.ReadOnly = true;
            this.continent.Width = 150;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 8;
            this.country.Name = "country";
            this.country.ReadOnly = true;
            this.country.Width = 150;
            // 
            // regionName
            // 
            this.regionName.HeaderText = "Region";
            this.regionName.MinimumWidth = 8;
            this.regionName.Name = "regionName";
            this.regionName.ReadOnly = true;
            this.regionName.Width = 150;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 8;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 150;
            // 
            // district
            // 
            this.district.HeaderText = "District";
            this.district.MinimumWidth = 8;
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Width = 150;
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip";
            this.zip.MinimumWidth = 8;
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            this.zip.Width = 150;
            // 
            // latitude
            // 
            this.latitude.HeaderText = "Latitude";
            this.latitude.MinimumWidth = 8;
            this.latitude.Name = "latitude";
            this.latitude.ReadOnly = true;
            this.latitude.Width = 150;
            // 
            // longitude
            // 
            this.longitude.HeaderText = "Longitude";
            this.longitude.MinimumWidth = 8;
            this.longitude.Name = "longitude";
            this.longitude.ReadOnly = true;
            this.longitude.Width = 150;
            // 
            // timezone
            // 
            this.timezone.HeaderText = "Timezone";
            this.timezone.MinimumWidth = 8;
            this.timezone.Name = "timezone";
            this.timezone.ReadOnly = true;
            this.timezone.Width = 150;
            // 
            // isp
            // 
            this.isp.HeaderText = "ISP";
            this.isp.MinimumWidth = 8;
            this.isp.Name = "isp";
            this.isp.ReadOnly = true;
            this.isp.Width = 150;
            // 
            // org
            // 
            this.org.HeaderText = "Organization";
            this.org.MinimumWidth = 8;
            this.org.Name = "org";
            this.org.ReadOnly = true;
            this.org.Width = 150;
            // 
            // autonomousSystem
            // 
            this.autonomousSystem.HeaderText = "Auto Sys.";
            this.autonomousSystem.MinimumWidth = 8;
            this.autonomousSystem.Name = "autonomousSystem";
            this.autonomousSystem.ReadOnly = true;
            this.autonomousSystem.Width = 150;
            // 
            // asname
            // 
            this.asname.HeaderText = "Auto Sys. Name";
            this.asname.MinimumWidth = 8;
            this.asname.Name = "asname";
            this.asname.ReadOnly = true;
            this.asname.Width = 150;
            // 
            // reverseDNS
            // 
            this.reverseDNS.HeaderText = "Reverse DNS";
            this.reverseDNS.MinimumWidth = 8;
            this.reverseDNS.Name = "reverseDNS";
            this.reverseDNS.ReadOnly = true;
            this.reverseDNS.Width = 150;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile";
            this.mobile.MinimumWidth = 8;
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 150;
            // 
            // proxy
            // 
            this.proxy.HeaderText = "Proxy";
            this.proxy.MinimumWidth = 8;
            this.proxy.Name = "proxy";
            this.proxy.ReadOnly = true;
            this.proxy.Width = 150;
            // 
            // hosting
            // 
            this.hosting.HeaderText = "Hosting";
            this.hosting.MinimumWidth = 8;
            this.hosting.Name = "hosting";
            this.hosting.ReadOnly = true;
            this.hosting.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 13;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.serviceName});
            this.dataGridView2.Location = new System.Drawing.Point(533, 154);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(512, 531);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.MinimumWidth = 8;
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 150;
            // 
            // serviceName
            // 
            this.serviceName.HeaderText = "Service Name";
            this.serviceName.MinimumWidth = 8;
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            this.serviceName.Width = 350;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "CVE ID";
            this.textBox1.Size = new System.Drawing.Size(381, 31);
            this.textBox1.TabIndex = 18;
            // 
            // searchCVE
            // 
            this.searchCVE.Location = new System.Drawing.Point(920, 74);
            this.searchCVE.Name = "searchCVE";
            this.searchCVE.Size = new System.Drawing.Size(125, 34);
            this.searchCVE.TabIndex = 19;
            this.searchCVE.Text = "Search CVE";
            this.searchCVE.UseVisualStyleBackColor = true;
            this.searchCVE.Click += new System.EventHandler(this.searchCVE_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(533, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Vendor Name";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Search CVE By Vendor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(687, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Vendor Product";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 24;
            // 
            // portScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 701);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.searchCVE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.portSpanOne);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.portSpanTwo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "portScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portSpanTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portSpanOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scanButton;
        private MaskedTextBox ipAddressTextBox;
        private NumericUpDown portSpanTwo;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private NumericUpDown portSpanOne;
        private DataGridView dataGridView1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn serviceName;
        private DataGridViewTextBoxColumn Active;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn iPAddressColumn;
        private DataGridViewTextBoxColumn continent;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn regionName;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn district;
        private DataGridViewTextBoxColumn zip;
        private DataGridViewTextBoxColumn latitude;
        private DataGridViewTextBoxColumn longitude;
        private DataGridViewTextBoxColumn timezone;
        private DataGridViewTextBoxColumn isp;
        private DataGridViewTextBoxColumn org;
        private DataGridViewTextBoxColumn autonomousSystem;
        private DataGridViewTextBoxColumn asname;
        private DataGridViewTextBoxColumn reverseDNS;
        private DataGridViewTextBoxColumn mobile;
        private DataGridViewTextBoxColumn proxy;
        private DataGridViewTextBoxColumn hosting;
        private TextBox textBox1;
        private Button searchCVE;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox2;
    }
}