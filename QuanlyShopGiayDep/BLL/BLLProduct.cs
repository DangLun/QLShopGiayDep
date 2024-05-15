using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
namespace QuanlyShopGiayDep.BLL
{
    public class BLLProduct
    {
        ProductDAL productdal = new ProductDAL();
        public DataTable LoadData()
        {
            DataTable data = new DataTable();
            data = productdal.LoadData();
            return data;
        }
        public DataTable SearchProductByTypesearch(string type, string SearchInput)
        {
            DataTable data = new DataTable();
            data = productdal.SearchProductByTypesearch(type, SearchInput);
            return data;
        }

        public int GetIDBrandByNameBrand(string nameBrand)
        {
            int ID = productdal.GetIDBrandByNameBrand(nameBrand);
            return ID;
        }

        public int GetIDTypeByNameType(string nameType)
        {
            int ID = productdal.GetIDTypeByNameType(nameType);
            return ID;
        }
        
        public int DeleteProductByID(int id) {
            
            int row_effect = 0;
            row_effect = productdal.DeleteProductByID(id);
            return row_effect;
        }

        public int AddProduct(ProductModel product)
        {
            int row_effect = productdal.AddProduct(product);
            return row_effect;
        }

        public DataTable SelectProductByID(int id)
        {
            DataTable data = new DataTable();
            data = productdal.SelectProductByID(id);
            return data;
        }

        public int UpdateProduct(ProductModel product)
        {
            int row_effect = 0;
            row_effect = productdal.UpdateProduct(product);
            return row_effect;
        }

        public DataTable LoadDetailProduct(int idProduct)
        {
            DataTable data = new DataTable();
            data = productdal.LoadDetailProduct(idProduct);
            return data;
        }
        public int AddProductWithScanQR(ProductJsonModel product)
        {
            return productdal.AddProductWithScanQR(product);
        }
        public int getQuantityProductByID(int id)
        {
            return productdal.getQuantityProductByID(id);   
        }

        public int getQuantityProductByIDAndSize(int id, int size)
        {
            return productdal.getQuantityProductByIDAndSize(id, size);
        }
    }
}
