using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Cafe_N7.DAO
{    
    internal class Taikhoan
    {
        KetNoiCSDL kncsdl;

        public Taikhoan()
        {
            kncsdl = new KetNoiCSDL();
        }
        public bool Login(string userName, string passWord)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDN = @TenDN AND MK = @MK";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@TenDN", userName),
                new SqlParameter("@MK", passWord),
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);
            return  dt.Rows.Count > 0 ;
        }
        bool check(string tendn, string tennv, string mk, string loai)
        {
            if (tendn == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                return false;
            }
            if (tennv == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên!");
                return false;
            }
            if (mk == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                return false;
            }
            if (loai == "")
            {
                MessageBox.Show("Chưa nhập loại tài khoản!");
                return false;
            }
            return true;
        }
        public DataTable GetAllTK()
        {
            string sql = "select * from TaiKhoan";
            return kncsdl.ReadData(sql);
        }
        public DataTable GetSomeTK(string tendn)
        {
            string sql = "select * from TaiKhoan TenDN = @tendn";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@tendn",tendn)
            };
            return kncsdl.ReadData(sql, sp);
        }
        public void CreateTK(string tendn, string tennv, string mk, string loai)
        {
            if (check(tendn, tennv, mk, loai))
            {
                string sql = "INSERT INTO TaiKhoan values(@tendn,@tennv,@mk,@loai)";
                SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@tendn", tendn),
                new SqlParameter("@tennv", tennv),
                new SqlParameter("@mk", mk),
                new SqlParameter("@loai", loai)
                };
                kncsdl.CreateUpdateDelete(sql, sp);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }

        }
        public void DeleteTK(string tendn)
        {
            string sql = "DELETE FROM TaiKhoan WHERE TenDN = @tendn";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@tendn",tendn)
            };
            kncsdl.CreateUpdateDelete(sql, sp);
        }
        public void UpdateTK(string tendn, string tennv, string mk, string loai)
        {
            if (check(tendn, tennv, mk, loai))
            {
                string sql = "UPDATE TaiKhoan SET TenNV = @tennv, MK = @mk, Loai = @loai WHERE TenDN = @tendn";
                SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@tendn", tendn),
            new SqlParameter("@tennv", tennv),
            new SqlParameter("@mk", mk),
            new SqlParameter("@loai", loai)
            };
                kncsdl.CreateUpdateDelete(sql, sp);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }
        public bool Isvalid_TK(string tendn)
        {
            string sql = "select * from TaiKhoan where TenDN = @tendn";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@tendn",tendn)
            };
            if (kncsdl.ReadData(sql, sp) != null)
            {
                return true;
            }
            return false;
        }
    }
}
