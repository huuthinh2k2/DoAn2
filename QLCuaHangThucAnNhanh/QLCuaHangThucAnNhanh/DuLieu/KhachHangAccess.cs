using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class KhachHangAccess
    {
        Database db;
            public KhachHangAccess()
            {
            db = new Database();
            }
        public DataTable GetData()
        {
            String sql = "Select* from KhachHang";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void InsertKH(string tenkh,string dienthoai,string diachi)
        {
            string sql = string.Format("Insert into KhachHang values(N'{0}','{1}',N'{2}')", tenkh, dienthoai, diachi);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteKH(int idkh)
        {
            string sql = string.Format("Delete from KhachHang where MaKH = {0}", idkh);
            db.ExecuteNonQuery(sql);
        }
        public void UpdateKH(string tenkh, string diachi, string dienthoai,int idkh)
        {
            string sql = string.Format("Update KhachHang set TenKH = N'{0}',DiaChiKH=N'{1}',DienThoaiKH=N'{2}' Where MaKH={3} ", tenkh, diachi, dienthoai,idkh);
            db.ExecuteNonQuery(sql);
        }
        public int GetMaKH()
        {
            string sql = "Select MAX(MaKH) from KhachHang"; ;
            DataTable dt= db.Execute(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimKiem(string ten)
        {
            string sql = "Select * from KhachHang where TenKH Like N'%" + ten + "%'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
