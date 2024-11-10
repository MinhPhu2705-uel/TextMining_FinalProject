using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class frmDangNhap : Form
    {
        private const string ConnectionString = "Server=MSI\\THANHGIANG;Database=Brazilian_ECommerce_Public_Dataset_by_Olist2024;User Id=Phu_guest;Password=@Uel12345678;TrustServerCertificate=True;";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Form Load event
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Checkbox for showing/hiding password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Exit Button Click event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Confirm exit
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Login Button Click event
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string? accountType = cbbLoaiTaiKhoan.SelectedItem?.ToString();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            // Check if account type is selected
            if (string.IsNullOrEmpty(accountType))
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check credentials in SQL Server
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", accountType);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            if (result.ToString() == "Người bán")
                            {
                                MessageBox.Show("Đăng nhập thành công với tài khoản Người bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Truyền giá trị vào Product form
                                Product productForm = new Product
                                {
                                    CurrentUsername = username, // Gán tên đăng nhập
                                    CurrentAccountType = accountType // Gán loại tài khoản
                                };
                                productForm.Show();

                                // Ẩn form đăng nhập
                                this.Hide();
                            }
                            else if (result.ToString() == "Người bán")
                            {
                                MessageBox.Show("Đăng nhập thành công với tài khoản Người bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Open Product form
                                Product productForm = new Product
                                {
                                    CurrentUsername = username,    // Truyền tên đăng nhập
                                    CurrentAccountType = accountType // Truyền loại tài khoản
                                };
                                productForm.Show();

                                // Hide the login form
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập, mật khẩu hoặc loại tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Register Button Click event
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy registerForm = new frmDangKy();
            registerForm.ShowDialog();
        }

        // Label Click event (optional)
        private void label5_Click(object sender, EventArgs e)
        {

        }

        // ComboBox SelectedIndexChanged event
        private void cbbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            // Xử lý logic nếu cần, hoặc để trống nếu không sử dụng
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            // Xử lý logic nếu cần, hoặc để trống nếu không sử dụng
        }
    }
}
