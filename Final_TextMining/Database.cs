using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_TextMining
{
    public class Database
    {
        private string connectionString = "Data Source=MSI; Initial Catalog=Database; User ID=GIANGGIANG; Password=123456;";
        private SqlConnection conn;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("Kết nối thành công đến cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }

            return results;
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
