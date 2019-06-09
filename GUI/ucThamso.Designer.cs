namespace GUI
{
    partial class ucThamso
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
            this.dtgvThamSo = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTenThamSo = new System.Windows.Forms.ComboBox();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.lbTenTS = new System.Windows.Forms.Label();
            this.lbGiaTri = new System.Windows.Forms.Label();
            this.lbGiaTriMoi = new System.Windows.Forms.Label();
            this.tbGiaTriMoi = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThamSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvThamSo
            // 
            this.dtgvThamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThamSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.GiaTri});
            this.dtgvThamSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvThamSo.Location = new System.Drawing.Point(0, 0);
            this.dtgvThamSo.Name = "dtgvThamSo";
            this.dtgvThamSo.RowTemplate.Height = 24;
            this.dtgvThamSo.Size = new System.Drawing.Size(816, 365);
            this.dtgvThamSo.TabIndex = 0;
            this.dtgvThamSo.SelectionChanged += new System.EventHandler(this.dtgvThamSo_SelectionChanged);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(47, 422);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(195, 47);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CHỈNH SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(430, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 47);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(659, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 47);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(545, 422);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 47);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(310, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTenThamSo
            // 
            this.cbTenThamSo.Enabled = false;
            this.cbTenThamSo.FormattingEnabled = true;
            this.cbTenThamSo.Location = new System.Drawing.Point(209, 390);
            this.cbTenThamSo.Name = "cbTenThamSo";
            this.cbTenThamSo.Size = new System.Drawing.Size(121, 24);
            this.cbTenThamSo.TabIndex = 7;
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Enabled = false;
            this.tbGiaTri.Location = new System.Drawing.Point(419, 390);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(100, 22);
            this.tbGiaTri.TabIndex = 8;
            // 
            // lbTenTS
            // 
            this.lbTenTS.AutoSize = true;
            this.lbTenTS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTenTS.Location = new System.Drawing.Point(109, 393);
            this.lbTenTS.Name = "lbTenTS";
            this.lbTenTS.Size = new System.Drawing.Size(94, 17);
            this.lbTenTS.TabIndex = 9;
            this.lbTenTS.Text = "Tên Tham Số";
            // 
            // lbGiaTri
            // 
            this.lbGiaTri.AutoSize = true;
            this.lbGiaTri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGiaTri.Location = new System.Drawing.Point(362, 392);
            this.lbGiaTri.Name = "lbGiaTri";
            this.lbGiaTri.Size = new System.Drawing.Size(51, 17);
            this.lbGiaTri.TabIndex = 10;
            this.lbGiaTri.Text = "Giá Trị";
            // 
            // lbGiaTriMoi
            // 
            this.lbGiaTriMoi.AutoSize = true;
            this.lbGiaTriMoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGiaTriMoi.Location = new System.Drawing.Point(576, 393);
            this.lbGiaTriMoi.Name = "lbGiaTriMoi";
            this.lbGiaTriMoi.Size = new System.Drawing.Size(77, 17);
            this.lbGiaTriMoi.TabIndex = 12;
            this.lbGiaTriMoi.Text = "Giá Trị Mới";
            this.lbGiaTriMoi.Visible = false;
            // 
            // tbGiaTriMoi
            // 
            this.tbGiaTriMoi.Location = new System.Drawing.Point(659, 390);
            this.tbGiaTriMoi.Name = "tbGiaTriMoi";
            this.tbGiaTriMoi.Size = new System.Drawing.Size(100, 22);
            this.tbGiaTriMoi.TabIndex = 11;
            this.tbGiaTriMoi.Visible = false;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "STenThamSo";
            this.Ten.HeaderText = "Tên tham số";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 270;
            // 
            // GiaTri
            // 
            this.GiaTri.DataPropertyName = "SGiaTri";
            this.GiaTri.HeaderText = "Giá trị";
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.ReadOnly = true;
            this.GiaTri.Width = 280;
            // 
            // ucThamso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.lbGiaTriMoi);
            this.Controls.Add(this.tbGiaTriMoi);
            this.Controls.Add(this.lbGiaTri);
            this.Controls.Add(this.lbTenTS);
            this.Controls.Add(this.tbGiaTri);
            this.Controls.Add(this.cbTenThamSo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtgvThamSo);
            this.Name = "ucThamso";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucThamso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThamSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgvThamSo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTenThamSo;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label lbTenTS;
        private System.Windows.Forms.Label lbGiaTri;
        private System.Windows.Forms.Label lbGiaTriMoi;
        private System.Windows.Forms.TextBox tbGiaTriMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
    }
}
