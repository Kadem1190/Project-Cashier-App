namespace LoginKasir
{
    partial class Laporanpenjualan
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
            dataGridView1 = new DataGridView();
            label_role = new Label();
            label_KodeKasir = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(880, 348);
            dataGridView1.TabIndex = 0;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Location = new Point(22, 9);
            label_role.Name = "label_role";
            label_role.Size = new Size(62, 25);
            label_role.TabIndex = 1;
            label_role.Text = "label1";
            label_role.TextChanged += this.role_changed;
            // 
            // label_KodeKasir
            // 
            label_KodeKasir.AutoSize = true;
            label_KodeKasir.Location = new Point(22, 34);
            label_KodeKasir.Name = "label_KodeKasir";
            label_KodeKasir.Size = new Size(62, 25);
            label_KodeKasir.TabIndex = 2;
            label_KodeKasir.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(394, 34);
            label1.Name = "label1";
            label1.Size = new Size(135, 55);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Laporanpenjualan
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 504);
            Controls.Add(label1);
            Controls.Add(label_KodeKasir);
            Controls.Add(label_role);
            Controls.Add(dataGridView1);
            Name = "Laporanpenjualan";
            Text = "Laporanpenjualan";
            Load += Laporanpenjualan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        public Label label_role;
        public Label label_KodeKasir;
    }
}