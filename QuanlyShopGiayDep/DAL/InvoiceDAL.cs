using QuanlyShopGiayDep.DTO;
using QuanlyShopGiayDep.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class InvoiceDAL
    {
        ShopGiayDep _dbcontext = new ShopGiayDep();
        Provider provider = new Provider();
        //public async Task<List<InvoiceModel>> LoadData()
        //{
        //    var res = (from order in _dbcontext.Invoices
        //               join detail in _dbcontext.InvoiceDetails
        //              on order.ID equals detail.ID_Invoice
        //               join customer in _dbcontext.Customers
        //              on order.ID_Customer equals customer.ID
        //               select new InvoiceModel()
        //               {
        //                   ID = order.ID,
        //                   CreaDate = (DateTime)order.CreaDate,
        //                   BuyQuantity = (int)detail.BuyQuantity,
        //                   NameCustomer = customer.Name,
        //                   Phone = customer.Phone,
        //                   Gender = customer.Gender,
        //                   Score = (int)customer.Score
        //               }).ToListAsync();
        //    return await res;
        //}
        public DataTable LoadData()
        {
            string query = "select invoices.ID, Invoices.CreaDate, sum(InvoiceDetails.BuyQuantity) as BuyQuantity,Customers.Name as NameCustomer, Phone, Gender, Score from invoices inner join invoiceDetails on invoices.ID = invoiceDetails.ID_invoice left join Customers on customers.ID = Invoices.ID_Customer group by Invoices.ID, Invoices.CreaDate, Customers.Name, Phone, Gender, Score\r\n";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query);
            return data;
        }

        public List<InvoiceModel> SearchByType(string type, string input)
        {
            var result = _dbcontext.Invoices
            .Join(_dbcontext.InvoiceDetails,
                invoice => invoice.ID,
                detail => detail.ID_Invoice,
                (invoice, detail) => new { invoice, detail })
            .Join(_dbcontext.Customers,
                invDetail => invDetail.invoice.ID_Customer,
                customer => customer.ID,
                (invDetail, customer) => new { invDetail.invoice, invDetail.detail, customer })
            .GroupBy(invCust => new
            {
                invCust.invoice.ID,
                invCust.invoice.CreaDate,
                invCust.customer.Name,
                invCust.customer.Phone,
                invCust.customer.Gender,
                invCust.customer.Score
            })
            .Select(group => new InvoiceModel()
            {
                ID = group.Key.ID,
                CreaDate = (DateTime)group.Key.CreaDate,
                BuyQuantity = (int)group.Sum(g => g.detail.BuyQuantity),
                NameCustomer = group.Key.Name,
                Phone = group.Key.Phone,
                Gender = group.Key.Gender,
                Score = (int)group.Key.Score
            })
            .ToList();
            input = input.ToLower();
            if (type.ToLower() == "id")
            {
                return result.Where(st => st.ID.ToString().ToLower().Contains(input)).ToList();
            }
            else if (type.ToLower() == "sản phẩm")
            {
                return result.Where(st => st.BuyQuantity.ToString().ToLower().Contains(input)).ToList();
            }
            else if (type.ToLower() == "tên khách hàng")
            {
                return result.Where(st => st.NameCustomer.ToLower().Contains(input)).ToList();
            }
            else if (type.ToLower() == "điện thoại")
            {
                return result.Where(st => st.Phone.ToLower().Contains(input)).ToList();
            }
            else if (type.ToLower() == "giới tính")
            {
                return result.Where(st => st.Gender.ToLower().Contains(input)).ToList();
            }
            return result.Where(st => st.Score.ToString().ToLower().Contains(input)).ToList();
        }


        public int RemoveInvoice(int id)
        {
            var oneInvoice = _dbcontext.Invoices.FirstOrDefault(st => st.ID == id);
            _dbcontext.Invoices.Remove(oneInvoice);
            return _dbcontext.SaveChanges();
        }

        //public List<ProductModel> LoadDataOnAddOrder()
        //{
        //    return _dbcontext.Products.Select(p => new ProductModel
        //    {
        //        Id = p.ID,
        //        Name = p.Name,
        //        Price = (int)p.Price
        //    }).ToList();
        //}

        public DataTable LoadDataOnAddOrder()
        {
            DataTable dt = new DataTable();
            string query = "select ID, Name, Price from products";
            dt = provider.ExcuteQuery(query);
            return dt;
        }

        public DataTable LoadSizeByID(int id)
        {
            DataTable dt = new DataTable();
            string query = "select * from products inner join ProductDetails on Products.ID = ProductDetails.ID_Product where products.id = @id and ProductDetails.Quantity > 0";
            dt = provider.ExcuteQuery(query, new object[] {id});
            return dt;
        }

        public int GetTypeProductByID(int id)
        {
            var cnt = _dbcontext.Products.FirstOrDefault(p => p.ID == id).ID_Type;
            if (cnt == null) return -1;
            return (int)cnt;
        }

        public int GetPriceByIDProduct(int id)
        {
            DataTable dt = new DataTable();
            string query = "select * from products where id = @id ";
            dt = provider.ExcuteQuery(query, new object[] { id });
            return int.Parse(dt.Rows[0]["Price"].ToString());
        }

        public DataTable GetQuanTityBySizeAndIDProduct(int id, int size)
        {
            DataTable dt = new DataTable();
            string query = "select ProductDetails.Quantity from products inner join ProductDetails on Products.ID = ProductDetails.ID_Product where products.id = @id and size = @size ";
            dt = provider.ExcuteQuery(query, new object[] { id , size });
            return dt;
        }

        public int GetQuantityPhuKienByIDProduct(int id)
        {
            DataTable dt = new DataTable();
            string query = "select * from products where id = @id ";
            dt = provider.ExcuteQuery(query, new object[] { id });
            return int.Parse(dt.Rows[0]["Quantity"].ToString());
        }
        public int GetDiscountByIDProduct(int id)
        {
            DataTable dt = new DataTable();
            string query = "select * from products where id = @id ";
            dt = provider.ExcuteQuery(query, new object[] { id });
            return int.Parse(dt.Rows[0]["Discount"].ToString());
        }
        public DataTable GetTableStaffsByUsername(string username)
        {
            string query = "select * from staffs inner join accounts on staffs.ID_Account = accounts.id where username = @username ";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query, new object[] { username });
            return dt;
        }

        public int InsertInvoice(DateTime creadate, int idcustomer, int idstaff)
        {
            string query = "exec AddInvoice @creadate , @idcustomer , @idstaff ";
            int r = provider.ExcuteNonQuery(query, new object[] {creadate, idcustomer, idstaff});
            return r;
        }
        public int GetIDInvoiceMax()
        {
            string query = "select max(ID) as maxID from invoices";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query);
            return int.Parse(dt.Rows[0]["maxID"].ToString());
        }

        public DataTable GetDetailInvoie(int id)
        {
            string query = "select [Name] as N'Tên sản phẩm', BuyQuantity as N'SL', Price as N'Đơn Giá',\r\nDiscount as N'Khuyến mãi',\r\nBuyQuantity * (Price - (Price * Discount / 100)) as N'Thành Tiền'\r\n from invoicedetails inner join products on invoicedetails.ID_Product = products.id inner join invoices \r\non invoices.ID = invoicedetails.ID_Invoice where ID_Invoice = @id ";
            DataTable data = provider.ExcuteQuery(query, new object[] {id});
            return data;
        }

        public DataTable GetTimeByIDInvoice(int id)
        {
            string query = "select DAY(CreaDate) as N'Ngày', MONTH(CreaDate) as N'Tháng',YEAR(CreaDate) as N'Năm', \r\nFORMAT(CreaDate, 'HH:mm') AS N'Giờ'\r\nfrom invoicedetails inner join products on invoicedetails.ID_Product = products.id inner join invoices \r\non invoices.ID = invoicedetails.ID_Invoice where ID_Invoice = @id ";
            DataTable data = provider.ExcuteQuery(query, new object[] { id });
            return data;
        }

        public DataTable GetInfoCustomerByIDInvoice(int id)
        {
            string query = "select * from customers inner join invoices on invoices.ID_Customer = customers.ID where invoices.ID = @id ";
            DataTable data = provider.ExcuteQuery(query, new object[] { id });
            return data;
        }
    }
}
