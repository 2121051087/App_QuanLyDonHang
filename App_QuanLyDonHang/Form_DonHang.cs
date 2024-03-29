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
    public partial class Form_DonHang : Form
    {
        public Form_DonHang()
        {
            InitializeComponent();
        }

        private void Form_DonHang_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetAllDonHang().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        DataSet GetAllDonHang()
        {
            DataSet data = new DataSet();
            string query = "select * from DonHang";
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                  
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return data;
        }

        private void txt_idDH_Click(object sender, EventArgs e)
        {
            txt_idDH.BackColor = Color.White;
            panel_idDH.BackColor = Color.White;
            panel_idKH.BackColor = SystemColors.Control;
            txt_idKH.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            txt_idSP.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;

        }

        private void txt_idSP_Click(object sender, EventArgs e)
        {
            txt_idDH.BackColor = SystemColors.Control;
            panel_idDH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            txt_idKH.BackColor = SystemColors.Control;
            panel_idSP.BackColor = Color.White;
            txt_idSP.BackColor = Color.White;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
        }

        private void txt_idKH_Click(object sender, EventArgs e)
        {
            txt_idDH.BackColor = SystemColors.Control;
            panel_idDH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = Color.White;
            txt_idKH.BackColor = Color.White;
            panel_idSP.BackColor = SystemColors.Control;
            txt_idSP.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
        }

        private void txt_SoLuong_Click(object sender, EventArgs e)
        {
            txt_idDH.BackColor = SystemColors.Control;
            panel_idDH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            txt_idKH.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            txt_idSP.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = Color.White;
            txt_SoLuong.BackColor = Color.White;
            panel_Gia.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
        }

        private void txt_Gia_Click(object sender, EventArgs e)
        {
            txt_idDH.BackColor = SystemColors.Control;
            panel_idDH.BackColor = SystemColors.Control;
            panel_idKH.BackColor = SystemColors.Control;
            txt_idKH.BackColor = SystemColors.Control;
            panel_idSP.BackColor = SystemColors.Control;
            txt_idSP.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_Gia.BackColor = Color.White;
            txt_Gia.BackColor = Color.White;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // lay thong tin tu form
            string idDH = txt_idDH.Text.Trim();
            string idKH = txt_idKH.Text.Trim();
            string idSP = txt_idSP.Text.Trim();
            int soLuong, gia;

            if (!int.TryParse(txt_SoLuong.Text, out soLuong) ||
                !int.TryParse(txt_Gia.Text, out gia))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho số lượng và giá!");
                return;
            }

            // thuc hien them vao csdl
            string query = "INSERT INTO DonHang (idDH, idKH, idSP, SoLuong, Gia) VALUES (@idDH, @idKH, @idSP, @SoLuong, @Gia)";
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@idDH", idDH);
                    command.Parameters.AddWithValue("@idKH", idKH);
                    command.Parameters.AddWithValue("@idSP", idSP);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@Gia", gia);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã thêm đơn hàng mới thành công!");
                        // Cập nhật lại hiển thị danh sách đơn hàng trên giao diện
                        dataGridView1.DataSource = GetAllDonHang().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm đơn hàng mới!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // lay thong tin tu form
            string idDH = txt_idDH.Text.Trim();
            string idKH = txt_idKH.Text.Trim();
            string idSP = txt_idSP.Text.Trim();
            int soLuong, gia;

            if (!int.TryParse(txt_SoLuong.Text, out soLuong) ||
                !int.TryParse(txt_Gia.Text, out gia))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho số lượng và giá!");
                return;
            }

            // thuc hien cap nhat du lieu  vao csdl
            string query = "UPDATE DonHang SET idKH = @idKH, idSP = @idSP, SoLuong = @SoLuong, Gia = @Gia WHERE idDH = @idDH";
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@idDH", idDH);
                    command.Parameters.AddWithValue("@idKH", idKH);
                    command.Parameters.AddWithValue("@idSP", idSP);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@Gia", gia);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật đơn hàng thành công!");
                        // Cập nhật lại hiển thị danh sách đơn hàng trên giao diện
                        dataGridView1.DataSource = GetAllDonHang().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật đơn hàng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }       
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_idDH.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idDH"].Value.ToString();
            txt_idKH.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idKH"].Value.ToString();
            txt_idSP.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["idSP"].Value.ToString();
            txt_SoLuong.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString();
            txt_Gia.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Gia"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // lay idDH cua DonHang can xoa
            string idDH = txt_idDH.Text.Trim();

            if(string.IsNullOrEmpty(idDH))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa!");
                return;
            }

            // thuc hien xoa DonHang
            string query = "DELETE FROM DonHang WHERE idDH = @idDH";
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@idDH", idDH);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa đơn hàng thành công!");
                        // Cập nhật lại hiển thị danh sách đơn hàng trên giao diện
                        dataGridView1.DataSource = GetAllDonHang().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa đơn hàng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }   
        }
    }
}
