using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.Forms.Account;
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

namespace QuanlyShopGiayDep.Forms
{
    public partial class FrmAccounts : Form
    {
        public FrmAccounts()
        {
            InitializeComponent();
        }
        public bool is_insert = true;
        private Provider data = new Provider();
        private void LoadTK()
        {
            SqlConnection conn = data.ConnectSQL();
            string sql = "\r\nselect Accounts.ID, Username, Password, TypeAccount.Name from Accounts inner join TypeAccount \r\non Accounts.ID_TypeAccount = TypeAccount.ID";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 1;  
            thongtin.Enabled = false;
            LoadTK();
            btnSave.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenTK.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtMK.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            cmbRole.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = data.ConnectSQL();
                string sql = "delete Accounts where ID='" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadTK();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private void btnIensert_Click(object sender, EventArgs e)
        {
            is_insert = true;
            thongtin.Enabled = true;
            txtID.Enabled = false;
            btnSave.Enabled = true;
            cmbRole.Enabled = false;
            txtID.Clear();
            txtTenTK.Clear();
            txtMK.Clear();
            cmbRole.SelectedIndex = 1;
            txtTenTK.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            is_insert = false;
            thongtin.Enabled = true;
            txtID.Enabled = false;
            btnSave.Enabled = true;
            cmbRole.Enabled = true;
        }
        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) ||
                string.IsNullOrWhiteSpace(txtMK.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các trường.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                SqlConnection conn = data.ConnectSQL();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (is_insert)
                {
                    cmd.CommandText = "insertTK";
                }
                else
                {
                    SqlParameter pmatk = new SqlParameter("@matk", SqlDbType.Int);
                    pmatk.Value = txtID.Text;
                    cmd.Parameters.Add(pmatk);
                    cmd.CommandText = "updateTK";
                }
                SqlParameter ptentk = new SqlParameter("@tentk", SqlDbType.VarChar);
                ptentk.Value = txtTenTK.Text;
                cmd.Parameters.Add(ptentk);

                SqlParameter pmk = new SqlParameter("@mk", SqlDbType.VarChar);
                pmk.Value = txtMK.Text;
                cmd.Parameters.Add(pmk);

                SqlParameter prole = new SqlParameter("@role", SqlDbType.Int);
                int role = 2;
                if(cmbRole.Text == "Admin")
                {
                    role = 1;
                }
                prole.Value = role;
                cmd.Parameters.Add(prole);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadTK();
                    MessageBox.Show("Thực hiện thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực hiện thất bại!");
                }
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = data.ConnectSQL();
            string sql = "Select * from Accounts where Username like N'%" + txttimkiem.Text + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCapTK_Click(object sender, EventArgs e)
        {
            FrmCapTK frm = new FrmCapTK();
            frm.ShowDialog();
        }
    }
}
