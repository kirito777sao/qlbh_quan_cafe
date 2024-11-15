namespace QLBH_Cafe_N7
{
    partial class Admin
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
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.danhMụcSảnPhẩmToolStripMenuItem,
            this.bànĂnToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.nguyênLiệuToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // danhMụcSảnPhẩmToolStripMenuItem
            // 
            this.danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
            this.danhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.danhMụcSảnPhẩmToolStripMenuItem.Text = "Danh Mục Sản Phẩm";
            this.danhMụcSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.danhMụcSảnPhẩmToolStripMenuItem_Click);
            // 
            // bànĂnToolStripMenuItem
            // 
            this.bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            this.bànĂnToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bànĂnToolStripMenuItem.Text = "Bàn Ăn";
            this.bànĂnToolStripMenuItem.Click += new System.EventHandler(this.bànĂnToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            this.nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            this.nguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.nguyênLiệuToolStripMenuItem.Text = "Nguyên Liệu";
            this.nguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}