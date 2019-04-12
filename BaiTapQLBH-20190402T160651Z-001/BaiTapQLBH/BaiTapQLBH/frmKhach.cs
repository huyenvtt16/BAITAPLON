using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using DAO;


namespace BaiTapQLBH
{
    public partial class frmKhachhang : Form
    {
        KhachBUS khach = new KhachBUS();
        public frmKhachhang()
        {
            InitializeComponent();
           
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {

            dgvKhach.DataSource = khach.data();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemKH fr = new frmThemKH();
            fr.Show();
            this.Hide();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string user = txtMakhach.Text;
            if (String.IsNullOrEmpty(user))
            {
                MessageBox.Show("Bạn chưa nhập mã khách ");
            }
            else
            {
                try
                {
                    int addrow = new KhachBUS().xoa(user);
                    if (addrow > 0)
                    {
                        MessageBox.Show("Xóa Khách Hàng Thành Công");
                        /*txtMakhach.Text = "";
                        txtTenkhach.Text = "";
                        txtDiachi.Text = "";
                        txtDiachi.Text = "";
                        mskDienthoai.Text = "";*/
                        dgvKhach.DataSource = khach.data();

                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Thêm thất bại! \n\n" + ex.ToString());
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string MaKhach = txtMakhach.Text.Trim();
            string TenKhach = txtTenkhach.Text.Trim();
            string DiaChi = txtDiachi.Text.Trim();
            string DienThoai = mskDienthoai.Text;
            if (String.IsNullOrEmpty(MaKhach) || String.IsNullOrEmpty(TenKhach))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hoặc tên khách");
            }
            else
            { 
                KhachDTO user = new KhachDTO(MaKhach, TenKhach, DiaChi, DienThoai);
                try
                {
                    int addrow = new KhachBUS().sua(user);
                    if (addrow > 0)
                    {
                        MessageBox.Show("Sửa Khách Hàng Thành Công");
                        txtMakhach.Text = "";
                        txtTenkhach.Text = "";
                        txtDiachi.Text = "";
                        txtDiachi.Text = "";
                        mskDienthoai.Text = "";
                        dgvKhach.DataSource = khach.data();

                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Sửa thất bại! \n\n" + ex.ToString());
                }
            }
            
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fr = new frmMain();
            fr.Show();
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectrows = e.RowIndex;
            txtMakhach.Text = dgvKhach.Rows[selectrows].Cells[0].Value.ToString();
            txtTenkhach.Text = dgvKhach.Rows[selectrows].Cells[1].Value.ToString();
            txtDiachi.Text = dgvKhach.Rows[selectrows].Cells[2].Value.ToString();
            mskDienthoai.Text = dgvKhach.Rows[selectrows].Cells[3].Value.ToString();
        }

       
       
    }
}
