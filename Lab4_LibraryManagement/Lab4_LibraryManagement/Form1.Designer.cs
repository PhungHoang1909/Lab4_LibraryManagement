namespace Lab4_LibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_book = new Panel();
            btn_XoaSACH = new Button();
            btn_SuaSACH = new Button();
            btn_ThemSACH = new Button();
            txb_MoTa = new RichTextBox();
            txb_TheLoai = new TextBox();
            txb_TacGia = new TextBox();
            txb_NXB = new TextBox();
            txb_TenSach = new TextBox();
            txb_MaSach = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            btn_XoaSV = new Button();
            btn_SuaSV = new Button();
            btn_ThemSV = new Button();
            txb_DiaChi = new TextBox();
            txb_SDT = new TextBox();
            txb_TenSV = new TextBox();
            txb_MSSV = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dgv_Sach = new DataGridView();
            dgv_SV = new DataGridView();
            comboBox1 = new ComboBox();
            panel_book.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SV).BeginInit();
            SuspendLayout();
            // 
            // panel_book
            // 
            panel_book.Controls.Add(btn_XoaSACH);
            panel_book.Controls.Add(btn_SuaSACH);
            panel_book.Controls.Add(btn_ThemSACH);
            panel_book.Controls.Add(txb_MoTa);
            panel_book.Controls.Add(txb_TheLoai);
            panel_book.Controls.Add(txb_TacGia);
            panel_book.Controls.Add(txb_NXB);
            panel_book.Controls.Add(txb_TenSach);
            panel_book.Controls.Add(txb_MaSach);
            panel_book.Controls.Add(label7);
            panel_book.Controls.Add(label6);
            panel_book.Controls.Add(label5);
            panel_book.Controls.Add(label4);
            panel_book.Controls.Add(label3);
            panel_book.Controls.Add(label2);
            panel_book.Controls.Add(label1);
            panel_book.Location = new Point(72, 24);
            panel_book.Margin = new Padding(5);
            panel_book.Name = "panel_book";
            panel_book.Size = new Size(554, 509);
            panel_book.TabIndex = 0;
            // 
            // btn_XoaSACH
            // 
            btn_XoaSACH.Location = new Point(395, 437);
            btn_XoaSACH.Name = "btn_XoaSACH";
            btn_XoaSACH.Size = new Size(143, 49);
            btn_XoaSACH.TabIndex = 16;
            btn_XoaSACH.Text = "Xoá";
            btn_XoaSACH.UseVisualStyleBackColor = true;
            // 
            // btn_SuaSACH
            // 
            btn_SuaSACH.Location = new Point(209, 437);
            btn_SuaSACH.Name = "btn_SuaSACH";
            btn_SuaSACH.Size = new Size(143, 49);
            btn_SuaSACH.TabIndex = 15;
            btn_SuaSACH.Text = "Sửa";
            btn_SuaSACH.UseVisualStyleBackColor = true;
            // 
            // btn_ThemSACH
            // 
            btn_ThemSACH.Location = new Point(19, 437);
            btn_ThemSACH.Name = "btn_ThemSACH";
            btn_ThemSACH.Size = new Size(143, 49);
            btn_ThemSACH.TabIndex = 14;
            btn_ThemSACH.Text = "Thêm";
            btn_ThemSACH.UseVisualStyleBackColor = true;
            // 
            // txb_MoTa
            // 
            txb_MoTa.Location = new Point(168, 288);
            txb_MoTa.Name = "txb_MoTa";
            txb_MoTa.Size = new Size(338, 120);
            txb_MoTa.TabIndex = 13;
            txb_MoTa.Text = "";
            // 
            // txb_TheLoai
            // 
            txb_TheLoai.Location = new Point(168, 243);
            txb_TheLoai.Name = "txb_TheLoai";
            txb_TheLoai.Size = new Size(338, 38);
            txb_TheLoai.TabIndex = 11;
            // 
            // txb_TacGia
            // 
            txb_TacGia.Location = new Point(168, 195);
            txb_TacGia.Name = "txb_TacGia";
            txb_TacGia.Size = new Size(338, 38);
            txb_TacGia.TabIndex = 10;
            // 
            // txb_NXB
            // 
            txb_NXB.Location = new Point(168, 151);
            txb_NXB.Name = "txb_NXB";
            txb_NXB.Size = new Size(338, 38);
            txb_NXB.TabIndex = 9;
            // 
            // txb_TenSach
            // 
            txb_TenSach.Location = new Point(168, 107);
            txb_TenSach.Name = "txb_TenSach";
            txb_TenSach.Size = new Size(338, 38);
            txb_TenSach.TabIndex = 8;
            // 
            // txb_MaSach
            // 
            txb_MaSach.Location = new Point(168, 63);
            txb_MaSach.Name = "txb_MaSach";
            txb_MaSach.Size = new Size(338, 38);
            txb_MaSach.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 291);
            label7.Name = "label7";
            label7.Size = new Size(74, 31);
            label7.TabIndex = 6;
            label7.Text = "MoTa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 246);
            label6.Name = "label6";
            label6.Size = new Size(98, 31);
            label6.TabIndex = 5;
            label6.Text = "TheLoai:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 198);
            label5.Name = "label5";
            label5.Size = new Size(85, 31);
            label5.TabIndex = 4;
            label5.Text = "TacGia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 154);
            label4.Name = "label4";
            label4.Size = new Size(63, 31);
            label4.TabIndex = 3;
            label4.Text = "NXB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 113);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 2;
            label3.Text = "TenSach:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 66);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 1;
            label2.Text = "MaSach:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(180, 13);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 0;
            label1.Text = "TABLE: SACH";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btn_XoaSV);
            panel1.Controls.Add(btn_SuaSV);
            panel1.Controls.Add(btn_ThemSV);
            panel1.Controls.Add(txb_DiaChi);
            panel1.Controls.Add(txb_SDT);
            panel1.Controls.Add(txb_TenSV);
            panel1.Controls.Add(txb_MSSV);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(720, 24);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 486);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 294);
            label8.Name = "label8";
            label8.Size = new Size(95, 31);
            label8.TabIndex = 11;
            label8.Text = "MaSach";
            // 
            // btn_XoaSV
            // 
            btn_XoaSV.Location = new Point(398, 384);
            btn_XoaSV.Name = "btn_XoaSV";
            btn_XoaSV.Size = new Size(143, 49);
            btn_XoaSV.TabIndex = 16;
            btn_XoaSV.Text = "Xoá";
            btn_XoaSV.UseVisualStyleBackColor = true;
            // 
            // btn_SuaSV
            // 
            btn_SuaSV.Location = new Point(212, 384);
            btn_SuaSV.Name = "btn_SuaSV";
            btn_SuaSV.Size = new Size(143, 49);
            btn_SuaSV.TabIndex = 15;
            btn_SuaSV.Text = "Sửa";
            btn_SuaSV.UseVisualStyleBackColor = true;
            // 
            // btn_ThemSV
            // 
            btn_ThemSV.Location = new Point(22, 384);
            btn_ThemSV.Name = "btn_ThemSV";
            btn_ThemSV.Size = new Size(143, 49);
            btn_ThemSV.TabIndex = 14;
            btn_ThemSV.Text = "Thêm";
            btn_ThemSV.UseVisualStyleBackColor = true;
            // 
            // txb_DiaChi
            // 
            txb_DiaChi.Location = new Point(180, 245);
            txb_DiaChi.Name = "txb_DiaChi";
            txb_DiaChi.Size = new Size(338, 38);
            txb_DiaChi.TabIndex = 10;
            // 
            // txb_SDT
            // 
            txb_SDT.Location = new Point(180, 201);
            txb_SDT.Name = "txb_SDT";
            txb_SDT.Size = new Size(338, 38);
            txb_SDT.TabIndex = 9;
            // 
            // txb_TenSV
            // 
            txb_TenSV.Location = new Point(180, 157);
            txb_TenSV.Name = "txb_TenSV";
            txb_TenSV.Size = new Size(338, 38);
            txb_TenSV.TabIndex = 8;
            // 
            // txb_MSSV
            // 
            txb_MSSV.Location = new Point(180, 113);
            txb_MSSV.Name = "txb_MSSV";
            txb_MSSV.Size = new Size(338, 38);
            txb_MSSV.TabIndex = 7;
            txb_MSSV.TextChanged += txb_MSSV_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 248);
            label10.Name = "label10";
            label10.Size = new Size(86, 31);
            label10.TabIndex = 4;
            label10.Text = "DiaChi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 204);
            label11.Name = "label11";
            label11.Size = new Size(58, 31);
            label11.TabIndex = 3;
            label11.Text = "SDT:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 163);
            label12.Name = "label12";
            label12.Size = new Size(80, 31);
            label12.TabIndex = 2;
            label12.Text = "TenSV:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 116);
            label13.Name = "label13";
            label13.Size = new Size(78, 31);
            label13.TabIndex = 1;
            label13.Text = "MSSV:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(180, 13);
            label14.Name = "label14";
            label14.Size = new Size(186, 31);
            label14.TabIndex = 0;
            label14.Text = "TABLE: SINHVIEN";
            // 
            // dgv_Sach
            // 
            dgv_Sach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sach.Location = new Point(32, 541);
            dgv_Sach.Name = "dgv_Sach";
            dgv_Sach.RowHeadersWidth = 51;
            dgv_Sach.Size = new Size(619, 343);
            dgv_Sach.TabIndex = 2;
            // 
            // dgv_SV
            // 
            dgv_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SV.Location = new Point(675, 541);
            dgv_SV.Name = "dgv_SV";
            dgv_SV.RowHeadersWidth = 51;
            dgv_SV.Size = new Size(622, 343);
            dgv_SV.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "123123\t", "1548" });
            comboBox1.Location = new Point(180, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 39);
            comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 896);
            Controls.Add(dgv_SV);
            Controls.Add(dgv_Sach);
            Controls.Add(panel1);
            Controls.Add(panel_book);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management";
            panel_book.ResumeLayout(false);
            panel_book.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_book;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox txb_MoTa;
        private TextBox txb_TheLoai;
        private TextBox txb_TacGia;
        private TextBox txb_NXB;
        private TextBox txb_TenSach;
        private TextBox txb_MaSach;
        private Button btn_XoaSACH;
        private Button btn_SuaSACH;
        private Button btn_ThemSACH;
        private Panel panel1;
        private Button btn_XoaSV;
        private Button btn_SuaSV;
        private Button btn_ThemSV;
        private TextBox txb_DiaChi;
        private TextBox txb_SDT;
        private TextBox txb_TenSV;
        private TextBox txb_MSSV;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView dgv_Sach;
        private DataGridView dgv_SV;
        private Label label8;
        private ComboBox comboBox1;
    }
}
