using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Final_TextMining
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=MSI;Initial Catalog=DATABASE_NAME;User ID=GIANGGIANG;Password=123456;TrustServerCertificate=True";

        public string tendangnhap = "";
      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
        //{
        //    if (cbbLoaiTaiKhoan.SelectedIndex < 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn nhóm loại tài khoản");
        //        return;
        //    }
        //    if(string.IsNullOrEmpty(txtTenDangNhap.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được để trống");
        //        txtTenDangNhap.Select();
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(txtMatKhau.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
        //    }
        //    #region swtk
        //    tendangnhap = txtTenDangNhap.Text;
        //    string loaitk = "";
        //    switch(cbbLoaiTaiKhoan.Text)
        //    {
        //        case "Admin":
        //            loaitk = "admin";
        //            break;
        //        case "Người bán":
        //            loaitk = "Người bán";
        //            break;
        //        case "Người mua":
        //            loaitk = "Khách hàng";
        //            break;
        //    }
        //    #endregion
        //    //this.Hide();
        //}

        private void cbbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Nhập tài khoản")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
            
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text =="")
            {
                txtTenDangNhap.Text = "Nhập tài khoản";
                txtTenDangNhap.ForeColor = Color.DimGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.DimGray;
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
