﻿namespace BaiTapQLBH
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCTonkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhmuc,
            this.mnuHoadon,
            this.mnuTimkiem,
            this.mnuBaocao,
            this.mnuTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau,
            this.mnuPhanQuyen,
            this.mnuDangXuat});
            this.mnuHeThong.Image = global::BaiTapQLBH.Properties.Resources.User;
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 20);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(202, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuPhanQuyen
            // 
            this.mnuPhanQuyen.Image = global::BaiTapQLBH.Properties.Resources.User;
            this.mnuPhanQuyen.Name = "mnuPhanQuyen";
            this.mnuPhanQuyen.Size = new System.Drawing.Size(202, 22);
            this.mnuPhanQuyen.Text = "Phân quyền người dùng";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(202, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatlieu,
            this.mnuNhanvien,
            this.mnuKhachhang,
            this.mnuHanghoa});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuChatlieu
            // 
            this.mnuChatlieu.Name = "mnuChatlieu";
            this.mnuChatlieu.Size = new System.Drawing.Size(137, 22);
            this.mnuChatlieu.Text = "Chất liệu";
            this.mnuChatlieu.Click += new System.EventHandler(this.mnuChatlieu_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(137, 22);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(137, 22);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuHanghoa
            // 
            this.mnuHanghoa.Name = "mnuHanghoa";
            this.mnuHanghoa.Size = new System.Drawing.Size(137, 22);
            this.mnuHanghoa.Text = "Hàng hóa";
            this.mnuHanghoa.Click += new System.EventHandler(this.mnuHanghoa_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(65, 20);
            this.mnuHoadon.Text = "Hóa đơn";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(143, 22);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoadonban_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoadon,
            this.mnuFindHang,
            this.mnuFindKhachhang});
            this.mnuTimkiem.Name = "mnuTimkiem";
            this.mnuTimkiem.Size = new System.Drawing.Size(69, 20);
            this.mnuTimkiem.Text = "Tìm kiếm";
            // 
            // mnuFindHoadon
            // 
            this.mnuFindHoadon.Name = "mnuFindHoadon";
            this.mnuFindHoadon.Size = new System.Drawing.Size(137, 22);
            this.mnuFindHoadon.Text = "Hóa đơn";
            this.mnuFindHoadon.Click += new System.EventHandler(this.mnuFindHoadon_Click);
            // 
            // mnuFindHang
            // 
            this.mnuFindHang.Name = "mnuFindHang";
            this.mnuFindHang.Size = new System.Drawing.Size(137, 22);
            this.mnuFindHang.Text = "Hàng";
            // 
            // mnuFindKhachhang
            // 
            this.mnuFindKhachhang.Name = "mnuFindKhachhang";
            this.mnuFindKhachhang.Size = new System.Drawing.Size(137, 22);
            this.mnuFindKhachhang.Text = "Khách hàng";
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCTonkho,
            this.mnuBCDoanhthu,
            this.mnuInHoaDon,
            this.danhSáchHóaĐơnToolStripMenuItem});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaocao.Text = "Báo cáo";
            // 
            // mnuBCTonkho
            // 
            this.mnuBCTonkho.Name = "mnuBCTonkho";
            this.mnuBCTonkho.Size = new System.Drawing.Size(176, 22);
            this.mnuBCTonkho.Text = "Tồn kho";
            this.mnuBCTonkho.Click += new System.EventHandler(this.mnuBCTonkho_Click);
            // 
            // mnuBCDoanhthu
            // 
            this.mnuBCDoanhthu.Name = "mnuBCDoanhthu";
            this.mnuBCDoanhthu.Size = new System.Drawing.Size(176, 22);
            this.mnuBCDoanhthu.Text = "Doanh thu";
            // 
            // mnuInHoaDon
            // 
            this.mnuInHoaDon.Name = "mnuInHoaDon";
            this.mnuInHoaDon.Size = new System.Drawing.Size(176, 22);
            this.mnuInHoaDon.Text = "In hóa đơn";
            this.mnuInHoaDon.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // danhSáchHóaĐơnToolStripMenuItem
            // 
            this.danhSáchHóaĐơnToolStripMenuItem.Name = "danhSáchHóaĐơnToolStripMenuItem";
            this.danhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.danhSáchHóaĐơnToolStripMenuItem.Text = "Danh sách hóa đơn";
            // 
            // mnuTrogiup
            // 
            this.mnuTrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phụcHồiToolStripMenuItem});
            this.mnuTrogiup.Name = "mnuTrogiup";
            this.mnuTrogiup.Size = new System.Drawing.Size(63, 20);
            this.mnuTrogiup.Text = "Trợ giúp";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saoLưuToolStripMenuItem.Text = "Sao Lưu";
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.phụcHồiToolStripMenuItem.Text = "Phục Hồi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(357, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chương trình quản lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(386, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bán hàng lưu niệm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương Trình Quản Lý Bán Hàng Lưu Niệm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCTonkho;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnuTrogiup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanQuyen;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuInHoaDon;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnToolStripMenuItem;
    }
}