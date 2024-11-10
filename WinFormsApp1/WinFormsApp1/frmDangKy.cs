using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmDangKy : Form
    {
        // Connection string for SQL Server
        private const string ConnectionString = "Server=MSI\\THANHGIANG;Database=Brazilian_ECommerce_Public_Dataset_by_Olist2024;User Id=Phu_guest;Password=@Uel12345678;TrustServerCertificate=True;";

        public frmDangKy()
        {
            InitializeComponent();
        }

        // Checkbox for showing/hiding password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !cbHienThiMatKhau.Checked;
            txtXacNhanMatKhau.UseSystemPasswordChar = !cbHienThiMatKhau.Checked;
        }

        // Register Button
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string role = cbbLoaiTaiKhoan.SelectedItem?.ToString();
            string password = txtMatKhau.Text.Trim();
            string confirmPassword = txtXacNhanMatKhau.Text.Trim();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6 || password.Length > 32 || !HasUpperCase(password) || !HasLowerCase(password) || !HasDigit(password))
            {
                MessageBox.Show("Mật khẩu phải dài từ 6-32 ký tự và có ít nhất 1 ký tự viết hoa, viết thường, và số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu thông tin vào cơ sở dữ liệu SQL Server
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra tài khoản đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Thêm tài khoản mới
                    string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password); // Bạn có thể mã hóa mật khẩu nếu cần
                        insertCmd.Parameters.AddWithValue("@Role", role);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa các trường nhập liệu
                    txtTaiKhoan.Text = string.Empty;
                    txtMatKhau.Text = string.Empty;
                    txtXacNhanMatKhau.Text = string.Empty;
                    cbbLoaiTaiKhoan.SelectedIndex = -1;

                    // Đóng form đăng ký
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm kiểm tra mật khẩu
        private bool HasUpperCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        private bool HasLowerCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }

        private bool HasDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cbbLoaiTaiKhoan.SelectedIndex = 0;
        }
    }
}
