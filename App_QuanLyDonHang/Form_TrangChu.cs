using App_QuanLyDonHang.Properties;
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
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }
        private bool check;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panel1.Width += 20;
                if (panel1.Size == panel1.MaximumSize)
                {
                    pic_Menu.Left += 110;
                    timer1.Stop();
                    check = false;
                    pic_Menu.Image = Resources.arrow;
                }
            }
            else
            {
                panel1.Width -= 20;
                if (panel1.Size == panel1.MinimumSize)
                {
                    pic_Menu.Left = 10;
                    timer1.Stop();
                    check = true;
                    pic_Menu.Image = Resources.justified_text;
                }
            }

        }

        private void pic_Menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void ShowMenuPopup()
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }
        private void pic_dot_Click(object sender, EventArgs e)
        {
            ShowMenuPopup();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.ShowDialog();
            this.Close();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DonHang form_DonHang = new Form_DonHang();
            form_DonHang.ShowDialog();

            this.Show();
            form_DonHang.FormClosed += (s, args) => this.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_KhachHang form_KhachHang = new Form_KhachHang();
            form_KhachHang.ShowDialog();

            this.Show();
            form_KhachHang.FormClosed += (s, args) => this.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SanPham form_SanPham = new Form_SanPham();
            form_SanPham.ShowDialog();

            this.Show();
            form_SanPham.FormClosed += (s, args) => this.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhaCungCap form_NhaCungCap = new Form_NhaCungCap();
            form_NhaCungCap.ShowDialog();

            this.Show();
            form_NhaCungCap.FormClosed += (s, args) => this.Show();
        }
    }
}
