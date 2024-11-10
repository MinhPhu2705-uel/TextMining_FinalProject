
namespace WinFormsApp1
{
    partial class frmDoiMatKhauNguoiBan
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
            txtMatKhauCu = new TextBox();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbHienThi = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(100, 17);
            label1.Name = "label1";
            label1.Size = new Size(381, 48);
            label1.TabIndex = 0;
            label1.Text = "Change your password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 107);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 154);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 197);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 4;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(275, 104);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(206, 31);
            txtMatKhauCu.TabIndex = 6;
            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauCu.TextChanged += this.txtMatKhauCu_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(275, 151);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(206, 31);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += this.txtMatKhau_TextChanged;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(275, 197);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(206, 31);
            txtNhapLaiMatKhau.TabIndex = 8;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.TextChanged += this.txtNhapLaiMatKhau_TextChanged;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Location = new Point(122, 270);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(135, 48);
            btnDoiMatKhau.TabIndex = 11;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += this.btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(323, 270);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(135, 48);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += this.btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(172, 107);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 13;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(148, 154);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(218, 197);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // cbHienThi
            // 
            cbHienThi.AutoSize = true;
            cbHienThi.Location = new Point(359, 234);
            cbHienThi.Name = "cbHienThi";
            cbHienThi.Size = new Size(99, 29);
            cbHienThi.TabIndex = 16;
            cbHienThi.Text = "Hiển thị";
            cbHienThi.UseVisualStyleBackColor = true;
            cbHienThi.CheckedChanged += this.cbHienThi_CheckedChanged;
            // 
            // frmDoiMatKhauNguoiBan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 450);
            Controls.Add(cbHienThi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhauNguoiBan";
            Text = "DoiMatKhau";
            Load += this.frmDoiMatKhauNguoiBan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmDoiMatKhauNguoiBan_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhau;
        private TextBox txtNhapLaiMatKhau;
        private Button btnDoiMatKhau;
        private Button btnThoat;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox cbHienThi;
    }
}