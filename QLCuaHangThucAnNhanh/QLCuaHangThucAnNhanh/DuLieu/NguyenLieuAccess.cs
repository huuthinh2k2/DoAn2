using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class NguyenLieuAccess
    {
        Database db;
        public NguyenLieuAccess()
        {
            db = new Database();
        }

        public DataTable GetData()
        {
            string sql = "Select * from NguyenLieu";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable GetDataTable()
        {
            string sql = "Select MaNL,TenNL,TonKhoNL,DonViTinh.DonVi from NguyenLieu,DonViTinh where NguyenLieu.DonVi = DonViTinh.MaDV";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public void InsertNL(string tennl,int tonkho,int donvi)
        {
            string sql = string.Format("Insert into NguyenLieu values(N'{0}',{1},{2})",tennl,tonkho,donvi);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteNL(int idnl)
        {
            string sql = "Delete from NguyenLieu where MaNL=" + idnl;
            db.ExecuteNonQuery(sql);
        }
        public void UpdateNL(string tennl, int tonkho,int donvi ,int idnl)
        {
            string sql = string.Format("Update NguyenLieu Set TenNL=N'{0}',TonKhoNL={1},DonVi={2} Where MaNL={3}",tennl,tonkho,donvi,idnl);
            db.ExecuteNonQuery(sql);
        }

        public void UpdateTonKho(int tonkho,int manl)
        {
            string sql = string.Format("Update NguyenLieu set TonKhoNL={0} where MaNL={1}",tonkho,manl);
            db.ExecuteNonQuery(sql);
        }

        public int GetTonKho(int manl)
        {
            string sql = "Select TonKhoNL from NguyenLieu where MaNL=" + manl;
            DataTable dt = db.Execute(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimKiem(string tennl)
        {
            string sql = "Select MaNL,TenNL,TonKhoNL,DonViTinh.DonVi from NguyenLieu,DonViTinh where NguyenLieu.DonVi = DonViTinh.MaDV and TenNL Like N'%" + tennl + "%'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
