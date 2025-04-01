using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangThucAnNhanh.DuLieu
{
    public class BanAccess
    {
        Database db;
        public BanAccess()
        {
            db = new Database();
        }

        public DataTable GetData()
        {
            string sql = "Select * from Ban";
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
