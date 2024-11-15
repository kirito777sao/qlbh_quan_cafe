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
    public partial class BanAn : Form
    {
        Ban ban = new Ban();
        public BanAn()
        {
            InitializeComponent();
        }

        private void btThemBan_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Tên Bàn"); txtTenBan.Focus(); return; }            
            if (cbTinhTrangBan.Text.Trim() == "") { MessageBox.Show("Chưa Chọn Tình Trạng"); cbTinhTrangBan.Focus(); return; }           
            ban.createTable(txtTenBan.Text.Trim(), cbTinhTrangBan.Text);
            dgvBan.DataSource = ban.getAllTbale();
            ClearTexts();
            MessageBox.Show("Thêm Thành Công");
        }

        private void btSuaBan_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Tên Bàn"); txtMaBan.Focus(); return; }
            if (txtTenBan.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Tên Bàn"); txtTenBan.Focus(); return; }
            if (cbTinhTrangBan.Text.Trim() == "") { MessageBox.Show("Chưa Chọn Tình Trạng"); cbTinhTrangBan.Focus(); return; }
            ban.editTable(int.Parse(txtMaBan.Text.Trim()),txtTenBan.Text.Trim(), cbTinhTrangBan.Text);
            dgvBan.DataSource = ban.getAllTbale();
            ClearTexts();
            MessageBox.Show("Sửa Thành Công");
        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows == null) { return; }
            if (dgvBan.SelectedRows[0].Cells[0].Value == null) { return; }
            if (MessageBox.Show("Có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvBan.SelectedRows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    ban.deleteTable(ma);
                }
                dgvBan.DataSource = ban.getAllTbale();
                ClearTexts();
                MessageBox.Show("Xóa Thành Công");
            }
        }

        private void btXemBan_Click(object sender, EventArgs e)
        {
            dgvBan.DataSource = ban.getAllTbale();
        }

        private void btTimBan_Click(object sender, EventArgs e)
        {
            DataTable dt = ban.searchTable(txtTimBan.Text);
            if (dt != null)
            {
                dgvBan.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Bàn!", "Thông báo");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void ClearTexts()
        {
            txtMaBan.Clear();
            txtTenBan.Clear();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //chỉ số của hàng ddang chọn 
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dgvBan.Rows[i];
                txtMaBan.Text = r.Cells[0].Value.ToString();
                txtTenBan.Text = r.Cells[1].Value.ToString();
                cbTinhTrangBan.Text = r.Cells[2].Value.ToString();
            }
        }
    }
}
