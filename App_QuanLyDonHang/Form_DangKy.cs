using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLyDonHang
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
            radioButton_agree.CheckedChanged += radioButton_agree_CheckedChanged;

            btn_SignUp.Enabled = false;
            btn_SignUp.BackColor = SystemColors.Control;
        }

        private void txt_UserName_Click(object sender, EventArgs e)
        {
            txt_UserName.BackColor = Color.White;
            panel_userName.BackColor = Color.White;
            panel_password.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
            panel_reEnter.BackColor = SystemColors.Control;
            txt_Re_Enter_Password.BackColor = SystemColors.Control;
            panel_Email.BackColor = SystemColors.Control;
            txt_Email.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_UserName.BackColor = SystemColors.Control;
            panel_userName.BackColor = SystemColors.Control;
            panel_password.BackColor = Color.White;
            txt_password.BackColor = Color.White;
            panel_reEnter.BackColor = SystemColors.Control;
            txt_Re_Enter_Password.BackColor = SystemColors.Control;
            panel_Email.BackColor = SystemColors.Control;
            txt_Email.BackColor = SystemColors.Control;
        }

        private void txt_Re_Enter_Password_Click(object sender, EventArgs e)
        {
            txt_UserName.BackColor = SystemColors.Control;
            panel_userName.BackColor = SystemColors.Control;
            panel_password.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
            panel_reEnter.BackColor = Color.White; 
            txt_Re_Enter_Password.BackColor = Color.White;
            panel_Email.BackColor = SystemColors.Control;
            txt_Email.BackColor = SystemColors.Control;
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            txt_UserName.BackColor = SystemColors.Control;
            panel_userName.BackColor = SystemColors.Control;
            panel_password.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
            panel_reEnter.BackColor = SystemColors.Control;
            txt_Re_Enter_Password.BackColor = SystemColors.Control;
            panel_Email.BackColor = Color.White;
            txt_Email.BackColor = Color.White;
        }

        private void radioButton_agree_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_agree.Checked )
            {
                btn_SignUp.Enabled = true;
                btn_SignUp.BackColor = Color.FromArgb(33, 121, 184);
            }
            else
            {
                btn_SignUp.Enabled = false;
                btn_SignUp.BackColor = Color.Black;
            }
        }
        // -----------------  Xu li logic  -------------------------------------


        public bool checkAccount(string ac)// check mat khau va tai khoan 
        {
            return Regex.IsMatch(ac, @"^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string email)// check email
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            // lay du lieu tu form
            string tentk = txt_UserName.Text;
            string matkhau = txt_password.Text;
            string XacNhanMatKhau = txt_Re_Enter_Password.Text;
            string email = txt_Email.Text;


            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự , với các  ký tự chữ và số , chữc hoa và chữ thường "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự , với các  ký tự chữ và số , chữc hoa và chữ thường "); return; }
            if (XacNhanMatKhau != matkhau) { MessageBox.Show("Mật khẩu không trùng khớp !"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập email đúng định dạng !"); return; }
            if (modify.taiKhoans("Select * from TaiKhoan where email = '" + email + "'").Count != 0) { MessageBox.Show("Email đã tồn tại !"); return; }
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công ! Bạn có muốn đăng nhập luôn không ?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    Form_DangNhap form_DangNhap = new Form_DangNhap();
                    form_DangNhap.ShowDialog();
                    this.Close();
                };
                
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký , vui lòng đăng ký tên khác !"); return;
            }

        }
    }
}
