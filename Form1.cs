using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Aplikasi_Kasir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginKasir
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlDataReader reader;
        Koneksi konek = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = '*';
            txtbox_Username.Text = "Insert Username";
            txtbox_Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konek.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT KodeKasir, LevelKasir FROM tbl_kasir WHERE KodeKasir = @username AND PasswordKasir = @password", conn);
                cmd.Parameters.AddWithValue("@username", txtbox_Username.Text);
                cmd.Parameters.AddWithValue("@password", txtbox_Password.Text);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string kodeKasir = reader["KodeKasir"].ToString();
                    string levelKasir = reader["LevelKasir"].ToString();

                    FormMenuUtama frmUtama = new FormMenuUtama(kodeKasir, levelKasir);
                    frmUtama.menuLogin.Enabled = true;
                    frmUtama.menuLogout.Enabled = true;
                    frmUtama.exitToolStripMenuItem.Enabled = true;
                    frmUtama.menuMaster.Enabled = true;
                    frmUtama.menuTransaksi.Enabled = true;
                    frmUtama.menuUtility.Enabled = true;
                    frmUtama.menuLaporan.Enabled = true;

                    frmUtama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbox_Username_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
