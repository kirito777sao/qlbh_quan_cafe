using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DTO
{
    public class Table
    {
        public int MaBan { get; set; }
        public string TenBan {  get; set; }
        public string TinhTrang { get; set; }

        public Table(int id, string name, string status)
        {
            this.MaBan = id;
            this.TenBan = name;
            this.TinhTrang = status;
        }

        public Table (DataRow row)
        {
            this.MaBan = (int)row["MaBan"];
            this.TenBan = row["TenBan"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
        }
    }
}
