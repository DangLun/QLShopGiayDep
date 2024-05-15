using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class HomeDAL
    {
        Provider provider = new Provider();
        public int GetQuantityInvoice()
        {
            string query = "select * from invoices";
            DataTable r = provider.ExcuteQuery(query);
            if (r.Rows.Count == 0) return 0;
            return r.Rows.Count - 1;
        }

        public int GetQuantityInvoiceInMonth(int month)
        {
            string query = "select * from invoices where MONTH(CreaDate) = @month ";
            DataTable r = provider.ExcuteQuery(query, new object[] {month});
            if (r.Rows.Count == 0) return 0;
            return r.Rows.Count - 1;
        }
        public int GetQuantityBuyProduct()
        {
            string query = "select sum(BuyQuantity) as 'sumProduct' from invoicedetails";
            DataTable r = provider.ExcuteQuery(query);
            return int.Parse(r.Rows[0]["sumProduct"].ToString());
        }

        public int GetQuantityBuyProductInMonth(int month)
        {
            string query = "select sum(BuyQuantity) as 'sumProduct' from invoicedetails inner join invoices \r\non invoicedetails.ID_Invoice = invoices.id where MONTH(CreaDate) = @month ";
            DataTable r = provider.ExcuteQuery(query, new object[] {month});
            if (r.Rows[0]["sumProduct"] == DBNull.Value)
            {
                return 0;
            }
            return int.Parse(r.Rows[0]["sumProduct"].ToString());
        }

        public int GetDoanhThu()
        {
            string query = "select sum(BuyQuantity * (Price - (Price * Discount / 100))) as 'sum' from invoicedetails inner join invoices \r\non invoicedetails.ID_Invoice = invoices.id inner join Products on Products.ID = invoicedetails.ID_Product\r\n";
            DataTable r = provider.ExcuteQuery(query);
            if (r.Rows[0]["sum"] == DBNull.Value)
            {
                return 0;
            }
            return int.Parse(r.Rows[0]["sum"].ToString());
        }

        public int GetDoanhThuInMonth(int month)
        {
            string query = "select sum(BuyQuantity * (Price - (Price * Discount / 100))) as 'sum' from invoicedetails inner join invoices \r\non invoicedetails.ID_Invoice = invoices.id inner join Products on Products.ID = invoicedetails.ID_Product\r\nwhere MONTH(creadate) = @month ";
            DataTable r = provider.ExcuteQuery(query, new object[] { month });
            if (r.Rows[0]["sum"] == DBNull.Value)
            {
                return 0;
            }
            return int.Parse(r.Rows[0]["sum"].ToString());
        }
        public int GetQuanTityCustomer()
        {
            string query = "select * from customers";
            DataTable r = provider.ExcuteQuery(query);
            return r.Rows.Count;
        }

        public int GetQuantityCustomerInMonth(int month)
        {
            string query = "select * from customers where MONTH(creadate) = @month ";
            DataTable r = provider.ExcuteQuery(query, new object[] { month });
            return r.Rows.Count;
        }

        public int GetQuantityProductByType(string type)
        {
            string query = "select sum(BuyQuantity) as 'quantity' from products inner join invoicedetails on products.ID = invoicedetails.ID_Product\r\ninner join TypeProducts on Products.ID_Type = TypeProducts.ID \r\nwhere LOWER(TypeProducts.[Name]) like N'" + type+"'";
            DataTable r = provider.ExcuteQuery(query);
            return int.Parse(r.Rows[0]["quantity"].ToString());
        }

        public int GetDoanhThuTheoNam(int year)
        {
            string query = "select sum(BuyQuantity * (Price - (Price * Discount / 100))) as 'sum' from invoicedetails inner join invoices on invoicedetails.ID_Invoice = invoices.id inner join Products on Products.ID = invoicedetails.ID_Product where year(creadate) = @year";
            DataTable r = provider.ExcuteQuery(query, new object[] { year });

            // Kiểm tra xem DataTable r có tồn tại hay không và có ít nhất một hàng không
            if (r == null || r.Rows.Count == 0)
            {
                // Nếu không có kết quả hoặc không có hàng, trả về giá trị mong muốn (ví dụ: 0)
                return 0;
            }

            // Lấy giá trị của cột 'sum' từ DataRow đầu tiên trong DataTable
            object sumValue = r.Rows[0]["sum"];

            // Kiểm tra giá trị NULL
            if (sumValue == DBNull.Value)
            {
                // Nếu giá trị là NULL, trả về giá trị mong muốn (ví dụ: 0)
                return 0;
            }

            // Chuyển đổi giá trị sang kiểu số nguyên và trả về
            return Convert.ToInt32(sumValue);
        }
    }
}
