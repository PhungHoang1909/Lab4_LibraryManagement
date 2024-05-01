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
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.panel_Sach = new System.Windows.Forms.Panel();
            this.panel_SinhVien = new System.Windows.Forms.Panel();
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
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_QuanLyThuVienDataSet = new Lab4.Lab4_QuanLyThuVienDataSet();
            this.sINHVIENTableAdapter = new Lab4.Lab4_QuanLyThuVienDataSetTableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.panel_Sach.SuspendLayout();
            this.panel_SinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(4, 358);
            this.dgv_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.Size = new System.Drawing.Size(861, 392);
            this.dgv_Sach.TabIndex = 0;
            // 
            // panel_Sach
            // 
            this.panel_Sach.Controls.Add(this.dgv_Sach);
            this.panel_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Sach.Location = new System.Drawing.Point(16, 15);
            this.panel_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Sach.Name = "panel_Sach";
            this.panel_Sach.Size = new System.Drawing.Size(869, 754);
            this.panel_Sach.TabIndex = 2;
            // 
            // panel_SinhVien
            // 
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
            this.panel_SinhVien.Controls.Add(this.dgv_SinhVien);
            this.panel_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_SinhVien.Location = new System.Drawing.Point(893, 15);
            this.panel_SinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.panel_SinhVien.Name = "panel_SinhVien";
            this.panel_SinhVien.Size = new System.Drawing.Size(556, 754);
            this.panel_SinhVien.TabIndex = 3;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(188, 203);
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(317, 30);
            this.txb_DiaChi.TabIndex = 12;
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(188, 160);
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Size = new System.Drawing.Size(317, 30);
            this.txb_SDT.TabIndex = 11;
            // 
            // txb_TenSV
            // 
            this.txb_TenSV.Location = new System.Drawing.Point(188, 118);
            this.txb_TenSV.Name = "txb_TenSV";
            this.txb_TenSV.Size = new System.Drawing.Size(317, 30);
            this.txb_TenSV.TabIndex = 10;
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.Location = new System.Drawing.Point(188, 78);
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
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(213, 287);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(123, 51);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
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
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.AutoGenerateColumns = false;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSSVDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.dgv_SinhVien.DataSource = this.sINHVIENBindingSource;
            this.dgv_SinhVien.Location = new System.Drawing.Point(4, 358);
            this.dgv_SinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.Size = new System.Drawing.Size(548, 392);
            this.dgv_SinhVien.TabIndex = 0;
            this.dgv_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellContentClick);
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 782);
            this.Controls.Add(this.panel_SinhVien);
            this.Controls.Add(this.panel_Sach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.panel_Sach.ResumeLayout(false);
            this.panel_SinhVien.ResumeLayout(false);
            this.panel_SinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.Panel panel_Sach;
        private System.Windows.Forms.Panel panel_SinhVien;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private Lab4_QuanLyThuVienDataSet lab4_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private Lab4_QuanLyThuVienDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
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
    }
}

