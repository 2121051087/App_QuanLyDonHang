using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLyDonHang
{
    public partial class Form_SanPham : Form
    {
        public Form_SanPham()
        {
            InitializeComponent();
        }

        private void txt_idSP_Click(object sender, EventArgs e)
        {
            txt_idSP.BackColor = Color.White;
            panel_idSP.BackColor = Color.White;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;

        }

        private void txt_idNCC_Click(object sender, EventArgs e)
        {
            txt_idSP.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_idNCC.BackColor = Color.White;
            txt_idNCC.BackColor = Color.White;
        }

        private void txt_Name_Click(object sender, EventArgs e)
        {
            txt_idSP.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            panel_Name.BackColor = Color.White;
            txt_Name.BackColor = Color.White;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;

        }

        private void txt_MoTa_Click(object sender, EventArgs e)
        {
            txt_idSP.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = Color.White;
            txt_Mota.BackColor = Color.White;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;
        }

        private void txt_Gia_Click(object sender, EventArgs e)
        {
            txt_idSP.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_Gia.BackColor = Color.White;
            txt_Gia.BackColor = Color.White;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;
        }
        // -----------------   Xử lí logic   -------------------------------------

        private void Form_SanPham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllSanPham().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        DataSet GetAllSanPham()
        {
            DataSet data = new DataSet();

            string query = "select * from SanPham";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_Gia.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Gia"].Value.ToString();
            txt_idNCC.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idNCC"].Value.ToString();
            txt_Mota.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Mota"].Value.ToString();
            txt_Name.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Name"].Value.ToString();
            txt_idSP.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idSP"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // lay thoong tin tu text box
            string idSP = txt_idSP.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string Gia = txt_Gia.Text.Trim();
            string Mota = txt_Mota.Text.Trim();
            string idNCC = txt_idNCC.Text.Trim();

            //kiem tra du lieu da nhap day du chua
            if (idSP == "" || Name == "" || Gia == "" || Mota == "" || idNCC == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            // thuc hien them du lieu vao database
            string query = "insert into SanPham values(@idSP, @Name, @Gia, @Mota, @idNCC)";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idSP", idSP);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Gia", Gia);
                    command.Parameters.AddWithValue("@Mota", Mota);
                    command.Parameters.AddWithValue("@idNCC", idNCC);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu thành công");

                    dataGridView1.DataSource = GetAllSanPham().Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // lay du lieu tu text box
            string idSP = txt_idSP.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string Gia = txt_Gia.Text.Trim();
            string Mota = txt_Mota.Text.Trim();
            string idNCC = txt_idNCC.Text.Trim();

            //kiem tra du lieu da nhap day du chua  
            if (idSP == "" || Name == "" || Gia == "" || Mota == "" || idNCC == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // thuc hien cap nhat du lieu vao database
            string query = "update SanPham set Name = @Name, Gia = @Gia, Mota = @Mota, idNCC = @idNCC where idSP = @idSP";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idSP", idSP);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Gia", Gia);
                    command.Parameters.AddWithValue("@Mota", Mota);
                    command.Parameters.AddWithValue("@idNCC", idNCC);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu thành công");

                    dataGridView1.DataSource = GetAllSanPham().Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //lay idSP cua san pham can xoa
            string idSP = txt_idSP.Text;
            if (string.IsNullOrEmpty(idSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }
            //thuc hien xoa san pham trong database
            string query = "delete from SanPham where idSP = @idSP";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idSP", idSP);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công");

                    dataGridView1.DataSource = GetAllSanPham().Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
