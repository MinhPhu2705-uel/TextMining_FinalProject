using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Product : Form
    {
        private string currentUsername;
        private string currentAccountType;
        private string? username;
        private string? accountType;
        private const string ConnectionString = "Server=MSI\\THANHGIANG;Database=Brazilian_ECommerce_Public_Dataset_by_Olist2024;User Id=Phu_guest;Password=@Uel12345678;TrustServerCertificate=True;";

        public string CurrentUsername { get; set; }
        public string CurrentAccountType { get; set; }

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadCategories();

            // Set default category to "Food" in English and load its mapped data
            string defaultEnglishCategory = "Food";
            string defaultCategory = MapEnglishToCategory(defaultEnglishCategory);

            if (!string.IsNullOrEmpty(defaultCategory))
            {
                cbbDanhMuc.SelectedItem = defaultCategory;
                LoadReviewsAndProductsByCategory(defaultCategory);
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh mục mặc định!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            string query = "SELECT DISTINCT product_category_name FROM product_category_name_translation WHERE product_category_name IS NOT NULL";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Thêm giá trị từ product_category_name
                                cbbDanhMuc.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string MapEnglishToCategory(string englishName)
        {
            string query = "SELECT product_category_name FROM product_category_name_translation WHERE product_category_name_english = @EnglishName";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EnglishName", englishName);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void LoadReviewsAndProductsByCategory(string categoryName)
        {
            string query = @"
    SELECT 
        p.product_category_name AS product_category,
        oi.product_id,
        o.order_id,
        r.review_comment_message
    FROM olist_products_dataset p
    INNER JOIN olist_order_items_dataset oi ON p.product_id = oi.product_id
    INNER JOIN olist_orders_dataset o ON oi.order_id = o.order_id
    LEFT JOIN olist_order_reviews_datasett r ON o.order_id = r.order_id
    WHERE p.product_category_name = @CategoryName;";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // Cập nhật DataGridView
                            dgvProductReview.DataSource = null;
                            dgvProductReview.DataSource = table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedCategory = cbbDanhMuc.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                LoadReviewsAndProductsByCategory(selectedCategory);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtNhapIdSanPham.Text.Trim();
            string? selectedCategory = cbbDanhMuc.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm hoặc chọn danh mục.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                SELECT 
                    r.review_id,
                    p.product_id,
                    r.order_id
                FROM olist_products_dataset p
                LEFT JOIN olist_order_items_dataset oi ON p.product_id = oi.product_id
                LEFT JOIN olist_order_reviews_datasett r ON oi.order_id = r.order_id
                WHERE (@SearchText IS NULL OR p.product_id LIKE '%' + @SearchText + '%')
                AND (@Category IS NULL OR p.product_category_name = @Category)";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText);
                        cmd.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(selectedCategory) ? (object)DBNull.Value : selectedCategory);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvProductReview.DataSource = null;
                            dgvProductReview.DataSource = table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuanLySanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham productManagementForm = new frmQuanLySanPham();
            productManagementForm.Show();
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUsername) || string.IsNullOrEmpty(CurrentAccountType))
            {
                MessageBox.Show("Không thể đổi mật khẩu vì thông tin tài khoản chưa được truyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmDoiMatKhauNguoiBan doiMatKhauForm = new frmDoiMatKhauNguoiBan(CurrentUsername, CurrentAccountType);
            doiMatKhauForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();
        }
    }
}
