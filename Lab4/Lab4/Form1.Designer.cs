namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.panel_Sach = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_XoaSV = new System.Windows.Forms.Button();
            this.chbox_enable_mssv = new System.Windows.Forms.CheckBox();
            this.Cbx_MSSV = new System.Windows.Forms.ComboBox();
            this.rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.txb_TheLoai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_TacGia = new System.Windows.Forms.TextBox();
            this.txb_NXB = new System.Windows.Forms.TextBox();
            this.txb_TenSach = new System.Windows.Forms.TextBox();
            this.txb_MaSach = new System.Windows.Forms.TextBox();
            this.btn_XoaSach = new System.Windows.Forms.Button();
            this.btn_SuaSach = new System.Windows.Forms.Button();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_SinhVien = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.txb_SDT = new System.Windows.Forms.TextBox();
            this.txb_TenSV = new System.Windows.Forms.TextBox();
            this.txb_MSSV = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_QuanLyThuVienDataSet = new Lab4.Lab4_QuanLyThuVienDataSet();
            this.sINHVIENTableAdapter = new Lab4.Lab4_QuanLyThuVienDataSetTableAdapters.SINHVIENTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.panel_Sach.SuspendLayout();
            this.panel_SinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(4, 349);
            this.dgv_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Sach.MultiSelect = false;
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.ReadOnly = true;
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(857, 332);
            this.dgv_Sach.TabIndex = 0;
            this.dgv_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            this.dgv_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            this.dgv_Sach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            this.dgv_Sach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            // 
            // panel_Sach
            // 
            this.panel_Sach.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Sach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Sach.Controls.Add(this.textBox1);
            this.panel_Sach.Controls.Add(this.bttn_XoaSV);
            this.panel_Sach.Controls.Add(this.chbox_enable_mssv);
            this.panel_Sach.Controls.Add(this.Cbx_MSSV);
            this.panel_Sach.Controls.Add(this.rtb_MoTa);
            this.panel_Sach.Controls.Add(this.txb_TheLoai);
            this.panel_Sach.Controls.Add(this.label11);
            this.panel_Sach.Controls.Add(this.label12);
            this.panel_Sach.Controls.Add(this.label13);
            this.panel_Sach.Controls.Add(this.txb_TacGia);
            this.panel_Sach.Controls.Add(this.txb_NXB);
            this.panel_Sach.Controls.Add(this.txb_TenSach);
            this.panel_Sach.Controls.Add(this.txb_MaSach);
            this.panel_Sach.Controls.Add(this.btn_XoaSach);
            this.panel_Sach.Controls.Add(this.btn_SuaSach);
            this.panel_Sach.Controls.Add(this.btn_ThemSach);
            this.panel_Sach.Controls.Add(this.label6);
            this.panel_Sach.Controls.Add(this.label7);
            this.panel_Sach.Controls.Add(this.label8);
            this.panel_Sach.Controls.Add(this.label9);
            this.panel_Sach.Controls.Add(this.label10);
            this.panel_Sach.Controls.Add(this.dgv_Sach);
            this.panel_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Sach.Location = new System.Drawing.Point(16, 129);
            this.panel_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Sach.Name = "panel_Sach";
            this.panel_Sach.Size = new System.Drawing.Size(869, 689);
            this.panel_Sach.TabIndex = 2;
            this.panel_Sach.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Sach_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 30);
            this.textBox1.TabIndex = 36;
            // 
            // bttn_XoaSV
            // 
            this.bttn_XoaSV.Location = new System.Drawing.Point(668, 291);
            this.bttn_XoaSV.Name = "bttn_XoaSV";
            this.bttn_XoaSV.Size = new System.Drawing.Size(123, 51);
            this.bttn_XoaSV.TabIndex = 33;
            this.bttn_XoaSV.Text = "Trả Sách";
            this.bttn_XoaSV.UseVisualStyleBackColor = true;
            this.bttn_XoaSV.Click += new System.EventHandler(this.bttn_XoaSV_Click);
            // 
            // chbox_enable_mssv
            // 
            this.chbox_enable_mssv.AutoSize = true;
            this.chbox_enable_mssv.Location = new System.Drawing.Point(796, 126);
            this.chbox_enable_mssv.Name = "chbox_enable_mssv";
            this.chbox_enable_mssv.Size = new System.Drawing.Size(18, 17);
            this.chbox_enable_mssv.TabIndex = 32;
            this.chbox_enable_mssv.UseVisualStyleBackColor = true;
            this.chbox_enable_mssv.CheckedChanged += new System.EventHandler(this.chbox_enable_mssv_CheckedChanged);
            // 
            // Cbx_MSSV
            // 
            this.Cbx_MSSV.Location = new System.Drawing.Point(668, 118);
            this.Cbx_MSSV.Name = "Cbx_MSSV";
            this.Cbx_MSSV.Size = new System.Drawing.Size(122, 33);
            this.Cbx_MSSV.TabIndex = 34;
            this.Cbx_MSSV.Click += new System.EventHandler(this.Cbx_MSSV_Click);
            // 
            // rtb_MoTa
            // 
            this.rtb_MoTa.Location = new System.Drawing.Point(559, 164);
            this.rtb_MoTa.Name = "rtb_MoTa";
            this.rtb_MoTa.Size = new System.Drawing.Size(232, 96);
            this.rtb_MoTa.TabIndex = 30;
            this.rtb_MoTa.Text = "";
            // 
            // txb_TheLoai
            // 
            this.txb_TheLoai.Location = new System.Drawing.Point(559, 82);
            this.txb_TheLoai.Name = "txb_TheLoai";
            this.txb_TheLoai.Size = new System.Drawing.Size(232, 30);
            this.txb_TheLoai.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Mô Tả:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "MSSV:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(436, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Thể Loại:";
            // 
            // txb_TacGia
            // 
            this.txb_TacGia.Location = new System.Drawing.Point(161, 207);
            this.txb_TacGia.Name = "txb_TacGia";
            this.txb_TacGia.Size = new System.Drawing.Size(232, 30);
            this.txb_TacGia.TabIndex = 24;
            // 
            // txb_NXB
            // 
            this.txb_NXB.Location = new System.Drawing.Point(161, 164);
            this.txb_NXB.Name = "txb_NXB";
            this.txb_NXB.Size = new System.Drawing.Size(232, 30);
            this.txb_NXB.TabIndex = 23;
            // 
            // txb_TenSach
            // 
            this.txb_TenSach.Location = new System.Drawing.Point(161, 122);
            this.txb_TenSach.Name = "txb_TenSach";
            this.txb_TenSach.Size = new System.Drawing.Size(232, 30);
            this.txb_TenSach.TabIndex = 22;
            // 
            // txb_MaSach
            // 
            this.txb_MaSach.Location = new System.Drawing.Point(161, 77);
            this.txb_MaSach.Name = "txb_MaSach";
            this.txb_MaSach.ReadOnly = true;
            this.txb_MaSach.Size = new System.Drawing.Size(232, 30);
            this.txb_MaSach.TabIndex = 35;
            // 
            // btn_XoaSach
            // 
            this.btn_XoaSach.Location = new System.Drawing.Point(458, 291);
            this.btn_XoaSach.Name = "btn_XoaSach";
            this.btn_XoaSach.Size = new System.Drawing.Size(123, 51);
            this.btn_XoaSach.TabIndex = 20;
            this.btn_XoaSach.Text = "Xoá";
            this.btn_XoaSach.UseVisualStyleBackColor = true;
            this.btn_XoaSach.Click += new System.EventHandler(this.btn_XoaSach_Click);
            // 
            // btn_SuaSach
            // 
            this.btn_SuaSach.Location = new System.Drawing.Point(243, 291);
            this.btn_SuaSach.Name = "btn_SuaSach";
            this.btn_SuaSach.Size = new System.Drawing.Size(123, 51);
            this.btn_SuaSach.TabIndex = 19;
            this.btn_SuaSach.Text = "Sửa";
            this.btn_SuaSach.UseVisualStyleBackColor = true;
            this.btn_SuaSach.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Location = new System.Drawing.Point(43, 291);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(123, 51);
            this.btn_ThemSach.TabIndex = 18;
            this.btn_ThemSach.Text = "Thêm";
            this.btn_ThemSach.UseVisualStyleBackColor = true;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tác Giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "NXB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tên Sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(319, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "TABLE: SACH";
            // 
            // panel_SinhVien
            // 
            this.panel_SinhVien.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_SinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_SinhVien.Controls.Add(this.dataGridView1);
            this.panel_SinhVien.Controls.Add(this.txb_DiaChi);
            this.panel_SinhVien.Controls.Add(this.txb_SDT);
            this.panel_SinhVien.Controls.Add(this.txb_TenSV);
            this.panel_SinhVien.Controls.Add(this.txb_MSSV);
            this.panel_SinhVien.Controls.Add(this.btn_Xoa);
            this.panel_SinhVien.Controls.Add(this.btn_Sua);
            this.panel_SinhVien.Controls.Add(this.btn_Them);
            this.panel_SinhVien.Controls.Add(this.label5);
            this.panel_SinhVien.Controls.Add(this.label4);
            this.panel_SinhVien.Controls.Add(this.label3);
            this.panel_SinhVien.Controls.Add(this.label2);
            this.panel_SinhVien.Controls.Add(this.label1);
            this.panel_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_SinhVien.Location = new System.Drawing.Point(893, 129);
            this.panel_SinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.panel_SinhVien.Name = "panel_SinhVien";
            this.panel_SinhVien.Size = new System.Drawing.Size(556, 689);
            this.panel_SinhVien.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 347);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 334);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(188, 203);
            this.txb_DiaChi.MaxLength = 100;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(317, 30);
            this.txb_DiaChi.TabIndex = 12;
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(188, 160);
            this.txb_SDT.MaxLength = 10;
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Size = new System.Drawing.Size(317, 30);
            this.txb_SDT.TabIndex = 11;
            // 
            // txb_TenSV
            // 
            this.txb_TenSV.Location = new System.Drawing.Point(188, 118);
            this.txb_TenSV.MaxLength = 100;
            this.txb_TenSV.Name = "txb_TenSV";
            this.txb_TenSV.Size = new System.Drawing.Size(317, 30);
            this.txb_TenSV.TabIndex = 10;
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.Location = new System.Drawing.Point(188, 78);
            this.txb_MSSV.MaxLength = 50;
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.Size = new System.Drawing.Size(317, 30);
            this.txb_MSSV.TabIndex = 9;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(406, 287);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(123, 51);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(213, 287);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(123, 51);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(20, 287);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(123, 51);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TABLE: SinhVien";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(388, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(790, 62);
            this.label14.TabIndex = 4;
            this.label14.Text = "OU Library Management System";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(24, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 100);
            this.panel1.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(158, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 25);
            this.label18.TabIndex = 3;
            this.label18.Text = "2151013026";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "2151013023";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "2151013022";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "StudentID:";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.lab4_QuanLyThuVienDataSet;
            // 
            // lab4_QuanLyThuVienDataSet
            // 
            this.lab4_QuanLyThuVienDataSet.DataSetName = "Lab4_QuanLyThuVienDataSet";
            this.lab4_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1282, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1465, 828);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel_SinhVien);
            this.Controls.Add(this.panel_Sach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.panel_Sach.ResumeLayout(false);
            this.panel_Sach.PerformLayout();
            this.panel_SinhVien.ResumeLayout(false);
            this.panel_SinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.Panel panel_Sach;
        private System.Windows.Forms.Panel panel_SinhVien;
        private Lab4_QuanLyThuVienDataSet lab4_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private Lab4_QuanLyThuVienDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.TextBox txb_SDT;
        private System.Windows.Forms.TextBox txb_TenSV;
        private System.Windows.Forms.TextBox txb_MSSV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_TacGia;
        private System.Windows.Forms.TextBox txb_NXB;
        private System.Windows.Forms.TextBox txb_TenSach;
        private System.Windows.Forms.TextBox txb_MaSach;
        private System.Windows.Forms.Button btn_XoaSach;
        private System.Windows.Forms.Button btn_SuaSach;
        private System.Windows.Forms.Button btn_ThemSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_TheLoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtb_MoTa;
        private System.Windows.Forms.ComboBox Cbx_MSSV;
        private System.Windows.Forms.CheckBox chbox_enable_mssv;
        private System.Windows.Forms.Button bttn_XoaSV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

