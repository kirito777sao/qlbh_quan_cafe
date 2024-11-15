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
    public class MenuDAO
    {
        KetNoiCSDL kncsdl;

        public MenuDAO()
        {
            kncsdl = new KetNoiCSDL();
        }

        public List<Menu> getListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string sql = "SELECT sp.TenSP, cthd.SoLuong, sp.GiaBan, sp.GiaBan*cthd.SoLuong AS ThanhTien FROM ChiTietHD AS cthd, HD AS hd, SanPham AS sp\r\nWHERE cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP AND hd.TinhTrang = 0 AND hd.MaBan = @MaBan";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaBan", id)
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);

            foreach (DataRow dr in dt.Rows)
            {
                Menu menu = new Menu(dr);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }    
}
