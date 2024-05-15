using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using OfficeOpenXml;
using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.Forms;
using QuanlyShopGiayDep.Model;
using ZXing.OneD;
using LicenseContext = OfficeOpenXml.LicenseContext;
namespace QuanlyShopGiayDep
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }
        int current_row = -1;
        private string Username = "";
        BLLStaff staffbll = new BLLStaff();
        public FrmOrders(string username)
        {
            InitializeComponent();
            Username = username;
        }
        private void CapQuyenExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        BLLInvoice invoicebll = new BLLInvoice();
        private void LoadDataGridView()
        {
            DataTable data = new DataTable();
            data = invoicebll.LoadData();
            dgvOrders.DataSource = data;
        }
        public void LoadData()
        {
            LoadDataGridView();
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                if (column.HeaderText.ToLower() == "ngày lập") continue;
                cmbOrderType.Items.Add(column.HeaderText);
            }
            cmbOrderType.SelectedIndex = 0;
            CapQuyenExcel();
        }
        private void FrmOrders_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ExportExcel(DataGridView data, string name)
        {
            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("Dữ liệu");
                for (int i = 0; i < data.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1].Value = data.Columns[i].HeaderText;
                }
                for (int i = 0; i < data.RowCount; i++)
                {
                    for (int j = 0; j < data.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = data.Rows[i].Cells[j].Value;
                    }
                }
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = name + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelPackage.SaveAs(new FileStream(saveFileDialog.FileName, FileMode.Create));
                    MessageBox.Show("Xuất file Excel thành công!");
                }
            }
        }
        private void btnExportExcelOrders_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvOrders, "ListOrders");
        }
        public void SearchByType(string type, string input)
        {
            dgvOrders.DataSource = invoicebll.SearchByType(type, input);
        }
        private void txtInputSearchOrder_TextChanged(object sender, EventArgs e)
        {
            string SearchInput = txtInputSearchOrder.Text;
            string tieuchi = cmbOrderType.SelectedItem.ToString();
            if (string.IsNullOrEmpty(SearchInput))
            {
                LoadDataGridView();
                return;
            }
            SearchByType(tieuchi, SearchInput);
        }

        private void btnDropOrder_Click(object sender, EventArgs e)
        {
            if (current_row == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(dgvOrders.Rows[current_row].Cells[0].Value.ToString());
            if (MessageBox.Show("Bạn thật sự muốn xóa " + id.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int row_effect  = invoicebll.RemoveInvoice(id);
                if (row_effect > 0)
                {
                    MessageBox.Show("Xóa thành công " + id.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_row = e.RowIndex;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmaddorder = new FrmAddOrder(Username);
            frmaddorder.ShowDialog();
            LoadDataGridView();
        }
        private DataTable GetDetailInvoie(int id)
        {
            DataTable dt = new DataTable();
            dt = invoicebll.GetDetailInvoie(id);
            return dt;
        }

        private DataTable GetInfoCustomerByIDInvoice(int id)
        {
            DataTable dt = new DataTable();
            dt = invoicebll.GetInfoCustomerByIDInvoice(id);
            return dt;
        }
        private void setFormat(ref Document document, string title, string value, iTextSharp.text.Font font)
        {
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100; // Đảm bảo bảng chiếm toàn bộ chiều rộng của tài liệu

            // Tạo ô cho phần "Tiền thanh toán: "
            PdfPCell titlex = new PdfPCell(new Phrase(title, font));
            titlex.Border = iTextSharp.text.Rectangle.NO_BORDER; // Loại bỏ đường viền
            titlex.HorizontalAlignment = Element.ALIGN_LEFT; // Căn trái

            // Tạo ô cho số tiền thanh toán
            PdfPCell valuex = new PdfPCell(new Phrase(value, font));
            valuex.Border = iTextSharp.text.Rectangle.NO_BORDER; // Loại bỏ đường viền
            valuex.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn phải

            // Thêm các ô vào bảng
            table.AddCell(titlex);
            table.AddCell(valuex);

            // Thêm bảng vào tài liệu
            document.Add(table);
        }
        private string GetNameStaffByIDInvoice(int id)
        {
            return staffbll.GetNameStaffByIDInvoice(id);   
        }

        private DataTable GetTimeByIDInvoice(int id)
        {
            return invoicebll.GetTimeByIDInvoice(id);
        }

        private void ExportToPDF(int id)
        {
            DataTable data = GetDetailInvoie(id);
            DataTable Time = GetTimeByIDInvoice(id);
            string filePath = "C:\\Study\\Lean_University\\Nam-3\\HK2\\DOT-Net\\BTL\\QuanlyShopGiayDep\\output.pdf";
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A5, 5, 5, 5, 5);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                string imagePath = "C:\\Study\\Lean_University\\Nam-3\\HK2\\DOT-Net\\BTL\\QuanlyShopGiayDep\\logoInvoiceExport.png";
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
                img.ScaleToFit(150, 150);
                img.Alignment = Element.ALIGN_CENTER;
                document.Add(img);

                BaseFont bf = BaseFont.CreateFont("C:\\Windows\\fonts\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 12);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("HÓA ĐƠN THANH TOÁN", boldFont);
                title.Alignment = Element.ALIGN_CENTER; 
                document.Add(title);

                iTextSharp.text.Paragraph mahd = new iTextSharp.text.Paragraph("Mã HĐ: " + id.ToString(), boldFont);
                mahd.Alignment = Element.ALIGN_CENTER; 
                mahd.SpacingAfter = 20; 
                document.Add(mahd);
                iTextSharp.text.Paragraph Nhanvien = new iTextSharp.text.Paragraph();
                Chunk titlenhanvien = new Chunk("Thu Ngân: ", boldFont);
                Chunk tennhanvien = new Chunk(GetNameStaffByIDInvoice(id), textFont);
                Nhanvien.Add(titlenhanvien);
                Nhanvien.Add(tennhanvien);
                Nhanvien.Alignment = Element.ALIGN_LEFT; 
                Nhanvien.SpacingAfter = 10; 
                document.Add(Nhanvien);
               
                iTextSharp.text.Paragraph Ngaylap = new iTextSharp.text.Paragraph();
                Chunk titleNgayLap = new Chunk("Ngày lập: ", boldFont);
                Chunk ngay = new Chunk(Time.Rows[0]["Ngày"].ToString() + "/" + Time.Rows[0]["Tháng"].ToString() + "/" + Time.Rows[0]["Năm"].ToString(), textFont);
                Ngaylap.Add(titleNgayLap);
                Ngaylap.Add(ngay);
                Ngaylap.Alignment = Element.ALIGN_LEFT; 
                Ngaylap.SpacingAfter = 10; 
                document.Add(Ngaylap);



                iTextSharp.text.Paragraph Giolap = new iTextSharp.text.Paragraph();
                Chunk titlegio = new Chunk("Giờ: ", boldFont);
                Chunk gio = new Chunk(Time.Rows[0]["Giờ"].ToString(), textFont);
                Giolap.Add(titlegio);
                Giolap.Add(gio);
                Giolap.Alignment = Element.ALIGN_LEFT; 
                Giolap.SpacingAfter = 20; 
                document.Add(Giolap);


                PdfPTable pdfTable = new PdfPTable(data.Columns.Count + 1);
                pdfTable.WidthPercentage = 100; 
                pdfTable.DefaultCell.Padding = 5; 


                PdfPCell ttCellHeader = new PdfPCell(new Phrase("TT", boldFont));
                ttCellHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(ttCellHeader);
                foreach (DataColumn column in data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, boldFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                }
                int rowNumber = 1;
                int sumPrice = 0;
                foreach (DataRow row in data.Rows)
                {
                    PdfPCell ttCell = new PdfPCell(new Phrase(rowNumber.ToString(), textFont));
                    ttCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTable.AddCell(ttCell);
                    sumPrice += int.Parse(row["Thành Tiền"].ToString());
                    foreach (var cellValue in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(cellValue.ToString(), textFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER; 
                        pdfTable.AddCell(cell);
                    }
                    rowNumber++;
                }
                document.Add(pdfTable);
                iTextSharp.text.Paragraph newline3 = new iTextSharp.text.Paragraph();
                Chunk chunknewline3 = new Chunk("\n");
                newline3.Add(chunknewline3);
                document.Add(newline3);

                string sumPriceString = sumPrice.ToString("N0", new CultureInfo("vi-VN"));
                setFormat(ref document, "Tiền Thanh Toán: ", sumPriceString, boldFont);
                setFormat(ref document, "Tiền Khách Đưa: ", sumPriceString, boldFont);
                setFormat(ref document, "Tiền Thừa: ", "0", boldFont);
                iTextSharp.text.Paragraph newline2 = new iTextSharp.text.Paragraph();
                Chunk chunknewline2 = new Chunk("\n"); 
                newline2.Add(chunknewline2);
                document.Add(newline2);
                LineSeparator lineSeparator = new LineSeparator();
                lineSeparator.LineColor = BaseColor.BLACK; 
                lineSeparator.LineWidth = 1; 
                document.Add(lineSeparator);


                iTextSharp.text.Paragraph luuY = new iTextSharp.text.Paragraph("Lưu ý: Quy đổi 1đ = 100k", boldFont);
                luuY.Alignment = Element.ALIGN_LEFT;
                document.Add(luuY);

                iTextSharp.text.Paragraph newline1 = new iTextSharp.text.Paragraph();
                Chunk chunknewline1 = new Chunk("\n"); // Ký tự xuống dòng
                newline1.Add(chunknewline1);
                document.Add(newline1);
                LineSeparator line2 = new LineSeparator();

                line2.LineColor = BaseColor.BLACK; 
                line2.LineWidth = 1; 
                document.Add(line2);


                iTextSharp.text.Paragraph newline = new iTextSharp.text.Paragraph();
                Chunk chunknewline = new Chunk("\n"); 
                newline.Add(chunknewline);
                document.Add(newline);
                DataTable infocustomer = GetInfoCustomerByIDInvoice(id);
                if(infocustomer.Rows.Count > 0)
                {
                    setFormat(ref document, "+ Tên hội viên: ", infocustomer.Rows[0]["Name"].ToString(), textFont);
                    setFormat(ref document, "+ Điểm tích lũy: ", infocustomer.Rows[0]["Score"].ToString(), textFont);
                }
                document.Close();
            }
            Process.Start(filePath);
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (current_row == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int IDInvoice = int.Parse(dgvOrders.Rows[current_row].Cells[0].Value.ToString());
            ExportToPDF(IDInvoice);
        }
    }
}
