
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    partial class Product
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnQuanLySanPham = new Button();
            dgvProductReview = new DataGridView();
            label1 = new Label();
            cbbDanhMuc = new ComboBox();
            txtNhapIdSanPham = new TextBox();
            btnTimKiem = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductReview).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(270, 34);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(270, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // btnQuanLySanPham
            // 
            btnQuanLySanPham.Location = new Point(580, 36);
            btnQuanLySanPham.Name = "btnQuanLySanPham";
            btnQuanLySanPham.Size = new Size(208, 60);
            btnQuanLySanPham.TabIndex = 1;
            btnQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            btnQuanLySanPham.UseVisualStyleBackColor = true;
            btnQuanLySanPham.Click += btnQuanLySanPham_Click;
            // 
            // dgvProductReview
            // 
            dgvProductReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductReview.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductReview.Location = new Point(12, 102);
            dgvProductReview.Name = "dgvProductReview";
            dgvProductReview.RowHeadersWidth = 62;
            dgvProductReview.Size = new Size(776, 336);
            dgvProductReview.TabIndex = 2;
            dgvProductReview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 3;
            label1.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(12, 63);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(182, 33);
            cbbDanhMuc.TabIndex = 4;
            cbbDanhMuc.SelectedIndexChanged += cbbDanhMuc_SelectedIndexChanged;
            // 
            // txtNhapIdSanPham
            // 
            txtNhapIdSanPham.Location = new Point(212, 63);
            txtNhapIdSanPham.Name = "txtNhapIdSanPham";
            txtNhapIdSanPham.PlaceholderText = "Nhập product_id";
            txtNhapIdSanPham.Size = new Size(201, 31);
            txtNhapIdSanPham.TabIndex = 5;
            txtNhapIdSanPham.TextChanged += txtNhapTenSanPham_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(419, 63);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += BtnTimKiem_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimKiem);
            Controls.Add(txtNhapIdSanPham);
            Controls.Add(cbbDanhMuc);
            Controls.Add(label1);
            Controls.Add(dgvProductReview);
            Controls.Add(btnQuanLySanPham);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductReview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham quanLySanPhamForm = new frmQuanLySanPham();
            quanLySanPhamForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtNhapTenSanPham_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtNhapIdSanPham.Text.Trim();
            string? selectedCategory = cbbDanhMuc.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Vui lòng chọn danh mục trước khi tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"
        SELECT TOP 50
            p.product_category_name AS product_category,
            oi.product_id,
            o.order_id,
            r.review_comment_message AS review_comment
        FROM olist_products_dataset p
        INNER JOIN olist_order_items_dataset oi ON p.product_id = oi.product_id
        INNER JOIN olist_orders_dataset o ON oi.order_id = o.order_id
        LEFT JOIN olist_order_reviews_datasett r ON o.order_id = r.order_id
        WHERE p.product_category_name = @CategoryName
        AND (@SearchText IS NULL OR oi.product_id IN 
            (SELECT DISTINCT product_id 
             FROM olist_order_items_dataset
             WHERE product_id LIKE '%' + @SearchText + '%'));";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", selectedCategory);
                        cmd.Parameters.AddWithValue("@SearchText", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText);

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

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button btnQuanLySanPham;
        private DataGridView dgvProductReview;
        private Label label1;
        private ComboBox cbbDanhMuc;
        private TextBox txtNhapIdSanPham;
        private Button btnTimKiem;
    }
}
