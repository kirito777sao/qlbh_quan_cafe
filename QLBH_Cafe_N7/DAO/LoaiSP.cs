using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Cafe_N7.DTO;

namespace QLBH_Cafe_N7.DAO
{
    public class LoaiSP
    {
        KetNoiCSDL kncsdl;

        public LoaiSP()
        {
            kncsdl = new KetNoiCSDL();
        }

        public List<Category> getListCategory()
        {
            List<Category> listLoaiSP = new List<Category>();

            string sql = "SELECT * FROM LoaiSP";
            
            DataTable dt = kncsdl.ReadData(sql);

            foreach (DataRow dr in dt.Rows)
            {
                Category category = new Category(dr);
                listLoaiSP.Add(category);
            }

            return listLoaiSP;
        }
    }
}
