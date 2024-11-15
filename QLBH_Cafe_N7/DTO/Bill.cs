using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Bill
    {
        public int MaHD {  get; set; }
        public DateTime? NgayBan { get; set; } //thêm dấu ? tức là kiểu dữ liệu này không thể null được
        public int MaBan { get; set; }
        public int TinhTrang { get; set; }

        public int GiamGia { get; set; }

        public Bill(int maHD, DateTime? ngayBan, int maBan, int tinhTrang, int giamGia = 0)
        {
            this.MaHD = maHD;
            this.NgayBan = ngayBan;
            this.MaBan = maBan;
            this.TinhTrang = tinhTrang;
            this.GiamGia = giamGia;
        }

        public Bill(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            var NgayBanCheck = row["NgayBan"];
            if(NgayBanCheck.ToString() != "")//có những th bị null (bản chất k null) trả về string dẻ kiểm tra rỗng
            {
                this.NgayBan = (DateTime?)NgayBanCheck;
            }            
            this.MaBan = (int)row["MaBan"];
            this.TinhTrang = (int)row["TinhTrang"];
            this.TinhTrang = (int)row["GiamGia"];
        }
    }
}
