using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Cafe_N7.DAO
{
    internal class Nguyenlieu
    {
        KetNoiCSDL kncsdl;
        public Nguyenlieu()
        {
            kncsdl = new KetNoiCSDL();

        }
        bool check(string manl, string tennl, string sl, string hsd, string tenncc, string gianhap, string maloai)
        {
            if (manl == "")
            {
                MessageBox.Show("Chưa nhập mã nguyên liệu!");
                return false;
            }
            if (tennl == "")
            {
                MessageBox.Show("Chưa nhập tên nguyên liệu!");
                return false;
            }
            if (sl == "")
            {
                MessageBox.Show("Chưa nhập số lượng!");
                return false;
            }

            if (tenncc == "")
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp!");
                return false;
            }

            if (gianhap == "")
            {
                MessageBox.Show("Chưa nhập giá nhập!");
                return false;
            }
            if (hsd == "")
            {
                MessageBox.Show("Chưa nhập hạn sử dụng!");
                return false;
            }
            if (maloai == "")
            {
                MessageBox.Show("Chưa nhập mã loại!");
                return false;
            }
            return true;

        }
        public DataTable GetAllNL()
        {
            string sql = "select * from NguyenLieu";
            return kncsdl.ReadData(sql);
        }

        public DataTable GetSomeNL(string manl)
        {
            string sql = "select * from NguyenLieu where MaNL=@ma";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@ma",manl)
            };
            return kncsdl.ReadData(sql, sp);
        }
        public bool Isvalid_NL(string manl)
        {
            string sql = "select * from NguyenLieu where MaNL=@manl";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@manl",manl)
            };
            if (kncsdl.ReadData(sql, sp).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void CreateNL(string manl, string tennl, string sl, string hsd, string tenncc, string gianhap, string maloai)
        {
            if (check(manl, tennl, sl, hsd, tenncc, gianhap, maloai))
            {
                string sql = "INSERT INTO NguyenLieu VALUES(@manl, @tennl, @sl, @hsd, @tenncc, @gianhap, @maloai)";
                SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@manl", manl),
                new SqlParameter("@tennl", tennl),
                new SqlParameter("@sl", sl),
                new SqlParameter("@hsd", hsd),
                new SqlParameter("@tenncc", tenncc),
                new SqlParameter("@gianhap", gianhap),
                 new SqlParameter("@maloai", maloai),
                };
                kncsdl.CreateUpdateDelete(sql, sp);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm ko thành công!");
            }

        }
        public void DeleteNL(string manl)
        {
            string sql = "delete NguyenLieu where MaNL = @manl";
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@manl",manl)
            };
            kncsdl.CreateUpdateDelete(sql, sp);
        }
        public void UpdateNL(string manl, string tennl, string sl, string hsd, string tenncc, string gianhap, string maloai)
        {

            string sql = "UPDATE NguyenLieu SET TenNL = @tennl, SLTon = @sl,HanSD = @hsd, TenNCC = @tenncc, GiaNhap = @gianhap, MaLoai = @maloai " +
            " WHERE MaNl = @manl;";
            SqlParameter[] sp = new SqlParameter[] {
                    new SqlParameter("@manl", manl),
                    new SqlParameter("@tennl", tennl),
                    new SqlParameter("@sl", sl),
                    new SqlParameter("@hsd", hsd),
                    new SqlParameter("@tenncc",tenncc),
                    new SqlParameter("@gianhap",gianhap),
                    new SqlParameter("@maloai",maloai)
                };
            kncsdl.CreateUpdateDelete(sql, sp);
        }
    }
}

