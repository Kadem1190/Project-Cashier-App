namespace LoginKasir
{
    partial class Penjualan
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
            components = new System.ComponentModel.Container();
            label_nomorJual = new Label();
            nomor_jual = new Label();
            LBLTanggal = new Label();
            label4 = new Label();
            label5 = new Label();
            LBLJam = new Label();
            total_price = new Label();
            label_totalItem = new Label();
            label9 = new Label();
            label10 = new Label();
            NamaBarang = new Label();
            label12 = new Label();
            total_harga_insert = new Label();
            label_amount_item = new Label();
            dataGridView1 = new DataGridView();
            KodeBarang = new TextBox();
            jumlah = new TextBox();
            label16 = new Label();
            field_uang = new TextBox();
            button2 = new Button();
            LBLNamaKasir = new Label();
            label21 = new Label();
            btn_insert = new Button();
            btn_bayar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_nomorJual
            // 
            label_nomorJual.BorderStyle = BorderStyle.Fixed3D;
            label_nomorJual.Font = new Font("Segoe UI", 8F);
            label_nomorJual.Location = new Point(5, 22);
            label_nomorJual.Name = "label_nomorJual";
            label_nomorJual.Size = new Size(150, 37);
            label_nomorJual.TabIndex = 0;
            label_nomorJual.Text = "Nomor Jual";
            // 
            // nomor_jual
            // 
            nomor_jual.BorderStyle = BorderStyle.Fixed3D;
            nomor_jual.Font = new Font("Segoe UI", 8F);
            nomor_jual.Location = new Point(161, 22);
            nomor_jual.Name = "nomor_jual";
            nomor_jual.Size = new Size(279, 37);
            nomor_jual.TabIndex = 1;
            nomor_jual.Text = "Nomor Jual";
            // 
            // LBLTanggal
            // 
            LBLTanggal.BorderStyle = BorderStyle.Fixed3D;
            LBLTanggal.Font = new Font("Segoe UI", 8F);
            LBLTanggal.Location = new Point(834, 22);
            LBLTanggal.Name = "LBLTanggal";
            LBLTanggal.Size = new Size(150, 37);
            LBLTanggal.TabIndex = 3;
            LBLTanggal.Text = "Nomor Jual";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(678, 22);
            label4.Name = "label4";
            label4.Size = new Size(150, 37);
            label4.TabIndex = 2;
            label4.Text = "Tanggal";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(678, 59);
            label5.Name = "label5";
            label5.Size = new Size(150, 37);
            label5.TabIndex = 4;
            label5.Text = "Jam";
            // 
            // LBLJam
            // 
            LBLJam.BorderStyle = BorderStyle.Fixed3D;
            LBLJam.Font = new Font("Segoe UI", 8F);
            LBLJam.Location = new Point(834, 59);
            LBLJam.Name = "LBLJam";
            LBLJam.Size = new Size(150, 37);
            LBLJam.TabIndex = 5;
            LBLJam.Text = "Nomor Jual";
            // 
            // total_price
            // 
            total_price.BorderStyle = BorderStyle.Fixed3D;
            total_price.Font = new Font("Segoe UI", 8F);
            total_price.Location = new Point(161, 72);
            total_price.Name = "total_price";
            total_price.Size = new Size(410, 37);
            total_price.TabIndex = 7;
            total_price.Text = "Nomor Jual";
            // 
            // label_totalItem
            // 
            label_totalItem.BorderStyle = BorderStyle.Fixed3D;
            label_totalItem.Font = new Font("Segoe UI", 8F);
            label_totalItem.Location = new Point(5, 72);
            label_totalItem.Name = "label_totalItem";
            label_totalItem.Size = new Size(150, 37);
            label_totalItem.TabIndex = 6;
            label_totalItem.Text = "TOTAL";
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 8F);
            label9.Location = new Point(7, 173);
            label9.Name = "label9";
            label9.Size = new Size(83, 37);
            label9.TabIndex = 8;
            label9.Text = "KODE";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 8F);
            label10.Location = new Point(161, 173);
            label10.Name = "label10";
            label10.Size = new Size(83, 37);
            label10.TabIndex = 9;
            label10.Text = "NAMA";
            // 
            // NamaBarang
            // 
            NamaBarang.BorderStyle = BorderStyle.Fixed3D;
            NamaBarang.Font = new Font("Segoe UI", 8F);
            NamaBarang.Location = new Point(250, 173);
            NamaBarang.Name = "NamaBarang";
            NamaBarang.Size = new Size(296, 37);
            NamaBarang.TabIndex = 10;
            NamaBarang.Text = "NAMA";
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI", 8F);
            label12.Location = new Point(646, 173);
            label12.Name = "label12";
            label12.Size = new Size(121, 37);
            label12.TabIndex = 11;
            label12.Text = "HARGA";
            // 
            // total_harga_insert
            // 
            total_harga_insert.BorderStyle = BorderStyle.Fixed3D;
            total_harga_insert.Font = new Font("Segoe UI", 8F);
            total_harga_insert.Location = new Point(773, 173);
            total_harga_insert.Name = "total_harga_insert";
            total_harga_insert.Size = new Size(121, 37);
            total_harga_insert.TabIndex = 12;
            total_harga_insert.Text = "HARGA";
            // 
            // label_amount_item
            // 
            label_amount_item.BorderStyle = BorderStyle.Fixed3D;
            label_amount_item.Font = new Font("Segoe UI", 8F);
            label_amount_item.Location = new Point(897, 173);
            label_amount_item.Name = "label_amount_item";
            label_amount_item.Size = new Size(89, 37);
            label_amount_item.TabIndex = 13;
            label_amount_item.Text = "JUMLAH";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(923, 192);
            dataGridView1.TabIndex = 15;
            // 
            // KodeBarang
            // 
            KodeBarang.Location = new Point(7, 213);
            KodeBarang.Name = "KodeBarang";
            KodeBarang.Size = new Size(83, 31);
            KodeBarang.TabIndex = 16;
            KodeBarang.TextChanged += KodeBarang_TextChanged;
            KodeBarang.KeyPress += keyPress;
            // 
            // jumlah
            // 
            jumlah.Location = new Point(897, 213);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(89, 31);
            jumlah.TabIndex = 17;
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Font = new Font("Segoe UI", 8F);
            label16.Location = new Point(656, 498);
            label16.Name = "label16";
            label16.Size = new Size(150, 37);
            label16.TabIndex = 18;
            label16.Text = "Dibayar";
            // 
            // field_uang
            // 
            field_uang.Location = new Point(812, 501);
            field_uang.Name = "field_uang";
            field_uang.Size = new Size(168, 31);
            field_uang.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(20, 492);
            button2.Name = "button2";
            button2.Size = new Size(275, 73);
            button2.TabIndex = 24;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = true;
            // 
            // LBLNamaKasir
            // 
            LBLNamaKasir.BorderStyle = BorderStyle.Fixed3D;
            LBLNamaKasir.Font = new Font("Segoe UI", 8F);
            LBLNamaKasir.Location = new Point(834, 96);
            LBLNamaKasir.Name = "LBLNamaKasir";
            LBLNamaKasir.Size = new Size(150, 37);
            LBLNamaKasir.TabIndex = 27;
            LBLNamaKasir.Text = "Nomor Jual";
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Font = new Font("Segoe UI", 8F);
            label21.Location = new Point(678, 96);
            label21.Name = "label21";
            label21.Size = new Size(150, 37);
            label21.TabIndex = 26;
            label21.Text = "Kasir";
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(850, 250);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(136, 31);
            btn_insert.TabIndex = 28;
            btn_insert.Text = "INSERT";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_bayar
            // 
            btn_bayar.Location = new Point(727, 543);
            btn_bayar.Name = "btn_bayar";
            btn_bayar.Size = new Size(253, 31);
            btn_bayar.TabIndex = 29;
            btn_bayar.Text = "Bayar";
            btn_bayar.UseVisualStyleBackColor = true;
            btn_bayar.Click += btn_bayar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += updated_data;
            // 
            // Penjualan
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 586);
            Controls.Add(btn_bayar);
            Controls.Add(btn_insert);
            Controls.Add(LBLNamaKasir);
            Controls.Add(label21);
            Controls.Add(button2);
            Controls.Add(field_uang);
            Controls.Add(label16);
            Controls.Add(jumlah);
            Controls.Add(KodeBarang);
            Controls.Add(dataGridView1);
            Controls.Add(label_amount_item);
            Controls.Add(total_harga_insert);
            Controls.Add(label12);
            Controls.Add(NamaBarang);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(total_price);
            Controls.Add(label_totalItem);
            Controls.Add(LBLJam);
            Controls.Add(label5);
            Controls.Add(LBLTanggal);
            Controls.Add(label4);
            Controls.Add(nomor_jual);
            Controls.Add(label_nomorJual);
            Name = "Penjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Penjualan";
            Load += Penjualan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nomorJual;
        private Label nomor_jual;
        private Label LBLTanggal;
        private Label label4;
        private Label label5;
        private Label LBLJam;
        private Label total_price;
        private Label label_totalItem;
        private Label label9;
        private Label label10;
        private Label NamaBarang;
        private Label label12;
        private Label total_harga_insert;
        private Label label_amount_item;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox KodeBarang;
        private TextBox jumlah;
        private Label label15;
        private Label label16;
        private TextBox field_uang;
        private Label LBLItem;
        private Label label18;
        private Button button2;
        private Label LBLKembali;
        private Label label21;
        private Button btn_insert;
        private Button btn_bayar;
        private System.Windows.Forms.Timer timer1;
        public Label LBLNamaKasir;
    }
}