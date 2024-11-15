using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Category
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public Category(int maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }

        public Category (DataRow row)
        {
            this.MaLoai = (int)row["MaLoai"];
            this.TenLoai = row["TenLoai"].ToString();
        }
    }
}
