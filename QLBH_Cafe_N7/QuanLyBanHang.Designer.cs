namespace QLBH_Cafe_N7
{
    partial class QuanLyBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            this.btThemMon = new System.Windows.Forms.Button();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvHD = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btGiamGia = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btChuyenBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowBan = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.numSP);
            this.panel2.Controls.Add(this.btThemMon);
            this.panel2.Controls.Add(this.cbSP);
            this.panel2.Controls.Add(this.cbLoaiSP);
            this.panel2.Location = new System.Drawing.Point(657, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 78);
            this.panel2.TabIndex = 2;
            // 
            // numSP
            // 
            this.numSP.Location = new System.Drawing.Point(358, 31);
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(74, 20);
            this.numSP.TabIndex = 3;
            this.numSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btThemMon
            // 
            this.btThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.Location = new System.Drawing.Point(233, 15);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(119, 48);
            this.btThemMon.TabIndex = 2;
            this.btThemMon.Text = "Thêm Món";
            this.btThemMon.UseVisualStyleBackColor = true;
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(20, 42);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(182, 21);
            this.cbSP.TabIndex = 1;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(20, 15);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(182, 21);
            this.cbLoaiSP.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.lvHD);
            this.panel3.Location = new System.Drawing.Point(657, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 573);
            this.panel3.TabIndex = 3;
            // 
            // lvHD
            // 
            this.lvHD.HideSelection = false;
            this.lvHD.Location = new System.Drawing.Point(4, 4);
            this.lvHD.Name = "lvHD";
            this.lvHD.Size = new System.Drawing.Size(442, 566);
            this.lvHD.TabIndex = 0;
            this.lvHD.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numGiamGia);
            this.panel4.Controls.Add(this.cbChuyenBan);
            this.panel4.Controls.Add(this.btGiamGia);
            this.panel4.Controls.Add(this.btThanhToan);
            this.panel4.Controls.Add(this.btChuyenBan);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1112, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 656);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(6, 604);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(180, 20);
            this.txtTongTien.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng Tiền";
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(4, 494);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(147, 20);
            this.numGiamGia.TabIndex = 7;
            this.numGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(3, 211);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(183, 21);
            this.cbChuyenBan.TabIndex = 6;
            // 
            // btGiamGia
            // 
            this.btGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiamGia.Location = new System.Drawing.Point(3, 432);
            this.btGiamGia.Name = "btGiamGia";
            this.btGiamGia.Size = new System.Drawing.Size(184, 55);
            this.btGiamGia.TabIndex = 5;
            this.btGiamGia.Text = "Giảm Giá";
            this.btGiamGia.UseVisualStyleBackColor = true;
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.Location = new System.Drawing.Point(3, 301);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(184, 55);
            this.btThanhToan.TabIndex = 4;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenBan.Location = new System.Drawing.Point(4, 150);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.Size = new System.Drawing.Size(184, 55);
            this.btChuyenBan.TabIndex = 3;
            this.btChuyenBan.Text = "Chuyển Bàn";
            this.btChuyenBan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH_Cafe_N7.Properties.Resources.Screenshot_2024_11_01_113726;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowBan
            // 
            this.flowBan.BackColor = System.Drawing.SystemColors.Info;
            this.flowBan.Location = new System.Drawing.Point(13, 28);
            this.flowBan.Name = "flowBan";
            this.flowBan.Size = new System.Drawing.Size(638, 656);
            this.flowBan.TabIndex = 5;
            // 
            // QuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1315, 696);
            this.Controls.Add(this.flowBan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvHD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowBan;
        private System.Windows.Forms.NumericUpDown numSP;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button btGiamGia;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btChuyenBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
    }
}