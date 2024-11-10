using Microsoft.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmDoiMatKhauNguoiBan : Form
    {
        private const string ConnectionString = "Server=MSI\\THANHGIANG;Database=Brazilian_ECommerce_Public_Dataset_by_Olist2024;User Id=Phu_guest;Password=@Uel12345678;TrustServerCertificate=True;";
        private readonly string currentUsername;
        private readonly string currentAccountType;

        public frmDoiMatKhauNguoiBan(string username, string accountType)
        {
            InitializeComponent();
            currentUsername = username;
            currentAccountType = accountType;
        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            bool isPasswordVisible = cbHienThi.Checked;
            txtMatKhau.UseSystemPasswordChar = !isPasswordVisible;
            txtNhapLaiMatKhau.UseSystemPasswordChar = !isPasswordVisible;
            txtMatKhauCu.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatePassword(matKhauMoi))
            {
                MessageBox.Show("Mật khẩu phải dài từ 6-32 ký tự và có ít nhất 1 ký tự viết hoa, viết thường, và số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", currentUsername); // Giá trị từ thuộc tính
                        checkCmd.Parameters.AddWithValue("@Password", matKhauCu);
                        checkCmd.Parameters.AddWithValue("@Role", currentAccountType);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng hoặc tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Cập nhật mật khẩu mới
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username AND Role = @Role";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", matKhauMoi);
                        updateCmd.Parameters.AddWithValue("@Username", currentUsername);
                        updateCmd.Parameters.AddWithValue("@Role", currentAccountType);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm kiểm tra độ phức tạp của mật khẩu
        private bool ValidatePassword(string password)
        {
            const string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,32}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
