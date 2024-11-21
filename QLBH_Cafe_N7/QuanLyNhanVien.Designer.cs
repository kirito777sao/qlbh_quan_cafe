namespace QLBH_Cafe_N7
{
	partial class QuanLyNhanVien
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
			this.button5 = new System.Windows.Forms.Button();
			this.txt_timkiem = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.txt_diachi = new System.Windows.Forms.TextBox();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.txt_chucvu = new System.Windows.Forms.TextBox();
			this.txt_hoten = new System.Windows.Forms.TextBox();
			this.txt_ma = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.dgv_nhanvien);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.txt_timkiem);
			this.groupBox2.Location = new System.Drawing.Point(29, 266);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(712, 235);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm nhân viên";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 16);
			this.label8.TabIndex = 3;
			this.label8.Text = "Thông tin tìm kiếm";
			// 
			// dgv_nhanvien
			// 
			this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_nhanvien.Location = new System.Drawing.Point(13, 79);
			this.dgv_nhanvien.Name = "dgv_nhanvien";
			this.dgv_nhanvien.RowHeadersWidth = 51;
			this.dgv_nhanvien.RowTemplate.Height = 24;
			this.dgv_nhanvien.Size = new System.Drawing.Size(684, 150);
			this.dgv_nhanvien.TabIndex = 2;
			this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(464, 37);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Tìm kiếm";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// txt_timkiem
			// 
			this.txt_timkiem.Location = new System.Drawing.Point(162, 38);
			this.txt_timkiem.Name = "txt_timkiem";
			this.txt_timkiem.Size = new System.Drawing.Size(191, 22);
			this.txt_timkiem.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtp_ngaysinh);
			this.groupBox1.Controls.Add(this.btn_thoat);
			this.groupBox1.Controls.Add(this.btn_xoa);
			this.groupBox1.Controls.Add(this.btn_sua);
			this.groupBox1.Controls.Add(this.btn_them);
			this.groupBox1.Controls.Add(this.txt_diachi);
			this.groupBox1.Controls.Add(this.txt_sdt);
			this.groupBox1.Controls.Add(this.txt_chucvu);
			this.groupBox1.Controls.Add(this.txt_hoten);
			this.groupBox1.Controls.Add(this.txt_ma);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(29, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(712, 204);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// dtp_ngaysinh
			// 
			this.dtp_ngaysinh.CustomFormat = "yyyy/MM/dd";
			this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_ngaysinh.Location = new System.Drawing.Point(421, 73);
			this.dtp_ngaysinh.Name = "dtp_ngaysinh";
			this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaysinh.TabIndex = 16;
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(586, 161);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_thoat.TabIndex = 15;
			this.btn_thoat.Text = "Thoát";
			this.btn_thoat.UseVisualStyleBackColor = true;
			this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(398, 161);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 14;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(223, 161);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 13;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(50, 162);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 12;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// txt_diachi
			// 
			this.txt_diachi.Location = new System.Drawing.Point(421, 115);
			this.txt_diachi.Name = "txt_diachi";
			this.txt_diachi.Size = new System.Drawing.Size(201, 22);
			this.txt_diachi.TabIndex = 11;
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(421, 37);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(201, 22);
			this.txt_sdt.TabIndex = 9;
			// 
			// txt_chucvu
			// 
			this.txt_chucvu.Location = new System.Drawing.Point(102, 114);
			this.txt_chucvu.Name = "txt_chucvu";
			this.txt_chucvu.Size = new System.Drawing.Size(167, 22);
			this.txt_chucvu.TabIndex = 8;
			// 
			// txt_hoten
			// 
			this.txt_hoten.Location = new System.Drawing.Point(102, 73);
			this.txt_hoten.Name = "txt_hoten";
			this.txt_hoten.Size = new System.Drawing.Size(167, 22);
			this.txt_hoten.TabIndex = 7;
			// 
			// txt_ma
			// 
			this.txt_ma.Location = new System.Drawing.Point(102, 37);
			this.txt_ma.Name = "txt_ma";
			this.txt_ma.Size = new System.Drawing.Size(167, 22);
			this.txt_ma.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(333, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(333, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = " Ngày sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(330, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Số điện thoại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Chức vụ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Họ và tên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã nhân viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(248, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quản lý nhân viên";
			// 
			// QuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 528);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "QuanLyNhanVien";
			this.Text = "QuanLyNhanVien";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgv_nhanvien;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txt_timkiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.TextBox txt_diachi;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.TextBox txt_chucvu;
		private System.Windows.Forms.TextBox txt_hoten;
		private System.Windows.Forms.TextBox txt_ma;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}