namespace SubnetCaculatorApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_netmask = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_subnet_id = new System.Windows.Forms.Label();
            this.lbl_inverted_decimal_netmask = new System.Windows.Forms.Label();
            this.txt_inverted_decimal_netmask = new System.Windows.Forms.TextBox();
            this.lbl_inverted_binary_netmask = new System.Windows.Forms.Label();
            this.txt_inverted_binary_netmask = new System.Windows.Forms.TextBox();
            this.txt_binary_netmask = new System.Windows.Forms.TextBox();
            this.lbl_binary_netmask = new System.Windows.Forms.Label();
            this.lbl_broadcast = new System.Windows.Forms.Label();
            this.txt_binary_adress = new System.Windows.Forms.TextBox();
            this.lbl_binary_address = new System.Windows.Forms.Label();
            this.gb_ipconfig = new System.Windows.Forms.GroupBox();
            this.txt_adr_byte4 = new System.Windows.Forms.TextBox();
            this.txt_adr_byte3 = new System.Windows.Forms.TextBox();
            this.txt_adr_byte2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_adr_byte1 = new System.Windows.Forms.TextBox();
            this.gb_netmaskconfig = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_mask_byte4 = new System.Windows.Forms.ComboBox();
            this.cb_mask_byte3 = new System.Windows.Forms.ComboBox();
            this.cb_mask_byte2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_mask_byte1 = new System.Windows.Forms.ComboBox();
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_borrow_bits = new System.Windows.Forms.TextBox();
            this.txt_timetolive = new System.Windows.Forms.TextBox();
            this.txt_brdaddress = new System.Windows.Forms.TextBox();
            this.txt_subaddress = new System.Windows.Forms.TextBox();
            this.txt_number_subnets = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_number_subnets = new System.Windows.Forms.Label();
            this.lbl_number_clientadresses = new System.Windows.Forms.Label();
            this.txt_number_clientaddresses = new System.Windows.Forms.TextBox();
            this.list_subnet_ids = new System.Windows.Forms.ListBox();
            this.gb_available_subnets = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_operations = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_reuse = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.btn_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.select_import = new System.Windows.Forms.ToolStripMenuItem();
            this.select_close = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_aboutSC = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ipconfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_netmaskconfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gb_available_subnets.SuspendLayout();
            this.gb_operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(12, 45);
            this.lbl_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(105, 22);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "ĐỊA CHỈ IP";
            // 
            // lbl_netmask
            // 
            this.lbl_netmask.AutoSize = true;
            this.lbl_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_netmask.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netmask.Location = new System.Drawing.Point(9, 41);
            this.lbl_netmask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_netmask.Name = "lbl_netmask";
            this.lbl_netmask.Size = new System.Drawing.Size(152, 22);
            this.lbl_netmask.TabIndex = 8;
            this.lbl_netmask.Text = "MẶT NẠ MẠNG";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(107)))), ((int)(((byte)(25)))));
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_start.Location = new System.Drawing.Point(25, 39);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(307, 64);
            this.btn_start.TabIndex = 21;
            this.btn_start.Text = "BẮT ĐẦU";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_subnet_id
            // 
            this.lbl_subnet_id.AutoSize = true;
            this.lbl_subnet_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_subnet_id.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subnet_id.Location = new System.Drawing.Point(72, 50);
            this.lbl_subnet_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subnet_id.Name = "lbl_subnet_id";
            this.lbl_subnet_id.Size = new System.Drawing.Size(196, 22);
            this.lbl_subnet_id.TabIndex = 20;
            this.lbl_subnet_id.Text = "ĐỊA CHỈ MẠNG CON";
            // 
            // lbl_inverted_decimal_netmask
            // 
            this.lbl_inverted_decimal_netmask.AutoSize = true;
            this.lbl_inverted_decimal_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_inverted_decimal_netmask.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inverted_decimal_netmask.Location = new System.Drawing.Point(9, 151);
            this.lbl_inverted_decimal_netmask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inverted_decimal_netmask.Name = "lbl_inverted_decimal_netmask";
            this.lbl_inverted_decimal_netmask.Size = new System.Drawing.Size(212, 22);
            this.lbl_inverted_decimal_netmask.TabIndex = 21;
            this.lbl_inverted_decimal_netmask.Text = "MẶT NẠ MẠNG (ĐẢO)";
            // 
            // txt_inverted_decimal_netmask
            // 
            this.txt_inverted_decimal_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_inverted_decimal_netmask.Enabled = false;
            this.txt_inverted_decimal_netmask.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inverted_decimal_netmask.Location = new System.Drawing.Point(289, 145);
            this.txt_inverted_decimal_netmask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_inverted_decimal_netmask.Name = "txt_inverted_decimal_netmask";
            this.txt_inverted_decimal_netmask.ReadOnly = true;
            this.txt_inverted_decimal_netmask.Size = new System.Drawing.Size(381, 31);
            this.txt_inverted_decimal_netmask.TabIndex = 12;
            this.txt_inverted_decimal_netmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_inverted_binary_netmask
            // 
            this.lbl_inverted_binary_netmask.AutoSize = true;
            this.lbl_inverted_binary_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_inverted_binary_netmask.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inverted_binary_netmask.Location = new System.Drawing.Point(9, 202);
            this.lbl_inverted_binary_netmask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inverted_binary_netmask.Name = "lbl_inverted_binary_netmask";
            this.lbl_inverted_binary_netmask.Size = new System.Drawing.Size(228, 22);
            this.lbl_inverted_binary_netmask.TabIndex = 23;
            this.lbl_inverted_binary_netmask.Text = "DẠNG NHỊ PHÂN (ĐẢO)";
            // 
            // txt_inverted_binary_netmask
            // 
            this.txt_inverted_binary_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_inverted_binary_netmask.Enabled = false;
            this.txt_inverted_binary_netmask.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inverted_binary_netmask.Location = new System.Drawing.Point(290, 196);
            this.txt_inverted_binary_netmask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_inverted_binary_netmask.Name = "txt_inverted_binary_netmask";
            this.txt_inverted_binary_netmask.ReadOnly = true;
            this.txt_inverted_binary_netmask.Size = new System.Drawing.Size(381, 31);
            this.txt_inverted_binary_netmask.TabIndex = 13;
            this.txt_inverted_binary_netmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_binary_netmask
            // 
            this.txt_binary_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_binary_netmask.Enabled = false;
            this.txt_binary_netmask.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_binary_netmask.Location = new System.Drawing.Point(290, 88);
            this.txt_binary_netmask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_binary_netmask.Name = "txt_binary_netmask";
            this.txt_binary_netmask.ReadOnly = true;
            this.txt_binary_netmask.Size = new System.Drawing.Size(381, 31);
            this.txt_binary_netmask.TabIndex = 11;
            this.txt_binary_netmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_binary_netmask
            // 
            this.lbl_binary_netmask.AutoSize = true;
            this.lbl_binary_netmask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_binary_netmask.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_binary_netmask.Location = new System.Drawing.Point(11, 98);
            this.lbl_binary_netmask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_binary_netmask.Name = "lbl_binary_netmask";
            this.lbl_binary_netmask.Size = new System.Drawing.Size(168, 22);
            this.lbl_binary_netmask.TabIndex = 25;
            this.lbl_binary_netmask.Text = "DẠNG NHỊ PHÂN";
            // 
            // lbl_broadcast
            // 
            this.lbl_broadcast.AutoSize = true;
            this.lbl_broadcast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_broadcast.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_broadcast.Location = new System.Drawing.Point(415, 46);
            this.lbl_broadcast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_broadcast.Name = "lbl_broadcast";
            this.lbl_broadcast.Size = new System.Drawing.Size(206, 22);
            this.lbl_broadcast.TabIndex = 27;
            this.lbl_broadcast.Text = "ĐỊA CHỈ BROADCAST";
            // 
            // txt_binary_adress
            // 
            this.txt_binary_adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_binary_adress.Enabled = false;
            this.txt_binary_adress.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_binary_adress.Location = new System.Drawing.Point(289, 81);
            this.txt_binary_adress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_binary_adress.Name = "txt_binary_adress";
            this.txt_binary_adress.ReadOnly = true;
            this.txt_binary_adress.Size = new System.Drawing.Size(382, 31);
            this.txt_binary_adress.TabIndex = 5;
            this.txt_binary_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_binary_address
            // 
            this.lbl_binary_address.AutoSize = true;
            this.lbl_binary_address.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_binary_address.Location = new System.Drawing.Point(11, 88);
            this.lbl_binary_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_binary_address.Name = "lbl_binary_address";
            this.lbl_binary_address.Size = new System.Drawing.Size(168, 22);
            this.lbl_binary_address.TabIndex = 29;
            this.lbl_binary_address.Text = "DẠNG NHỊ PHÂN";
            // 
            // gb_ipconfig
            // 
            this.gb_ipconfig.Controls.Add(this.txt_adr_byte4);
            this.gb_ipconfig.Controls.Add(this.txt_adr_byte3);
            this.gb_ipconfig.Controls.Add(this.txt_adr_byte2);
            this.gb_ipconfig.Controls.Add(this.pictureBox1);
            this.gb_ipconfig.Controls.Add(this.label2);
            this.gb_ipconfig.Controls.Add(this.label1);
            this.gb_ipconfig.Controls.Add(this.txt_class);
            this.gb_ipconfig.Controls.Add(this.txt_adr_byte1);
            this.gb_ipconfig.Controls.Add(this.lbl_ip);
            this.gb_ipconfig.Controls.Add(this.txt_binary_adress);
            this.gb_ipconfig.Controls.Add(this.lbl_binary_address);
            this.gb_ipconfig.Location = new System.Drawing.Point(4, 85);
            this.gb_ipconfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_ipconfig.Name = "gb_ipconfig";
            this.gb_ipconfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_ipconfig.Size = new System.Drawing.Size(681, 169);
            this.gb_ipconfig.TabIndex = 31;
            this.gb_ipconfig.TabStop = false;
            // 
            // txt_adr_byte4
            // 
            this.txt_adr_byte4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_adr_byte4.Enabled = false;
            this.txt_adr_byte4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adr_byte4.Location = new System.Drawing.Point(595, 35);
            this.txt_adr_byte4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adr_byte4.Name = "txt_adr_byte4";
            this.txt_adr_byte4.Size = new System.Drawing.Size(76, 31);
            this.txt_adr_byte4.TabIndex = 4;
            this.txt_adr_byte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adr_byte4.TextChanged += new System.EventHandler(this.txt_adr_byte4_TextChanged);
            this.txt_adr_byte4.Leave += new System.EventHandler(this.txt_adr_byte4_Leave);
            // 
            // txt_adr_byte3
            // 
            this.txt_adr_byte3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_adr_byte3.Enabled = false;
            this.txt_adr_byte3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adr_byte3.Location = new System.Drawing.Point(490, 35);
            this.txt_adr_byte3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adr_byte3.Name = "txt_adr_byte3";
            this.txt_adr_byte3.Size = new System.Drawing.Size(76, 31);
            this.txt_adr_byte3.TabIndex = 3;
            this.txt_adr_byte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adr_byte3.Leave += new System.EventHandler(this.txt_adr_byte3_Leave);
            // 
            // txt_adr_byte2
            // 
            this.txt_adr_byte2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_adr_byte2.Enabled = false;
            this.txt_adr_byte2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adr_byte2.Location = new System.Drawing.Point(394, 35);
            this.txt_adr_byte2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adr_byte2.Name = "txt_adr_byte2";
            this.txt_adr_byte2.Size = new System.Drawing.Size(76, 31);
            this.txt_adr_byte2.TabIndex = 2;
            this.txt_adr_byte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adr_byte2.Leave += new System.EventHandler(this.txt_adr_byte2_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(197, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "CẤU HÌNH IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "LỚP";
            // 
            // txt_class
            // 
            this.txt_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_class.Enabled = false;
            this.txt_class.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_class.Location = new System.Drawing.Point(289, 125);
            this.txt_class.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_class.Name = "txt_class";
            this.txt_class.ReadOnly = true;
            this.txt_class.Size = new System.Drawing.Size(382, 31);
            this.txt_class.TabIndex = 6;
            this.txt_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_adr_byte1
            // 
            this.txt_adr_byte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_adr_byte1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adr_byte1.Location = new System.Drawing.Point(289, 35);
            this.txt_adr_byte1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adr_byte1.Name = "txt_adr_byte1";
            this.txt_adr_byte1.Size = new System.Drawing.Size(76, 31);
            this.txt_adr_byte1.TabIndex = 1;
            this.txt_adr_byte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adr_byte1.Leave += new System.EventHandler(this.txt_adr_byte1_Leave);
            // 
            // gb_netmaskconfig
            // 
            this.gb_netmaskconfig.Controls.Add(this.pictureBox2);
            this.gb_netmaskconfig.Controls.Add(this.cb_mask_byte4);
            this.gb_netmaskconfig.Controls.Add(this.cb_mask_byte3);
            this.gb_netmaskconfig.Controls.Add(this.cb_mask_byte2);
            this.gb_netmaskconfig.Controls.Add(this.label4);
            this.gb_netmaskconfig.Controls.Add(this.lbl_netmask);
            this.gb_netmaskconfig.Controls.Add(this.cb_mask_byte1);
            this.gb_netmaskconfig.Controls.Add(this.txt_binary_netmask);
            this.gb_netmaskconfig.Controls.Add(this.lbl_binary_netmask);
            this.gb_netmaskconfig.Controls.Add(this.txt_inverted_binary_netmask);
            this.gb_netmaskconfig.Controls.Add(this.lbl_inverted_binary_netmask);
            this.gb_netmaskconfig.Controls.Add(this.txt_inverted_decimal_netmask);
            this.gb_netmaskconfig.Controls.Add(this.lbl_inverted_decimal_netmask);
            this.gb_netmaskconfig.Location = new System.Drawing.Point(4, 286);
            this.gb_netmaskconfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_netmaskconfig.Name = "gb_netmaskconfig";
            this.gb_netmaskconfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_netmaskconfig.Size = new System.Drawing.Size(681, 258);
            this.gb_netmaskconfig.TabIndex = 32;
            this.gb_netmaskconfig.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // cb_mask_byte4
            // 
            this.cb_mask_byte4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.cb_mask_byte4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mask_byte4.Enabled = false;
            this.cb_mask_byte4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mask_byte4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cb_mask_byte4.FormattingEnabled = true;
            this.cb_mask_byte4.Items.AddRange(new object[] {
            "252",
            "248",
            "240",
            "224",
            "192",
            "128",
            "0"});
            this.cb_mask_byte4.Location = new System.Drawing.Point(595, 35);
            this.cb_mask_byte4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_mask_byte4.Name = "cb_mask_byte4";
            this.cb_mask_byte4.Size = new System.Drawing.Size(76, 32);
            this.cb_mask_byte4.TabIndex = 10;
            this.cb_mask_byte4.SelectedIndexChanged += new System.EventHandler(this.cb_mask_byte4_SelectedIndexChanged);
            // 
            // cb_mask_byte3
            // 
            this.cb_mask_byte3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.cb_mask_byte3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mask_byte3.Enabled = false;
            this.cb_mask_byte3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mask_byte3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cb_mask_byte3.FormattingEnabled = true;
            this.cb_mask_byte3.Items.AddRange(new object[] {
            "255",
            "254",
            "252",
            "248",
            "240",
            "224",
            "192",
            "128",
            "0"});
            this.cb_mask_byte3.Location = new System.Drawing.Point(490, 35);
            this.cb_mask_byte3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_mask_byte3.Name = "cb_mask_byte3";
            this.cb_mask_byte3.Size = new System.Drawing.Size(76, 32);
            this.cb_mask_byte3.TabIndex = 9;
            this.cb_mask_byte3.SelectedIndexChanged += new System.EventHandler(this.cb_mask_byte3_SelectedIndexChanged);
            // 
            // cb_mask_byte2
            // 
            this.cb_mask_byte2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.cb_mask_byte2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mask_byte2.Enabled = false;
            this.cb_mask_byte2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mask_byte2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cb_mask_byte2.FormattingEnabled = true;
            this.cb_mask_byte2.Items.AddRange(new object[] {
            "255",
            "254",
            "252",
            "248",
            "240",
            "224",
            "192",
            "128"});
            this.cb_mask_byte2.Location = new System.Drawing.Point(394, 35);
            this.cb_mask_byte2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_mask_byte2.Name = "cb_mask_byte2";
            this.cb_mask_byte2.Size = new System.Drawing.Size(76, 32);
            this.cb_mask_byte2.TabIndex = 8;
            this.cb_mask_byte2.SelectedIndexChanged += new System.EventHandler(this.cb_mask_byte2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(183, -6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "CẤU HÌNH MẶT NẠ MẠNG";
            // 
            // cb_mask_byte1
            // 
            this.cb_mask_byte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.cb_mask_byte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mask_byte1.Enabled = false;
            this.cb_mask_byte1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mask_byte1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cb_mask_byte1.FormattingEnabled = true;
            this.cb_mask_byte1.Items.AddRange(new object[] {
            "255"});
            this.cb_mask_byte1.Location = new System.Drawing.Point(289, 35);
            this.cb_mask_byte1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_mask_byte1.Name = "cb_mask_byte1";
            this.cb_mask_byte1.Size = new System.Drawing.Size(76, 32);
            this.cb_mask_byte1.TabIndex = 7;
            this.cb_mask_byte1.SelectedIndexChanged += new System.EventHandler(this.cb_mask_byte1_SelectedIndexChanged);
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.pictureBox5);
            this.gb_results.Controls.Add(this.label8);
            this.gb_results.Controls.Add(this.label7);
            this.gb_results.Controls.Add(this.txt_borrow_bits);
            this.gb_results.Controls.Add(this.txt_timetolive);
            this.gb_results.Controls.Add(this.txt_brdaddress);
            this.gb_results.Controls.Add(this.txt_subaddress);
            this.gb_results.Controls.Add(this.txt_number_subnets);
            this.gb_results.Controls.Add(this.label5);
            this.gb_results.Controls.Add(this.lbl_number_subnets);
            this.gb_results.Controls.Add(this.lbl_number_clientadresses);
            this.gb_results.Controls.Add(this.txt_number_clientaddresses);
            this.gb_results.Controls.Add(this.lbl_subnet_id);
            this.gb_results.Controls.Add(this.lbl_broadcast);
            this.gb_results.Location = new System.Drawing.Point(4, 554);
            this.gb_results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_results.Name = "gb_results";
            this.gb_results.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_results.Size = new System.Drawing.Size(681, 255);
            this.gb_results.TabIndex = 33;
            this.gb_results.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(209, -4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "SỐ BIT MƯỢN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "BƯỚC NHẢY";
            // 
            // txt_borrow_bits
            // 
            this.txt_borrow_bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_borrow_bits.Enabled = false;
            this.txt_borrow_bits.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_borrow_bits.Location = new System.Drawing.Point(374, 211);
            this.txt_borrow_bits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_borrow_bits.Name = "txt_borrow_bits";
            this.txt_borrow_bits.ReadOnly = true;
            this.txt_borrow_bits.Size = new System.Drawing.Size(298, 31);
            this.txt_borrow_bits.TabIndex = 19;
            this.txt_borrow_bits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_timetolive
            // 
            this.txt_timetolive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_timetolive.Enabled = false;
            this.txt_timetolive.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timetolive.Location = new System.Drawing.Point(17, 214);
            this.txt_timetolive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_timetolive.Name = "txt_timetolive";
            this.txt_timetolive.ReadOnly = true;
            this.txt_timetolive.Size = new System.Drawing.Size(296, 31);
            this.txt_timetolive.TabIndex = 18;
            this.txt_timetolive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_brdaddress
            // 
            this.txt_brdaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_brdaddress.Enabled = false;
            this.txt_brdaddress.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brdaddress.Location = new System.Drawing.Point(374, 75);
            this.txt_brdaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_brdaddress.Name = "txt_brdaddress";
            this.txt_brdaddress.ReadOnly = true;
            this.txt_brdaddress.Size = new System.Drawing.Size(298, 31);
            this.txt_brdaddress.TabIndex = 15;
            this.txt_brdaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_subaddress
            // 
            this.txt_subaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_subaddress.Enabled = false;
            this.txt_subaddress.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subaddress.Location = new System.Drawing.Point(16, 79);
            this.txt_subaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_subaddress.Name = "txt_subaddress";
            this.txt_subaddress.ReadOnly = true;
            this.txt_subaddress.Size = new System.Drawing.Size(298, 31);
            this.txt_subaddress.TabIndex = 14;
            this.txt_subaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_number_subnets
            // 
            this.txt_number_subnets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_number_subnets.Enabled = false;
            this.txt_number_subnets.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_subnets.Location = new System.Drawing.Point(374, 142);
            this.txt_number_subnets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_number_subnets.Name = "txt_number_subnets";
            this.txt_number_subnets.ReadOnly = true;
            this.txt_number_subnets.Size = new System.Drawing.Size(298, 31);
            this.txt_number_subnets.TabIndex = 17;
            this.txt_number_subnets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(255, -5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "KẾT QUẢ";
            // 
            // lbl_number_subnets
            // 
            this.lbl_number_subnets.AutoSize = true;
            this.lbl_number_subnets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_number_subnets.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number_subnets.Location = new System.Drawing.Point(415, 114);
            this.lbl_number_subnets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_number_subnets.Name = "lbl_number_subnets";
            this.lbl_number_subnets.Size = new System.Drawing.Size(225, 22);
            this.lbl_number_subnets.TabIndex = 32;
            this.lbl_number_subnets.Text = "SỐ LƯỢNG MẠNG CON";
            // 
            // lbl_number_clientadresses
            // 
            this.lbl_number_clientadresses.AutoSize = true;
            this.lbl_number_clientadresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.lbl_number_clientadresses.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number_clientadresses.Location = new System.Drawing.Point(18, 118);
            this.lbl_number_clientadresses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_number_clientadresses.Name = "lbl_number_clientadresses";
            this.lbl_number_clientadresses.Size = new System.Drawing.Size(284, 22);
            this.lbl_number_clientadresses.TabIndex = 30;
            this.lbl_number_clientadresses.Text = "SỐ LƯỢNG ĐỊA CHỈ MÁY CHỦ";
            // 
            // txt_number_clientaddresses
            // 
            this.txt_number_clientaddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.txt_number_clientaddresses.Enabled = false;
            this.txt_number_clientaddresses.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_clientaddresses.Location = new System.Drawing.Point(17, 146);
            this.txt_number_clientaddresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_number_clientaddresses.Name = "txt_number_clientaddresses";
            this.txt_number_clientaddresses.ReadOnly = true;
            this.txt_number_clientaddresses.Size = new System.Drawing.Size(298, 31);
            this.txt_number_clientaddresses.TabIndex = 16;
            this.txt_number_clientaddresses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_subnet_ids
            // 
            this.list_subnet_ids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.list_subnet_ids.FormattingEnabled = true;
            this.list_subnet_ids.ItemHeight = 20;
            this.list_subnet_ids.Location = new System.Drawing.Point(9, 38);
            this.list_subnet_ids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_subnet_ids.MultiColumn = true;
            this.list_subnet_ids.Name = "list_subnet_ids";
            this.list_subnet_ids.Size = new System.Drawing.Size(327, 404);
            this.list_subnet_ids.TabIndex = 20;
            // 
            // gb_available_subnets
            // 
            this.gb_available_subnets.Controls.Add(this.label3);
            this.gb_available_subnets.Controls.Add(this.list_subnet_ids);
            this.gb_available_subnets.Location = new System.Drawing.Point(694, 85);
            this.gb_available_subnets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_available_subnets.Name = "gb_available_subnets";
            this.gb_available_subnets.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_available_subnets.Size = new System.Drawing.Size(346, 459);
            this.gb_available_subnets.TabIndex = 35;
            this.gb_available_subnets.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(19, -4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "MẠNG KHẢ DỤNG";
            // 
            // gb_operations
            // 
            this.gb_operations.Controls.Add(this.pictureBox4);
            this.gb_operations.Controls.Add(this.btn_reuse);
            this.gb_operations.Controls.Add(this.btn_reset);
            this.gb_operations.Controls.Add(this.label6);
            this.gb_operations.Controls.Add(this.btn_start);
            this.gb_operations.Location = new System.Drawing.Point(694, 554);
            this.gb_operations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_operations.Name = "gb_operations";
            this.gb_operations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_operations.Size = new System.Drawing.Size(346, 255);
            this.gb_operations.TabIndex = 36;
            this.gb_operations.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(55, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // btn_reuse
            // 
            this.btn_reuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(107)))), ((int)(((byte)(25)))));
            this.btn_reuse.Enabled = false;
            this.btn_reuse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reuse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reuse.Location = new System.Drawing.Point(25, 181);
            this.btn_reuse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reuse.Name = "btn_reuse";
            this.btn_reuse.Size = new System.Drawing.Size(307, 64);
            this.btn_reuse.TabIndex = 23;
            this.btn_reuse.Text = "TÁI SỬ DỤNG";
            this.btn_reuse.UseVisualStyleBackColor = false;
            this.btn_reuse.Click += new System.EventHandler(this.btn_reuse_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(107)))), ((int)(((byte)(25)))));
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Location = new System.Drawing.Point(25, 112);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(307, 64);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "KHỞI TẠO";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(87, -5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "LỰA CHỌN";
            // 
            // menustrip
            // 
            this.menustrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.menustrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_about});
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menustrip.Size = new System.Drawing.Size(1045, 36);
            this.menustrip.TabIndex = 37;
            this.menustrip.Text = "menustrip";
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(228)))), ((int)(((byte)(158)))));
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(104, 32);
            this.btn_about.Text = "Thông tin";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // toolstrip_file
            // 
            this.toolstrip_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(218)))));
            this.toolstrip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.select_import,
            this.select_close});
            this.toolstrip_file.Name = "toolstrip_file";
            this.toolstrip_file.Size = new System.Drawing.Size(46, 24);
            this.toolstrip_file.Text = "File";
            // 
            // select_import
            // 
            this.select_import.Name = "select_import";
            this.select_import.Size = new System.Drawing.Size(102, 34);
            // 
            // select_close
            // 
            this.select_close.Name = "select_close";
            this.select_close.Size = new System.Drawing.Size(102, 34);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(218)))));
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.select_aboutSC});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hilfeToolStripMenuItem.Text = "Help";
            // 
            // select_aboutSC
            // 
            this.select_aboutSC.Name = "select_aboutSC";
            this.select_aboutSC.Size = new System.Drawing.Size(308, 34);
            this.select_aboutSC.Text = "About Subnet Calculator";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1045, 818);
            this.Controls.Add(this.gb_operations);
            this.Controls.Add(this.gb_results);
            this.Controls.Add(this.gb_netmaskconfig);
            this.Controls.Add(this.gb_available_subnets);
            this.Controls.Add(this.menustrip);
            this.Controls.Add(this.gb_ipconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menustrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Subnet Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gb_ipconfig.ResumeLayout(false);
            this.gb_ipconfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_netmaskconfig.ResumeLayout(false);
            this.gb_netmaskconfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb_results.ResumeLayout(false);
            this.gb_results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gb_available_subnets.ResumeLayout(false);
            this.gb_available_subnets.PerformLayout();
            this.gb_operations.ResumeLayout(false);
            this.gb_operations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_netmask;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_subnet_id;
        private System.Windows.Forms.Label lbl_inverted_decimal_netmask;
        private System.Windows.Forms.TextBox txt_inverted_decimal_netmask;
        private System.Windows.Forms.Label lbl_inverted_binary_netmask;
        private System.Windows.Forms.TextBox txt_inverted_binary_netmask;
        private System.Windows.Forms.TextBox txt_binary_netmask;
        private System.Windows.Forms.Label lbl_binary_netmask;
        private System.Windows.Forms.Label lbl_broadcast;
        private System.Windows.Forms.TextBox txt_binary_adress;
        private System.Windows.Forms.Label lbl_binary_address;
        private System.Windows.Forms.GroupBox gb_ipconfig;
        private System.Windows.Forms.GroupBox gb_netmaskconfig;
        private System.Windows.Forms.ComboBox cb_mask_byte1;
        private System.Windows.Forms.ListBox list_subnet_ids;
        private System.Windows.Forms.GroupBox gb_available_subnets;
        private System.Windows.Forms.Label lbl_number_subnets;
        private System.Windows.Forms.Label lbl_number_clientadresses;
        private System.Windows.Forms.TextBox txt_number_clientaddresses;
        private System.Windows.Forms.GroupBox gb_operations;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_file;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem select_aboutSC;
        private System.Windows.Forms.ToolStripMenuItem select_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reuse;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ToolStripMenuItem select_import;
        private System.Windows.Forms.TextBox txt_timetolive;
        private System.Windows.Forms.TextBox txt_brdaddress;
        private System.Windows.Forms.TextBox txt_subaddress;
        private System.Windows.Forms.TextBox txt_number_subnets;
        private System.Windows.Forms.TextBox txt_borrow_bits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_mask_byte2;
        private System.Windows.Forms.TextBox txt_adr_byte1;
        private System.Windows.Forms.ComboBox cb_mask_byte4;
        private System.Windows.Forms.ComboBox cb_mask_byte3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_adr_byte4;
        private System.Windows.Forms.TextBox txt_adr_byte3;
        private System.Windows.Forms.TextBox txt_adr_byte2;
        private System.Windows.Forms.GroupBox gb_results;
        private System.Windows.Forms.ToolStripMenuItem btn_about;
    }
}

