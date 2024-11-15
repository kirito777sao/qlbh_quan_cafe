using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Cafe_N7.DTO;

namespace QLBH_Cafe_N7.DAO
{
    public class SanPham
    {
        KetNoiCSDL kncsdl;

        public SanPham() 
        {
            kncsdl = new KetNoiCSDL();
        }

        public List<Food> getFoodByCategoryID(int id)
        {
            List<Food> listSP = new List<Food>();

            string sql = "SELECT * FROM SanPham WHERE MaLoai = @MaLoai";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaLoai", id)
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);

            foreach (DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                listSP.Add(food);
            }

            return listSP;
        }
    }
}
