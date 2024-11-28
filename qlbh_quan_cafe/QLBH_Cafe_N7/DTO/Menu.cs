using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Menu
    {
        public string TenMon {  get; set; }
        public int SoLuong { get; set; }
        public float GiaBan { get; set; }
        public float ThanhTien { get; set; }

        public Menu(string tenMon, int soLuong, float gia, float thanhTien)
        {
            this.TenMon = tenMon;
            this.SoLuong = soLuong;
            this.GiaBan = gia;
            this.ThanhTien = thanhTien;
        }

        public Menu(DataRow row)
        {
            this.TenMon = row["TenSP"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.GiaBan = (float)Convert.ToDouble(row["GiaBan"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString());
        }
    }
}
