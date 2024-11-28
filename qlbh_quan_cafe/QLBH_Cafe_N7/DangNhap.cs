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
    public partial class DangNhap : Form
    {
        private TaiKhoan taiKhoan = new TaiKhoan(); // Khai báo đối tượng TaiKhoan
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyBanHang qlbh = new QuanLyBanHang();
            string userName = txtTenDN.Text;
            string passWord = txtMK.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
            }
            else
            {
                if (taiKhoan.Login(userName, passWord)) // Gọi phương thức Login của lớp TaiKhoan
                {
                    this.Hide();
                    qlbh.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng vui lòng nhập lại");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
