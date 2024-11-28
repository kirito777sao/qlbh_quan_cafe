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
    public partial class NguyenLieu : Form
    {
        Nguyenlieu nl = new Nguyenlieu();
        public NguyenLieu()
        {
            InitializeComponent();
        }
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        void ClearTexts()
        {
            txtMaNL.Clear();
            txtTenNL.Clear();
            txtSL.Clear();
            dtphsd.Text = null;
            txtTenNCC.Clear();
            txtgianhap.Clear();
            txtmaloai.Clear();
        }
        void DuaDLVaoBang()
        {
            dtgNguyenlieu.DataSource = nl.GetAllNL();

        }
        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafeDataSet1.NguyenLieu' table. You can move, or remove it, as needed.
            this.nguyenLieuTableAdapter.Fill(this.quanLyQuanCafeDataSet1.NguyenLieu);
            DuaDLVaoBang();
        }

        private void btThemNL_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã!");
                txtMaNL.Focus();
                return;
            }
            if (txtTenNL.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên!");
                txtTenNL.Focus();
                return;
            }
            if (txtSL.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng!");
                txtSL.Focus();
                return;
            }
            if (txtgianhap.Text == "")
            {
                MessageBox.Show("Chưa nhập giá nhập!");
                txtgianhap.Focus();
                return;
            }
            if (dtphsd == null)
            {
                MessageBox.Show("Chưa nhập hạn sử dụng!");
                dtphsd.Focus();
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp!");
                txtTenNCC.Focus();
                return;
            }
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Chưa nhập mã loại!");
                txtmaloai.Focus();
                return;
            }
            if (!nl.Isvalid_NL(txtMaNL.Text.Trim()))
            {
                MessageBox.Show("Mã nguyên liệu đã tồn tại");
                txtMaNL.Focus();
                return;
            }
            else
            {
                nl.CreateNL(txtMaNL.Text, txtTenNL.Text, txtgianhap.Text, txtSL.Text, dtphsd.Text, txtTenNCC.Text, txtmaloai.Text);
                DuaDLVaoBang();
                ClearTexts();
            }
        }

        private void btsuanl_Click(object sender, EventArgs e)
        {
            if (!nl.Isvalid_NL(txtMaNL.Text.Trim()))
            {
                nl.UpdateNL(txtMaNL.Text, txtTenNL.Text, txtgianhap.Text, txtSL.Text, dtphsd.Text, txtTenNCC.Text, txtmaloai.Text);
                DuaDLVaoBang();
                ClearTexts();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                if (MessageBox.Show("Không tồn tại nguyên liệu nào có mã như vậy, có muốn thêm không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    btThemNL_Click(sender, e);
                }

            }
        }

        private void dtgNguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;//Chỉ số của hàng đang chọn
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dtgNguyenlieu.Rows[i];
                txtMaNL.Text = r.Cells[0].Value.ToString();
                txtTenNL.Text = r.Cells[1].Value.ToString();
                txtgianhap.Text = r.Cells[2].Value.ToString();
                txtSL.Text = r.Cells[3].Value.ToString();
                dtphsd.Text = r.Cells[4].Value.ToString();
                txtTenNCC.Text = r.Cells[5].Value.ToString();
                txtmaloai.Text = r.Cells[6].Value.ToString();
            }
        }

        private void btxoanl_Click(object sender, EventArgs e)
        {
            if (dtgNguyenlieu.SelectedRows == null) return;
            if (dtgNguyenlieu.SelectedRows[0].Cells[0].Value == null) return;
            if (MessageBox.Show("Chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in dtgNguyenlieu.SelectedRows)
                {
                    string ma = r.Cells[0].Value.ToString();
                    nl.DeleteNL(ma);
                }
                DuaDLVaoBang();
                ClearTexts();
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txtMaNL.Text = string.Empty;
            txtTenNL.Text = string.Empty;
            txtSL.Text = string.Empty;
            dtphsd.Text = string.Empty;
            txtgianhap.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
            txtmaloai.Text = string.Empty;
        }
    }
    }

