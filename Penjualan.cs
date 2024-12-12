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
    public partial class Penjualan : Form
    {

        DataSet ds;
        DataTable produk;
        SqlCommand cmd;
        SqlDataReader rd;

        public Penjualan()
        {
            InitializeComponent();
            penjualan = this;
        }

        public static Penjualan penjualan;

        Boolean isFillColumns()
        {
            if (KodeBarang.Text.Trim() == "" || jumlah.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill All The Columns!");
                return false;
            }
            //MessageBox.Show("Semua Field Telah Diisi!");
            return true;
        }



        void createDataset()
        {
            ds = new DataSet();
            produk = new DataTable("produk");
            DataColumn kode_Barang = new DataColumn("kode_barang", typeof(string));
            DataColumn nama_Barang = new DataColumn("nama_barang", typeof(string));
            DataColumn harga_barang = new DataColumn("harga_barang", typeof(int));
            DataColumn jumlah_barang = new DataColumn("jumlah_barang", typeof(int));
            DataColumn sub_total = new DataColumn("sub_total", typeof(int));

            produk.Columns.Add(kode_Barang);
            produk.Columns.Add(nama_Barang);
            produk.Columns.Add(harga_barang);
            produk.Columns.Add(jumlah_barang);
            produk.Columns.Add(sub_total);



            ds.Tables.Add(produk);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "produk";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void AddingDataIntoTableProduk(String kodeBarang, String namaBarang, int hargaBarang, int jumlah_barang, int sub_total)
        {
            DataRow newRow = produk.NewRow();

            newRow["kode_barang"] = kodeBarang;
            newRow["nama_barang"] = namaBarang;
            newRow["harga_barang"] = hargaBarang;
            newRow["jumlah_barang"] = jumlah_barang;
            newRow["sub_total"] = sub_total;

            if (IfSameID(kodeBarang))
            {
                AddingSameID(kodeBarang);
            }
            else
            {
                produk.Rows.Add(newRow);
            }


            if (ds.HasChanges())
            {
                dataGridView1.Refresh();
                setTotalPrice();
                if (getLengtProduk() == 0)
                {
                    btn_bayar.Enabled = false;
                }
                else
                {
                    btn_bayar.Enabled = true;
                }
            }

            KondisiAwalInput();
        }

        int getLengtProduk()
        {

            int lengthProduk = 0;

            foreach (DataRow row in produk.Rows)
            {
                lengthProduk += 1;
            }

            return lengthProduk;
        }

        int GetTotalPrice()
        {

            int totalPrice = 0;

            foreach (DataRow row in produk.Rows)
            {
                totalPrice += Convert.ToInt32(row["sub_total"]);
            }
            return totalPrice;
        }


        void setTotalPrice()
        {
            total_price.Text = Convert.ToString(GetTotalPrice());
            label_amount_item.Text = getLengtProduk().ToString();
        }

        Boolean IfSameID(String kodeBarang)
        {
            foreach (DataRow row in produk.Rows)
            {

                if (row["kode_barang"].ToString() == kodeBarang)
                {
                    return true;
                }

            }
            return false;
        }
        void AddingSameID(String kodeBarang)
        {
            foreach (DataRow row in produk.Rows)
            {

                if (row["kode_barang"].ToString() == kodeBarang)
                {
                    row["jumlah_barang"] = Convert.ToInt32(row["jumlah_barang"]) + Convert.ToInt32(jumlah.Text.ToString());
                    row["sub_total"] = Convert.ToInt32(row["harga_barang"]) * Convert.ToInt32(row["jumlah_barang"]);
                }

            }

        }


        void KondisiAwal()
        {
            KodeBarang.Clear();
            NamaBarang.Text = "";
            jumlah.Text = "1";
            total_price.Text = "";
            LBLJam.Text = DateTime.Now.ToString("HH:mm:ss");
            label_amount_item.Text = "";
            LBLTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            total_harga_insert.Text = "";
        }


        void KondisiAwalInput()
        {
            KodeBarang.Clear();
            NamaBarang.Text = "";
            jumlah.Text = "1";
            total_harga_insert.Text = "";
        }

        String GetCommandToInsertTransaction(int uang, int kembalian)
        {
            String cmdJual = "INSERT INTO Jual(no_jual, total_harga, dibayar, kembalian, KodeKasir, tanggal) " +
                             "VALUES ('" + nomor_jual.Text.ToString() + "', "
                             + GetTotalPrice() + ", "
                             + uang + ", "
                             + kembalian + ", '"+LBLNamaKasir.Text.ToString() +"', '"
                             + DateTime.Now + "');";
            String cmdDetailJual = "INSERT INTO DetailJual(no_jual,kode_barang,nama_barang,harga_barang,jumlah_item,total_harga)";
            int length = 0;
            foreach (DataRow row in produk.Rows)
            {
                if (length == 0)
                {
                    cmdDetailJual += "values('" + nomor_jual.Text.ToString() + "', '" + row["kode_barang"].ToString() + "', '" + row["nama_barang"] + "', " + Convert.ToInt32(row["harga_barang"]) + ", " + Convert.ToInt32(row["jumlah_barang"]) + ", " + Convert.ToInt32(row["sub_total"]) + ")";
                }
                else
                {
                    cmdDetailJual += ",('" + nomor_jual.Text.ToString() + "', '" + row["kode_barang"].ToString() + "','" + row["nama_barang"] + "', " + Convert.ToInt32(row["harga_barang"]) + ", " + Convert.ToInt32(row["jumlah_barang"]) + ", " + Convert.ToInt32(row["sub_total"]) + ")";
                }

                length++;
            }
            cmdDetailJual += ';';
            String gabungan = cmdJual + cmdDetailJual;
            return gabungan;
        }

        void InserTransactionIntoDatabase(int uang, int kembalian)
        {
            SqlConnection conn = new Koneksi().GetConn();
            String sql = GetCommandToInsertTransaction(uang, kembalian);
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Mencatat Laporan Penjualan Ke Dalam Database", "Laporan Di Catat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        void abc()
        {
            if (isFillColumns())
            {

                SqlConnection conn = new Koneksi().GetConn();
                conn.Open();
                //MessageBox.Show("SELECT * FROM Produk where kode_barang='" + KodeBarang.Text.ToString() + "'");
                cmd = new SqlCommand("SELECT * FROM Produk where KodeBarang ='" + KodeBarang.Text.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();




                if (rd.Read())
                {
                    String kode_barang = rd[0].ToString();
                    String nama_barang = rd[1].ToString();

                    int harga = Convert.ToInt32(rd[2]);
                    int jumlah_barang = Convert.ToInt32(jumlah.Text.ToString());
                    int sub_total = harga * jumlah_barang;


                    AddingDataIntoTableProduk(kode_barang, nama_barang, harga, jumlah_barang, sub_total);

                }
                else
                {
                    MessageBox.Show("Barang Tidak Di Temukan", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }


                conn.Close();
            }
        }









        private void btn_insert_Click(object sender, EventArgs e)
        {
            //KodeBarang.Text = "";
            abc();
        }





        private void jumlah_TextChanged(object sender, EventArgs e)
        {
            jumlah.Text = jumlah.Text.Trim();
            jumlah.Text = jumlah.Text.Replace("\n", "");
            if (jumlah.Text.Trim() != "")
            {
                if (Convert.ToInt64(jumlah.Text.ToString()) >= 100)
                {
                    jumlah.Text = Convert.ToString(10);
                }
                else if (Convert.ToInt32(jumlah.Text.ToString()) <= 0)
                {
                    jumlah.Text = Convert.ToString(1);
                }
            }
        }

        private void KodeBarang_TextChanged(object sender, EventArgs e)
        {
            KodeBarang.Text = KodeBarang.Text.Trim();
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = new Koneksi().GetConn();
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Produk where KodeBarang ='" + KodeBarang.Text.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();


                if (!isFillColumns()) return;


                if (rd.Read())
                {
                    String kode_barang = rd[0].ToString();
                    String nama_barang = rd[1].ToString();

                    int harga = Convert.ToInt32(rd[2]);
                    int jumlah_barang = Convert.ToInt32(jumlah.Text.ToString());
                    int sub_total = harga * jumlah_barang;

                    KodeBarang.Text = kode_barang;
                    NamaBarang.Text = nama_barang;
                    total_harga_insert.Text = sub_total.ToString();
                }
                else
                {
                    MessageBox.Show("Barang Tidak Di Temukan", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void total_price_Click(object sender, EventArgs e)
        {

        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            int totalHarga = Convert.ToInt32(total_price.Text.ToString());
            int uang = Convert.ToInt32(field_uang.Text.ToString());
            int kembalian = uang - totalHarga;

            if (kembalian >= 0)
            {
                //MessageBox.Show(GetCommandToInsertTransaction(uang,kembalian));
                InserTransactionIntoDatabase(uang, kembalian);
                produk.Clear();
                KondisiAwal();
            }
            else
            {
                MessageBox.Show("Uangnya Kurang ya kak!");
            }
            field_uang.Clear();
        }

        private void field_uang_TextChanged(object sender, EventArgs e)
        {
            field_uang.Text = field_uang.Text.Trim();
            field_uang.Text = field_uang.Text.Replace("\n", "");
        }


       private void updated_data(object sender, EventArgs e)
        {
            LBLJam.Text = DateTime.Now.ToString("HH:mm:ss");
            LBLTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            createDataset();
            createDataset();
            KondisiAwal();
            
        }
         
    }

}