namespace GUI
{
    partial class ucPhanQuyen
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
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnTimNguoiDung = new System.Windows.Forms.Button();
            this.btnXoaNguoiDung = new System.Windows.Forms.Button();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbThongTinNguoiDung = new System.Windows.Forms.Label();
            this.btnSuaQuyen = new System.Windows.Forms.Button();
            this.btnXong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTenDangNhap.Location = new System.Drawing.Point(3, 47);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(119, 20);
            this.lbTenDangNhap.TabIndex = 2;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(146, 47);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(257, 22);
            this.tbTenDangNhap.TabIndex = 5;
            // 
            // btnTimNguoiDung
            // 
            this.btnTimNguoiDung.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnTimNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNguoiDung.Location = new System.Drawing.Point(448, 35);
            this.btnTimNguoiDung.Name = "btnTimNguoiDung";
            this.btnTimNguoiDung.Size = new System.Drawing.Size(171, 49);
            this.btnTimNguoiDung.TabIndex = 6;
            this.btnTimNguoiDung.Text = "Tìm người dùng";
            this.btnTimNguoiDung.UseVisualStyleBackColor = false;
            this.btnTimNguoiDung.Click += new System.EventHandler(this.btnTimNguoiDung_Click);
            // 
            // btnXoaNguoiDung
            // 
            this.btnXoaNguoiDung.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoaNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnXoaNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNguoiDung.Location = new System.Drawing.Point(176, 262);
            this.btnXoaNguoiDung.Name = "btnXoaNguoiDung";
            this.btnXoaNguoiDung.Size = new System.Drawing.Size(175, 49);
            this.btnXoaNguoiDung.TabIndex = 7;
            this.btnXoaNguoiDung.Text = "Xóa người dùng";
            this.btnXoaNguoiDung.UseVisualStyleBackColor = false;
            // 
            // dtgvUser
            // 
            this.dtgvUser.AllowUserToAddRows = false;
            this.dtgvUser.AllowUserToDeleteRows = false;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDangNhap,
            this.colEdit,
            this.colDelete,
            this.colAdd,
            this.colExport,
            this.colAdmin});
            this.dtgvUser.Location = new System.Drawing.Point(0, 173);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(816, 73);
            this.dtgvUser.TabIndex = 9;
            this.dtgvUser.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellValueChanged);
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDangNhap.FillWeight = 108.6675F;
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 98.26649F;
            this.colEdit.HeaderText = "EDIT";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDelete.FillWeight = 98.26649F;
            this.colDelete.HeaderText = "DELETE";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAdd.FillWeight = 98.26649F;
            this.colAdd.HeaderText = "ADD";
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            // 
            // colExport
            // 
            this.colExport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExport.FillWeight = 98.26649F;
            this.colExport.HeaderText = "EXPORT";
            this.colExport.Name = "colExport";
            this.colExport.ReadOnly = true;
            // 
            // colAdmin
            // 
            this.colAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAdmin.FillWeight = 98.26649F;
            this.colAdmin.HeaderText = "ADMIN";
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.ReadOnly = true;
            // 
            // lbThongTinNguoiDung
            // 
            this.lbThongTinNguoiDung.AutoSize = true;
            this.lbThongTinNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNguoiDung.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbThongTinNguoiDung.Location = new System.Drawing.Point(171, 127);
            this.lbThongTinNguoiDung.Name = "lbThongTinNguoiDung";
            this.lbThongTinNguoiDung.Size = new System.Drawing.Size(488, 29);
            this.lbThongTinNguoiDung.TabIndex = 8;
            this.lbThongTinNguoiDung.Text = "DANH SÁCH QUYỀN CỦA NGƯỜI DÙNG";
            // 
            // btnSuaQuyen
            // 
            this.btnSuaQuyen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSuaQuyen.FlatAppearance.BorderSize = 0;
            this.btnSuaQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaQuyen.Location = new System.Drawing.Point(484, 262);
            this.btnSuaQuyen.Name = "btnSuaQuyen";
            this.btnSuaQuyen.Size = new System.Drawing.Size(175, 49);
            this.btnSuaQuyen.TabIndex = 10;
            this.btnSuaQuyen.Text = "Chỉnh sửa";
            this.btnSuaQuyen.UseVisualStyleBackColor = false;
            this.btnSuaQuyen.Click += new System.EventHandler(this.btnSuaQuyen_Click);
            // 
            // btnXong
            // 
            this.btnXong.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXong.FlatAppearance.BorderSize = 0;
            this.btnXong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXong.Location = new System.Drawing.Point(484, 262);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(175, 49);
            this.btnXong.TabIndex = 11;
            this.btnXong.Text = "Hoàn tất";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // ucPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.btnSuaQuyen);
            this.Controls.Add(this.dtgvUser);
            this.Controls.Add(this.lbThongTinNguoiDung);
            this.Controls.Add(this.btnXoaNguoiDung);
            this.Controls.Add(this.btnTimNguoiDung);
            this.Controls.Add(this.tbTenDangNhap);
            this.Controls.Add(this.lbTenDangNhap);
            this.Name = "ucPhanQuyen";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.TextBox tbTenDangNhap;
        private System.Windows.Forms.Button btnTimNguoiDung;
        private System.Windows.Forms.Button btnXoaNguoiDung;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Label lbThongTinNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdmin;
        private System.Windows.Forms.Button btnSuaQuyen;
        private System.Windows.Forms.Button btnXong;
    }
}
