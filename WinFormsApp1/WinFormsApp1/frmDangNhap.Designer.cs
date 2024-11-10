
namespace WinFormsApp1
{
    partial class frmDangNhap
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
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            btnThoat = new Button();
            btnDangNhap = new Button();
            cbbLoaiTaiKhoan = new ComboBox();
            btnDangKy = new Button();
            label5 = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 94);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Loại Tài Khoản";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(458, 159);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(287, 31);
            txtTenDangNhap.TabIndex = 3;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 159);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên Đăng Nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(458, 224);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(287, 31);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 227);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(598, 297);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(147, 56);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(458, 297);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(112, 53);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Items.AddRange(new object[] { "Người mua", "Người bán" });
            cbbLoaiTaiKhoan.Location = new Point(458, 91);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(287, 33);
            cbbLoaiTaiKhoan.TabIndex = 8;
            cbbLoaiTaiKhoan.SelectedIndexChanged += cbbLoaiTaiKhoan_SelectedIndexChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(633, 359);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 53);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 373);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 11;
            label5.Text = "Chưa có tài khoản?";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(567, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 454);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(507, 35);
            label4.Name = "label4";
            label4.Size = new Size(188, 41);
            label4.TabIndex = 9;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(btnDangKy);
            Controls.Add(label4);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // No custom 
        }

        #endregion

        private Label label1;
        private TextBox txtTenDangNhap;
        private Label label2;
        private TextBox txtMatKhau;
        private Label label3;
        private Button btnThoat;
        private Button btnDangNhap;
        private ComboBox cbbLoaiTaiKhoan;
        private Button btnDangKy;
        private Label label5;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label4;
    }
}
