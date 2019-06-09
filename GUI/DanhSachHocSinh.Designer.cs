namespace GUI
{
    partial class DanhSachHocSinh
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
            this.dtgvDanhSachHS = new System.Windows.Forms.DataGridView();
            this.MSHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiepCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiepMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDanhSachHS
            // 
            this.dtgvDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHS,
            this.HoVaTen,
            this.GioiTinh,
            this.NgaySinh,
            this.NoiSinh,
            this.NguyenQuan,
            this.DanToc,
            this.TonGiao,
            this.HoKhau,
            this.TenCha,
            this.NgheNghiepCha,
            this.TenMe,
            this.NgheNghiepMe,
            this.UuTien});
            this.dtgvDanhSachHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachHS.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachHS.Name = "dtgvDanhSachHS";
            this.dtgvDanhSachHS.RowTemplate.Height = 24;
            this.dtgvDanhSachHS.Size = new System.Drawing.Size(800, 450);
            this.dtgvDanhSachHS.TabIndex = 60;
            // 
            // MSHS
            // 
            this.MSHS.DataPropertyName = "MaHS";
            this.MSHS.HeaderText = "Mã số học sinh";
            this.MSHS.Name = "MSHS";
            this.MSHS.ReadOnly = true;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoTen";
            this.HoVaTen.HeaderText = "Tên học sinh";
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi sinh";
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.ReadOnly = true;
            // 
            // NguyenQuan
            // 
            this.NguyenQuan.DataPropertyName = "NguyenQuan";
            this.NguyenQuan.HeaderText = "Nguyên quán";
            this.NguyenQuan.Name = "NguyenQuan";
            this.NguyenQuan.ReadOnly = true;
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "Dân tộc";
            this.DanToc.Name = "DanToc";
            this.DanToc.ReadOnly = true;
            // 
            // TonGiao
            // 
            this.TonGiao.DataPropertyName = "TonGiao";
            this.TonGiao.HeaderText = "Tôn giáo";
            this.TonGiao.Name = "TonGiao";
            this.TonGiao.ReadOnly = true;
            // 
            // HoKhau
            // 
            this.HoKhau.DataPropertyName = "HoKhauTT";
            this.HoKhau.HeaderText = "Hộ khẩu thường trú";
            this.HoKhau.Name = "HoKhau";
            this.HoKhau.ReadOnly = true;
            // 
            // TenCha
            // 
            this.TenCha.DataPropertyName = "TenCha";
            this.TenCha.HeaderText = "Tên cha";
            this.TenCha.Name = "TenCha";
            this.TenCha.ReadOnly = true;
            // 
            // NgheNghiepCha
            // 
            this.NgheNghiepCha.DataPropertyName = "NNCha";
            this.NgheNghiepCha.HeaderText = "Nghề nghiệp cha";
            this.NgheNghiepCha.Name = "NgheNghiepCha";
            this.NgheNghiepCha.ReadOnly = true;
            // 
            // TenMe
            // 
            this.TenMe.DataPropertyName = "TenMe";
            this.TenMe.HeaderText = "Tên mẹ";
            this.TenMe.Name = "TenMe";
            this.TenMe.ReadOnly = true;
            // 
            // NgheNghiepMe
            // 
            this.NgheNghiepMe.DataPropertyName = "NNMe";
            this.NgheNghiepMe.HeaderText = "Nghề nghiệp mẹ";
            this.NgheNghiepMe.Name = "NgheNghiepMe";
            this.NgheNghiepMe.ReadOnly = true;
            // 
            // UuTien
            // 
            this.UuTien.DataPropertyName = "UuTien";
            this.UuTien.HeaderText = "Đối tượng ưu tiên";
            this.UuTien.Name = "UuTien";
            this.UuTien.ReadOnly = true;
            // 
            // DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvDanhSachHS);
            this.Name = "DanhSachHocSinh";
            this.Text = "DanhSachHocSinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgvDanhSachHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiepCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiepMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTien;
    }
}