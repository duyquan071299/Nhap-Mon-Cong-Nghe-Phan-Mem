namespace GUI
{
    partial class ucQuanlylop
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.tbSiSo = new System.Windows.Forms.TextBox();
            this.lbSiSo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xóa toàn bộ học sinh khỏi danh sách lớp";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(292, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMaHS
            // 
            this.tbMaHS.Enabled = false;
            this.tbMaHS.Location = new System.Drawing.Point(428, 116);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.Size = new System.Drawing.Size(121, 22);
            this.tbMaHS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(292, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã HS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(299, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 44);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(428, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 44);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvDanhSachLop
            // 
            this.dtgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Ten,
            this.GioiTinh});
            this.dtgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhSachLop.Location = new System.Drawing.Point(0, 308);
            this.dtgvDanhSachLop.Name = "dtgvDanhSachLop";
            this.dtgvDanhSachLop.RowTemplate.Height = 24;
            this.dtgvDanhSachLop.Size = new System.Drawing.Size(816, 211);
            this.dtgvDanhSachLop.TabIndex = 19;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            this.MaHS.Width = 115;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "HoTen";
            this.Ten.HeaderText = "Tên học sinh";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 300;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 150;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Items.AddRange(new object[] {
            "K10",
            "K11",
            "K12"});
            this.cbKhoi.Location = new System.Drawing.Point(428, 29);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 24);
            this.cbKhoi.TabIndex = 20;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbKhoi.Location = new System.Drawing.Point(292, 29);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(42, 20);
            this.lbKhoi.TabIndex = 21;
            this.lbKhoi.Text = "Khối";
            this.lbKhoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(428, 59);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 22;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // tbSiSo
            // 
            this.tbSiSo.Enabled = false;
            this.tbSiSo.Location = new System.Drawing.Point(428, 89);
            this.tbSiSo.Name = "tbSiSo";
            this.tbSiSo.Size = new System.Drawing.Size(121, 22);
            this.tbSiSo.TabIndex = 24;
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiSo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSiSo.Location = new System.Drawing.Point(292, 89);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(47, 20);
            this.lbSiSo.TabIndex = 23;
            this.lbSiSo.Text = "Sỉ số";
            this.lbSiSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucQuanlylop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.tbSiSo);
            this.Controls.Add(this.lbSiSo);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.lbKhoi);
            this.Controls.Add(this.cbKhoi);
            this.Controls.Add(this.dtgvDanhSachLop);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbMaHS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ucQuanlylop";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucQuanlylop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvDanhSachLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}
