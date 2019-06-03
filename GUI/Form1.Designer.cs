namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlMainMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucTracuuDiem1 = new GUI.ucTracuuDiem();
            this.ucTraCuuTTHS1 = new GUI.ucTraCuuTTHS();
            this.quanLyLop1 = new GUI.ucQuanlylop();
            this.quanly1 = new GUI.ucQuanlyHocsinh();
            this.ucQuanlyDiem1 = new GUI.ucQuanlyDiem();
            this.ucBaocaoMon1 = new GUI.ucBaocaoMon();
            this.ucBaocaoNam1 = new GUI.ucBaocaoNam();
            this.ucThamso1 = new GUI.ucThamso();
            this.ucPhanQuyen1 = new GUI.ucPhanQuyen();
            this.PnlMainMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainMenu
            // 
            this.PnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PnlMainMenu.Controls.Add(this.button4);
            this.PnlMainMenu.Controls.Add(this.button3);
            this.PnlMainMenu.Controls.Add(this.button2);
            this.PnlMainMenu.Controls.Add(this.sidepanel);
            this.PnlMainMenu.Controls.Add(this.button1);
            this.PnlMainMenu.Controls.Add(this.panel3);
            this.PnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMainMenu.Name = "PnlMainMenu";
            this.PnlMainMenu.Size = new System.Drawing.Size(295, 531);
            this.PnlMainMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 62);
            this.button4.TabIndex = 11;
            this.button4.Text = "HỆ THỐNG";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 62);
            this.button3.TabIndex = 10;
            this.button3.Text = "BÁO CÁO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 62);
            this.button2.TabIndex = 9;
            this.button2.Text = "TRA CỨU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Red;
            this.sidepanel.Location = new System.Drawing.Point(0, 188);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(17, 62);
            this.sidepanel.TabIndex = 8;
            this.sidepanel.TabStop = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "QUẢN LÝ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 130);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucPhanQuyen1);
            this.panel4.Controls.Add(this.ucThamso1);
            this.panel4.Controls.Add(this.ucBaocaoNam1);
            this.panel4.Controls.Add(this.ucBaocaoMon1);
            this.panel4.Controls.Add(this.ucQuanlyDiem1);
            this.panel4.Controls.Add(this.ucTracuuDiem1);
            this.panel4.Controls.Add(this.ucTraCuuTTHS1);
            this.panel4.Controls.Add(this.quanLyLop1);
            this.panel4.Controls.Add(this.quanly1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(292, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 531);
            this.panel4.TabIndex = 5;
            // 
            // ucTracuuDiem1
            // 
            this.ucTracuuDiem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucTracuuDiem1.Location = new System.Drawing.Point(0, 0);
            this.ucTracuuDiem1.Name = "ucTracuuDiem1";
            this.ucTracuuDiem1.Size = new System.Drawing.Size(831, 531);
            this.ucTracuuDiem1.TabIndex = 3;
            // 
            // ucTraCuuTTHS1
            // 
            this.ucTraCuuTTHS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucTraCuuTTHS1.Location = new System.Drawing.Point(0, 0);
            this.ucTraCuuTTHS1.Name = "ucTraCuuTTHS1";
            this.ucTraCuuTTHS1.Size = new System.Drawing.Size(831, 531);
            this.ucTraCuuTTHS1.TabIndex = 2;
            // 
            // quanLyLop1
            // 
            this.quanLyLop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.quanLyLop1.Location = new System.Drawing.Point(-4, 0);
            this.quanLyLop1.Name = "quanLyLop1";
            this.quanLyLop1.Size = new System.Drawing.Size(832, 531);
            this.quanLyLop1.TabIndex = 1;
            // 
            // quanly1
            // 
            this.quanly1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.quanly1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.quanly1.Dock = System.Windows.Forms.DockStyle.Right;
            this.quanly1.Location = new System.Drawing.Point(0, 0);
            this.quanly1.Name = "quanly1";
            this.quanly1.Size = new System.Drawing.Size(831, 531);
            this.quanly1.TabIndex = 0;
            // 
            // ucQuanlyDiem1
            // 
            this.ucQuanlyDiem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucQuanlyDiem1.Location = new System.Drawing.Point(-1, 0);
            this.ucQuanlyDiem1.Name = "ucQuanlyDiem1";
            this.ucQuanlyDiem1.Size = new System.Drawing.Size(832, 531);
            this.ucQuanlyDiem1.TabIndex = 4;
            // 
            // ucBaocaoMon1
            // 
            this.ucBaocaoMon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucBaocaoMon1.Location = new System.Drawing.Point(0, 0);
            this.ucBaocaoMon1.Name = "ucBaocaoMon1";
            this.ucBaocaoMon1.Size = new System.Drawing.Size(831, 531);
            this.ucBaocaoMon1.TabIndex = 5;
            // 
            // ucBaocaoNam1
            // 
            this.ucBaocaoNam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucBaocaoNam1.Location = new System.Drawing.Point(0, 0);
            this.ucBaocaoNam1.Name = "ucBaocaoNam1";
            this.ucBaocaoNam1.Size = new System.Drawing.Size(831, 531);
            this.ucBaocaoNam1.TabIndex = 6;
            // 
            // ucThamso1
            // 
            this.ucThamso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucThamso1.Location = new System.Drawing.Point(0, 0);
            this.ucThamso1.Name = "ucThamso1";
            this.ucThamso1.Size = new System.Drawing.Size(831, 531);
            this.ucThamso1.TabIndex = 7;
            // 
            // ucPhanQuyen1
            // 
            this.ucPhanQuyen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ucPhanQuyen1.Location = new System.Drawing.Point(0, 0);
            this.ucPhanQuyen1.Name = "ucPhanQuyen1";
            this.ucPhanQuyen1.Size = new System.Drawing.Size(831, 531);
            this.ucPhanQuyen1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1123, 531);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlMainMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ucQuanlyHocsinh quanly1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private ucQuanlylop quanLyLop1;
        private ucTraCuuTTHS ucTraCuuTTHS1;
        private ucTracuuDiem ucTracuuDiem1;
        private ucQuanlyDiem ucQuanlyDiem1;
        private ucBaocaoMon ucBaocaoMon1;
        private ucBaocaoNam ucBaocaoNam1;
        private ucPhanQuyen ucPhanQuyen1;
        private ucThamso ucThamso1;
    }
}

