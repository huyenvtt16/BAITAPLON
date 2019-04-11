namespace BaiTapQLBH
{
    partial class frmInHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsbTenSanPham = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbThanhTien = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btThêm = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // lsbTenSanPham
            // 
            this.lsbTenSanPham.FormattingEnabled = true;
            this.lsbTenSanPham.Location = new System.Drawing.Point(28, 57);
            this.lsbTenSanPham.Name = "lsbTenSanPham";
            this.lsbTenSanPham.Size = new System.Drawing.Size(313, 251);
            this.lsbTenSanPham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thành tiền";
            // 
            // lsbThanhTien
            // 
            this.lsbThanhTien.FormattingEnabled = true;
            this.lsbThanhTien.Location = new System.Drawing.Point(347, 57);
            this.lsbThanhTien.Name = "lsbThanhTien";
            this.lsbThanhTien.Size = new System.Drawing.Size(287, 251);
            this.lsbThanhTien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(109, 353);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(151, 20);
            this.txtTenSanPham.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá:";
            // 
            // nudDonGia
            // 
            this.nudDonGia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDonGia.Location = new System.Drawing.Point(109, 379);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(151, 20);
            this.nudDonGia.TabIndex = 4;
            this.nudDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDonGia.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng Tiền:";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(109, 405);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(151, 20);
            this.nudTongTien.TabIndex = 4;
            this.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTongTien.ThousandsSeparator = true;
            // 
            // nudTienMat
            // 
            this.nudTienMat.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTienMat.Location = new System.Drawing.Point(109, 431);
            this.nudTienMat.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(151, 20);
            this.nudTienMat.TabIndex = 4;
            this.nudTienMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienMat.ThousandsSeparator = true;
            // 
            // nudTienTra
            // 
            this.nudTienTra.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTienTra.Location = new System.Drawing.Point(109, 457);
            this.nudTienTra.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.Size = new System.Drawing.Size(151, 20);
            this.nudTienTra.TabIndex = 4;
            this.nudTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTienTra.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiền mặt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiền trả:";
            // 
            // btThêm
            // 
            this.btThêm.Image = global::BaiTapQLBH.Properties.Resources.add;
            this.btThêm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThêm.Location = new System.Drawing.Point(422, 376);
            this.btThêm.Name = "btThêm";
            this.btThêm.Size = new System.Drawing.Size(90, 30);
            this.btThêm.TabIndex = 5;
            this.btThêm.Text = "Thêm";
            this.btThêm.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Image = global::BaiTapQLBH.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(422, 412);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 36);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btInHoaDon
            // 
            this.btInHoaDon.Location = new System.Drawing.Point(422, 454);
            this.btInHoaDon.Name = "btInHoaDon";
            this.btInHoaDon.Size = new System.Drawing.Size(90, 23);
            this.btInHoaDon.TabIndex = 5;
            this.btInHoaDon.Text = "In hóa đơn";
            this.btInHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 511);
            this.Controls.Add(this.btInHoaDon);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThêm);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.nudDonGia);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbThanhTien);
            this.Controls.Add(this.lsbTenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInHoaDon";
            this.Text = "In Hóa Đơn";
            
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThêm;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btInHoaDon;
    }
}