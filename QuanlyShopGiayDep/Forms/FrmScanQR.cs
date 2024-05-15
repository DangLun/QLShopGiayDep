using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using ZXing;
using static ZXing.QrCode.Internal.Mode;
namespace QuanlyShopGiayDep.Forms
{
    public partial class FrmScanQR : Form
    {
        public FrmScanQR()
        {
            InitializeComponent();
        }
        FilterInfoCollection filtercollection;
        VideoCaptureDevice videoCaptureDevice;
        BLLProduct productbll = new BLLProduct();
        private void OpenCamera(int index = 0)
        {
            videoCaptureDevice = new VideoCaptureDevice(filtercollection[index].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            if(!videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Start();
            }
        }
        private void StopCamera()
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    ptbScanQR.Image = null;
                }
            }
        }
        public int GetIDBrandByNameBrand(string nameBrand)
        {
            Provider provider = new Provider();
            string query = "select ID from brands where Name = @nameBrand ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { nameBrand });
            int ID = int.Parse(data.Rows[0]["ID"].ToString());
            return ID;
        }
        public int GetIDTypeByNameType(string nameType)
        {
            Provider provider = new Provider();
            string query = "select ID from TypeProducts where Name = @nameType";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { nameType });
            int ID = int.Parse(data.Rows[0]["ID"].ToString());
            return ID;
        }
        private bool IsValidProduct(string name, int price, int discount, int id_brand, int id_type, int quantity)
        {
            Provider provider = new Provider();
            string query = "select * from products where Name = @name and Price = @price and Discount = @discount and ID_Brand = @id_brand and ID_Type = @id_type and Quantity = @quantity";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { name, price, discount, id_brand, id_type, quantity });
            if(data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var res = reader.Decode(bitmap);
            if (res != null)
            {
                try
                {
                    string infoProduct = res.ToString();
                    ProductJsonModel product = JsonConvert.DeserializeObject<ProductJsonModel>(infoProduct);
                    string name = product.Name;
                    int price = product.Price;
                    int discount = product.Discount;
                    int id_brand = GetIDBrandByNameBrand(product.Brand);
                    int id_type = GetIDTypeByNameType(product.Type);
                    int quantity = product.Quantity;

                    if (IsValidProduct(name, price, discount, id_brand, id_type, quantity))
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        productbll.AddProductWithScanQR(product);
                        MessageBox.Show("Đã thêm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã QR Không dùng để thêm sản phẩm !\n" + ex.GetBaseException(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ptbScanQR.Image = bitmap;
        }

        private void FrmScanQR_Load(object sender, EventArgs e)
        {
            filtercollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filtercollection)
            {
                cmbChoiceDevice.Items.Add(device.Name);
            }
            cmbChoiceDevice.SelectedIndex = 0;
        }

        private void FrmScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenCamera(cmbChoiceDevice.SelectedIndex);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            StopCamera();
        }
    }
}
