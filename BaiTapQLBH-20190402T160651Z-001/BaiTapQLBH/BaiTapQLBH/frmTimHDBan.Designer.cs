namespace BaiTapQLBH
{
    partial class frmTimHDBan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.cboKetQua = new System.Windows.Forms.ComboBox();
            this.btDong = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(18, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 167);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HĐB";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày bán";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã khách";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(18, 17);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(179, 21);
            this.cboTimKiem.TabIndex = 4;
            // 
            // cboKetQua
            // 
            this.cboKetQua.FormattingEnabled = true;
            this.cboKetQua.Location = new System.Drawing.Point(237, 17);
            this.cboKetQua.Name = "cboKetQua";
            this.cboKetQua.Size = new System.Drawing.Size(180, 21);
            this.cboKetQua.TabIndex = 5;
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.ForeColor = System.Drawing.Color.Blue;
            this.btDong.Image = global::BaiTapQLBH.Properties.Resources.close;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(246, 253);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(89, 34);
            this.btDong.TabIndex = 2;
            this.btDong.Text = "  Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiem.ForeColor = System.Drawing.Color.Blue;
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(476, 12);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(91, 34);
            this.btTimkiem.TabIndex = 2;
            this.btTimkiem.Text = "   Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            // 
            // frmTimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 299);
            this.Controls.Add(this.cboKetQua);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTimHDBan";
            this.Text = "Tìm kiếm hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.ComboBox cboKetQua;
    }
}