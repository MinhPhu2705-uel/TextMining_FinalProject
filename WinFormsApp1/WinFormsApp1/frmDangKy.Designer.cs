
namespace WinFormsApp1
{
    partial class frmDangKy
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnDangKy = new Button();
            btnThoat = new Button();
            label6 = new Label();
            cbbLoaiTaiKhoan = new ComboBox();
            label7 = new Label();
            cbHienThiMatKhau = new CheckBox();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 74);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";

            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(427, 68);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(255, 31);
            txtTaiKhoan.TabIndex = 1;
            txtTaiKhoan.TextChanged += textBox1_TextChanged;

            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(427, 177);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(255, 31);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += textBox2_TextChanged;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 183);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";

            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(427, 280);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(255, 31);
            txtXacNhanMatKhau.TabIndex = 5;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.TextChanged += textBox3_TextChanged;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 286);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 4;
            label3.Text = "Xác nhận mật khẩu";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 25);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 6;
            label4.Text = "ĐĂNG KÝ";

            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(401, 330);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(130, 45);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += button1_Click;

            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(552, 330);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 45);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button2_Click;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 129);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 10;
            label6.Text = "Loại tài khoản";

            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Items.AddRange(new object[] { "Người bán", "Người mua" });
            cbbLoaiTaiKhoan.Location = new Point(427, 123);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(255, 33);
            cbbLoaiTaiKhoan.TabIndex = 11;
            cbbLoaiTaiKhoan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F);
            label7.Location = new Point(427, 212);
            label7.Name = "label7";
            label7.Size = new Size(225, 30);
            label7.TabIndex = 12;
            label7.Text = "* Vui lòng nhập mật khẩu dài 6-32 ký tự, \r\n   có ký tự chữ số, chữ hoa và chữ thường";

            // 
            // cbHienThiMatKhau
            // 
            cbHienThiMatKhau.AutoSize = true;
            cbHienThiMatKhau.Location = new Point(513, 245);
            cbHienThiMatKhau.Name = "cbHienThiMatKhau";
            cbHienThiMatKhau.Size = new Size(178, 29);
            cbHienThiMatKhau.TabIndex = 13;
            cbHienThiMatKhau.Text = "Hiển thị mật khẩu";
            cbHienThiMatKhau.UseVisualStyleBackColor = true;
            cbHienThiMatKhau.CheckedChanged += checkBox1_CheckedChanged;

            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbHienThiMatKhau);
            Controls.Add(label7);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKy);
            Controls.Add(label4);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label1);
            Name = "frmDangKy";
            Text = "frmDangKy";
            Load += frmDangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtXacNhanMatKhau;
        private Label label3;
        private Label label4;
        private Button btnDangKy;
        private Button btnThoat;
        private Label label6;
        private ComboBox cbbLoaiTaiKhoan;
        private Label label7;
        private CheckBox cbHienThiMatKhau;
    }
}
