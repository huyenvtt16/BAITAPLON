using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace BaiTapQLBH
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM tblMatHang WHERE NgaySX >= '" + dtpNgaySX.Value.ToString() + "'";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            rpvBaoCao.LocalReport.ReportPath = "rptSanPham.rdlc";

            if(ds.Tables[0].Rows.Count>0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "tblMatHang";
                rds.Value = ds.Tables[0];

                rpvBaoCao.LocalReport.DataSources.Clear();

                rpvBaoCao.LocalReport.DataSources.Add(rds);

                rpvBaoCao.RefreshReport();
            }
        }
    }
}
