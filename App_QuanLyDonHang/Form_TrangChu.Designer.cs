namespace App_QuanLyDonHang
{
    partial class Form_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_dot = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dot)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic_Menu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(230, 530);
            this.panel1.MinimumSize = new System.Drawing.Size(80, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 530);
            this.panel1.TabIndex = 0;
            // 
            // pic_Menu
            // 
            this.pic_Menu.Image = global::App_QuanLyDonHang.Properties.Resources.justified_text;
            this.pic_Menu.Location = new System.Drawing.Point(20, 44);
            this.pic_Menu.Name = "pic_Menu";
            this.pic_Menu.Size = new System.Drawing.Size(42, 42);
            this.pic_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Menu.TabIndex = 1;
            this.pic_Menu.TabStop = false;
            this.pic_Menu.Click += new System.EventHandler(this.pic_Menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.btn_NhaCungCap);
            this.panel2.Controls.Add(this.btn_KhachHang);
            this.panel2.Controls.Add(this.btn_SanPham);
            this.panel2.Controls.Add(this.btn_DonHang);
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.MaximumSize = new System.Drawing.Size(230, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 414);
            this.panel2.TabIndex = 0;
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.FlatAppearance.BorderSize = 0;
            this.btn_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.Image = global::App_QuanLyDonHang.Properties.Resources.wholesale;
            this.btn_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(0, 270);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_NhaCungCap.Size = new System.Drawing.Size(230, 64);
            this.btn_NhaCungCap.TabIndex = 3;
            this.btn_NhaCungCap.Text = "Nhà cung cấp";
            this.btn_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhaCungCap.UseVisualStyleBackColor = true;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Image = global::App_QuanLyDonHang.Properties.Resources.group;
            this.btn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 90);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 11, 0);
            this.btn_KhachHang.Size = new System.Drawing.Size(230, 64);
            this.btn_KhachHang.TabIndex = 2;
            this.btn_KhachHang.Text = "Khách hàng ";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.White;
            this.btn_SanPham.Image = global::App_QuanLyDonHang.Properties.Resources.package;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(0, 180);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(230, 64);
            this.btn_SanPham.TabIndex = 1;
            this.btn_SanPham.Text = "Sản phẩm ";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.FlatAppearance.BorderSize = 0;
            this.btn_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHang.ForeColor = System.Drawing.Color.White;
            this.btn_DonHang.Image = global::App_QuanLyDonHang.Properties.Resources.shopping_list;
            this.btn_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonHang.Location = new System.Drawing.Point(0, 0);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Padding = new System.Windows.Forms.Padding(10, 0, 34, 0);
            this.btn_DonHang.Size = new System.Drawing.Size(230, 64);
            this.btn_DonHang.TabIndex = 0;
            this.btn_DonHang.Text = "Đơn hàng";
            this.btn_DonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DonHang.UseVisualStyleBackColor = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.pic_dot);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 50);
            this.panel3.TabIndex = 1;
            // 
            // pic_dot
            // 
            this.pic_dot.Image = global::App_QuanLyDonHang.Properties.Resources.dots__1_;
            this.pic_dot.Location = new System.Drawing.Point(748, 7);
            this.pic_dot.Name = "pic_dot";
            this.pic_dot.Size = new System.Drawing.Size(36, 36);
            this.pic_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dot.TabIndex = 2;
            this.pic_dot.TabStop = false;
            this.pic_dot.Click += new System.EventHandler(this.pic_dot_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.btn_LogOut);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btn_account);
            this.panel4.Location = new System.Drawing.Point(660, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 151);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_LogOut.Location = new System.Drawing.Point(3, 103);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(122, 45);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.button4.Location = new System.Drawing.Point(3, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.White;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btn_account.Location = new System.Drawing.Point(3, 3);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(121, 48);
            this.btn_account.TabIndex = 0;
            this.btn_account.Text = "Account";
            this.btn_account.UseVisualStyleBackColor = false;
            // 
            // Form_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_QuanLyDonHang.Properties.Resources._9a13d2cd8e53813f4ed555e43151229d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(818, 570);
            this.Name = "Form_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dot)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DonHang;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.PictureBox pic_Menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic_dot;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}