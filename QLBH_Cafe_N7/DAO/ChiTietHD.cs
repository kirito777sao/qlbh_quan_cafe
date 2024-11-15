using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Cafe_N7.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBH_Cafe_N7.DAO
{
    internal class ChiTietHD
    {
        KetNoiCSDL kncsdl;
        public ChiTietHD()
        {
            kncsdl = new KetNoiCSDL();

        }

        public List<Billinfo> getListChiTietHD(int id)
        {
            List<Billinfo> listChiTietHD = new List<Billinfo>();

            string sql = "SELECT * FROM ChiTietHD WHERE MaHD = @MaHD";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaHD", id)
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);

            foreach (DataRow dr in dt.Rows)
            {
                Billinfo info = new Billinfo(dr);
                listChiTietHD.Add(info);
            }

            return listChiTietHD;
        }

        // Có 3 th có thể xảy ra :
        //- Nếu bàn lấy bill , bill k có thì phải tạo bill ms dựa vào bàn rồi insert billinfo vào
        //- Nếu bàn đã có bill thì chỉ cần billinfo với th food chưa tồn tại
        //- Nếu bàn đã có bill và có food thì cập nhật sl food
        public void InsertCTHD(int idBill, int idFood, int count)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@idBill", idBill),
                    new SqlParameter("@idFood", idFood),
                    new SqlParameter("@count", count)
                };

                kncsdl.CreateUpdateDelete("USP_InsertBillInfo", sqlParameters, CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }

    }
}
