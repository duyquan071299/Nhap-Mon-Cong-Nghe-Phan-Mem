namespace GUI
{
    partial class ucQuanLyHocSinh
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
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbHoKhau = new System.Windows.Forms.Label();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTonGiao = new System.Windows.Forms.Label();
            this.lbTenCha = new System.Windows.Forms.Label();
            this.lbTenMe = new System.Windows.Forms.Label();
            this.cbTonGiao = new System.Windows.Forms.ComboBox();
            this.lbNgheNghiepCha = new System.Windows.Forms.Label();
            this.lbNgheNghiepMe = new System.Windows.Forms.Label();
            this.lbUuTien = new System.Windows.Forms.Label();
            this.cbUuTien = new System.Windows.Forms.ComboBox();
            this.lbMaHocSinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbNguyenQuan = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.tbHoVaTen = new System.Windows.Forms.TextBox();
            this.tbNguyenQuan = new System.Windows.Forms.TextBox();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.tbHoKhau = new System.Windows.Forms.TextBox();
            this.tbTenCha = new System.Windows.Forms.TextBox();
            this.tbTenMe = new System.Windows.Forms.TextBox();
            this.tbNgheNghiepCha = new System.Windows.Forms.TextBox();
            this.tbNgheNghiepMe = new System.Windows.Forms.TextBox();
            this.tbMaHocSinh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Enabled = false;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(672, 10);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(136, 24);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(151, 37);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(223, 22);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // lbHoKhau
            // 
            this.lbHoKhau.AutoSize = true;
            this.lbHoKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbHoKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbHoKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoKhau.ForeColor = System.Drawing.Color.Snow;
            this.lbHoKhau.Location = new System.Drawing.Point(9, 91);
            this.lbHoKhau.Name = "lbHoKhau";
            this.lbHoKhau.Size = new System.Drawing.Size(96, 18);
            this.lbHoKhau.TabIndex = 27;
            this.lbHoKhau.Text = "Hộ khẩu TT";
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoVaTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoVaTen.ForeColor = System.Drawing.Color.Snow;
            this.lbHoVaTen.Location = new System.Drawing.Point(9, 12);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(58, 18);
            this.lbHoVaTen.TabIndex = 28;
            this.lbHoVaTen.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(347, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Dân tộc";
            // 
            // lbTonGiao
            // 
            this.lbTonGiao.AutoSize = true;
            this.lbTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.lbTonGiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTonGiao.ForeColor = System.Drawing.Color.Snow;
            this.lbTonGiao.Location = new System.Drawing.Point(581, 63);
            this.lbTonGiao.Name = "lbTonGiao";
            this.lbTonGiao.Size = new System.Drawing.Size(74, 18);
            this.lbTonGiao.TabIndex = 34;
            this.lbTonGiao.Text = "Tôn giáo";
            // 
            // lbTenCha
            // 
            this.lbTenCha.AutoSize = true;
            this.lbTenCha.BackColor = System.Drawing.Color.Transparent;
            this.lbTenCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTenCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCha.ForeColor = System.Drawing.Color.Snow;
            this.lbTenCha.Location = new System.Drawing.Point(9, 123);
            this.lbTenCha.Name = "lbTenCha";
            this.lbTenCha.Size = new System.Drawing.Size(68, 18);
            this.lbTenCha.TabIndex = 35;
            this.lbTenCha.Text = "Tên cha";
            // 
            // lbTenMe
            // 
            this.lbTenMe.AutoSize = true;
            this.lbTenMe.BackColor = System.Drawing.Color.Transparent;
            this.lbTenMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTenMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMe.ForeColor = System.Drawing.Color.Snow;
            this.lbTenMe.Location = new System.Drawing.Point(9, 152);
            this.lbTenMe.Name = "lbTenMe";
            this.lbTenMe.Size = new System.Drawing.Size(64, 18);
            this.lbTenMe.TabIndex = 36;
            this.lbTenMe.Text = "Tên mẹ";
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.Enabled = false;
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.Items.AddRange(new object[] {
            "Phật giáo",
            "Thiên Chúa giáo",
            "Công giáo",
            "Cao Đài",
            "Tìn Lành",
            "Hòa Hỏa",
            "Không có đạo"});
            this.cbTonGiao.Location = new System.Drawing.Point(672, 63);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(136, 24);
            this.cbTonGiao.TabIndex = 37;
            // 
            // lbNgheNghiepCha
            // 
            this.lbNgheNghiepCha.AutoSize = true;
            this.lbNgheNghiepCha.BackColor = System.Drawing.Color.Transparent;
            this.lbNgheNghiepCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbNgheNghiepCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgheNghiepCha.ForeColor = System.Drawing.Color.Snow;
            this.lbNgheNghiepCha.Location = new System.Drawing.Point(438, 129);
            this.lbNgheNghiepCha.Name = "lbNgheNghiepCha";
            this.lbNgheNghiepCha.Size = new System.Drawing.Size(101, 18);
            this.lbNgheNghiepCha.TabIndex = 40;
            this.lbNgheNghiepCha.Text = "Nghề nghiệp";
            // 
            // lbNgheNghiepMe
            // 
            this.lbNgheNghiepMe.AutoSize = true;
            this.lbNgheNghiepMe.BackColor = System.Drawing.Color.Transparent;
            this.lbNgheNghiepMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbNgheNghiepMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgheNghiepMe.ForeColor = System.Drawing.Color.Snow;
            this.lbNgheNghiepMe.Location = new System.Drawing.Point(438, 156);
            this.lbNgheNghiepMe.Name = "lbNgheNghiepMe";
            this.lbNgheNghiepMe.Size = new System.Drawing.Size(101, 18);
            this.lbNgheNghiepMe.TabIndex = 41;
            this.lbNgheNghiepMe.Text = "Nghề nghiệp";
            // 
            // lbUuTien
            // 
            this.lbUuTien.AutoSize = true;
            this.lbUuTien.BackColor = System.Drawing.Color.Transparent;
            this.lbUuTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUuTien.ForeColor = System.Drawing.Color.Snow;
            this.lbUuTien.Location = new System.Drawing.Point(9, 182);
            this.lbUuTien.Name = "lbUuTien";
            this.lbUuTien.Size = new System.Drawing.Size(136, 18);
            this.lbUuTien.TabIndex = 44;
            this.lbUuTien.Text = "Đối tượng ưu tiên";
            // 
            // cbUuTien
            // 
            this.cbUuTien.Enabled = false;
            this.cbUuTien.FormattingEnabled = true;
            this.cbUuTien.Items.AddRange(new object[] {
            "Đối tượng 01",
            "Đối tượng 02",
            "Đối tượng 03",
            "Đối tượng 04",
            "Không có"});
            this.cbUuTien.Location = new System.Drawing.Point(151, 180);
            this.cbUuTien.Name = "cbUuTien";
            this.cbUuTien.Size = new System.Drawing.Size(657, 24);
            this.cbUuTien.TabIndex = 47;
            // 
            // lbMaHocSinh
            // 
            this.lbMaHocSinh.AutoSize = true;
            this.lbMaHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbMaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHocSinh.ForeColor = System.Drawing.Color.Snow;
            this.lbMaHocSinh.Location = new System.Drawing.Point(28, 220);
            this.lbMaHocSinh.Name = "lbMaHocSinh";
            this.lbMaHocSinh.Size = new System.Drawing.Size(119, 18);
            this.lbMaHocSinh.TabIndex = 53;
            this.lbMaHocSinh.Text = "Mã HS cần tìm";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lbNgaySinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Snow;
            this.lbNgaySinh.Location = new System.Drawing.Point(9, 37);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(82, 18);
            this.lbNgaySinh.TabIndex = 55;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.BackColor = System.Drawing.Color.Transparent;
            this.lbNoiSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.ForeColor = System.Drawing.Color.Snow;
            this.lbNoiSinh.Location = new System.Drawing.Point(501, 37);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(70, 18);
            this.lbNoiSinh.TabIndex = 56;
            this.lbNoiSinh.Text = "Nơi sinh";
            // 
            // lbNguyenQuan
            // 
            this.lbNguyenQuan.AutoSize = true;
            this.lbNguyenQuan.BackColor = System.Drawing.Color.Transparent;
            this.lbNguyenQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNguyenQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguyenQuan.ForeColor = System.Drawing.Color.Snow;
            this.lbNguyenQuan.Location = new System.Drawing.Point(9, 65);
            this.lbNguyenQuan.Name = "lbNguyenQuan";
            this.lbNguyenQuan.Size = new System.Drawing.Size(105, 18);
            this.lbNguyenQuan.TabIndex = 57;
            this.lbNguyenQuan.Text = "Nguyên quán";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Snow;
            this.lbGioiTinh.Location = new System.Drawing.Point(582, 8);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(71, 18);
            this.lbGioiTinh.TabIndex = 58;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(174, 222);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 62);
            this.btnTim.TabIndex = 60;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // tbHoVaTen
            // 
            this.tbHoVaTen.Enabled = false;
            this.tbHoVaTen.Location = new System.Drawing.Point(151, 9);
            this.tbHoVaTen.Name = "tbHoVaTen";
            this.tbHoVaTen.Size = new System.Drawing.Size(419, 22);
            this.tbHoVaTen.TabIndex = 65;
            // 
            // tbNguyenQuan
            // 
            this.tbNguyenQuan.Enabled = false;
            this.tbNguyenQuan.Location = new System.Drawing.Point(151, 67);
            this.tbNguyenQuan.Name = "tbNguyenQuan";
            this.tbNguyenQuan.Size = new System.Drawing.Size(190, 22);
            this.tbNguyenQuan.TabIndex = 66;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Enabled = false;
            this.tbNoiSinh.Location = new System.Drawing.Point(585, 37);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(223, 22);
            this.tbNoiSinh.TabIndex = 67;
            // 
            // tbHoKhau
            // 
            this.tbHoKhau.Enabled = false;
            this.tbHoKhau.Location = new System.Drawing.Point(151, 95);
            this.tbHoKhau.Name = "tbHoKhau";
            this.tbHoKhau.Size = new System.Drawing.Size(657, 22);
            this.tbHoKhau.TabIndex = 68;
            // 
            // tbTenCha
            // 
            this.tbTenCha.Enabled = false;
            this.tbTenCha.Location = new System.Drawing.Point(151, 125);
            this.tbTenCha.Name = "tbTenCha";
            this.tbTenCha.Size = new System.Drawing.Size(281, 22);
            this.tbTenCha.TabIndex = 69;
            // 
            // tbTenMe
            // 
            this.tbTenMe.Enabled = false;
            this.tbTenMe.Location = new System.Drawing.Point(151, 152);
            this.tbTenMe.Name = "tbTenMe";
            this.tbTenMe.Size = new System.Drawing.Size(281, 22);
            this.tbTenMe.TabIndex = 70;
            // 
            // tbNgheNghiepCha
            // 
            this.tbNgheNghiepCha.Enabled = false;
            this.tbNgheNghiepCha.Location = new System.Drawing.Point(563, 125);
            this.tbNgheNghiepCha.Name = "tbNgheNghiepCha";
            this.tbNgheNghiepCha.Size = new System.Drawing.Size(245, 22);
            this.tbNgheNghiepCha.TabIndex = 71;
            // 
            // tbNgheNghiepMe
            // 
            this.tbNgheNghiepMe.Enabled = false;
            this.tbNgheNghiepMe.Location = new System.Drawing.Point(563, 150);
            this.tbNgheNghiepMe.Name = "tbNgheNghiepMe";
            this.tbNgheNghiepMe.Size = new System.Drawing.Size(245, 22);
            this.tbNgheNghiepMe.TabIndex = 72;
            // 
            // tbMaHocSinh
            // 
            this.tbMaHocSinh.Location = new System.Drawing.Point(12, 245);
            this.tbMaHocSinh.Name = "tbMaHocSinh";
            this.tbMaHocSinh.Size = new System.Drawing.Size(146, 22);
            this.tbMaHocSinh.TabIndex = 73;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(288, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 62);
            this.btnThem.TabIndex = 74;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(484, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 62);
            this.btnXoa.TabIndex = 75;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(585, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 62);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.Black;
            this.btnBoQua.Location = new System.Drawing.Point(696, 222);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(101, 62);
            this.btnBoQua.TabIndex = 77;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // cbDanToc
            // 
            this.cbDanToc.Enabled = false;
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Thái",
            "Mường",
            "Khmer",
            "Hoa",
            "Nùng",
            "H\'Mông",
            "Dao",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Sán Chay",
            "Chăm",
            "Cơ Ho",
            "Xơ Đăng",
            "Sán Dìu",
            "Hrê",
            "Ra Glai",
            "Mnông",
            "Thổ",
            "Xtiêng",
            "Khơ mú",
            "Bru - Vân Kiều",
            "Cơ Tu",
            "Giáy",
            "Tà Ôi",
            "Mạ",
            "Giẻ-Triêng",
            "Co",
            "Chơ Ro",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "La Chí",
            "Kháng",
            "Phù Lá",
            "La Hủ",
            "La Ha",
            "Pà Thẻn",
            "Lự",
            "Ngái",
            "Chứt",
            "Lô Lô",
            "Mảng",
            "Cơ Lao",
            "Bố Y",
            "Cống",
            "Si La",
            "Pu Péo",
            "Rơ Măm",
            "Brâu",
            "Ơ Đu"});
            this.cbDanToc.Location = new System.Drawing.Point(434, 63);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(136, 24);
            this.cbDanToc.TabIndex = 78;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(383, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 62);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(391, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "(mm/dd/yy)";
            // 
            // dtgvDanhSachSinhVien
            // 
            this.dtgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgvDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhSachSinhVien.Location = new System.Drawing.Point(0, 297);
            this.dtgvDanhSachSinhVien.Name = "dtgvDanhSachSinhVien";
            this.dtgvDanhSachSinhVien.RowTemplate.Height = 24;
            this.dtgvDanhSachSinhVien.Size = new System.Drawing.Size(816, 222);
            this.dtgvDanhSachSinhVien.TabIndex = 59;
            this.dtgvDanhSachSinhVien.SelectionChanged += new System.EventHandler(this.dtgvDanhSachSinhVien_SelectionChanged);
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
            // ucQuanLyHocSinh
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbMaHocSinh);
            this.Controls.Add(this.tbNgheNghiepMe);
            this.Controls.Add(this.tbNgheNghiepCha);
            this.Controls.Add(this.tbTenMe);
            this.Controls.Add(this.tbTenCha);
            this.Controls.Add(this.tbHoKhau);
            this.Controls.Add(this.tbNoiSinh);
            this.Controls.Add(this.tbNguyenQuan);
            this.Controls.Add(this.tbHoVaTen);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgvDanhSachSinhVien);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbNguyenQuan);
            this.Controls.Add(this.lbNoiSinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbMaHocSinh);
            this.Controls.Add(this.cbUuTien);
            this.Controls.Add(this.lbUuTien);
            this.Controls.Add(this.lbNgheNghiepMe);
            this.Controls.Add(this.lbNgheNghiepCha);
            this.Controls.Add(this.cbTonGiao);
            this.Controls.Add(this.lbTenMe);
            this.Controls.Add(this.lbTenCha);
            this.Controls.Add(this.lbTonGiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHoVaTen);
            this.Controls.Add(this.lbHoKhau);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbGioiTinh);
            this.Name = "ucQuanLyHocSinh";
            this.Size = new System.Drawing.Size(816, 519);
            this.Load += new System.EventHandler(this.ucQuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbHoKhau;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTonGiao;
        private System.Windows.Forms.Label lbTenCha;
        private System.Windows.Forms.Label lbTenMe;
        private System.Windows.Forms.ComboBox cbTonGiao;
        private System.Windows.Forms.Label lbNgheNghiepCha;
        private System.Windows.Forms.Label lbNgheNghiepMe;
        private System.Windows.Forms.Label lbUuTien;
        private System.Windows.Forms.ComboBox cbUuTien;
        private System.Windows.Forms.Label lbMaHocSinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbNguyenQuan;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbHoVaTen;
        private System.Windows.Forms.TextBox tbNguyenQuan;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.TextBox tbHoKhau;
        private System.Windows.Forms.TextBox tbTenCha;
        private System.Windows.Forms.TextBox tbTenMe;
        private System.Windows.Forms.TextBox tbNgheNghiepCha;
        private System.Windows.Forms.TextBox tbNgheNghiepMe;
        private System.Windows.Forms.TextBox tbMaHocSinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.ComboBox cbDanToc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvDanhSachSinhVien;
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
