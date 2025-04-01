using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class NhanVienAccess
    {
        Database db;
        public NhanVienAccess()
        {
            db = new Database();
        }

        public DataTable getData()
        {
            string sql = "Select MaNV,TenNV,DienThoaiNV,DiaChiNV,NgaySinh,GioiTinhNV,TenCV from NhanVien,ChucVu Where NhanVien.ChucVu=ChucVu.MaCV";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void InsertNV(string ten,string dienthoai,string diachi,string ngaysinh,string gioitinh,int chucvu)
        {
            string sql =string.Format("Insert into NhanVien Values(N'{0}','{1}',N'{2}','{3}',N'{4}',N'{5}')",ten,dienthoai,diachi,ngaysinh,gioitinh,chucvu);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteNV(int idnv)
        {
            string sql = "Delete from NhanVien where MaNV ="+idnv;
            db.ExecuteNonQuery(sql);
        }
        public void UpdateNV(string ten, string dienthoai, string diachi, string ngaysinh,string gioitinh ,int chucvu,int idnv)
        {
            string sql = string.Format("Update NhanVien set TenNV=N'{0}',DienThoaiNV='{1}',DiaChiNV=N'{2}',NgaySinh='{3}',GioiTinhNV=N'{4}',ChucVu=N'{5}' Where MaNV = {6}", ten, dienthoai, diachi, ngaysinh,gioitinh,chucvu,idnv);
            db.ExecuteNonQuery(sql);
        }
        public DataTable TimKiem(string tennv)
        {
            string sql = "Select * from NhanVien where TenNV Like N'%" + tennv + "%'";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
