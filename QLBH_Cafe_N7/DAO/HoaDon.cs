using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Cafe_N7.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBH_Cafe_N7.DAO
{
    //có nhiệm vụ lấy HD từ id-table
    public class HoaDon
    {
        KetNoiCSDL kncsdl;

        public HoaDon()
        {
            kncsdl = new KetNoiCSDL();
        }

        public int getHDByTableID(int id)
        {
            string sql = "SELECT * FROM HD WHERE MaBan = @MaBan AND TinhTrang = 0";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaBan", id),
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);

            if (dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.MaBan; // lấy mã bàn của bill
            }

            return -1;
        }

        public void InsertHD(int id)
        {
            string sql = "INSERT INTO HD (NgayBan, MaBan, TinhTrang, GiamGia) VALUES (GETDATE(), @MaBan, 0, 0)";//truyền vào tham số (paramester dấu hiệu @ tránh ng dùng nhập vào lệnh tác động loại bỏ csdl)
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaBan", id),
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }

        public void checkOut(int id, int giamGia, float tongTien)
        {
            string sql = "UPDATE HD SET TinhTrang = 1, GiamGia = @GiamGia, TongTien = @TongTien WHERE MaHD = @MaHD";//truyền vào tham số (paramester dấu hiệu @ tránh ng dùng nhập vào lệnh tác động loại bỏ csdl)
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaHD", id),
                new SqlParameter("@GiamGia", giamGia),
                new SqlParameter("@TongTien", tongTien),
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }

        public DataTable getHDListByDate(DateTime ngayBan)
        {
            string sql = "SELECT b.TenBan AS [Tên Bàn], NgayBan AS [Ngày Bán], GiamGia [Giảm Giá (%)], hd.TongTien AS [Tổng Tiền]" +
                "\r\nFROM HD AS hd, ChiTietHD AS cthd, Ban AS b, SanPham AS sp\r\nWHERE NgayBan = '20231219' AND hd.TinhTrang = 1 AND b.MaBan = hd.MaBan" +
                "\r\nAND cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP\r\n";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@NgayBan", ngayBan),
            };
            return kncsdl.ReadData(sql);
        }

        public int getMaxBill()
        {
            try
            {
                string sql = "SELECT MAX(MaHD) FROM HD";
                DataTable dt = kncsdl.ReadData(sql); // Đọc dữ liệu vào DataTable

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value) // Kiểm tra xem có dữ liệu và không phải NULL
                {
                    return Convert.ToInt32(dt.Rows[0][0]); // Chuyển đổi giá trị sang int
                }
                else
                {
                    return 1; // Trả về 1 nếu không có hóa đơn nào
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ: ghi log lỗi
                MessageBox.Show("Lỗi: " + ex.Message); // Hoặc cách xử lý lỗi khác
                return 1; // Hoặc trả về một giá trị mặc định khác
            }
        }
    }
}
