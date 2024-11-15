using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Cafe_N7.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBH_Cafe_N7.DAO
{
    internal class Ban
    {
        KetNoiCSDL kncsdl;

        public Ban()
        {
            kncsdl = new KetNoiCSDL();
        }

        public static int tablewidth = 145;
        public static int tableheight = 145;


        // Load danh sách table
        public List<Table> LoadTableList()
        {
            List<Table> tblist = new List<Table>();

            string sql = "SELECT * FROM Ban";            
            DataTable dt = kncsdl.ReadData(sql);

            foreach(DataRow dr in dt.Rows)
            {
                Table tb = new Table(dr);
                tblist.Add(tb);
            }
            return tblist;
        }

        //lấy toàn bộ dl bảng Ban
        public DataTable getAllTbale()
        {
            string sql = "SELECT * FROM Ban";

            return kncsdl.ReadData(sql);
        }

        //thêm sách
        public void createTable(string ten, string tt)
        {
            string sql = "INSERT INTO Ban (TenBan, TinhTrang) VALUES (@TenBan, @TinhTrang)";//truyền vào tham số (paramester dấu hiệu @ tránh ng dùng nhập vào lệnh tác động loại bỏ csdl)
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@TenBan", ten),
                new SqlParameter("@TinhTrang", tt),
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }

        //sửa sách
        public void editTable(int ma, string ten, string tt)
        {
            string sql = "UPDATE Ban SET TenBan = @TenBan, TinhTrang = @TinhTrang WHERE MaBan = @MaBan";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaBan", ma),
                new SqlParameter("@TenBan", ten),
                new SqlParameter("@TinhTrang", tt),
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }

        //xóa sách
        public void deleteTable(string ma)
        {
            string sql = "DELETE FROM Ban WHERE MaBan = @MaBan";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaBan", ma),
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }

        //tìm kiếm sách
        public DataTable searchTable(string keyword)
        {
            string sql = "SELECT * FROM Ban WHERE MaBan LIKE @Keyword OR TenBan LIKE @Keyword OR TinhTrang LIKE @Keyword";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%"),
            };
            return kncsdl.ReadData(sql, sqlParameter);
        }
    }
}
