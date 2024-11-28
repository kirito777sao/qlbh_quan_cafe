namespace QLBH_Cafe_N7
{
    partial class BanAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXemBan = new System.Windows.Forms.Button();
            this.btXoaBan = new System.Windows.Forms.Button();
            this.btSuaBan = new System.Windows.Forms.Button();
            this.btThemBan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimBan = new System.Windows.Forms.TextBox();
            this.btTimBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTinhTrangBan = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXemBan);
            this.panel1.Controls.Add(this.btXoaBan);
            this.panel1.Controls.Add(this.btSuaBan);
            this.panel1.Controls.Add(this.btThemBan);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 70);
            this.panel1.TabIndex = 0;
            // 
            // btXemBan
            // 
            this.btXemBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemBan.Location = new System.Drawing.Point(469, 11);
            this.btXemBan.Name = "btXemBan";
            this.btXemBan.Size = new System.Drawing.Size(111, 46);
            this.btXemBan.TabIndex = 3;
            this.btXemBan.Text = "Xem";
            this.btXemBan.UseVisualStyleBackColor = true;
            this.btXemBan.Click += new System.EventHandler(this.btXemBan_Click);
            // 
            // btXoaBan
            // 
            this.btXoaBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaBan.Location = new System.Drawing.Point(324, 11);
            this.btXoaBan.Name = "btXoaBan";
            this.btXoaBan.Size = new System.Drawing.Size(111, 46);
            this.btXoaBan.TabIndex = 2;
            this.btXoaBan.Text = "Xóa";
            this.btXoaBan.UseVisualStyleBackColor = true;
            this.btXoaBan.Click += new System.EventHandler(this.btXoaBan_Click);
            // 
            // btSuaBan
            // 
            this.btSuaBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaBan.Location = new System.Drawing.Point(173, 11);
            this.btSuaBan.Name = "btSuaBan";
            this.btSuaBan.Size = new System.Drawing.Size(111, 46);
            this.btSuaBan.TabIndex = 1;
            this.btSuaBan.Text = "Sửa";
            this.btSuaBan.UseVisualStyleBackColor = true;
            this.btSuaBan.Click += new System.EventHandler(this.btSuaBan_Click);
            // 
            // btThemBan
            // 
            this.btThemBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemBan.Location = new System.Drawing.Point(19, 11);
            this.btThemBan.Name = "btThemBan";
            this.btThemBan.Size = new System.Drawing.Size(111, 46);
            this.btThemBan.TabIndex = 0;
            this.btThemBan.Text = "Thêm";
            this.btThemBan.UseVisualStyleBackColor = true;
            this.btThemBan.Click += new System.EventHandler(this.btThemBan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBan);
            this.panel2.Location = new System.Drawing.Point(4, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 494);
            this.panel2.TabIndex = 1;
            // 
            // dgvBan
            // 
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Location = new System.Drawing.Point(4, 4);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(592, 487);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimBan);
            this.panel3.Controls.Add(this.btTimBan);
            this.panel3.Location = new System.Drawing.Point(611, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 70);
            this.panel3.TabIndex = 2;
            // 
            // txtTimBan
            // 
            this.txtTimBan.Location = new System.Drawing.Point(18, 25);
            this.txtTimBan.Name = "txtTimBan";
            this.txtTimBan.Size = new System.Drawing.Size(164, 20);
            this.txtTimBan.TabIndex = 6;
            // 
            // btTimBan
            // 
            this.btTimBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimBan.Location = new System.Drawing.Point(188, 11);
            this.btTimBan.Name = "btTimBan";
            this.btTimBan.Size = new System.Drawing.Size(111, 46);
            this.btTimBan.TabIndex = 5;
            this.btTimBan.Text = "Tìm Kiếm";
            this.btTimBan.UseVisualStyleBackColor = true;
            this.btTimBan.Click += new System.EventHandler(this.btTimBan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btThoat);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbTinhTrangBan);
            this.panel4.Controls.Add(this.txtTenBan);
            this.panel4.Controls.Add(this.txtMaBan);
            this.panel4.Location = new System.Drawing.Point(611, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 494);
            this.panel4.TabIndex = 3;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(101, 431);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(111, 46);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tình Trạng Bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Bàn:";
            // 
            // cbTinhTrangBan
            // 
            this.cbTinhTrangBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrangBan.FormattingEnabled = true;
            this.cbTinhTrangBan.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.cbTinhTrangBan.Location = new System.Drawing.Point(176, 159);
            this.cbTinhTrangBan.Name = "cbTinhTrangBan";
            this.cbTinhTrangBan.Size = new System.Drawing.Size(121, 30);
            this.cbTinhTrangBan.TabIndex = 2;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(176, 106);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(121, 29);
            this.txtTenBan.TabIndex = 1;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(176, 61);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(121, 29);
            this.txtMaBan.TabIndex = 0;
            // 
            // BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 576);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BanAn";
            this.Text = "Bàn Ăn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXemBan;
        private System.Windows.Forms.Button btXoaBan;
        private System.Windows.Forms.Button btSuaBan;
        private System.Windows.Forms.Button btThemBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimBan;
        private System.Windows.Forms.Button btTimBan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTinhTrangBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaBan;
    }
}