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
using Microsoft.VisualBasic;
using static System.Windows.Forms.AxHost;

namespace QuanLyHopDong
{
    public partial class frmHopDong : Form
    {
        private bool isNewMode = false;
        private bool isEditMode = false;
        private string currentMaHopDong = string.Empty;
        private enum FormState { Viewing, Adding, Editing }
        private FormState _state = FormState.Viewing;
        public frmHopDong()
        {
            InitializeComponent();
            cboMaKH.DropDownStyle = ComboBoxStyle.DropDown;
            cboMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            DAO.Connect();

            // Load Khách hàng
            var dtKH = DAO.LoadDataToTable("SELECT MaKH, TenKH FROM Khachhang");
            cboMaKH.DataSource = dtKH;
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "TenKH";

            // Load Báo
            var dtBao = DAO.LoadDataToTable("SELECT MaBao, TenBao FROM Bao");
            cboMaBao.DataSource = dtBao;
            cboMaBao.ValueMember = "MaBao";
            cboMaBao.DisplayMember = "TenBao";
            cboMaBao.SelectedIndex = 0;

            // Load Thể loại (toàn bộ, sẽ filter sau)
            var dtTL = DAO.LoadDataToTable("SELECT MaTheLoai, TenTheLoai FROM Theloai");
            cboMaTheLoai.DataSource = dtTL;
            cboMaTheLoai.ValueMember = "MaTheLoai";
            cboMaTheLoai.DisplayMember = "TenTheLoai";

            // Sự kiện
            cboMaBao.SelectedIndexChanged += cboMaBao_SelectedIndexChanged;
            cboMaTheLoai.SelectedIndexChanged += (s, ev) => UpdateNhuanBut();
            nudSoNgay.ValueChanged += (s, ev) => UpdateThanhTien();


            // Chạy lần đầu
            cboMaBao_SelectedIndexChanged(null, null);
            UpdateThanhTien();

            btnLuuHD.Enabled = false;
            btnBoQuaHD.Enabled = false;

            // Load DataGridView
            LoadGrid();
            LoadKhachHang();    
        }

        private void cboMaBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mB = cboMaBao.SelectedValue?.ToString();
            if (mB == null) return;

            
            string sql = $@"
SELECT TL.MaTheLoai, TL.TenTheLoai
FROM TheLoai TL
 JOIN Bao_Theloai BT ON TL.MaTheLoai = BT.MaTheLoai
WHERE BT.MaBao = '{mB}'";
            var dtTL = DAO.LoadDataToTable(sql);

            cboMaTheLoai.DataSource = dtTL;
            cboMaTheLoai.ValueMember = "MaTheLoai";
            cboMaTheLoai.DisplayMember = "TenTheLoai";

            
            if (dtTL.Rows.Count > 0)
            {
                cboMaTheLoai.SelectedIndex = 0;
                UpdateNhuanBut();
            }
            else
            {
                
                cboMaTheLoai.SelectedIndex = -1;
                txtNhuanBut.Text = "0.00";
                UpdateThanhTien();
            }
        }

