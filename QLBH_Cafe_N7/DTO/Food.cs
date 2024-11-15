using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Food
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaBan { get; set; }
        public int MaLoai { get; set; }

        public Food(int maSP, string tenSP, float giaBan, int maLoai)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaBan = giaBan;
            this.MaLoai = maLoai;
        }

        public Food (DataRow row) 
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.GiaBan = (float)Convert.ToDouble(row["GiaBan"].ToString());
            this.MaLoai = (int)row["MaLoai"];
        }

    }
}
