using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Billinfo
    {
        public int MaHD {  get; set; }
        public int MaSP { get; set; }
        public int SL { get; set; }

        public Billinfo(int maHD, int maSP, int sL)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SL = sL;
        }

        public Billinfo (DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.MaSP = (int)row["MaSP"];
            this.SL = (int)row["SoLuong"];
        }
    }
}
