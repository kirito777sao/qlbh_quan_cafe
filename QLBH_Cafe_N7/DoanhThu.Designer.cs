namespace QLBH_Cafe_N7
{
    partial class DoanhThu
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
            this.btThongKe = new System.Windows.Forms.Button();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.dtpNgayBan);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 41);
            this.panel1.TabIndex = 0;
            // 
            // btThongKe
            // 
            this.btThongKe.Location = new System.Drawing.Point(592, 6);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(75, 23);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(197, 9);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDoanhThu);
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 562);
            this.panel2.TabIndex = 1;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 4);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(879, 551);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doanh Thu Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
    }
}