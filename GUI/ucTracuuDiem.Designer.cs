namespace GUI
{
    partial class ucTracuuDiem
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
            this.tbMaHs = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dtgvDSDiem = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(206, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(206, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(206, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(206, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học kì";
            // 
            // tbMaHs
            // 
            this.tbMaHs.Location = new System.Drawing.Point(355, 36);
            this.tbMaHs.Name = "tbMaHs";
            this.tbMaHs.Size = new System.Drawing.Size(113, 22);
            this.tbMaHs.TabIndex = 10;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(355, 80);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(266, 22);
            this.tbTen.TabIndex = 11;
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(355, 123);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(266, 24);
            this.cbMon.TabIndex = 12;
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHK.Location = new System.Drawing.Point(355, 168);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(113, 24);
            this.cbHK.TabIndex = 13;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(252, 214);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(330, 43);
            this.btnTraCuu.TabIndex = 20;
            this.btnTraCuu.Text = "Tra cứu điểm ";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dtgvDSDiem
            // 
            this.dtgvDSDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDSDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Ten,
            this.Lop,
            this.Mon,
            this.HK,
            this.Diem15,
            this.Diem45,
            this.DiemCK,
            this.DiemTB});
            this.dtgvDSDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDSDiem.Location = new System.Drawing.Point(0, 292);
            this.dtgvDSDiem.Name = "dtgvDSDiem";
            this.dtgvDSDiem.RowTemplate.Height = 24;
            this.dtgvDSDiem.Size = new System.Drawing.Size(816, 227);
            this.dtgvDSDiem.TabIndex = 21;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MSHocSInh";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            this.MaHS.Width = 60;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "HoTenHS";
            this.Ten.HeaderText = "Tên học sinh";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 70;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            this.Lop.Width = 47;
            // 
            // Mon
            // 
            this.Mon.DataPropertyName = "Mon";
            this.Mon.HeaderText = "Tên môn học";
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            this.Mon.Width = 65;
            // 
            // HK
            // 
            this.HK.DataPropertyName = "HocKy";
            this.HK.HeaderText = "Học kì";
            this.HK.Name = "HK";
            this.HK.ReadOnly = true;
            this.HK.Width = 30;
            // 
            // Diem15
            // 
            this.Diem15.DataPropertyName = "Diem15ph";
            this.Diem15.HeaderText = "Điểm 15 phút";
            this.Diem15.Name = "Diem15";
            this.Diem15.ReadOnly = true;
            this.Diem15.Width = 70;
            // 
            // Diem45
            // 
            this.Diem45.DataPropertyName = "Diem45ph";
            this.Diem45.HeaderText = "Điểm 45 phút";
            this.Diem45.Name = "Diem45";
            this.Diem45.ReadOnly = true;
            this.Diem45.Width = 70;
            // 
            // DiemCK
            // 
            this.DiemCK.DataPropertyName = "DiemCK";
            this.DiemCK.HeaderText = "Điểm cuối kì";
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.ReadOnly = true;
            this.DiemCK.Width = 70;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm trung bình";
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.ReadOnly = true;
            this.DiemTB.Width = 70;
            // 
            // ucTracuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.dtgvDSDiem);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMaHs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucTracuuDiem";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucTracuuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaHs;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dtgvDSDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem45;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}
