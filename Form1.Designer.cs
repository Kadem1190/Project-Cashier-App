namespace LoginKasir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbox_Username = new TextBox();
            txtbox_Password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txtbox_Username
            // 
            txtbox_Username.BackColor = Color.White;
            txtbox_Username.BorderStyle = BorderStyle.None;
            txtbox_Username.Location = new Point(152, 279);
            txtbox_Username.Name = "txtbox_Username";
            txtbox_Username.Size = new Size(280, 24);
            txtbox_Username.TabIndex = 0;
            txtbox_Username.TextChanged += txtbox_Username_TextChanged;
            // 
            // txtbox_Password
            // 
            txtbox_Password.BackColor = Color.White;
            txtbox_Password.BorderStyle = BorderStyle.None;
            txtbox_Password.Location = new Point(153, 370);
            txtbox_Password.Name = "txtbox_Password";
            txtbox_Password.Size = new Size(280, 24);
            txtbox_Password.TabIndex = 1;
            txtbox_Password.TextChanged += textBox2_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(152, 457);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(289, 36);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1_2_;
            ClientSize = new Size(558, 570);
            Controls.Add(btn_login);
            Controls.Add(txtbox_Password);
            Controls.Add(txtbox_Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_Username;
        private TextBox txtbox_Password;
        private Button btn_login;
    }
}
