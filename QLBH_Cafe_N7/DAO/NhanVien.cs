using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Cafe_N7.DAO
{
	public class NhanVien
	{

		KetNoiCSDL kncsdl;

		public NhanVien() { kncsdl = new KetNoiCSDL(); }

		public DataTable getAllNhanVien()
		{
			string sql = "SELECT * FROM NhanVien";

			return kncsdl.ReadData(sql);
		}

		public void createNhanVien(string ten, string cv, string ns, string dc, string sdt)
		{
			string sql = "INSERT INTO NhanVien ( TenNV, Chucvu, NgaySinh, DiaChi, SoDienThoai) VALUES (@TenNV, @Chucvu, @NgaySinh, @DiaChi,@SoDienThoai)";//truyền vào tham số (paramester dấu hiệu @ tránh ng dùng nhập vào lệnh tác động loại bỏ csdl)
			SqlParameter[] sqlParameter = new SqlParameter[]
			{
				new SqlParameter("@TenNV", ten),
				new SqlParameter("@Chucvu", cv),
				new SqlParameter("@NgaySinh", ns),
				new SqlParameter("@DiaChi", dc),
				new SqlParameter("@SoDienThoai", sdt),
			};
			kncsdl.CreateUpdateDelete(sql, sqlParameter);
		}

		public void editNhanVien(int ma, string ten, string cv, string ns,  string dc, string sdt)
		{
			string sql = "UPDATE NhanVien SET TenNV = @TenNV, Chucvu = @Chucvu, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaNV = @MaNV";
			SqlParameter[] sqlParameter = new SqlParameter[]
			{
				new SqlParameter("@MaNV", ma),
				new SqlParameter("@TenNV", ten),
				new SqlParameter("@Chucvu", cv),
				new SqlParameter("@NgaySinh", ns),
				new SqlParameter("@DiaChi", dc),
				new SqlParameter("@SoDienThoai", sdt),
			};
			kncsdl.CreateUpdateDelete(sql, sqlParameter);
		}

		public void deleteNhanVien(string ma)
		{
			string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
			SqlParameter[] sqlParameter = new SqlParameter[]
			{
				new SqlParameter("@MaNV", ma),
			};
			kncsdl.CreateUpdateDelete(sql, sqlParameter);
		}

		public DataTable searchNhanVien(string keyword)
		{
			string sql = "SELECT * FROM NhanVien WHERE MaNV LIKE @Keyword OR TenNV LIKE @Keyword OR SoDienThoai LIKE @Keyword OR NgaySinh LIKE @Keyword OR DiaChi LIKE @Keyword OR Chucvu LIKE @Keyword ";
			SqlParameter[] sqlParameter = new SqlParameter[]
			{
				new SqlParameter("@Keyword", "%" + keyword + "%"),
			};
			return kncsdl.ReadData(sql, sqlParameter);
		}
	}
}
