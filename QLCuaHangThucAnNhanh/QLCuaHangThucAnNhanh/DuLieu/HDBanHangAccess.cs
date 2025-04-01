using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class HDBanHangAccess
    {
        Database db;
        public HDBanHangAccess()
        {
            db = new Database();
        }

        public DataTable CheckHD()
        {
            string sql = "Select MaHDBanHang from HDBanHang where TrangThai=N'Đang tạo' or TrangThai=N'Đang chỉnh sửa'";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public string GetMaHD()
        {
            string sql = "Select Max(MaHDBanHang) from HDBanHang";
            DataTable dt = db.Execute(sql);
            return dt.Rows[0][0].ToString();
        }
        public DataTable GetHDbyID(string mahd)
        {
            string sql = "Select * from HDBanHang,NhanVien,KhachHang,Ban where MaHDBanHang='" + mahd + "' and HDBanHang.MaNV=NhanVien.MaNV and HDBanHang.MaKH=KhachHang.MaKH and HDBanHang.MaBan=Ban.MaBan";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void CreateHD(string mahd)
        {
            string sql = string.Format("Insert Into HDBanHang values('{0}',null,null,null,null,null,null)", mahd);
            db.ExecuteNonQuery(sql);
        }
        public void InsertHDItem(string mahd, int mamon, int sl)
        {
            string sql = string.Format("Insert Into ChiTietHDBanHang values('{0}',{1},{2})", mahd, mamon, sl);
            db.ExecuteNonQuery(sql);
        }
        public void deleteItem(int mamon, string mahd)
        {
            string sql = string.Format("Delete from ChiTietHDBanHang where MaMon={0} and MaHD='{1}'", mamon, mahd);
            db.ExecuteNonQuery(sql);
        }
        public DataTable getItem(string mahd)
        {
            string sql = "Select MaHD,ChiTietHDBanHang.MaMon,TenMon,SLMon,GiaMon from ChiTietHDBanHang,MonAn where ChiTietHDBanHang.MaMon=MonAn.MaMon and MaHD='" + mahd + "'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable GetAllHD()
        {
            string sql = "Select * from HDBanHang";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void UpdateItem(int sl,int mamon, string mahd)
        {
            string sql = string.Format("Update ChiTietHDBanHang set SLMon ={0} where MaMon={1} and MaHD='{2}'", sl,mamon, mahd);
            db.ExecuteNonQuery(sql);
        }
        public DataTable GetItemByID(string mahd)
        {
            string sql = "Select * from ChiTietHDBanHang where MaHD='" + mahd + "'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public decimal GetTongtien(string mahd)
        {
            string sql = "Select SUM(SLMon*GiaMon) from ChiTietHDBanHang,MonAn where ChiTietHDBanHang.MaMon=MonAn.MaMon and MaHD='" + mahd + "'";
            DataTable dt = db.Execute(sql);
            return decimal.Parse(dt.Rows[0][0].ToString());
        }
        public string AutoID()
        {
            string sql = "Select count(MaHDBanHang)+1 from HDBanHang";
            DataTable dt = db.Execute(sql);
            return "HD0" + dt.Rows[0][0].ToString();
        }
        public void SaveHD(string mahd, string ngaytao, decimal thanhtien, int manv,int makh,int maban,decimal giamgia)
        {
            string sql = string.Format("Update HDBanHang set NgayTao='{0}',ThanhTien={1},MaNV={2},MaKH={3},MaBan={4},GiamGia={5} where MaHDBanHang='{6}'",ngaytao,thanhtien,manv,makh,maban,giamgia,mahd);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteHD(string mahd)
        {
            string sql = "Delete from HDBanHang where MaHDBanHang='" + mahd + "'";
            string sql1 = "Delete from ChiTietHDBanHang where MaHD='" + mahd + "'";
            db.ExecuteNonQuery(sql1);
            db.ExecuteNonQuery(sql);
        }
        public decimal GetDoanhThu(string ngay1,string ngay2)
        {
            string sql = string.Format("Select SUM(ThanhTien) from HDBanHang where NgayTao between '{0}' and '{1}'",ngay1,ngay2);
            string sql1 = string.Format("Select SUM(GiamGia) from HDBanHang where NgayTao between '{0}' and '{1}'",ngay1,ngay2);
            DataTable dt = db.Execute(sql);
            DataTable dt1 = db.Execute(sql1);
            decimal doanhthu = decimal.Parse(dt.Rows[0][0].ToString()) - decimal.Parse(dt1.Rows[0][0].ToString());
            return doanhthu;
        }
        public DataTable KTNgay(string ngay1,string ngay2)
        {
            string sql = string.Format("Select * from HDBanHang where NgayTao between '{0}' and '{1}'", ngay1, ngay2);
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
