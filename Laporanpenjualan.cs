using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikasi_Kasir;
using LoginKasir;

namespace LoginKasir
{
    public partial class Laporanpenjualan : Form
    {

        private DataSet ds;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public static Laporanpenjualan laporan;

        public Laporanpenjualan()
        {
            InitializeComponent();
            laporan = this;
        }


        void munculDetailDataPenjualan()
        {
            SqlConnection conn = new Koneksi().GetConn();
            conn.Open();

            cmd = new SqlCommand("Select * From DetailJual", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailJual");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "DetailJual";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void munculDataPenjualan()
        {
            SqlConnection conn = new Koneksi().GetConn();
            conn.Open();

            cmd = new SqlCommand("Select * From Jual", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Jual");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Jual";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        private void Laporan_Load(object sender, EventArgs e)
        {
        }

        private void role_changed(object sender, EventArgs e)
        {
            if (label_role.Text.ToString() == "admin")
            {
                munculDataPenjualan();
                label1.Text = "Data Penjualan";
            }
            else if (label_role.Text.ToString() == "user")
            {
                munculDetailDataPenjualan();
                label1.Text = "Data Detail Penjualan";

            }
        }

        private void Laporanpenjualan_Load(object sender, EventArgs e)
        {

        }

      
    }


}