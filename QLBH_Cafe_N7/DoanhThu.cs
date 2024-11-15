using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Cafe_N7.DAO;

namespace QLBH_Cafe_N7
{
    public partial class DoanhThu : Form
    {
        private HoaDon hd = new HoaDon();
        public DoanhThu()
        {
            InitializeComponent();
        }

        void LoadListHD(DateTime ngayBan)
        {
           dgvDoanhThu.DataSource = hd.getHDListByDate(ngayBan);
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            LoadListHD(dtpNgayBan.Value);
        }
    }
}
