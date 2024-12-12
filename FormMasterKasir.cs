using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Aplikasi_Kasir;

namespace LoginKasir
{
    public partial class FormMasterKasir : Form
    {
        Koneksi Konek = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        void KondisiAwal()
        {
            txtbox_kodekasir.Clear();
            txtbox_namakasir.Clear();
            txtbox_password.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            munculLevel();
            MunculDataKasir();
        }

        void munculLevel()
        {
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("kasir");
        }

        void MunculDataKasir()
        {
            using (SqlConnection conn = Konek.GetConn())
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM tbl_kasir", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_kasir");
                    dataGridView1.DataSource = ds.Tables["tbl_kasir"];
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_kodekasir.Text) ||
                string.IsNullOrWhiteSpace(txtbox_namakasir.Text) ||
                string.IsNullOrWhiteSpace(txtbox_password.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("[!] Pastikan semua form terisi");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO tbl_kasir (KodeKasir, NamaKasir, PasswordKasir, LevelKasir) VALUES (@KodeKasir, @NamaKasir, @PasswordKasir, @LevelKasir)", conn);
                        cmd.Parameters.AddWithValue("@KodeKasir", txtbox_kodekasir.Text);
                        cmd.Parameters.AddWithValue("@NamaKasir", txtbox_namakasir.Text);
                        cmd.Parameters.AddWithValue("@PasswordKasir", txtbox_password.Text);
                        cmd.Parameters.AddWithValue("@LevelKasir", comboBox1.Text);

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
            if (string.IsNullOrWhiteSpace(txtbox_kodekasir.Text) ||
                string.IsNullOrWhiteSpace(txtbox_namakasir.Text) ||
                string.IsNullOrWhiteSpace(txtbox_password.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("[!] Pastikan semua form terisi");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE tbl_kasir SET NamaKasir = @NamaKasir, PasswordKasir = @PasswordKasir, LevelKasir = @LevelKasir WHERE KodeKasir = @KodeKasir", conn);
                        cmd.Parameters.AddWithValue("@KodeKasir", txtbox_kodekasir.Text);
                        cmd.Parameters.AddWithValue("@NamaKasir", txtbox_namakasir.Text);
                        cmd.Parameters.AddWithValue("@PasswordKasir", txtbox_password.Text);
                        cmd.Parameters.AddWithValue("@LevelKasir", comboBox1.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui!");
                        }
                        else
                        {
                            MessageBox.Show("[!] Data tidak ditemukan untuk diperbarui.");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_kodekasir.Text))
            {
                MessageBox.Show("[!] Masukkan Kode Kasir yang ingin dihapus");
            }
            else
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM tbl_kasir WHERE KodeKasir = @KodeKasir", conn);
                        cmd.Parameters.AddWithValue("@KodeKasir", txtbox_kodekasir.Text);

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

        private void txtbox_kodekasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection conn = Konek.GetConn())
                {
                    try
                    {
                        cmd = new SqlCommand("SELECT * FROM tbl_kasir WHERE KodeKasir = @KodeKasir", conn);
                        cmd.Parameters.AddWithValue("@KodeKasir", txtbox_kodekasir.Text);

                        conn.Open();
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            txtbox_namakasir.Text = rd["NamaKasir"].ToString();
                            txtbox_password.Text = rd["PasswordKasir"].ToString();
                            comboBox1.Text = rd["LevelKasir"].ToString();
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
    }
}
