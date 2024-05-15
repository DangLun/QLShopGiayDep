using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace QuanlyShopGiayDep.DAL
{
    public class Provider
    {
        public string ConnectString = @"Data Source=ACERNITRO5-D\SQLEXPRESS;Initial Catalog=QLShopGiayDep;Integrated Security=True";
        public Provider() {
        }
        public SqlConnection ConnectSQL()
        {
            return new SqlConnection(ConnectString);
        }
        public DataTable ExcuteQuery(string query, object[] Params = null)
        {
            DataTable Data = new DataTable();
            using(SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if(Params != null)
                    {
                        string[] listNameParam = query.Split(' ');
                        int index = 0;
                        foreach(string item in listNameParam)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, Params[index++]);
                            }
                        }
                    }
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(Data);
                    }
                }
                conn.Close();
            }
            return Data;
        }
        public int ExcuteNonQuery(string query, object[] Params = null)
        {
            int rows_effected = 0;
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (Params != null)
                    {
                        string[] listNameParam = query.Split(' ');
                        int index = 0;
                        foreach (string item in listNameParam)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, Params[index++]);
                            }
                        }
                    }
                    rows_effected = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return rows_effected;
        }
        public int ExecuteScalar(string query, object[] Params = null)
        {
            int newID = 0;
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (Params != null)
                    {
                        string[] listNameParam = query.Split(' ');
                        int index = 0;
                        foreach (string item in listNameParam)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, Params[index++]);
                            }
                        }
                    }
                    object execute = cmd.ExecuteScalar();
                    if (execute != null)
                    {
                        newID = (int)execute;
                    }
                }
                conn.Close();
            }
            return newID;
        }
    }
}
