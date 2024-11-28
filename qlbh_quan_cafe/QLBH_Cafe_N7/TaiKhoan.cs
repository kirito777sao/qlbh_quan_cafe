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
    public partial class TaiKhoan : Form
    {
        Taikhoan tk = new Taikhoan();
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (txtTendn.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtTendn.Focus();
                return;
            }
            if (txtTennv.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên!");
                txtTennv.Focus();
                return;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMK.Focus();
                return;

            }
            if (txtloaitk.Text == "")
            {
                MessageBox.Show("Chưa nhập loại tài khoản!");
                txtloaitk.Focus();
                return;
            }
            if (!tk.Isvalid_TK(txtTendn.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                txtTendn.Focus();
                return;
            }
            else
            {
                tk.CreateTK(txtTendn.Text, txtTennv.Text, txtMK.Text, txtloaitk.Text);
                DuaDLVaoBang();
                ClearTexts();
            }
        }
            void ClearTexts()
            {
                txtTendn.Clear();
                txtTennv.Clear();
                txtMK.Clear();
                txtloaitk.Clear();
            }
            void DuaDLVaoBang()
            {
                dtgTaikhoan.DataSource = tk.GetAllTK();
            }
        
        private void dtgTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dtgTaikhoan.Rows[i];
                txtTendn.Text = r.Cells[0].Value.ToString().Trim();
                txtTennv.Text = r.Cells[1].Value.ToString();
                txtMK.Text = r.Cells[2].Value.ToString();
                txtloaitk.Text = r.Cells[3].Value.ToString();
            }

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtTendn.Text = string.Empty;
            txtTennv.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtloaitk.Text = string.Empty;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

            if (dtgTaikhoan.SelectedRows == null) return;
            if (dtgTaikhoan.SelectedRows[0].Cells[0].Value == null) return;
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in dtgTaikhoan.SelectedRows)
                {
                    string tendn = r.Cells[0].Value.ToString();
                    tk.DeleteTK(tendn);
                }
                DuaDLVaoBang();
                ClearTexts();
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {

            if (!tk.Isvalid_TK(txtTendn.Text.Trim()))
            {
                tk.UpdateTK(txtTendn.Text, txtTennv.Text, txtMK.Text, txtloaitk.Text);
                DuaDLVaoBang();
                ClearTexts();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                if (MessageBox.Show("Không tồn tại khách hàng nào có mã như vậy, có muốn thêm không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    btnThemTK_Click(sender, e);
                }
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafeDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyQuanCafeDataSet.TaiKhoan);
            DuaDLVaoBang();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NguyenLieu nl = new NguyenLieu();
            nl.ShowDialog();
        }
    }
}
