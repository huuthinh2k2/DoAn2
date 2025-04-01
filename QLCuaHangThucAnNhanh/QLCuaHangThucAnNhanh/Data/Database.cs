using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.Data
{
    public class Database
    {
        SqlConnection Kn;
        SqlDataAdapter Da;
        DataTable ds;
        public Database()
        {
            string Ckn = "Data Source=DESKTOP-US9ME7A\\SQLEXPRESS;Initial Catalog=DienThoai;Integrated Security=True";
            Kn = new SqlConnection(Ckn);
        }
        public DataTable Execute(string SqlStr)
        {
            Da = new SqlDataAdapter(SqlStr, Kn);
            ds = new DataTable();
            Da.Fill(ds);
            return ds;
        }
        public void ExecuteNonQuery(string SqlStr)
        {
            SqlCommand cmd = new SqlCommand(SqlStr, Kn);
            Kn.Open();
            cmd.ExecuteNonQuery();
            Kn.Close();
        }
    }
}
