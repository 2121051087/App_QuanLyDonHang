namespace App_QuanLyDonHang
{
    partial class Form_KhachHang
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_idKH = new System.Windows.Forms.TextBox();
            this.lb_idKH = new System.Windows.Forms.Label();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Phone = new System.Windows.Forms.Panel();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_NgaySinh = new System.Windows.Forms.Panel();
            this.panel_idKH = new System.Windows.Forms.Panel();
            this.gb_BanGhi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel_Name.SuspendLayout();
            this.panel_Phone.SuspendLayout();
            this.panel_NgaySinh.SuspendLayout();
            this.panel_idKH.SuspendLayout();
            this.gb_BanGhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(485, 381);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 42);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_idKH
            // 
            this.txt_idKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_idKH.Location = new System.Drawing.Point(106, 4);
            this.txt_idKH.Name = "txt_idKH";
            this.txt_idKH.Size = new System.Drawing.Size(200, 27);
            this.txt_idKH.TabIndex = 1;
            this.txt_idKH.Click += new System.EventHandler(this.txt_idKH_Click);
            // 
            // lb_idKH
            // 
            this.lb_idKH.AutoSize = true;
            this.lb_idKH.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.lb_idKH.Location = new System.Drawing.Point(5, 10);
            this.lb_idKH.Name = "lb_idKH";
            this.lb_idKH.Size = new System.Drawing.Size(57, 19);
            this.lb_idKH.TabIndex = 20;
            this.lb_idKH.Text = "idKH :";
            // 
            // panel_Name
            // 
            this.panel_Name.BackColor = System.Drawing.Color.White;
            this.panel_Name.Controls.Add(this.label2);
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(21, 120);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(339, 36);
            this.panel_Name.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Name.Location = new System.Drawing.Point(106, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 27);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Click += new System.EventHandler(this.txt_Name_Click);
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_NgaySinh.Location = new System.Drawing.Point(106, 4);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(200, 27);
            this.txt_NgaySinh.TabIndex = 1;
            this.txt_NgaySinh.Click += new System.EventHandler(this.txt_NgaySinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày sinh :";
            // 
            // panel_Phone
            // 
            this.panel_Phone.BackColor = System.Drawing.Color.White;
            this.panel_Phone.Controls.Add(this.txt_Phone);
            this.panel_Phone.Controls.Add(this.label5);
            this.panel_Phone.Location = new System.Drawing.Point(21, 246);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Size = new System.Drawing.Size(339, 36);
            this.panel_Phone.TabIndex = 27;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Phone.Location = new System.Drawing.Point(106, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(200, 27);
            this.txt_Phone.TabIndex = 1;
            this.txt_Phone.Click += new System.EventHandler(this.txt_Phone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone  :";
            // 
            // panel_NgaySinh
            // 
            this.panel_NgaySinh.BackColor = System.Drawing.Color.White;
            this.panel_NgaySinh.Controls.Add(this.txt_NgaySinh);
            this.panel_NgaySinh.Controls.Add(this.label3);
            this.panel_NgaySinh.Location = new System.Drawing.Point(21, 183);
            this.panel_NgaySinh.Name = "panel_NgaySinh";
            this.panel_NgaySinh.Size = new System.Drawing.Size(339, 36);
            this.panel_NgaySinh.TabIndex = 25;
            // 
            // panel_idKH
            // 
            this.panel_idKH.BackColor = System.Drawing.Color.White;
            this.panel_idKH.Controls.Add(this.txt_idKH);
            this.panel_idKH.Controls.Add(this.lb_idKH);
            this.panel_idKH.Location = new System.Drawing.Point(21, 59);
            this.panel_idKH.Name = "panel_idKH";
            this.panel_idKH.Size = new System.Drawing.Size(339, 36);
            this.panel_idKH.TabIndex = 21;
            // 
            // gb_BanGhi
            // 
            this.gb_BanGhi.BackColor = System.Drawing.SystemColors.Control;
            this.gb_BanGhi.Controls.Add(this.panel_Name);
            this.gb_BanGhi.Controls.Add(this.panel_Phone);
            this.gb_BanGhi.Controls.Add(this.panel_NgaySinh);
            this.gb_BanGhi.Controls.Add(this.panel_idKH);
            this.gb_BanGhi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_BanGhi.Location = new System.Drawing.Point(453, 9);
            this.gb_BanGhi.Name = "gb_BanGhi";
            this.gb_BanGhi.Size = new System.Drawing.Size(377, 342);
            this.gb_BanGhi.TabIndex = 28;
            this.gb_BanGhi.TabStop = false;
            this.gb_BanGhi.Text = "Bản ghi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khách hàng :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 448);
            this.panel1.TabIndex = 27;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::App_QuanLyDonHang.Properties.Resources.trash__1_;
            this.btn_Xoa.Location = new System.Drawing.Point(759, 381);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(42, 42);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::App_QuanLyDonHang.Properties.Resources.compose;
            this.btn_Sua.Location = new System.Drawing.Point(711, 381);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(42, 42);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.gb_BanGhi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.panel1);
            this.Name = "Form_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng ";
            this.Load += new System.EventHandler(this.Form_KhachHang_Load);
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_Phone.ResumeLayout(false);
            this.panel_Phone.PerformLayout();
            this.panel_NgaySinh.ResumeLayout(false);
            this.panel_NgaySinh.PerformLayout();
            this.panel_idKH.ResumeLayout(false);
            this.panel_idKH.PerformLayout();
            this.gb_BanGhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_idKH;
        private System.Windows.Forms.Label lb_idKH;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_NgaySinh;
        private System.Windows.Forms.Panel panel_idKH;
        private System.Windows.Forms.GroupBox gb_BanGhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel1;
    }
}