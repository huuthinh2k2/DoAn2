using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class HDNhapAccess
    {
        Database db;
        public HDNhapAccess()
        {
            db = new Database();
        }

        public string GetMaHD()
        {
            string sql = "Select MAX(MaHDNhap) from HDNhap";
            DataTable dt = db.Execute(sql);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetHDbyID(string mahd)
        {
            string sql ="Select * from HDNhap,NhanVien where MaHDNhap='"+mahd+"' and HDNhap.NguoiLap=NhanVien.MaNV";
            DataTable dt = db.Execute(sql);
            return dt;
        } 
        public void CreateHD(string mahd)
        {
            string sql =string.Format("Insert Into HDNhap values('{0}',null,null,null)",mahd);
            db.ExecuteNonQuery(sql);
        }

        public void InsertHDItem(string mahd,int manl,int sl,int dvt,decimal gianhap)
        {
            string sql = string.Format("Insert Into ChiTietHDNhap values('{0}',{1},{2},{3},{4})",mahd,manl,sl,dvt,gianhap);
            db.ExecuteNonQuery(sql);
        }
        public void deleteItem(int manl,string mahd)
        {
            string sql =string.Format("Delete from ChiTietHDNhap where MaNL={0} and MaHD='{1}'",manl,mahd);
            db.ExecuteNonQuery(sql);
        }
        public DataTable getItem(string mahd)
        {
            string sql = "Select MaHD,ChiTietHDNhap.MaNL,TenNL,SLNhap,DonViTinh.DonVi,GiaNhap from ChiTietHDNhap,DonViTinh,NguyenLieu where ChiTietHDNhap.MaNL=NguyenLieu.MaNL and ChiTietHDNhap.DVT = DonViTinh.MaDV and MaHD='"+ mahd +"'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable GetAllHD()
        {
            string sql = "Select * from HDNhap";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void UpdateItem(int sl,decimal gianhap,int dvt,int manl,string mahd)
        {
            string sql = string.Format("Update ChiTietHDNhap set SLNhap ={0},GiaNhap={1},DVT={2} where MaNL={3} and MaHD='{4}'",sl,gianhap,dvt,manl,mahd);
            db.ExecuteNonQuery(sql);
        }
        public void UpdateQuantity(int sl,int manl,string mahd)
        {
            string sql = string.Format("Update ChiTietHDNhap set SLNhap={0} where MaHD='{1}' and MaNL={2}", sl, mahd, manl);
            db.ExecuteNonQuery(sql);
        }
        public DataTable GetItemByID(string mahd)
        {
            string sql = "Select * from ChiTietHDNhap where MaHD='"+mahd+"'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public decimal GetTongtien(string mahd)
        {
            string sql = "Select SUM(GiaNhap*SLNhap) from ChiTietHDNhap where MaHD='"+mahd+"'";
            DataTable dt = db.Execute(sql);
            return decimal.Parse(dt.Rows[0][0].ToString());
        }

        public string AutoID()
        {
            string sql = "Select count(MaHDNhap)+1 from HDNhap";
            DataTable dt = db.Execute(sql);
            return "HDN0"+dt.Rows[0][0].ToString();
        }
        public void SaveHD(string mahd,string ngaynhap,decimal tongtien,int nguoilap)
        {
            string sql =string.Format("Update HDNhap set NgayNhap='{0}',TongTienNhap={1},NguoiLap={2} where MaHDNhap='{3}'",ngaynhap,tongtien,nguoilap,mahd);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteHD(string mahd)
        {
            string sql = "Delete from HDNhap where MaHDNhap='" + mahd + "'";
            string sql1 = "Delete from ChiTietHDNhap where MaHD='" + mahd + "'";
            db.ExecuteNonQuery(sql1);
            db.ExecuteNonQuery(sql);
        }
        public decimal GetPhiNL(string ngay1,string ngay2)
        {
            string sql = string.Format("Select SUM(TongTienNhap) from HDNhap where NgayNhap between '{0}' and '{1}'", ngay1, ngay2);
            DataTable dt = db.Execute(sql);
            return decimal.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable KTNgay(string ngay1, string ngay2)
        {
            string sql = string.Format("Select * from HDBanHang where NgayTao between '{0}' and '{1}'", ngay1, ngay2);
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
