using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Form1 : Form
    {
        // Remember to change connectionString to YOURS
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=Lab4_QuanLyThuVien;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            
           conn.Open();
           string query = "SELECT * FROM SINHVIEN";
           SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
           DataTable table = new DataTable();
           adapter.Fill(table);
           dataGridView1.DataSource = table;
           conn.Close();
            
        }

        private void LoadMSSV()
        {
            conn.Open();
            string query = "SELECT MSSV FROM SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Cbx_MSSV.DataSource = ds;
            conn.Close();

            Cbx_MSSV.DataSource = ds.Tables[0]; // You need to bind to the DataTable, not the entire DataSet
            Cbx_MSSV.DisplayMember = "MSSV"; // Specify the display member
            Cbx_MSSV.ValueMember = "MSSV"; // Specify the value member
        }

        private void LoadGridSach()
        {

            conn.Open();
            string query = "SELECT * FROM SACH";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_Sach.DataSource = table;
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4_QuanLyThuVienDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            LoadGrid();
            LoadGridSach();
            LoadMSSV();

        }



        /*private void LoadData()
        {
            string query = "SELECT * FROM SINHVIEN";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);
                }
            }

            dataGridView1.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int mssv = int.Parse(txb_MSSV.Text);
            string tenSV = txb_TenSV.Text;
            string sdt = txb_SDT.Text;
            string diaChi = txb_DiaChi.Text;

            string query = "INSERT INTO SINHVIEN (MSSV, TenSV, SDT, DiaChi) VALUES (@MSSV, @TenSV, @SDT, @DiaChi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MSSV", mssv);
                    command.Parameters.AddWithValue("@TenSV", tenSV);
                    command.Parameters.AddWithValue("@SDT", sdt);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully.");

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add data.");
                    }
                }
            }
        }*/
        private void ClearText()
        {
            txb_MSSV.Text = "";
            txb_TenSV.Text = "";
            txb_SDT.Text = "";
            txb_DiaChi.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txb_MSSV.Text = row.Cells[0].Value.ToString();
                txb_TenSV.Text = row.Cells[1].Value.ToString();
                txb_SDT.Text = row.Cells[2].Value.ToString();
                txb_DiaChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int mssv = int.Parse(txb_MSSV.Text);
            string tenSV = txb_TenSV.Text;
            string sdt = txb_SDT.Text;
            string diaChi = txb_DiaChi.Text;

            string query = "INSERT INTO SINHVIEN (MSSV, TenSV, SDT, DiaChi) VALUES (@MSSV, @TenSV, @SDT, @DiaChi)";
            
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MSSV", mssv);
                command.Parameters.AddWithValue("@TenSV", tenSV);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@DiaChi", diaChi);

                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data added successfully.");

                    LoadGrid();
                    LoadMSSV();
                }
                else
                {
                    MessageBox.Show("Failed to add data.");
                }
            }
            ClearText();
        }


        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            // Check if MSSV is provided
            if (string.IsNullOrEmpty(txb_MSSV.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            int mssv = int.Parse(txb_MSSV.Text);
            string tenSV = txb_TenSV.Text;
            string sdt = txb_SDT.Text;
            string diaChi = txb_DiaChi.Text;

            string query = "UPDATE SINHVIEN SET TenSV = @TenSV, SDT = @SDT, DiaChi = @DiaChi WHERE MSSV = @MSSV";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MSSV", mssv);
                command.Parameters.AddWithValue("@TenSV", tenSV);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@DiaChi", diaChi);

                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully.");
                    LoadMSSV();
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Failed to update data.");
                }
            }
            ClearText();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int mssvToDelete = int.Parse(txb_MSSV.Text); // Assuming txb_MSSVToDelete is a TextBox where the user inputs the MSSV to delete

            string query = "DELETE FROM SINHVIEN WHERE MSSV = @MSSV";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MSSV", mssvToDelete);

                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted successfully.");
                    ClearText();
                    LoadMSSV();
                    LoadGrid(); // Assuming LoadGrid() reloads the data grid after a change
                }
                else
                {
                    MessageBox.Show("Failed to delete data. MSSV not found.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if MaSach is provided
            if (string.IsNullOrEmpty(txb_MaSach.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            int maSach = int.Parse(txb_MaSach.Text);
            string tenSach = txb_TenSach.Text;
            string nxb = txb_NXB.Text;
            string Tacgia = txb_TacGia.Text;
            string theloai = txb_TheLoai.Text;
            int? mssv = null;
            if (!string.IsNullOrEmpty(Cbx_MSSV.Text))
            {
                mssv = int.Parse(Cbx_MSSV.Text);
            }
            string mota = rtb_MoTa.Text;

            string query = "UPDATE SACH SET TenSach = @TenSach, NXB = @nxb, TG = @Tacgia, TheLoai = @theloai, MoTa = @mota";

            // Add MSSV to the query if it's provided
            if (mssv.HasValue)
            {
                query += ", MSSV = @MSSV";
            }
            query += " WHERE MaSach = @maSach";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@maSach", maSach);
                command.Parameters.AddWithValue("@TenSach", tenSach);
                command.Parameters.AddWithValue("@nxb", nxb);
                command.Parameters.AddWithValue("@Tacgia", Tacgia);
                command.Parameters.AddWithValue("@theloai", theloai);
                command.Parameters.AddWithValue("@mota", mota);

                // Add MSSV parameter if it's provided
                if (mssv.HasValue)
                {
                    command.Parameters.AddWithValue("@MSSV", mssv.Value);
                }

                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully.");
                    LoadMSSV();
                    LoadGrid();
                    LoadGridSach();
                }
                else
                {
                    MessageBox.Show("Failed to update data.");
                }
            }
            ClearText();
        }

        /*      private void button2_Click(object sender, EventArgs e)
              {
                  // Check if MSSV is provided
                  if (string.IsNullOrEmpty(txb_MaSach.Text))
                  {
                      MessageBox.Show("Please select a row to update.");
                      return;
                  }

                  int maSach = int.Parse(txb_MaSach.Text);
                  string tenSach = txb_TenSach.Text;
                  string nxb = txb_NXB.Text;
                  string Tacgia = txb_TacGia.Text;
                  string theloai = txb_TheLoai.Text;
                  int mssv = int.Parse(Cbx_MSSV.Text);
                  string mota = rtb_MoTa.Text;

                  string query = "UPDATE SACH SET TenSach = @tenSach, NXB = @nxb, TG = @Tacgia, TheLoai = @Tacgia, MoTa = @mota, MSSV = @mssv WHERE MaSach = @maSach";

                  using (SqlCommand command = new SqlCommand(query, conn))
                  {
                      command.Parameters.AddWithValue("@maSach", maSach);
                      command.Parameters.AddWithValue("@MSSV", mssv);
                      command.Parameters.AddWithValue("@TenSach", tenSach);
                      command.Parameters.AddWithValue("@nxb", nxb);
                      command.Parameters.AddWithValue("@tacgia", Tacgia);
                      command.Parameters.AddWithValue("@theloai", theloai);
                      command.Parameters.AddWithValue("@mota", mota);

                      conn.Open();
                      int rowsAffected = command.ExecuteNonQuery();
                      conn.Close();

                      if (rowsAffected > 0)
                      {
                          MessageBox.Show("Data updated successfully.");
                          LoadMSSV();
                          LoadGrid();
                          LoadGridSach();
                      }
                      else
                      {
                          MessageBox.Show("Failed to update data.");
                      }
                  }
                  ClearText();
              }*/

        private void dgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Sach.Rows[e.RowIndex];

                txb_MaSach.Text = row.Cells[0].Value.ToString();
                txb_TenSach.Text = row.Cells[1].Value.ToString();
                txb_NXB.Text = row.Cells[2].Value.ToString();
                txb_TacGia.Text = row.Cells[3].Value.ToString();
                txb_TheLoai.Text = row.Cells[4].Value.ToString();
                rtb_MoTa.Text = row.Cells[5].Value.ToString();
                Cbx_MSSV.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Cbx_MSSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
