namespace LoginKasir
{
    partial class FormMasterBarang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtbox_KodeBarang = new TextBox();
            txtbox_NamaBarang = new TextBox();
            txtbox_HargaBeli = new TextBox();
            txtbox_HargaJual = new TextBox();
            txtbox_JumlahBrg = new TextBox();
            label6 = new Label();
            combobox_SatuanBrg = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_create = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 98);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Harga Beli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 3;
            label4.Text = "Harga Jual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 172);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // txtbox_KodeBarang
            // 
            txtbox_KodeBarang.Location = new Point(199, 17);
            txtbox_KodeBarang.Name = "txtbox_KodeBarang";
            txtbox_KodeBarang.Size = new Size(150, 31);
            txtbox_KodeBarang.TabIndex = 5;
            txtbox_KodeBarang.KeyPress += txtbox_KodeBarang_KeyPress;
            // 
            // txtbox_NamaBarang
            // 
            txtbox_NamaBarang.Location = new Point(199, 54);
            txtbox_NamaBarang.Name = "txtbox_NamaBarang";
            txtbox_NamaBarang.Size = new Size(527, 31);
            txtbox_NamaBarang.TabIndex = 6;
            // 
            // txtbox_HargaBeli
            // 
            txtbox_HargaBeli.Location = new Point(199, 92);
            txtbox_HargaBeli.Name = "txtbox_HargaBeli";
            txtbox_HargaBeli.Size = new Size(230, 31);
            txtbox_HargaBeli.TabIndex = 7;
            // 
            // txtbox_HargaJual
            // 
            txtbox_HargaJual.Location = new Point(199, 129);
            txtbox_HargaJual.Name = "txtbox_HargaJual";
            txtbox_HargaJual.Size = new Size(230, 31);
            txtbox_HargaJual.TabIndex = 8;
            // 
            // txtbox_JumlahBrg
            // 
            txtbox_JumlahBrg.Location = new Point(199, 166);
            txtbox_JumlahBrg.Name = "txtbox_JumlahBrg";
            txtbox_JumlahBrg.Size = new Size(230, 31);
            txtbox_JumlahBrg.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 206);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 11;
            label6.Text = "Satuan Barang";
            // 
            // combobox_SatuanBrg
            // 
            combobox_SatuanBrg.FormattingEnabled = true;
            combobox_SatuanBrg.Location = new Point(199, 206);
            combobox_SatuanBrg.Name = "combobox_SatuanBrg";
            combobox_SatuanBrg.Size = new Size(230, 33);
            combobox_SatuanBrg.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(728, 187);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(516, 249);
            button1.Name = "button1";
            button1.Size = new Size(77, 27);
            button1.TabIndex = 16;
            button1.Text = "RETURN";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(415, 249);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 27);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.IndianRed;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(312, 249);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(76, 27);
            btn_update.TabIndex = 14;
            btn_update.Text = "EDIT";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.IndianRed;
            btn_create.FlatAppearance.BorderSize = 0;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_create.ForeColor = SystemColors.ButtonHighlight;
            btn_create.Location = new Point(210, 249);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(80, 27);
            btn_create.TabIndex = 13;
            btn_create.Text = "INPUT";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // FormMasterBarang
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_create);
            Controls.Add(combobox_SatuanBrg);
            Controls.Add(label6);
            Controls.Add(txtbox_JumlahBrg);
            Controls.Add(txtbox_HargaJual);
            Controls.Add(txtbox_HargaBeli);
            Controls.Add(txtbox_NamaBarang);
            Controls.Add(txtbox_KodeBarang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBarang";
            Text = "Form Master Barang";
            Load += FormMasterBarang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtbox_KodeBarang;
        private TextBox txtbox_NamaBarang;
        private TextBox txtbox_HargaBeli;
        private TextBox txtbox_HargaJual;
        private TextBox txtbox_JumlahBrg;
        private Label label6;
        private ComboBox combobox_SatuanBrg;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_create;
    }
}