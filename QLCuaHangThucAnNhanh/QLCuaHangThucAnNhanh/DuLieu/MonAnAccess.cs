using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
   public class MonAnAccess
    {
        Database db;
        public MonAnAccess()
        {
            db = new Database();
        }

        public DataTable GetData()
        {
            string sql = "Select * from MonAn";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public void InsertMA(string tenmon,int tonkho,decimal gia)
        {
            string sql = string.Format("Insert into MonAn Values(N'{0}',{1},{2})", tenmon, tonkho, gia);
            db.ExecuteNonQuery(sql);
        }

        public void DeleteMA(int idmon)
        {
            string sql = "Delete from MonAn where MaMon=" + idmon;
            db.ExecuteNonQuery(sql);
        }

        public void UpdateMA(int idmon,string tenmon, int tonkho, decimal gia)
        {
            string sql = string.Format("Update MonAn set TenMon=N'{0}',TonKhoMonAn={1},GiaMon={2} Where MaMon = {3}", tenmon, tonkho, gia, idmon);
            db.ExecuteNonQuery(sql);
        }
        public void UpdateSL(int sl,int mamon)
        {
            string sql = string.Format("Update MonAn set TonKhoMonAn={0} where MaMon={1}",sl,mamon);
            db.ExecuteNonQuery(sql);
        }
        public int GetSL(int mamon)
        {
            string sql = "Select TonKhoMonAn from MonAn where MaMon=" + mamon;
            DataTable dt = db.Execute(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimKiem(string tenmon)
        {
            string sql = "Select * from MonAn where TenMon Like N'%" + tenmon + "%'";
           DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
