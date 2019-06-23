namespace GUI
{
    partial class ucTraCuuTTHS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dtgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.MSHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(96, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số học sinh";
            // 
            // tbMaHS
            // 
            this.tbMaHS.Location = new System.Drawing.Point(256, 35);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.Size = new System.Drawing.Size(139, 22);
            this.tbMaHS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(419, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(96, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên học sinh";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(256, 75);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(345, 22);
            this.tbTen.TabIndex = 8;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(480, 34);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 12;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(300, 113);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(276, 47);
            this.btnTraCuu.TabIndex = 15;
            this.btnTraCuu.Text = "Tra cứu thông tin";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dtgvDanhSachSinhVien
            // 
            this.dtgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHS,
            this.HoVaTen,
            this.Lop,
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
            this.dtgvDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhSachSinhVien.Location = new System.Drawing.Point(0, 297);
            this.dtgvDanhSachSinhVien.Name = "dtgvDanhSachSinhVien";
            this.dtgvDanhSachSinhVien.RowTemplate.Height = 24;
            this.dtgvDanhSachSinhVien.Size = new System.Drawing.Size(816, 222);
            this.dtgvDanhSachSinhVien.TabIndex = 60;
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
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
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
            // ucTraCuuTTHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.dtgvDanhSachSinhVien);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaHS);
            this.Controls.Add(this.label1);
            this.Name = "ucTraCuuTTHS";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucTraCuuTTHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dtgvDanhSachSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
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
