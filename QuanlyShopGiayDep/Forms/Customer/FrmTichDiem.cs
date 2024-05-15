using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyShopGiayDep.Forms.Customer
{
    public partial class FrmTichDiem : Form
    {
        public FrmTichDiem()
        {
            InitializeComponent();
        }
        private int sumPrice = 0;
        public FrmTichDiem(int _sumPrice)
        {
            InitializeComponent();
            sumPrice = _sumPrice;
        }
        private string namecustomer = "";
        private string sdt = "";
        private int IDCurrentCustomer = -1;
        BLLCustomer customerbll = new BLLCustomer();
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

        private void FrmTichDiem_Load(object sender, EventArgs e)
        {
            int score = sumPrice / 100000;
            lbAddScore.Text = score.ToString();
            lbNameCustomer.Text = namecustomer.ToString();
            lbSDT.Text = sdt.ToString();
            lbSDT.Focus();
            LoadDataComboBox();
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
            if(cmbCustomer.SelectedIndex == 0)
            {
                cmbCustomer.SelectedIndex = 0;
            }else
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
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string phone = txtSDT.Text;
            DataTable dt = customerbll.GetDatabySDT(phone);
            LoadDataSDTChange(dt);
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCustomer.SelectedValue != null)
            {
                int idCustomer = int.Parse(((DataRowView)cmbCustomer.SelectedItem)["ID"].ToString());
                DataTable dt = customerbll.GetDataCustomerByID(idCustomer);
                string name = dt.Rows[0]["Name"].ToString();
                string sdt = dt.Rows[0]["Phone"].ToString();
                int score = int.Parse(dt.Rows[0]["Score"].ToString());
                SetInfoCustomer(name, sdt, score);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer f = new FrmAddCustomer();
            f.ShowDialog();
            LoadDataComboBox();
            cmbCustomer.SelectedIndex = cmbCustomer.Items.Count - 1;
        }
        private void TichDiem()
        {
            if (cmbCustomer.SelectedValue != null)
            {
                int idCustomer = int.Parse(((DataRowView)cmbCustomer.SelectedItem)["ID"].ToString());
                //int scoreAdd = int.Parse(lbAddScore.Text);
                //customerbll.UpdateScoreCustomer(idCustomer, scoreAdd, 'C');
                IDCurrentCustomer = idCustomer;
                MessageBox.Show("Tích điểm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int getIDCustomer()
        {
            return IDCurrentCustomer;
        }
        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            TichDiem();
            this.Close();
        }
    }
}
