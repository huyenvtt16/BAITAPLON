using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DTO
{
    public class NhanVienDTO
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;

        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }

        public NhanVienDTO(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            this.MaNhanVien = manhanvien;
            this.TenNhanVien = tennhanvien;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
            this.NgaySinh = ngaysinh;
        }

        public NhanVienDTO(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }
    }
}
