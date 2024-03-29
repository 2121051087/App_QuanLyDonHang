using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLyDonHang
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

       

        // -----------------   Xử lí giao diện  -------------------------------------


        private void txt_account_Click(object sender, EventArgs e)
        {
            txt_account.BackColor = Color.White;
            panel_account.BackColor = Color.White;
            panel_password.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            panel_account.BackColor = SystemColors.Control;
            txt_account.BackColor = SystemColors.Control;

        }

        private void pic_password_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pic_password_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
            
            this.Show();
            form_DangKy.FormClosed += (s, args) => this.Show();
          
            
        }

        private void btn_ForgetPassWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QuenMatKhau form_QuenMatKhau = new Form_QuenMatKhau();
            form_QuenMatKhau.ShowDialog();
            
            this.Show();
            form_QuenMatKhau.FormClosed += (s, args) => this.Show();
            
            
        }
        //----------------   Xử li logic  -------------------------------------------

        Modify modify = new Modify();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tentk = txt_account.Text;
            string matkhau = txt_password.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản !"); }
            else if(matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu !"); }
            else
            {
                string query = "select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if(modify.taiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_TrangChu form_TrangChu = new Form_TrangChu();
                    form_TrangChu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
       





    }
}
