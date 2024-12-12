using System;
using System.Windows.Forms;

namespace LoginKasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;

        Form1 frmlogin;
        void frmlogin_formClosed(object sender, EventArgs e)
        {
            frmlogin = null;
        }
        FormMasterKasir frmKasir;

        void frmKasir_formClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        Laporanpenjualan frmLaporPenjualan;
         void frmLaporPenjualan_formClosed(object sender, FormClosedEventArgs e)
        {
            frmLaporPenjualan = null;
        }

        private string userRole;  // To store the role (LevelKasir)
        FormMasterBarang frmBarang;
        void frmBarang_formClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }

        Penjualan frmPenjualan;
        void frmPenjualan_formClosed(object sender, FormClosedEventArgs e)
        {
            frmPenjualan = null;
        }
        // Constructor that accepts userRole (LevelKasir)
        public FormMenuUtama(String kodeKasir, String levelKasir)
        {
            InitializeComponent();
            userRole = levelKasir;  // Store the role
            label_kodeKasir.Text = kodeKasir;
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            // Call the method to set the menu based on the user's role
            SetMenuBasedOnRole();
        }

        private void SetMenuBasedOnRole()
        {
            // Enable or disable menu items based on user role
            if (userRole == "admin")
            {
                // Enable menu items for admin
                menuMaster.Enabled = true;
                menugantiPassword.Enabled = true;
                menuLaporan.Enabled = true;
            }
            else if (userRole == "kasir")
            {
                // Disable certain menu items for kasir
                menuMaster.Enabled = false;
                menugantiPassword.Enabled = false;
                menuLaporan.Enabled = false;
                

                // Add tooltips to the disabled items for kasir

            }

            // Disable login and enable logout for logged-in users
            menuLogin.Enabled = false;
            menuLogout.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        //tombol login
        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmlogin == null)
            {
                this.Close();
                frmlogin = new Form1();
                frmlogin.FormClosed += new FormClosedEventHandler(frmlogin_formClosed);
                frmlogin.ShowDialog();
            }
            else
            {
                frmlogin.Activate();
            }
            //frmlogin = new FormLogin();
            //frmlogin.Show();
        }


        private void menuLogout_Click(object sender, EventArgs e)
        {
            // Handle logout action and reset menu
            MenuTerkunci();
        }

        private void menuKasir_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_formClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void menuGantiPassword_Click(object sender, EventArgs e)
        {
            // Handle ganti password menu action here if the menu is enabled
            if (menugantiPassword.Enabled)
            {
                // Open password change form or functionality
                MessageBox.Show("Ganti Password menu clicked!");
            }
        }

        // Method to lock the menu (disable most items)
        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            exitToolStripMenuItem.Enabled = true;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
            menu = this;
            label_kodeKasir.Text = "Logged Out";
        }

        // Event handler for when the Kasir form is closed


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void menuBarang_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_formClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void menuPenjualan_Click(object sender, EventArgs e)
        {
            if (frmPenjualan == null)
            {
                frmPenjualan = new Penjualan();
                frmPenjualan.FormClosed += new FormClosedEventHandler(frmPenjualan_formClosed);
                Penjualan.penjualan.LBLNamaKasir.Text = label_kodeKasir.Text.ToString();
                frmPenjualan.ShowDialog();
            }
            else
            {
                frmPenjualan.Activate();
            }
        }

        private void menulapPenjualan_Click(object sender, EventArgs e)
        {
            //Laporanpenjualan.FormClosed += new FormClosedEventHandler(frmPenjualan_formClosed);
            new Laporanpenjualan().Show();
            Laporanpenjualan.laporan.label_KodeKasir.Text = label_kodeKasir.Text.ToString();
            Laporanpenjualan.laporan.label_role.Text = userRole.ToString();
        }
    }
}
