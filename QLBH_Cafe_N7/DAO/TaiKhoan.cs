using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DAO
{    
    internal class TaiKhoan
    {
        KetNoiCSDL kncsdl;

        public TaiKhoan()
        {
            kncsdl = new KetNoiCSDL();
        }
        public bool Login(string userName, string passWord)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDN = @TenDN AND MK = @MK";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@TenDN", userName),
                new SqlParameter("@MK", passWord),
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);
            return  dt.Rows.Count > 0 ;
        }
    }
}
