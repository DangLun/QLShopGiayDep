using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class ProductDAL
    {
        Provider provider = new Provider();
        public DataTable LoadData()
        {
            string query = "select Products.ID, Products.Name, Price, Quantity, Discount, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query);
            return data;
        }
        public DataTable SearchProductByTypesearch(string type, string SearchInput)
        {
            string query = "exec SearchProductsByType @Type , @SearchInput ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { type, SearchInput });
            return data;
        }

        public int GetIDBrandByNameBrand(string nameBrand)
        {
            string query = "select ID from brands where Name = @nameBrand ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { nameBrand });
            int ID = int.Parse(data.Rows[0]["ID"].ToString());
            return ID;
        }

        public int GetIDTypeByNameType(string nameType)
        {
            string query = "select ID from TypeProducts where Name = @nameType ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { nameType });
            int ID = int.Parse(data.Rows[0]["ID"].ToString());
            return ID;
        }

        public int DeleteProductByID(int id)
        {
            string query = "delete products where id = @id ";
            int row_effect = 0;
            row_effect = provider.ExcuteNonQuery(query, new object[] { id });
            return row_effect;
        }

        
        private int GetMaxIDProduct()
        {
            string query = "select max(ID) as max from products";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query);
            return int.Parse(dt.Rows[0]["max"].ToString());
        }
        public int AddProduct(ProductModel product)
        {
            string query = "exec AddProduct @Name , @Price , @Discount , @ID_Brand , @ID_Type , @quantity ";
            string Name = product.Name;
            int price = product.Price;
            int discount = product.Discount;
            int id_brand = product.ID_Brand;
            int id_type = product.ID_Type;
            int quantity = 0;
            foreach(object[] item in product.Sizes)
            {
                quantity += int.Parse(item[1].ToString());
            }
            int row_e = provider.ExcuteNonQuery(query, new object[] { Name, price, discount, id_brand, id_type, quantity });
            int newID = GetMaxIDProduct();
            AddDetailProduct(newID, product.Sizes);
            return row_e;
        }
        public void AddDetailProductWithScanQR(int id, SizesDTO sizes)
        {
            string sql = "DeleteProductDetailByIDProduct @id ";
            provider.ExcuteNonQuery(sql, new object[] { id });
            string query = "AddDetailProduct @quantity , @size , @idproduct ";
            if(sizes.Size33 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size33, 33, id });
            if(sizes.Size34 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size34, 34, id });
            if (sizes.Size35 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size35, 35, id });
            if (sizes.Size36 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size36, 36, id });
            if (sizes.Size37 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size37, 37, id });
            if (sizes.Size38 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size38, 38, id });
            if (sizes.Size39 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size39, 39, id });
            if (sizes.Size40 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size40, 40, id });
            if (sizes.Size41 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size41, 41, id });
            if (sizes.Size42 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size42, 42, id });
            if (sizes.Size43 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size43, 43, id });
            if (sizes.Size44 != 0) provider.ExcuteNonQuery(query, new object[] { sizes.Size44, 44, id });
        }
        public int AddProductWithScanQR(ProductJsonModel product)
        {
            string query = "exec AddProduct @Name , @Price , @Discount , @ID_Brand , @ID_Type , @quantity ";
            string Name = product.Name;
            int price = product.Price;
            int discount = product.Discount;
            int id_brand = GetIDBrandByNameBrand(product.Brand);
            int id_type = GetIDTypeByNameType(product.Type);    
            int quantity = product.Quantity;
            int row_e = provider.ExcuteNonQuery(query, new object[] { Name, price, discount, id_brand, id_type, quantity });
            int newID = GetMaxIDProduct();
            AddDetailProductWithScanQR(newID, product.Sizes);
            return row_e;
        }

        public DataTable SelectProductByID(int id)
        {
            string query = "select * from products where id = @id ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { id });
            return data;
        }
        public void AddDetailProduct(int id, List<object[]> infoSizes)
        {
            string sql = "DeleteProductDetailByIDProduct @id ";
            provider.ExcuteNonQuery(sql, new object[] { id });
            foreach (object[] item in infoSizes)
            {
                string query = "AddDetailProduct @quantity , @size , @idproduct ";
                provider.ExcuteNonQuery(query, new object[] { item[1], item[0], id });
            }
        }
        public int UpdateProduct(ProductModel product)
        {
            string query = "exec updateproduct @id , @name , @price , @discount , @id_brand , @id_type , @quantity ";
            int id = product.Id;
            int price = product.Price;
            int discount = product.Discount;
            string name = product.Name;
            int id_brand = product.ID_Brand;
            int id_type = product.ID_Type;
            int quantity = 0;
            foreach (object[] item in product.Sizes)
            {
                quantity += int.Parse(item[1].ToString());
            }
            int row_effect = provider.ExcuteNonQuery(query, new object[] { id, name, price, discount, id_brand, id_type, quantity });
            AddDetailProduct(id, product.Sizes);
            return row_effect;
        }


        public DataTable LoadDetailProduct(int idProduct)
        {
            string query = "select * from ProductDetails where ID_Product = @id ";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query, new object[] { idProduct });
            return data;
        }

        public int getQuantityProductByID(int id)
        {
            string query = "select * from products where ID = @id ";
            DataTable dt = provider.ExcuteQuery(query, new object[] { id });
            return int.Parse(dt.Rows[0]["Quantity"].ToString());
        }
        public int getQuantityProductByIDAndSize(int id, int size)
        {
            string query = "select productdetails.Quantity from products inner join productdetails \r\non products.id = productdetails.ID_Product where products.id = @id and size = @size ";
            DataTable dt = provider.ExcuteQuery(query, new object[] { id, size });
            return int.Parse(dt.Rows[0]["Quantity"].ToString());
        }
    }
}
