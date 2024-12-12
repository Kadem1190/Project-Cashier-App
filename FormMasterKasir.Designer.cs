namespace LoginKasir
{
    partial class FormMasterKasir
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
            txtbox_kodekasir = new TextBox();
            txtbox_namakasir = new TextBox();
            txtbox_password = new TextBox();
            btn_create = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtbox_kodekasir
            // 
            txtbox_kodekasir.BackColor = Color.White;
            txtbox_kodekasir.BorderStyle = BorderStyle.None;
            txtbox_kodekasir.Font = new Font("Segoe UI", 6F);
            txtbox_kodekasir.Location = new Point(285, 84);
            txtbox_kodekasir.Name = "txtbox_kodekasir";
            txtbox_kodekasir.Size = new Size(135, 16);
            txtbox_kodekasir.TabIndex = 0;
            txtbox_kodekasir.KeyPress += txtbox_kodekasir_KeyPress;
            // 
            // txtbox_namakasir
            // 
            txtbox_namakasir.BackColor = Color.White;
            txtbox_namakasir.BorderStyle = BorderStyle.None;
            txtbox_namakasir.Font = new Font("Segoe UI", 6F);
            txtbox_namakasir.Location = new Point(285, 121);
            txtbox_namakasir.Name = "txtbox_namakasir";
            txtbox_namakasir.Size = new Size(357, 16);
            txtbox_namakasir.TabIndex = 1;
            // 
            // txtbox_password
            // 
            txtbox_password.BackColor = Color.White;
            txtbox_password.BorderStyle = BorderStyle.None;
            txtbox_password.Font = new Font("Segoe UI", 6F);
            txtbox_password.Location = new Point(285, 162);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(357, 16);
            txtbox_password.TabIndex = 2;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.Transparent;
            btn_create.FlatAppearance.BorderSize = 0;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_create.ForeColor = SystemColors.ButtonHighlight;
            btn_create.Location = new Point(239, 233);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(78, 26);
            btn_create.TabIndex = 4;
            btn_create.Text = "INPUT";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(341, 232);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(76, 27);
            btn_update.TabIndex = 5;
            btn_update.Text = "EDIT";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(444, 232);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 27);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(545, 232);
            button1.Name = "button1";
            button1.Size = new Size(77, 27);
            button1.TabIndex = 7;
            button1.Text = "RETURN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 150;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 6F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(288, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 24);
            comboBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(564, 134);
            dataGridView1.TabIndex = 9;
            // 
            // FormMasterKasir
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_67__1_;
            ClientSize = new Size(800, 456);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_create);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_namakasir);
            Controls.Add(txtbox_kodekasir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMasterKasir";
            Text = "FormMasterKasir";
            Load += FormMasterKasir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_kodekasir;
        private TextBox txtbox_namakasir;
        private TextBox txtbox_password;
        private Button btn_create;
        private Button btn_update;
        private Button btn_delete;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}