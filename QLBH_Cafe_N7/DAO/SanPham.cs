using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Cafe_N7.DTO;

namespace QLBH_Cafe_N7.DAO
{
    public class SanPham
    {
        KetNoiCSDL kncsdl;

        public SanPham() 
        {
            kncsdl = new KetNoiCSDL();
        }

        public List<Food> getFoodByCategoryID(int id)
        {
            List<Food> listSP = new List<Food>();

            string sql = "SELECT * FROM SanPham WHERE MaLoai = @MaLoai";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaLoai", id)
            };
            DataTable dt = kncsdl.ReadData(sql, sqlParameter);

            foreach (DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                listSP.Add(food);
            }

            return listSP;
        }
        public DataTable GetAllSP()
        {
            string sql = "SELECT * FROM SanPham";
            return kncsdl.ReadData(sql);
        }
        public void CreateSP(string MaSP, string TenSP, string GiaBanSP, string LoaiSP)
        {
            string sql = "INSERT INTO SanPham (TenSP, GiaBan, MaLoai) VALUES (@TenSP, @GiaBan, @MaLoai)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@GiaBan", GiaBanSP),
                new SqlParameter("@MaLoai", LoaiSP)
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }
        //Update
        public void UpdateSP(string MaSP, string TenSP, string GiaBanSP, string LoaiSP)
        {
            string sql = "UPDATE SanPham SET TenSP = @TenSP, GiaBan = @GiaBan, MaLoai = @MaLoai WHERE MaSP = @MaSP";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@GiaBan", GiaBanSP),
                new SqlParameter("@MaLoai", LoaiSP)
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }
        //Delete
        public void DeleteSP(string MaSP)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaSP", MaSP)
            };
            kncsdl.CreateUpdateDelete(sql, sqlParameter);
        }
        //Search
        public DataTable SearchSP(string keyword)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSP LIKE @Keyword OR TenSP LIKE @Keyword OR GiaBan LIKE @Keyword OR MaLoai LIKE @Keyword";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%"), // Sử dụng dấu % để tìm kiếm phần trùng khớp
            };
            return kncsdl.ReadData(sql, sqlParameter);
        }
        public DataTable GetLoaiSP(string maLoai)
        {
            string sql = @"
        SELECT 
            sp.MaSP, 
            sp.TenSP, 
            sp.GiaBan, 
            lsp.TenLoai
        FROM 
            SanPham sp
        INNER JOIN 
            LoaiSP lsp 
        ON 
            sp.MaLoai = lsp.MaLoai
        WHERE 
            lsp.MaLoai = @MaLoai";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@MaLoai", maLoai)
            };
            return kncsdl.ReadData(sql, sqlParameter);
        }
    }
}
