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
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
        {
            InitializeComponent();
            lb_KetQua.Text= "";
        }

        

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            panel_Email.BackColor = Color.White;
            lb_Email.BackColor = Color.FromArgb(33, 121, 184);
            lb_Email.ForeColor = Color.White;
            txt_Email.BackColor = Color.White;
        }

        Modify modify= new Modify();

        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng kí!"); }
            else
            {
                string query = "Select * from TaiKhoan where email = '" + email + "'";
                if (modify.taiKhoans(query).Count != 0)
                {
                    lb_KetQua.ForeColor = Color.Green;
                    lb_KetQua.Text = "Mật khẩu của bạn là : " + modify.taiKhoans(query)[0].MatKhau;
                }
                else
                {
                    lb_KetQua.ForeColor = Color.Red;
                    lb_KetQua.Text = "Email chưa được đăng ký !";
                }

            }
        }
    }
}
