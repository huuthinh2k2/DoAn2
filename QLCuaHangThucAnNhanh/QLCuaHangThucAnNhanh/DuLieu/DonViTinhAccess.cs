using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class DonViTinhAccess
    {
        Database db;
        public DonViTinhAccess()
        {
            db = new Database();
        }

        public DataTable GetData()
        {
            string sql = "Select * from DonViTinh";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
