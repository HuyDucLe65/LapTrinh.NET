namespace QuanLyHopDong
{
    partial class frmHopDong
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
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.nudSoNgay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhuanBut = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnBoQuaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.btnLuuHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(212, 71);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 24);
            this.cboMaKH.TabIndex = 0;
            this.cboMaKH.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(212, 116);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 24);
            this.cboMaBao.TabIndex = 1;
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Location = new System.Drawing.Point(212, 162);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(121, 24);
            this.cboMaTheLoai.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã báo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quản lý hợp đồng quảng cáo";
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.Location = new System.Drawing.Point(212, 212);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKy.TabIndex = 6;
            // 
            // nudSoNgay
            // 
            this.nudSoNgay.Location = new System.Drawing.Point(571, 123);
            this.nudSoNgay.Name = "nudSoNgay";
            this.nudSoNgay.Size = new System.Drawing.Size(120, 22);
            this.nudSoNgay.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số ngày đăng";
            // 
            // txtNhuanBut
            // 
            this.txtNhuanBut.Location = new System.Drawing.Point(571, 163);
            this.txtNhuanBut.Name = "txtNhuanBut";
            this.txtNhuanBut.ReadOnly = true;
            this.txtNhuanBut.Size = new System.Drawing.Size(100, 22);
            this.txtNhuanBut.TabIndex = 9;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(571, 200);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(100, 22);
            this.txtThanhTien.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhuận bút";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thành tiền";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(67, 415);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(75, 23);
            this.btnThemHD.TabIndex = 13;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(337, 415);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHD.TabIndex = 14;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnBoQuaHD
            // 
            this.btnBoQuaHD.Location = new System.Drawing.Point(616, 415);
            this.btnBoQuaHD.Name = "btnBoQuaHD";
            this.btnBoQuaHD.Size = new System.Drawing.Size(75, 23);
            this.btnBoQuaHD.TabIndex = 16;
            this.btnBoQuaHD.Text = "Bỏ qua";
            this.btnBoQuaHD.UseVisualStyleBackColor = true;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(197, 415);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(75, 23);
            this.btnSuaHD.TabIndex = 17;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(93, 259);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(645, 150);
            this.dgvHopDong.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã hợp đồng";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Location = new System.Drawing.Point(571, 79);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(100, 22);
            this.txtMaHopDong.TabIndex = 21;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(468, 415);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHD.TabIndex = 22;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnBoQuaHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtNhuanBut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudSoNgay);
            this.Controls.Add(this.dtpNgayKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaTheLoai);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.cboMaKH);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.NumericUpDown nudSoNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhuanBut;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnBoQuaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Button btnLuuHD;
    }
}