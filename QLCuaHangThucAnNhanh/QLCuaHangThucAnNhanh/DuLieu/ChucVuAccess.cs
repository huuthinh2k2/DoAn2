using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class ChucVuAccess
    {
        Database db;
        public ChucVuAccess()
        {
            db = new Database();
        }

        public DataTable GetData()
        {
            string sql = "Select * from ChucVu";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void InsertCV(string tencv)
        {
            string sql = string.Format("Insert into ChucVu values(N'{0}')", tencv);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteCV(int idcv)
        {
            string sql = string.Format("Delete from ChucVu Where MaCV={0}", idcv);
            db.ExecuteNonQuery(sql);
        }
        public void UpdateCV(string tencv,int idcv)
        {
            string sql = string.Format("Update ChucVu set TenCV=N'{0}' Where MaCV={1}", tencv, idcv);
            db.ExecuteNonQuery(sql);
        }
    }
}
