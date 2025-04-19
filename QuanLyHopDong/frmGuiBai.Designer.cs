namespace QuanLyHopDong
{
    partial class frmGuiBai
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayDang = new System.Windows.Forms.Label();
            this.lblNhuanBut = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.lblMaBao = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.dgvGuiBai = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayDang = new System.Windows.Forms.DateTimePicker();
            this.txtNhuanBut = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiBai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gửi bài và tính nhuận bút";
            // 
            // lblNgayDang
            // 
            this.lblNgayDang.AutoSize = true;
            this.lblNgayDang.Location = new System.Drawing.Point(441, 208);
            this.lblNgayDang.Name = "lblNgayDang";
            this.lblNgayDang.Size = new System.Drawing.Size(74, 16);
            this.lblNgayDang.TabIndex = 47;
            this.lblNgayDang.Text = "Ngày đăng";
            // 
            // lblNhuanBut
            // 
            this.lblNhuanBut.AutoSize = true;
            this.lblNhuanBut.Location = new System.Drawing.Point(441, 163);
            this.lblNhuanBut.Name = "lblNhuanBut";
            this.lblNhuanBut.Size = new System.Drawing.Size(67, 16);
            this.lblNhuanBut.TabIndex = 46;
            this.lblNhuanBut.Text = "Nhuận bút";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(441, 113);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(61, 16);
            this.lblNoiDung.TabIndex = 45;
            this.lblNoiDung.Text = "Nội dung";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(98, 212);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(86, 16);
            this.lblMaNV.TabIndex = 44;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(441, 76);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(53, 16);
            this.lblTieuDe.TabIndex = 43;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Location = new System.Drawing.Point(98, 161);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(72, 16);
            this.lblMaTheLoai.TabIndex = 42;
            this.lblMaTheLoai.Text = "Mã thể loại";
            // 
            // lblMaBao
            // 
            this.lblMaBao.AutoSize = true;
            this.lblMaBao.Location = new System.Drawing.Point(95, 116);
            this.lblMaBao.Name = "lblMaBao";
            this.lblMaBao.Size = new System.Drawing.Size(53, 16);
            this.lblMaBao.TabIndex = 41;
            this.lblMaBao.Text = "Mã báo";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(95, 76);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(98, 16);
            this.lblMaKH.TabIndex = 40;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // dgvGuiBai
            // 
            this.dgvGuiBai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuiBai.Location = new System.Drawing.Point(98, 249);
            this.dgvGuiBai.Name = "dgvGuiBai";
            this.dgvGuiBai.RowHeadersWidth = 51;
            this.dgvGuiBai.RowTemplate.Height = 24;
            this.dgvGuiBai.Size = new System.Drawing.Size(583, 150);
            this.dgvGuiBai.TabIndex = 39;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(683, 422);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(556, 422);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 37;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(441, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(322, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(200, 422);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayDang
            // 
            this.dtpNgayDang.Location = new System.Drawing.Point(556, 206);
            this.dtpNgayDang.Name = "dtpNgayDang";
            this.dtpNgayDang.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayDang.TabIndex = 32;
            // 
            // txtNhuanBut
            // 
            this.txtNhuanBut.Location = new System.Drawing.Point(556, 160);
            this.txtNhuanBut.Name = "txtNhuanBut";
            this.txtNhuanBut.ReadOnly = true;
            this.txtNhuanBut.Size = new System.Drawing.Size(100, 22);
            this.txtNhuanBut.TabIndex = 31;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(556, 115);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(100, 22);
            this.txtNoiDung.TabIndex = 30;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(556, 73);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(100, 22);
            this.txtTieuDe.TabIndex = 29;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(219, 204);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 24);
            this.cboMaNV.TabIndex = 28;
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Location = new System.Drawing.Point(219, 158);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(121, 24);
            this.cboMaTheLoai.TabIndex = 27;
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(219, 113);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 24);
            this.cboMaBao.TabIndex = 26;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(219, 71);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 24);
            this.cboMaKH.TabIndex = 25;
            // 
            // frmGuiBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNgayDang);
            this.Controls.Add(this.lblNhuanBut);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaTheLoai);
            this.Controls.Add(this.lblMaBao);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.dgvGuiBai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayDang);
            this.Controls.Add(this.txtNhuanBut);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.cboMaTheLoai);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label1);
            this.Name = "frmGuiBai";
            this.Text = "frmGuiBai";
            this.Load += new System.EventHandler(this.frmGuiBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayDang;
        private System.Windows.Forms.Label lblNhuanBut;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.Label lblMaBao;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DataGridView dgvGuiBai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayDang;
        private System.Windows.Forms.TextBox txtNhuanBut;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.ComboBox cboMaKH;
    }
}