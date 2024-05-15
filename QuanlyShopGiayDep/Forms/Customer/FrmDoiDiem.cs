using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms.Customer
{
    public partial class FrmDoiDiem : Form
    {
        public FrmDoiDiem()
        {
            InitializeComponent();
        }
        private int sumPrice = 0;
        private int IDCurrentCustomer = -1;
        private bool is_doidiem = false;
        public FrmDoiDiem(int _sumPrice)
        {
            InitializeComponent();
            sumPrice = _sumPrice;
        }
        private string namecustomer = "";
        private string sdt = "";
        private int currentscore = 0;
        BLLCustomer customerbll = new BLLCustomer();
        private int sotienconlai = 0;
        private void LoadDataComboBox()
        {
            DataTable dt = customerbll.GetData();
            //foreach (DataRow dr in dt.Rows) {
            //    cmbCustomer.Items.Add(dr["Phone"] + " - " + dr["Name"]);
            //}
            cmbCustomer.DataSource = dt;
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DisplayMember = "Phone";
            if (cmbCustomer.SelectedIndex == 0)
            {
                cmbCustomer.SelectedIndex = 0;
            }
            else
            {
                lbNameCustomer.Text = "";
                lbScore.Text = "0";
                lbSDT.Text = "";
            }
        }
        private void LoadDataSDTChange(DataTable data)
        {
            cmbCustomer.Refresh();
            //foreach (DataRow dr in data.Rows)
            //{
            //    cmbCustomer.Items.Add(dr["Phone"] + " - " + dr["Name"]);
            //}
            cmbCustomer.DataSource = data;
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DisplayMember = "Phone";
            if (cmbCustomer.SelectedIndex == 0)
            {
                cmbCustomer.SelectedIndex = 0;
            }
            else
            {
                lbNameCustomer.Text = "";
                lbScore.Text = "0";
                lbSDT.Text = "";
            }
        }
        private void SetInfoCustomer(string name, string phone, int score)
        {
            lbNameCustomer.Text = name;
            lbSDT.Text = phone;
            lbScore.Text = score.ToString();
        }
        private void FrmDoiDiem_Load(object sender, EventArgs e)
        {
            sotienconlai = sumPrice;
            int score = sumPrice / 10000;
            int is_du = sumPrice % 10000;
            if (is_du > 0) score++;
            lbTruScore.Text = score.ToString();
            lbNameCustomer.Text = namecustomer.ToString();
            lbSDT.Text = sdt.ToString();
            lbSDT.Focus();
            LoadDataComboBox();
        }
        public int getIDCustomer()
        {
            return IDCurrentCustomer;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string phone = txtSDT.Text;
            DataTable dt = customerbll.GetDatabySDT(phone);
            LoadDataSDTChange(dt);
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null)
            {
                int idCustomer = int.Parse(((DataRowView)cmbCustomer.SelectedItem)["ID"].ToString());
                DataTable dt = customerbll.GetDataCustomerByID(idCustomer);
                string name = dt.Rows[0]["Name"].ToString();
                string sdt = dt.Rows[0]["Phone"].ToString();
                int score = int.Parse(dt.Rows[0]["Score"].ToString());
                SetInfoCustomer(name, sdt, score);
            }
        }
        private void DoiDiem()
        {
            if (cmbCustomer.SelectedValue != null)
            {
                int truScore = int.Parse(lbTruScore.Text);
                int currentScore = int.Parse(lbScore.Text.ToString());
                currentscore = currentScore;
                IDCurrentCustomer = int.Parse(((DataRowView)cmbCustomer.SelectedItem)["ID"].ToString());
                if (truScore >= currentScore)
                {
                    sotienconlai = sumPrice - currentScore * 10000;
                    currentscore = 0;
                    return;
                }
                sotienconlai = 0;
                currentscore -= truScore;
                MessageBox.Show("Đổi điểm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int getPriceConLai()
        {
            return sotienconlai;
        }
        public int GetScoreCurrentScore()
        {
            return currentscore;
        }
        public bool IsDoidiem()
        {
            return is_doidiem;
        }
        private void btnDoiDiem_Click(object sender, EventArgs e)
        {
            DoiDiem();
            is_doidiem = true;
            this.Close();   
        }
    }
}
