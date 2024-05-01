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
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.lab4_QuanLyThuVienDataSet = new Lab4.Lab4_QuanLyThuVienDataSet();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new Lab4.Lab4_QuanLyThuVienDataSetTableAdapters.SINHVIENTableAdapter();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.panel_Sach.SuspendLayout();
            this.panel_SinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(3, 291);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.Size = new System.Drawing.Size(646, 190);
            this.dgv_Sach.TabIndex = 0;
            // 
            // panel_Sach
            // 
            this.panel_Sach.Controls.Add(this.dgv_Sach);
            this.panel_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Sach.Location = new System.Drawing.Point(12, 12);
            this.panel_Sach.Name = "panel_Sach";
            this.panel_Sach.Size = new System.Drawing.Size(652, 484);
            this.panel_Sach.TabIndex = 2;
            // 
            // panel_SinhVien
            // 
            this.panel_SinhVien.Controls.Add(this.dgv_SinhVien);
            this.panel_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_SinhVien.Location = new System.Drawing.Point(670, 12);
            this.panel_SinhVien.Name = "panel_SinhVien";
            this.panel_SinhVien.Size = new System.Drawing.Size(417, 484);
            this.panel_SinhVien.TabIndex = 3;
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
            this.dgv_SinhVien.Location = new System.Drawing.Point(3, 291);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.Size = new System.Drawing.Size(411, 190);
            this.dgv_SinhVien.TabIndex = 0;
            // 
            // lab4_QuanLyThuVienDataSet
            // 
            this.lab4_QuanLyThuVienDataSet.DataSetName = "Lab4_QuanLyThuVienDataSet";
            this.lab4_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.lab4_QuanLyThuVienDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 499);
            this.Controls.Add(this.panel_SinhVien);
            this.Controls.Add(this.panel_Sach);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.panel_Sach.ResumeLayout(false);
            this.panel_SinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
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
    }
}

