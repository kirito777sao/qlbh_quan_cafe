using QLBH_Cafe_N7.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Cafe_N7
{
	public partial class QuanLyNhanVien : Form
	{
		NhanVien nv = new NhanVien();
		public QuanLyNhanVien()
		{
			InitializeComponent();
			dgv_nhanvien.DataSource = nv.getAllNhanVien();
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (txt_hoten.Text == "") { MessageBox.Show("Chưa Nhập Họ và tên"); txt_hoten.Focus(); return; }
			if (txt_chucvu.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Chức vụ"); txt_chucvu.Focus(); return; }
			if (txt_sdt.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Điện Thoại"); txt_sdt.Focus(); return; }
			if (dtp_ngaysinh.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Ngày Sinh"); dtp_ngaysinh.Focus(); return; }
			if (txt_diachi.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Lượng"); txt_diachi.Focus(); return; }

			nv.createNhanVien( txt_hoten.Text, txt_chucvu.Text, dtp_ngaysinh.Text, txt_diachi.Text,  txt_sdt.Text);
			dgv_nhanvien.DataSource = nv.getAllNhanVien();
			MessageBox.Show("Thêm Thành Công");
		}

		private void btn_sua_Click(object sender, EventArgs e) 
		{
			if (txt_hoten.Text == "") { MessageBox.Show("Chưa Nhập Họ và tên"); txt_hoten.Focus(); return; }
			if (txt_chucvu.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Chức vụ"); txt_chucvu.Focus(); return; }
			if (txt_sdt.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Điện Thoại"); txt_sdt.Focus(); return; }
			if (dtp_ngaysinh.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Ngày Sinh"); dtp_ngaysinh.Focus(); return; }
			if (txt_diachi.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Số Lượng"); txt_diachi.Focus(); return; }

			nv.editNhanVien(int.Parse(txt_ma.Text), txt_hoten.Text, txt_chucvu.Text, dtp_ngaysinh.Text, txt_diachi.Text, txt_sdt.Text);
			dgv_nhanvien.DataSource = nv.getAllNhanVien();
			MessageBox.Show("Sửa Thành Công");
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (dgv_nhanvien.SelectedRows == null) { return; }
			if (MessageBox.Show("Có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				nv.deleteNhanVien(txt_ma.Text);	
				dgv_nhanvien.DataSource = nv.getAllNhanVien();
				ClearTexts();
				MessageBox.Show("Xóa Thành Công");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			DataTable dt = nv.searchNhanVien(txt_timkiem.Text);
			if (dt != null)
			{
				dgv_nhanvien.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo");
			}
		}
		void ClearTexts()
		{
			txt_ma.Clear();
			txt_hoten.Clear();
			txt_chucvu.Clear();
			txt_sdt.Clear();
			txt_diachi.Clear();
			txt_timkiem.Clear();
		}

		private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex; //chỉ số của hàng ddang chọn 
			if (i >= 0)
			{
				DataGridViewRow r = new DataGridViewRow();
				r = dgv_nhanvien.Rows[i];
				txt_ma.Text = r.Cells[0].Value.ToString();
				txt_hoten.Text = r.Cells[1].Value.ToString();
				txt_chucvu.Text = r.Cells[2].Value.ToString();
				dtp_ngaysinh.Text = r.Cells[3].Value.ToString();
				txt_diachi.Text = r.Cells[4].Value.ToString();
				txt_sdt.Text = r.Cells[5].Value.ToString();
			}
		}
	}
}
