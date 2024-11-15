using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Cafe_N7.DAO;
using QLBH_Cafe_N7.DTO;

namespace QLBH_Cafe_N7
{
    public partial class QuanLyBanHang : Form
    {
        private Ban ban = new Ban();
        private ChiTietHD cthd = new ChiTietHD();
        private HoaDon hd = new HoaDon();
        private MenuDAO menuDAO = new MenuDAO();
        private LoaiSP loaisp = new LoaiSP();
        private SanPham sp = new SanPham(); 

        public QuanLyBanHang()
        {
            InitializeComponent();
            LoadTable();
            LoadLoaiSP();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void LoadTable()
        {
            flowBan.Controls.Clear();
            List<Table> tableList = ban.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = Ban.tablewidth,
                    Height = Ban.tableheight,
                    Font = new Font("Times New Roman", 20, FontStyle.Bold), 
                    Text = item.TenBan + Environment.NewLine + item.TinhTrang
                };

                btn.Click += btn_Click;
                btn.Tag = item; //tag kiểu object dùng để lưu table

                switch (item.TinhTrang)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flowBan.Controls.Add(btn);
            }
        }

        void LoadLoaiSP()
        {
            List<Category> listLoaiSP = loaisp.getListCategory();
            cbLoaiSP.DataSource = listLoaiSP;
            cbLoaiSP.DisplayMember = "TenLoai";
        }

        void LoadDSSPByID(int id)
        {
            List<Food> listSP = sp.getFoodByCategoryID(id);
            cbSP.DataSource = listSP;
            cbSP.DisplayMember = "TenSP";
        }

        void showHD(int id)
        {
            lvHD.Items.Clear();
            /*List<Billinfo> listBillInfo = cthd.getListChiTietHD(hd.getHDByTableID(id));

            foreach (Billinfo items in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(items.MaSP.ToString());
                lvItem.SubItems.Add(items.SL.ToString());

                lvHD.Items.Add(lvItem);
            }*/
            List<DTO.Menu> listBillInfo = menuDAO.getListMenuByTable(id);
            double TongTien = 0;

            foreach (DTO.Menu items in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(items.TenMon.ToString());
                lvItem.SubItems.Add(items.SoLuong.ToString());
                lvItem.SubItems.Add(items.GiaBan.ToString());
                lvItem.SubItems.Add(items.ThanhTien.ToString());
                TongTien += items.ThanhTien;

                lvHD.Items.Add(lvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = TongTien.ToString("c", culture);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).MaBan;
            lvHD.Tag = (sender as Button).Tag;
            showHD(tableID);
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;
            id = selected.MaLoai;

            LoadDSSPByID(id);
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            Table table = lvHD.Tag as Table; //lấy tt bàn hiện tại
            //lấy ra idbill hiện tại
            int idBill = hd.getHDByTableID(table.MaBan);
            int idFood = (cbSP.SelectedItem as Food).MaSP;
            int count = (int)numSP.Value;

            if(idBill == -1)
            {
                hd.InsertHD(table.MaBan);
                cthd.InsertCTHD(hd.getMaxBill(), idFood, count);
            }
            else
            {
                cthd.InsertCTHD(idBill, idFood, count);
            }
            
            showHD(table.MaBan);
            LoadTable();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lvHD.Tag as Table;

            int idBill = hd.getHDByTableID(table.MaBan);
            int giamGia = (int)numGiamGia.Value;

            double totalPrice = Convert.ToDouble(txtTongTien.Text.Split(',')[0]);
            double finalPrice = totalPrice - (totalPrice / 100) * giamGia;
            if(idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng Tiền - (Tổng Tiền/100) x Giảm Giá = {1} - ({1}/100)x2 = {3}", table.TenBan, totalPrice, giamGia, finalPrice),"Thông báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    hd.checkOut(idBill, giamGia, (float)finalPrice);
                    showHD(table.MaBan);
                    LoadTable();
                }
            }
        }
    }
}
