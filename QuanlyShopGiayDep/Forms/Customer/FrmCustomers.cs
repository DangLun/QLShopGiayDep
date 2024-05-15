using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        bool is_insert = true;
        private string connectionString = @"Data Source=ACERNITRO5-D\SQLEXPRESS;Initial Catalog=QLShopGiayDep;Integrated Security=True;";
        private void LoadSP()
        {
            string chuoikn = @"Data Source=ACERNITRO5-D\SQLEXPRESS;Initial Catalog=QLShopGiayDep;Integrated Security=True;";
            string sql = "SELECT ID, Name, Gender, Phone, Score FROM Customers";
            using (SqlConnection conn = new SqlConnection(chuoikn))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataKH.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            thongtin.Enabled = false;
            LoadSP();
            cmbgioi.SelectedIndex = 0;
        }

        

        
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txttim.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                string sql = "SELECT ID, Name, Gender, Phone, Score FROM Customers WHERE ID LIKE @Keyword OR Name LIKE @Keyword";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        try
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataKH.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                LoadSP();
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtsdt.Text, out decimal Sodienthoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại là một số.");
                return;
            }

            if (!int.TryParse(numdiem.Text, out int Diem))
            {
                MessageBox.Show("Vui lòng nhập điểm là một số nguyên.");
                return;
            }
            string soDienThoai = txtsdt.Text.Trim();
            if (soDienThoai.Length != 10 || !soDienThoai.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có đúng 10 số.");
                return;
            }

            string sql = "";
            if (is_insert)
            {
                // Thêm khách hàng mới
                sql = "INSERT INTO Customers (Name, Gender, Phone, Score) VALUES (@Name, @Gender, @Phone, @Score)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Name", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbgioi.Text);
                    cmd.Parameters.AddWithValue("@Phone", soDienThoai);
                    cmd.Parameters.AddWithValue("@Score", Diem);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                        LoadSP();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        LoadSP();
                    }
                }
            }
            else
            {
                // Cập nhật thông tin khách hàng
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật!");
                    return;
                }

                sql = "UPDATE Customers SET Name = @Name, Gender = @Gender, Phone = @Phone, Score = @Score WHERE ID = @ID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Name", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbgioi.Text);
                    cmd.Parameters.AddWithValue("@Phone", soDienThoai);
                    cmd.Parameters.AddWithValue("@Score", Diem);
                    cmd.Parameters.AddWithValue("@ID", txtMaKH.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadSP();
                        }
                        else
                        {
                            MessageBox.Show("Không có khách hàng nào được cập nhật!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        LoadSP();
                    }
                }
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataKH.SelectedRows.Count > 0)
            {
                string makh = dataKH.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng có mã " + makh + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Customers WHERE ID = @ID";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", makh);

                            try
                            {
                                conn.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa thành công!");
                                    LoadSP();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy khách hàng để xóa!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            is_insert = false;
            thongtin.Enabled = true;
            luu.Enabled = true;
            txtMaKH.Enabled = false;
            numdiem.Enabled = true;
        }

        private void them_Click(object sender, EventArgs e)
        {
            is_insert = true;
            thongtin.Enabled = true;
            txtMaKH.Enabled = false;
            numdiem.Enabled = false;
            luu.Enabled = true;
            txtMaKH.Clear();
            txtTenKH.Clear();
            cmbgioi.SelectedIndex = 0;
            txtsdt.Clear();
            numdiem.Value = 0;
            txtTenKH.Focus();
        }

        private void dataKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtMaKH.Text = dataKH.Rows[r].Cells[0].Value.ToString();
            txtTenKH.Text = dataKH.Rows[r].Cells[1].Value.ToString();
            cmbgioi.Text = dataKH.Rows[r].Cells[2].Value.ToString();
            txtsdt.Text = dataKH.Rows[r].Cells[3].Value.ToString();
            numdiem.Text = dataKH.Rows[r].Cells[4].Value.ToString();
        }
    }
}
