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
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }

        private void txt_idNCC_Click(object sender, EventArgs e)
        {
            txt_idNCC.BackColor = Color.White;
            panel_idNCC.BackColor = Color.White;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;


        }

        private void txt_Name_Click(object sender, EventArgs e)
        {
            txt_Name.BackColor = Color.White;
            panel_Name.BackColor = Color.White;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
        }

        private void txt_Phone_Click(object sender, EventArgs e)
        {
            txt_Phone.BackColor = Color.White;
            panel_Phone.BackColor = Color.White;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;

        }

        private void txt_DiaChi_Click(object sender, EventArgs e)
        {
            txt_DiaChi.BackColor = Color.White;
            panel_DiaChi.BackColor = Color.White;
            panel_idNCC.BackColor = SystemColors.Control;
            txt_idNCC.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;

        }
        //-----------------   Xử lí logic   -------------------------------------
        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllNhaCungCap().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        DataSet GetAllNhaCungCap()
        {
            DataSet data = new DataSet();

            string query = "select * from NhaCungCap";
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
            txt_idNCC.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idNCC"].Value.ToString();
            txt_Name.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Name"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["DiaChi"].Value.ToString();
            txt_Phone.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Phone"].Value.ToString();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            // lấy thông tin từ các textbox
            string idNCC = txt_idNCC.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string DiaChi = txt_DiaChi.Text.Trim();
            string Phone = txt_Phone.Text.Trim();

            // kiểm tra thông tin đã nhập đầy đủ chưa
            if (idNCC == "" || Name == "" || DiaChi == "" || Phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            // thực hiện thêm dữ liệu vào database
            string query = "insert into NhaCungCap values(@idNCC, @Name, @DiaChi, @Phone)";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idNCC", idNCC);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    // Sau khi thêm dữ liệu, cập nhật lại DataGridView
                    dataGridView1.DataSource = GetAllNhaCungCap().Tables[0];
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

            //lay thong tin tu cac textbox
            string idNCC = txt_idNCC.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string DiaChi = txt_DiaChi.Text.Trim();
            string Phone = txt_Phone.Text.Trim();

            // kiem tra thong tin da nhap du chua
            if (idNCC == "" || Name == "" || DiaChi == "" || Phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            // thuc hien cap nhat du lieu vao database
            string query = "update NhaCungCap set Name = @Name, DiaChi = @DiaChi, Phone = @Phone where idNCC = @idNCC";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idNCC", idNCC);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhà cung cấp thành công");
                    dataGridView1.DataSource = GetAllNhaCungCap().Tables[0];
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
            // lay id cua nha cung cap can xoa
            string idNCC = txt_idNCC.Text.Trim();
            if (string.IsNullOrEmpty(idNCC))
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa!");
                return;
            }
            // thuc hien xoa nha cung cap trong co so du lieu
            string query = "DELETE FROM NhaCungCap WHERE idNCC = @idNCC";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idNCC", idNCC);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa nhà cung cấp thành công!");
                        dataGridView1.DataSource = GetAllNhaCungCap().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp!");
                    }
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
