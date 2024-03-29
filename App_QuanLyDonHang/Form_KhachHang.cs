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
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void txt_idKH_Click(object sender, EventArgs e)
        {
            txt_idKH.BackColor = Color.White;
            panel_idKH.BackColor = Color.White;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_NgaySinh.BackColor = SystemColors.Control;
            txt_NgaySinh.BackColor = SystemColors.Control;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;

        }

        private void txt_Name_Click(object sender, EventArgs e)
        {
            txt_idKH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            panel_Name.BackColor = Color.White;
            txt_Name.BackColor = Color.White;
            panel_NgaySinh.BackColor = SystemColors.Control;
            txt_NgaySinh.BackColor = SystemColors.Control;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;
        }

        private void txt_NgaySinh_Click(object sender, EventArgs e)
        {
            txt_idKH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_NgaySinh.BackColor = Color.White;
            txt_NgaySinh.BackColor = Color.White;
            panel_Phone.BackColor = SystemColors.Control;
            txt_Phone.BackColor = SystemColors.Control;

        }

        private void txt_Phone_Click(object sender, EventArgs e)
        {
            txt_idKH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            panel_Name.BackColor = SystemColors.Control;
            txt_Name.BackColor = SystemColors.Control;
            panel_NgaySinh.BackColor = SystemColors.Control;
            txt_NgaySinh.BackColor = SystemColors.Control;
            panel_Phone.BackColor = Color.White;
            txt_Phone.BackColor = Color.White;
        }
        // -----------------   Xử lí logic   -------------------------------------
        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllKhachHang().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        DataSet GetAllKhachHang()
        {
            DataSet data = new DataSet();
            string query = "select * from KhachHang";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }   
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_idKH.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idKH"].Value.ToString();
            txt_Name.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Name"].Value.ToString();
            txt_NgaySinh.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value.ToString();
            txt_Phone.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Phone"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu trên giao diện
            string idKH = txt_idKH.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string NgaySinh = txt_NgaySinh.Text.Trim();
            string Phone = txt_Phone.Text.Trim();

            // Kiểm tra dữ liệu nhập liệu
            if (string.IsNullOrEmpty(idKH) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(NgaySinh) || string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            // Thực hiện thêm dữ liệu vào database
            string query = "insert into KhachHang values(@idKH, @Name, @NgaySinh, @Phone)";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idKH", idKH);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    dataGridView1.DataSource = GetAllKhachHang().Tables[0];
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
            // Lấy thông tin từ các ô nhập liệu trên giao diện
            string idKH = txt_idKH.Text.Trim();
            string Name = txt_Name.Text.Trim();
            string NgaySinh = txt_NgaySinh.Text.Trim();
            string Phone = txt_Phone.Text.Trim();

            // Kiểm tra dữ liệu nhập liệu
            if (string.IsNullOrEmpty(idKH) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(NgaySinh) || string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            // thực hiện cập nhật dữ liệu vào database\
            string query = "update KhachHang set Name = @Name, NgaySinh = @NgaySinh, Phone = @Phone where idKH = @idKH";
            using (SqlConnection connection =  ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idKH", idKH);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    dataGridView1.DataSource = GetAllKhachHang().Tables[0];
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
            // Lấy idKH của khách hàng cần xóa
            string idKH = txt_idKH.Text.Trim();
            if (string.IsNullOrEmpty(idKH))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!");
                return;
            }
            // Thực hiện xóa khách hàng trong cơ sở dữ liệu
            string query = "delete from KhachHang where idKH = @idKH";
            using (SqlConnection connection = ConnectionString.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idKH", idKH);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công!");
                    dataGridView1.DataSource = GetAllKhachHang().Tables[0];
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
