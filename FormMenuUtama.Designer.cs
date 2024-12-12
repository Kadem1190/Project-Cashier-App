namespace LoginKasir
{
    partial class FormMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            menuKasir = new ToolStripMenuItem();
            menuBarang = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            menuPenjualan = new ToolStripMenuItem();
            menuLaporan = new ToolStripMenuItem();
            menulapDataMaster = new ToolStripMenuItem();
            menulapPenjualan = new ToolStripMenuItem();
            menuUtility = new ToolStripMenuItem();
            menugantiPassword = new ToolStripMenuItem();
            menuabout = new ToolStripMenuItem();
            label1 = new Label();
            label_kodeKasir = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster, menuTransaksi, menuLaporan, menuUtility });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, toolStripMenuItem1, exitToolStripMenuItem });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(60, 29);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(178, 34);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(178, 34);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(178, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { menuKasir, menuBarang });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(90, 29);
            menuMaster.Text = "Master";
            // 
            // menuKasir
            // 
            menuKasir.Name = "menuKasir";
            menuKasir.Size = new Size(180, 34);
            menuKasir.Text = "Kasir";
            menuKasir.Click += menuKasir_Click;
            // 
            // menuBarang
            // 
            menuBarang.Name = "menuBarang";
            menuBarang.Size = new Size(180, 34);
            menuBarang.Text = "Barang";
            menuBarang.Click += menuBarang_Click;
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { menuPenjualan });
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(112, 29);
            menuTransaksi.Text = "Transaksi";
            // 
            // menuPenjualan
            // 
            menuPenjualan.Name = "menuPenjualan";
            menuPenjualan.Size = new Size(206, 34);
            menuPenjualan.Text = "Penjualan";
            menuPenjualan.Click += menuPenjualan_Click;
            // 
            // menuLaporan
            // 
            menuLaporan.DropDownItems.AddRange(new ToolStripItem[] { menulapDataMaster, menulapPenjualan });
            menuLaporan.Name = "menuLaporan";
            menuLaporan.Size = new Size(102, 29);
            menuLaporan.Text = "Laporan";
            // 
            // menulapDataMaster
            // 
            menulapDataMaster.Name = "menulapDataMaster";
            menulapDataMaster.Size = new Size(270, 34);
            menulapDataMaster.Text = "Lap Data Master";
            // 
            // menulapPenjualan
            // 
            menulapPenjualan.Name = "menulapPenjualan";
            menulapPenjualan.Size = new Size(270, 34);
            menulapPenjualan.Text = "Lap Penjualan";
            menulapPenjualan.Click += menulapPenjualan_Click;
            // 
            // menuUtility
            // 
            menuUtility.DropDownItems.AddRange(new ToolStripItem[] { menugantiPassword, menuabout });
            menuUtility.Name = "menuUtility";
            menuUtility.Size = new Size(81, 29);
            menuUtility.Text = "Utility";
            // 
            // menugantiPassword
            // 
            menugantiPassword.Name = "menugantiPassword";
            menugantiPassword.Size = new Size(256, 34);
            menugantiPassword.Text = "Ganti Password";
            // 
            // menuabout
            // 
            menuabout.Name = "menuabout";
            menuabout.Size = new Size(256, 34);
            menuabout.Text = "About";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 52);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 1;
            label1.Text = "Currently login as:";
            // 
            // label_kodeKasir
            // 
            label_kodeKasir.AutoSize = true;
            label_kodeKasir.Location = new Point(195, 52);
            label_kodeKasir.Name = "label_kodeKasir";
            label_kodeKasir.Size = new Size(66, 25);
            label_kodeKasir.TabIndex = 2;
            label_kodeKasir.Text = "label2";
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_kodeKasir);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            Text = "FormMenuUtama";
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuKasir;
        private ToolStripMenuItem menuBarang;
        private ToolStripMenuItem menuPenjualan;
        private ToolStripMenuItem menulapDataMaster;
        private ToolStripMenuItem menulapPenjualan;
        private ToolStripMenuItem menugantiPassword;
        private ToolStripMenuItem menuabout;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuLaporan;
        public ToolStripMenuItem menuUtility;
        private Label label1;
        public Label label_kodeKasir;
    }
}