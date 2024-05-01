using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4_QuanLyThuVienDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.lab4_QuanLyThuVienDataSet.SINHVIEN);

        }

        private void dgv_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_SinhVien.Rows[e.RowIndex];

                txb_MSSV.Text = row.Cells[0].Value.ToString();
                txb_TenSV.Text = row.Cells[1].Value.ToString();
                txb_SDT.Text = row.Cells[2].Value.ToString();
                txb_DiaChi.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
