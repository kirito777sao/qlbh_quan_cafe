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
    public partial class QLSP : Form
    {
        SanPham sp = new SanPham();
        public QLSP()
        {
            InitializeComponent();
            dataGridView1.DataSource = sp.GetAllSP();
        }
        void ClearTexts()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
        }
        //Hiển thị
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.GetAllSP();
        }
        //Thêm
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Mã Sản Phẩm"); textBox1.Focus(); return; }
            if (textBox2.Text == "") { MessageBox.Show("Chưa Nhập Tên Sản Phẩm"); textBox2.Focus(); return; }
            if (textBox3.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Giá Bán"); textBox3.Focus(); return; }
            if (comboBox1.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Loại Sản Phẩm"); comboBox1.Focus(); return; }
            sp.CreateSP(textBox1.Text.Trim(), textBox2.Text, textBox3.Text, comboBox1.Text);
            dataGridView1.DataSource = sp.GetAllSP();
            ClearTexts();
            MessageBox.Show("Thêm Thành Công");
        }
        //Sửa
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") { MessageBox.Show("Chưa Nhập Tên Sản Phẩm"); textBox2.Focus(); return; }
            if (textBox3.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Giá Bán"); textBox3.Focus(); return; }
            if (comboBox1.Text.Trim() == "") { MessageBox.Show("Chưa Nhập Loại Sản Phẩm"); comboBox1.Focus(); return; }
            sp.UpdateSP(textBox1.Text.Trim(), textBox2.Text, textBox3.Text, comboBox1.Text);
            dataGridView1.DataSource = sp.GetAllSP();
            ClearTexts();
            MessageBox.Show("Sửa Thành Công");
        }
        //Xóa
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null) { return; }
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null) { return; }
            if (MessageBox.Show("Có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string MaSP = row.Cells[0].Value.ToString();
                    sp.DeleteSP(MaSP);
                }
                dataGridView1.DataSource = sp.GetAllSP();
                ClearTexts();
                MessageBox.Show("Xóa Thành Công");
            }
        }
        //Thoát chương trình
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //Tìm kiếm
        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = sp.SearchSP(textBox4.Text);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dataGridView1.Rows[i];
                textBox1.Text = r.Cells[0].Value.ToString();
                textBox2.Text = r.Cells[1].Value.ToString();
                textBox3.Text = r.Cells[2].Value.ToString();
                comboBox1.Text = r.Cells[3].Value.ToString();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaLoai = comboBox2.SelectedItem.ToString();
            DataTable dt = sp.GetLoaiSP(selectedMaLoai);
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cho loại sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
