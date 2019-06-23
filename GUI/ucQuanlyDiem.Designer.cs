namespace GUI
{
    partial class ucQuanlyDiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.tbDiem45 = new System.Windows.Forms.TextBox();
            this.tbDiem15 = new System.Windows.Forms.TextBox();
            this.tbDiemCuoiKy = new System.Windows.Forms.TextBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLayDanhSach = new System.Windows.Forms.Button();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(319, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(610, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(319, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm 15 phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(319, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(22, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điểm 45 phút";
            // 
            // dtgvDanhSachHocSinh
            // 
            this.dtgvDanhSachHocSinh.AllowUserToAddRows = false;
            this.dtgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.Diem15,
            this.Diem45,
            this.DiemCuoiKy,
            this.DiemTB});
            this.dtgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 252);
            this.dtgvDanhSachHocSinh.Name = "dtgvDanhSachHocSinh";
            this.dtgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dtgvDanhSachHocSinh.Size = new System.Drawing.Size(816, 267);
            this.dtgvDanhSachHocSinh.TabIndex = 7;
            this.dtgvDanhSachHocSinh.SelectionChanged += new System.EventHandler(this.dtgvDanhSachHocSinh_SelectionChanged);
            // 
            // tbDiem45
            // 
            this.tbDiem45.Enabled = false;
            this.tbDiem45.Location = new System.Drawing.Point(154, 121);
            this.tbDiem45.Name = "tbDiem45";
            this.tbDiem45.Size = new System.Drawing.Size(142, 22);
            this.tbDiem45.TabIndex = 10;
            // 
            // tbDiem15
            // 
            this.tbDiem15.Enabled = false;
            this.tbDiem15.Location = new System.Drawing.Point(453, 72);
            this.tbDiem15.Name = "tbDiem15";
            this.tbDiem15.Size = new System.Drawing.Size(142, 22);
            this.tbDiem15.TabIndex = 12;
            // 
            // tbDiemCuoiKy
            // 
            this.tbDiemCuoiKy.Enabled = false;
            this.tbDiemCuoiKy.Location = new System.Drawing.Point(453, 119);
            this.tbDiemCuoiKy.Name = "tbDiemCuoiKy";
            this.tbDiemCuoiKy.Size = new System.Drawing.Size(142, 22);
            this.tbDiemCuoiKy.TabIndex = 13;
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Items.AddRange(new object[] {
            "HK1",
            "Hk2"});
            this.cbHK.Location = new System.Drawing.Point(453, 21);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(142, 24);
            this.cbHK.TabIndex = 14;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(185, 167);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 41);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(348, 167);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 41);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "LƯU ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(614, 167);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 41);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLayDanhSach
            // 
            this.btnLayDanhSach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLayDanhSach.FlatAppearance.BorderSize = 0;
            this.btnLayDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDanhSach.Location = new System.Drawing.Point(614, 88);
            this.btnLayDanhSach.Name = "btnLayDanhSach";
            this.btnLayDanhSach.Size = new System.Drawing.Size(168, 41);
            this.btnLayDanhSach.TabIndex = 20;
            this.btnLayDanhSach.Text = "LẤY DANH SÁCH";
            this.btnLayDanhSach.UseVisualStyleBackColor = false;
            this.btnLayDanhSach.Click += new System.EventHandler(this.btnLayDanhSach_Click);
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(653, 25);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 24);
            this.cblop.TabIndex = 21;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(154, 19);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(142, 24);
            this.cbMonHoc.TabIndex = 22;
            // 
            // tbMaHS
            // 
            this.tbMaHS.Enabled = false;
            this.tbMaHS.Location = new System.Drawing.Point(154, 74);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.Size = new System.Drawing.Size(142, 22);
            this.tbMaHS.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(20, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "MSHS";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(484, 167);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 41);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên học sinh";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 105;
            // 
            // Diem15
            // 
            this.Diem15.DataPropertyName = "Diem15ph";
            this.Diem15.HeaderText = "Điểm 15 phút";
            this.Diem15.Name = "Diem15";
            this.Diem15.ReadOnly = true;
            this.Diem15.Width = 120;
            // 
            // Diem45
            // 
            this.Diem45.DataPropertyName = "Diem45ph";
            this.Diem45.HeaderText = "Điểm 45 phút";
            this.Diem45.Name = "Diem45";
            this.Diem45.ReadOnly = true;
            this.Diem45.Width = 120;
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.DataPropertyName = "DiemHocKy";
            this.DiemCuoiKy.HeaderText = "Điểm cuối kỳ";
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            this.DiemCuoiKy.ReadOnly = true;
            this.DiemCuoiKy.Width = 120;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm trung bình";
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.ReadOnly = true;
            // 
            // ucQuanlyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.tbMaHS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.btnLayDanhSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.tbDiemCuoiKy);
            this.Controls.Add(this.tbDiem15);
            this.Controls.Add(this.tbDiem45);
            this.Controls.Add(this.dtgvDanhSachHocSinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucQuanlyDiem";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucQuanlyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvDanhSachHocSinh;
        private System.Windows.Forms.TextBox tbDiem45;
        private System.Windows.Forms.TextBox tbDiem15;
        private System.Windows.Forms.TextBox tbDiemCuoiKy;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLayDanhSach;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem45;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}
