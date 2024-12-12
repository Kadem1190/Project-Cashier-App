using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikasi_Kasir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginKasir
{
    public partial class FormMasterBarang : Form
    {
        Koneksi Konek = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public FormMasterBarang()
        {
            InitializeComponent();
        }
        void KondisiAwal()
        {
            txtbox_KodeBarang.Clear();
            txtbox_NamaBarang.Clear();
            txtbox_HargaBeli.Clear();
            combobox_SatuanBrg.Items.Clear();
            combobox_SatuanBrg.Text = "";
            munculSatuan();
            MunculDataBarang();
        }

        void munculSatuan()
        {
            combobox_SatuanBrg.Items.Add("PCS");
            combobox_SatuanBrg.Items.Add("BOX");
            combobox_SatuanBrg.Items.Add("BOTOL");
            combobox_SatuanBrg.Items.Add("PAX");
            combobox_SatuanBrg.Items.Add("KILO");
            combobox_SatuanBrg.Items.Add("KARUNG");
        }

        void MunculDataBarang()
        {
            using (SqlConnection conn = Konek.GetConn())
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM Produk", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Produk");
                    dataGridView1.DataSource = ds.Tables["Produk"];
                    dataGridView1.AllowUserToAddRows = false;
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_KodeBarang.Text) ||
                string.IsNullOrWhiteSpace(txtbox_NamaBarang.Text) ||
                string.IsNullOrWhiteSpace(txtbox_HargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtbox_HargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtbox_JumlahBrg.Text) ||
                string.IsNullOrWhiteSpace(combobox_SatuanBrg.Text))
            {
                MessageBox.Show("[!] Pastikan semua form terisi");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO Produk (KodeBarang, NamaBarang, HargaBeli, HargaJual, JumlahBrg, SatuanBarang) VALUES (@KodeBarang, @NamaBarang, @HargaBeli, @HargaJual, @JumlahBrg, @SatuanBarang)", conn);
                        cmd.Parameters.AddWithValue("@KodeBarang", txtbox_KodeBarang.Text);
                        cmd.Parameters.AddWithValue("@NamaBarang", txtbox_NamaBarang.Text);
                        cmd.Parameters.AddWithValue("@HargaBeli", txtbox_HargaBeli.Text);
                        cmd.Parameters.AddWithValue("@HargaJual", txtbox_HargaJual.Text);
                        cmd.Parameters.AddWithValue("@JumlahBrg", txtbox_JumlahBrg.Text);
                        cmd.Parameters.AddWithValue("@SatuanBarang", combobox_SatuanBrg.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan!");

                        KondisiAwal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_KodeBarang.Text) ||
                string.IsNullOrWhiteSpace(txtbox_NamaBarang.Text) ||
                string.IsNullOrWhiteSpace(txtbox_HargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtbox_HargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtbox_JumlahBrg.Text) ||
                string.IsNullOrWhiteSpace(combobox_SatuanBrg.Text))
            {
                MessageBox.Show("[!] Pastikan semua form terisi");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Produk SET NamaBarang = @NamaBarang, HargaBeli = @HargaBeli, HargaJual = @HargaJual, JumlahBrg = @JumlahBrg, SatuanBarang = @SatuanBarang WHERE KodeBarang = @KodeBarang", conn);
                        cmd.Parameters.AddWithValue("@KodeBarang", txtbox_KodeBarang.Text);
                        cmd.Parameters.AddWithValue("@NamaBarang", txtbox_NamaBarang.Text);
                        cmd.Parameters.AddWithValue("@HargaBeli", txtbox_HargaBeli.Text);
                        cmd.Parameters.AddWithValue("@HargaJual", txtbox_HargaJual.Text);
                        cmd.Parameters.AddWithValue("@JumlahBrg", txtbox_JumlahBrg.Text);
                        cmd.Parameters.AddWithValue("@SatuanBarang", combobox_SatuanBrg.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan!");

                        KondisiAwal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_KodeBarang.Text))
            {
                MessageBox.Show("[!] Masukkan Kode Barang yang ingin dihapus");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM Produk WHERE KodeBarang = @KodeBarang", conn);
                        cmd.Parameters.AddWithValue("@KodeBarang", txtbox_KodeBarang.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus!");
                        }
                        else
                        {
                            MessageBox.Show("[!] Data tidak ditemukan untuk dihapus.");
                        }

                        KondisiAwal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void txtbox_KodeBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("SELECT * FROM Produk WHERE KodeBarang = @KodeBarang", conn);
                        cmd.Parameters.AddWithValue("@KodeBarang", txtbox_KodeBarang.Text);

                        conn.Open();
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            txtbox_NamaBarang.Text = rd["NamaBarang"].ToString();
                            txtbox_HargaBeli.Text = rd["HargaBeli"].ToString();
                            txtbox_HargaJual.Text = rd["HargaJual"].ToString();
                            txtbox_JumlahBrg.Text = rd["JumlahBrg"].ToString();
                            combobox_SatuanBrg.Text = rd["SatuanBarang"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("[!] Data tidak ditemukan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}



