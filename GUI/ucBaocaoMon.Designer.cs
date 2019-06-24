namespace GUI
{
    partial class ucBaocaoMon
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
            this.tbHK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLapBC = new System.Windows.Forms.Button();
            this.btnXuatBC = new System.Windows.Forms.Button();
            this.dtgvBaoCaoMon = new System.Windows.Forms.DataGridView();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHK
            // 
            this.tbHK.AutoSize = true;
            this.tbHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbHK.Location = new System.Drawing.Point(180, 40);
            this.tbHK.Name = "tbHK";
            this.tbHK.Size = new System.Drawing.Size(57, 20);
            this.tbHK.TabIndex = 0;
            this.tbHK.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(377, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn";
            // 
            // btnLapBC
            // 
            this.btnLapBC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLapBC.FlatAppearance.BorderSize = 0;
            this.btnLapBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBC.Location = new System.Drawing.Point(163, 98);
            this.btnLapBC.Name = "btnLapBC";
            this.btnLapBC.Size = new System.Drawing.Size(205, 63);
            this.btnLapBC.TabIndex = 7;
            this.btnLapBC.Text = "LẬP BÁO CÁO";
            this.btnLapBC.UseVisualStyleBackColor = false;
            this.btnLapBC.Click += new System.EventHandler(this.btnLapBC_Click);
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXuatBC.FlatAppearance.BorderSize = 0;
            this.btnXuatBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBC.Location = new System.Drawing.Point(409, 98);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.Size = new System.Drawing.Size(205, 63);
            this.btnXuatBC.TabIndex = 8;
            this.btnXuatBC.Text = "XUẤT BÁO CÁO";
            this.btnXuatBC.UseVisualStyleBackColor = false;
            this.btnXuatBC.Click += new System.EventHandler(this.btnXuatBC_Click);
            // 
            // dtgvBaoCaoMon
            // 
            this.dtgvBaoCaoMon.AllowUserToAddRows = false;
            this.dtgvBaoCaoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBaoCaoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lop,
            this.MonHoc,
            this.HK,
            this.SiSo,
            this.SLDat,
            this.TiLe});
            this.dtgvBaoCaoMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvBaoCaoMon.Location = new System.Drawing.Point(0, 179);
            this.dtgvBaoCaoMon.Name = "dtgvBaoCaoMon";
            this.dtgvBaoCaoMon.RowTemplate.Height = 24;
            this.dtgvBaoCaoMon.Size = new System.Drawing.Size(816, 340);
            this.dtgvBaoCaoMon.TabIndex = 9;
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(430, 39);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(121, 24);
            this.cbMon.TabIndex = 10;
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHK.Location = new System.Drawing.Point(247, 39);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 24);
            this.cbHK.TabIndex = 11;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            this.Lop.Width = 50;
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "Mon";
            this.MonHoc.HeaderText = "Môn học";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // HK
            // 
            this.HK.DataPropertyName = "HocKy";
            this.HK.HeaderText = "Học Kì";
            this.HK.Name = "HK";
            this.HK.ReadOnly = true;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sỉ số";
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            // 
            // SLDat
            // 
            this.SLDat.DataPropertyName = "SLDat";
            this.SLDat.HeaderText = "Số lượng đạt";
            this.SLDat.Name = "SLDat";
            this.SLDat.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.DataPropertyName = "TiLeDat";
            this.TiLe.HeaderText = "Tỉ lệ đạt";
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // ucBaocaoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.dtgvBaoCaoMon);
            this.Controls.Add(this.btnXuatBC);
            this.Controls.Add(this.btnLapBC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHK);
            this.Name = "ucBaocaoMon";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucBaocaoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLapBC;
        private System.Windows.Forms.Button btnXuatBC;
        private System.Windows.Forms.DataGridView dtgvBaoCaoMon;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
    }
}
