namespace GUI
{
    partial class ucBaocaoHocKy
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
            this.dtgvBaoCaoHocKy = new System.Windows.Forms.DataGridView();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBaoCaoHocKy
            // 
            this.dtgvBaoCaoHocKy.AllowUserToAddRows = false;
            this.dtgvBaoCaoHocKy.AllowUserToDeleteRows = false;
            this.dtgvBaoCaoHocKy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvBaoCaoHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBaoCaoHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLop,
            this.colHocKy,
            this.colSiSo,
            this.colSoLuongDat,
            this.colTyLe});
            this.dtgvBaoCaoHocKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvBaoCaoHocKy.Location = new System.Drawing.Point(0, 179);
            this.dtgvBaoCaoHocKy.Name = "dtgvBaoCaoHocKy";
            this.dtgvBaoCaoHocKy.RowTemplate.Height = 24;
            this.dtgvBaoCaoHocKy.Size = new System.Drawing.Size(816, 340);
            this.dtgvBaoCaoHocKy.TabIndex = 19;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXuatBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXuatBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(409, 90);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(205, 63);
            this.btnXuatBaoCao.TabIndex = 18;
            this.btnXuatBaoCao.Text = "XUẤT BÁO CÁO";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLapBaoCao.FlatAppearance.BorderSize = 0;
            this.btnLapBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBaoCao.Location = new System.Drawing.Point(163, 90);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(205, 63);
            this.btnLapBaoCao.TabIndex = 17;
            this.btnLapBaoCao.Text = "LẬP BÁO CÁO";
            this.btnLapBaoCao.UseVisualStyleBackColor = false;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(592, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(289, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Học kì";
            // 
            // cbHocKi
            // 
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHocKi.Location = new System.Drawing.Point(367, 33);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(113, 24);
            this.cbHocKi.TabIndex = 21;
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "Lop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.Name = "colHocKy";
            // 
            // colSiSo
            // 
            this.colSiSo.DataPropertyName = "SiSo";
            this.colSiSo.HeaderText = "Sĩ Số";
            this.colSiSo.Name = "colSiSo";
            // 
            // colSoLuongDat
            // 
            this.colSoLuongDat.DataPropertyName = "SLDat";
            this.colSoLuongDat.HeaderText = "Số lượng đạt";
            this.colSoLuongDat.Name = "colSoLuongDat";
            // 
            // colTyLe
            // 
            this.colTyLe.DataPropertyName = "TiLeDat";
            this.colTyLe.HeaderText = "Tỷ lệ";
            this.colTyLe.Name = "colTyLe";
            // 
            // ucBaocaoHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.cbHocKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvBaoCaoHocKy);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.label3);
            this.Name = "ucBaocaoHocKy";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucBaocaoHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBaoCaoHocKy;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLe;
    }
}