        // Tính DonGia (nhuận bút) tự động khi Thể loại thay đổi
        private void UpdateNhuanBut()
        {
            var mB = cboMaBao.SelectedValue?.ToString();
            var mTL = cboMaTheLoai.SelectedValue?.ToString();
            if (mB == null || mTL == null)
            {
                txtNhuanBut.Text = "0.00";
                return;
            }
            var dt = DAO.LoadDataToTable($@"
SELECT Nhuanbut 
FROM Bao_Theloai 
WHERE MaBao='{mB}' AND MaTheLoai='{mTL}'");
            txtNhuanBut.Text = dt.Rows.Count > 0
                ? dt.Rows[0]["Nhuanbut"].ToString()
                : "0.00";
            UpdateThanhTien();
        }

        private void UpdateThanhTien()
        {
            if (!decimal.TryParse(txtNhuanBut.Text, out var dg)) dg = 0;
            txtThanhTien.Text = (dg * nudSoNgay.Value).ToString("N0");
        }

        // Load lại DataGridView
        private void LoadGrid()
        {
            dgvHopDong.DataSource = DAO.LoadDataToTable(@"
SELECT
  HD.MaHopDong,
  HD.MaKH,
  HD.MaBao,
  HD.MaTheLoai,
  KH.TenKH      AS TenKH,
  B.TenBao      AS TenBao,
  TL.TenTheLoai AS TenTheLoai,
  HD.NgayKy,
  HD.SoNgay,
  HD.NhuanBut,
  HD.ThanhTien
FROM HopDong HD
 JOIN Khachhang KH ON HD.MaKH      = KH.MaKH
 JOIN Bao         B  ON HD.MaBao    = B.MaBao
 JOIN Theloai     TL ON HD.MaTheLoai = TL.MaTheLoai
");

            
            dgvHopDong.Columns["MaKH"].Visible = false;
            dgvHopDong.Columns["MaBao"].Visible = false;
            dgvHopDong.Columns["MaTheLoai"].Visible = false;

            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHopDong.AllowUserToAddRows = false;
            dgvHopDong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            _state = FormState.Adding;
            currentMaHopDong = "";

            // Clear form
            txtMaHopDong.Clear();
            cboMaKH.SelectedIndex = -1;        
            cboMaBao.SelectedIndex = 0;
            cboMaTheLoai.SelectedIndex = 0;
            dtpNgayKy.Value = DateTime.Today;
            nudSoNgay.Value = 1;
            UpdateNhuanBut();

            // Nút
            btnThemHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnLuuHD.Enabled = true;
            btnBoQuaHD.Enabled = true;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string maKH = cboMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            using (var chk = new SqlCommand("SELECT COUNT(*) FROM Khachhang WHERE MaKH=@K", DAO.con))
            {
                chk.Parameters.AddWithValue("@K", maKH);
                if ((int)chk.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand("INSERT INTO Khachhang(MaKH) VALUES(@K)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@K", maKH);
                        ins.ExecuteNonQuery();
                        LoadKhachHang();
                        if (_state == FormState.Editing)
                            cboMaKH.SelectedValue = maKH;
                    }
                }
            }

            // Insert mới
            if (_state == FormState.Adding)
            {
                string maHD = Guid.NewGuid().ToString("N").Substring(0, 10);
                using (var cmd = new SqlCommand(@"
INSERT INTO HopDong
  (MaHopDong, MaKH, MaBao, MaTheLoai, NgayKy, SoNgay, NhuanBut, ThanhTien)
VALUES
  (@M,@K,@B,@T,@N,@S,@D,@TT)", DAO.con))
                {
                    cmd.Parameters.AddWithValue("@M", maHD);
                    cmd.Parameters.AddWithValue("@K", maKH);
                    cmd.Parameters.AddWithValue("@B", cboMaBao.SelectedValue);
                    cmd.Parameters.AddWithValue("@T", cboMaTheLoai.SelectedValue);
                    cmd.Parameters.AddWithValue("@N", dtpNgayKy.Value);
                    cmd.Parameters.AddWithValue("@S", nudSoNgay.Value);
                    cmd.Parameters.AddWithValue("@D", decimal.Parse(txtNhuanBut.Text));
                    cmd.Parameters.AddWithValue("@TT", decimal.Parse(txtThanhTien.Text));
                    cmd.ExecuteNonQuery();
                }
                txtMaHopDong.Text = maHD;
                MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Update
            else if (_state == FormState.Editing)
            {
                using (var cmd = new SqlCommand(@"
UPDATE HopDong
SET
  MaKH      = @K,
  MaBao     = @B,
  MaTheLoai = @T,
  NgayKy    = @N,
  SoNgay    = @S,
  NhuanBut  = @D,
  ThanhTien = @TT
WHERE MaHopDong = @M", DAO.con))
                {
                    cmd.Parameters.AddWithValue("@M", currentMaHopDong);
                    cmd.Parameters.AddWithValue("@K", maKH);
                    cmd.Parameters.AddWithValue("@B", cboMaBao.SelectedValue);
                    cmd.Parameters.AddWithValue("@T", cboMaTheLoai.SelectedValue);
                    cmd.Parameters.AddWithValue("@N", dtpNgayKy.Value);
                    cmd.Parameters.AddWithValue("@S", nudSoNgay.Value);
                    cmd.Parameters.AddWithValue("@D", decimal.Parse(txtNhuanBut.Text));
                    cmd.Parameters.AddWithValue("@TT", decimal.Parse(txtThanhTien.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Quay về trạng thái View
            LoadGrid();
            _state = FormState.Viewing;
            currentMaHopDong = "";
            txtMaHopDong.Clear();
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnLuuHD.Enabled = false;
            btnBoQuaHD.Enabled = false;
        }

        private void btnBoquaHD_Click(object sender, EventArgs e)
        {
            isNewMode = false;
            // Reset lại giao diện
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnLuuHD.Enabled = false;
            btnBoQuaHD.Enabled = false;
        }
        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn một hợp đồng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _state = FormState.Editing;
            var row = dgvHopDong.SelectedRows[0];

        
            currentMaHopDong = row.Cells["MaHopDong"].Value.ToString();
            txtMaHopDong.Text = currentMaHopDong;

            LoadKhachHang();

         
            cboMaKH.SelectedValue = row.Cells["MaKH"].Value;
            cboMaBao.SelectedValue = row.Cells["MaBao"].Value;

      
            cboMaBao_SelectedIndexChanged(null, null);
            cboMaTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;

     
            dtpNgayKy.Value = Convert.ToDateTime(row.Cells["NgayKy"].Value);
            nudSoNgay.Value = Convert.ToDecimal(row.Cells["SoNgay"].Value);
            txtNhuanBut.Text = row.Cells["NhuanBut"].Value.ToString();
            txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();

            // Nút
            btnThemHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnLuuHD.Enabled = true;
            btnBoQuaHD.Enabled = true;
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn một hợp đồng để xóa.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvHopDong.SelectedRows[0];
            string maHD = row.Cells["MaHopDong"].Value.ToString();

            var dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa hợp đồng {maHD} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            using (var cmd = new SqlCommand(
                "DELETE FROM HopDong WHERE MaHopDong = @M", DAO.con))
            {
                cmd.Parameters.AddWithValue("@M", maHD);
                cmd.ExecuteNonQuery();
            }

            LoadGrid();
            currentMaHopDong = "";
            txtMaHopDong.Clear();

            MessageBox.Show("Xóa hợp đồng thành công.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadKhachHang()
        {
            var dtKH = DAO.LoadDataToTable("SELECT MaKH, TenKH FROM Khachhang");
            cboMaKH.DataSource = dtKH;
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.SelectedIndex = -1;  
        }
    }
}
