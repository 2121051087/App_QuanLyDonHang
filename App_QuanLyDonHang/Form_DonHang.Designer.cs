namespace App_QuanLyDonHang
{
    partial class Form_DonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_idSP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idSP = new System.Windows.Forms.TextBox();
            this.panel_Gia = new System.Windows.Forms.Panel();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_SoLuong = new System.Windows.Forms.Panel();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_idKH = new System.Windows.Forms.Panel();
            this.txt_idKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_idDH = new System.Windows.Forms.Panel();
            this.txt_idDH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_idSP.SuspendLayout();
            this.panel_Gia.SuspendLayout();
            this.panel_SoLuong.SuspendLayout();
            this.panel_idKH.SuspendLayout();
            this.panel_idDH.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đơn hàng :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 448);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_idSP);
            this.groupBox1.Controls.Add(this.panel_Gia);
            this.groupBox1.Controls.Add(this.panel_SoLuong);
            this.groupBox1.Controls.Add(this.panel_idKH);
            this.groupBox1.Controls.Add(this.panel_idDH);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(448, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 342);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_idSP
            // 
            this.panel_idSP.BackColor = System.Drawing.Color.White;
            this.panel_idSP.Controls.Add(this.label2);
            this.panel_idSP.Controls.Add(this.txt_idSP);
            this.panel_idSP.Location = new System.Drawing.Point(18, 90);
            this.panel_idSP.Name = "panel_idSP";
            this.panel_idSP.Size = new System.Drawing.Size(339, 36);
            this.panel_idSP.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "idSP :";
            // 
            // txt_idSP
            // 
            this.txt_idSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_idSP.Location = new System.Drawing.Point(100, 4);
            this.txt_idSP.Name = "txt_idSP";
            this.txt_idSP.Size = new System.Drawing.Size(200, 27);
            this.txt_idSP.TabIndex = 1;
            this.txt_idSP.Click += new System.EventHandler(this.txt_idSP_Click);
            // 
            // panel_Gia
            // 
            this.panel_Gia.BackColor = System.Drawing.Color.White;
            this.panel_Gia.Controls.Add(this.txt_Gia);
            this.panel_Gia.Controls.Add(this.label5);
            this.panel_Gia.Location = new System.Drawing.Point(18, 271);
            this.panel_Gia.Name = "panel_Gia";
            this.panel_Gia.Size = new System.Drawing.Size(339, 36);
            this.panel_Gia.TabIndex = 27;
            // 
            // txt_Gia
            // 
            this.txt_Gia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Gia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Gia.Location = new System.Drawing.Point(100, 4);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(200, 27);
            this.txt_Gia.TabIndex = 1;
            this.txt_Gia.Click += new System.EventHandler(this.txt_Gia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giá  :";
            // 
            // panel_SoLuong
            // 
            this.panel_SoLuong.BackColor = System.Drawing.Color.White;
            this.panel_SoLuong.Controls.Add(this.txt_SoLuong);
            this.panel_SoLuong.Controls.Add(this.label4);
            this.panel_SoLuong.Location = new System.Drawing.Point(18, 214);
            this.panel_SoLuong.Name = "panel_SoLuong";
            this.panel_SoLuong.Size = new System.Drawing.Size(339, 36);
            this.panel_SoLuong.TabIndex = 27;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(100, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 27);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.Click += new System.EventHandler(this.txt_SoLuong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng :";
            // 
            // panel_idKH
            // 
            this.panel_idKH.BackColor = System.Drawing.Color.White;
            this.panel_idKH.Controls.Add(this.txt_idKH);
            this.panel_idKH.Controls.Add(this.label3);
            this.panel_idKH.Location = new System.Drawing.Point(18, 153);
            this.panel_idKH.Name = "panel_idKH";
            this.panel_idKH.Size = new System.Drawing.Size(339, 36);
            this.panel_idKH.TabIndex = 25;
            // 
            // txt_idKH
            // 
            this.txt_idKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_idKH.Location = new System.Drawing.Point(100, 4);
            this.txt_idKH.Name = "txt_idKH";
            this.txt_idKH.Size = new System.Drawing.Size(200, 27);
            this.txt_idKH.TabIndex = 1;
            this.txt_idKH.Click += new System.EventHandler(this.txt_idKH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "idKH :";
            // 
            // panel_idDH
            // 
            this.panel_idDH.BackColor = System.Drawing.Color.White;
            this.panel_idDH.Controls.Add(this.txt_idDH);
            this.panel_idDH.Controls.Add(this.label7);
            this.panel_idDH.Location = new System.Drawing.Point(18, 29);
            this.panel_idDH.Name = "panel_idDH";
            this.panel_idDH.Size = new System.Drawing.Size(339, 36);
            this.panel_idDH.TabIndex = 21;
            // 
            // txt_idDH
            // 
            this.txt_idDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_idDH.Location = new System.Drawing.Point(100, 4);
            this.txt_idDH.Name = "txt_idDH";
            this.txt_idDH.Size = new System.Drawing.Size(200, 27);
            this.txt_idDH.TabIndex = 1;
            this.txt_idDH.Click += new System.EventHandler(this.txt_idDH_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "idDH :";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(480, 384);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 42);
            this.btn_Them.TabIndex = 24;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::App_QuanLyDonHang.Properties.Resources.compose;
            this.btn_Sua.Location = new System.Drawing.Point(706, 384);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(42, 42);
            this.btn_Sua.TabIndex = 26;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::App_QuanLyDonHang.Properties.Resources.trash__1_;
            this.btn_Xoa.Location = new System.Drawing.Point(754, 384);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(42, 42);
            this.btn_Xoa.TabIndex = 25;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng ";
            this.Load += new System.EventHandler(this.Form_DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel_idSP.ResumeLayout(false);
            this.panel_idSP.PerformLayout();
            this.panel_Gia.ResumeLayout(false);
            this.panel_Gia.PerformLayout();
            this.panel_SoLuong.ResumeLayout(false);
            this.panel_SoLuong.PerformLayout();
            this.panel_idKH.ResumeLayout(false);
            this.panel_idKH.PerformLayout();
            this.panel_idDH.ResumeLayout(false);
            this.panel_idDH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_idSP;
        private System.Windows.Forms.TextBox txt_idSP;
        private System.Windows.Forms.Panel panel_idDH;
        private System.Windows.Forms.TextBox txt_idDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_Gia;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_SoLuong;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_idKH;
        private System.Windows.Forms.TextBox txt_idKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}