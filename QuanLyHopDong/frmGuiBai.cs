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

namespace QuanLyHopDong
{
    public partial class frmGuiBai : Form
    {
        private string currentMaLanGui = "";
        public frmGuiBai()
        {
            InitializeComponent();
        }

        private void frmGuiBai_Load(object sender, EventArgs e)
        {
            DAO.Connect();

            cboMaBao.SelectedValueChanged += cboMaBao_SelectedValueChanged;
            cboMaTheLoai.SelectedValueChanged += OnBaoOrTheLoaiChanged;

            var dtKH = DAO.LoadDataToTable("SELECT MaKH, TenKH FROM KhachHang");
            cboMaKH.DataSource = dtKH;
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "TenKH";
            if (cboMaKH.Items.Count > 0)
                cboMaKH.SelectedIndex = 0;

            var dtBao = DAO.LoadDataToTable("SELECT MaBao, TenBao FROM Bao");
            cboMaBao.DataSource = dtBao;
            cboMaBao.ValueMember = "MaBao";
            cboMaBao.DisplayMember = "TenBao";
            if (cboMaBao.Items.Count > 0)
                cboMaBao.SelectedIndex = 0;

            var dtTL = DAO.LoadDataToTable("SELECT MaTheLoai, TenTheLoai FROM TheLoai");
            cboMaTheLoai.DataSource = dtTL;
            cboMaTheLoai.ValueMember = "MaTheLoai";
            cboMaTheLoai.DisplayMember = "TenTheLoai";
            if (cboMaTheLoai.Items.Count > 0)
                cboMaTheLoai.SelectedIndex = 0;

            var dtNV = DAO.LoadDataToTable("SELECT MaNV, TenNV FROM NhanVien");
            cboMaNV.DataSource = dtNV;
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.DisplayMember = "TenNV";
            if (cboMaNV.Items.Count > 0)
                cboMaNV.SelectedIndex = 0;

            dgvGuiBai.CellClick += dgvGuiBai_CellClick;
            LoadGrid();

            cboMaBao_SelectedValueChanged(null, null);
        }
        private void cboMaBao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMaBao.SelectedValue == null) return;
            string maBao = cboMaBao.SelectedValue.ToString();

            string sqlTL = $@"
      SELECT TL.MaTheLoai, TL.TenTheLoai
      FROM Theloai TL
      JOIN Bao_Theloai BT 
        ON TL.MaTheLoai = BT.MaTheLoai
      WHERE BT.MaBao = '{maBao}'";
            var dtTL = DAO.LoadDataToTable(sqlTL);
            cboMaTheLoai.DataSource = dtTL;
            cboMaTheLoai.ValueMember = "MaTheLoai";
            cboMaTheLoai.DisplayMember = "TenTheLoai";
            if (cboMaTheLoai.Items.Count > 0)
                cboMaTheLoai.SelectedIndex = 0;

            OnBaoOrTheLoaiChanged(null, null);
        }
        private void LoadGrid()
        {
            string sql = @"
SELECT 
  GB.MaLanGui   AS MaLanGui,
  GB.MaKH       AS MaKH,
  GB.MaBao      AS MaBao,
  GB.MaTheLoai  AS MaTheLoai,
  GB.MaNV       AS MaNV,
  KH.TenKH      AS TenKH,
  B.TenBao      AS TenBao,
  TL.TenTheLoai AS TenTheLoai,
  GB.TieuDe     AS TieuDe,
  GB.NoiDung    AS NoiDung,
  NV.TenNV      AS TenNV,
  GB.NgayDang   AS NgayDang,
  GB.NhuanBut   AS NhuanBut
FROM KhachGuiBai GB
 JOIN KhachHang KH ON GB.MaKH      = KH.MaKH
 JOIN Bao       B  ON GB.MaBao     = B.MaBao
 JOIN TheLoai   TL ON GB.MaTheLoai = TL.MaTheLoai
 JOIN NhanVien  NV ON GB.MaNV      = NV.MaNV";

            var dt = DAO.LoadDataToTable(sql);
            dgvGuiBai.DataSource = dt;

            dgvGuiBai.Columns["MaKH"].Visible = false;
            dgvGuiBai.Columns["MaBao"].Visible = false;
            dgvGuiBai.Columns["MaTheLoai"].Visible = false;
            dgvGuiBai.Columns["MaNV"].Visible = false;
        }

        private void OnBaoOrTheLoaiChanged(object sender, EventArgs e)
        {
            if (cboMaBao.SelectedValue == null || cboMaTheLoai.SelectedValue == null)
            {
                txtNhuanBut.Text = "0";
                return;
            }
            string maBao = cboMaBao.SelectedValue.ToString();
            string maTheLoai = cboMaTheLoai.SelectedValue.ToString();
            string sql = $@"
      SELECT Nhuanbut 
      FROM Bao_Theloai 
      WHERE MaBao='{maBao}' AND MaTheLoai='{maTheLoai}'";
            var dt = DAO.LoadDataToTable(sql);
            txtNhuanBut.Text = dt.Rows.Count > 0
              ? dt.Rows[0]["Nhuanbut"].ToString()
              : "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = cboMaKH.Text.Trim();
            string maBao = cboMaBao.Text.Trim();
            string maTheLoai = cboMaTheLoai.Text.Trim();
            string maNV = cboMaNV.Text.Trim();
            string tieuDe = txtTieuDe.Text.Trim();
            string noiDung = txtNoiDung.Text.Trim();
            decimal nhu = 0;
            decimal.TryParse(txtNhuanBut.Text, out nhu);

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Khachhang WHERE MaKH=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maKH);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand("INSERT INTO Khachhang(MaKH) VALUES(@x)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@x", maKH);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Theloai WHERE MaTheloai=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maTheLoai);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Theloai(MaTheloai,TenTheloai) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maTheLoai);
                        ins.Parameters.AddWithValue("@t", maTheLoai);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Bao WHERE MaBao=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maBao);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Bao(MaBao,TenBao) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maBao);
                        ins.Parameters.AddWithValue("@t", maBao);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Nhanvien WHERE MaNV=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maNV);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Nhanvien(MaNV,TenNV) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maNV);
                        ins.Parameters.AddWithValue("@t", maNV);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            string maLanGui = Guid.NewGuid().ToString("N").Substring(0, 10);
            string sql = @"
INSERT INTO Khachguibai
  (MaLanGui,MaKH,MaTheLoai,MaBao,Tieude,Noidung,MaNV,Ngaydang,Nhuanbut)
VALUES
  (@L,@K,@T,@B,@D,@N,@V,@G,@H)";

            using (var cmd = new SqlCommand(sql, DAO.con))
            {
                cmd.Parameters.AddWithValue("@L", maLanGui);
                cmd.Parameters.AddWithValue("@K", maKH);
                cmd.Parameters.AddWithValue("@T", maTheLoai);
                cmd.Parameters.AddWithValue("@B", maBao);
                cmd.Parameters.AddWithValue("@D", tieuDe);
                cmd.Parameters.AddWithValue("@N", noiDung);
                cmd.Parameters.AddWithValue("@V", maNV);
                cmd.Parameters.AddWithValue("@G", dtpNgayDang.Value);
                cmd.Parameters.AddWithValue("@H", nhu);

                cmd.ExecuteNonQuery();
            }

            LoadGrid();
            MessageBox.Show($"Thêm thành công! Mã lần gửi: {maLanGui}");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMaLanGui))
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để sửa.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = cboMaKH.SelectedValue?.ToString() ?? cboMaKH.Text.Trim();
            string maBao = cboMaBao.SelectedValue?.ToString() ?? cboMaBao.Text.Trim();
            string maTheLoai = cboMaTheLoai.SelectedValue?.ToString() ?? cboMaTheLoai.Text.Trim();
            string maNV = cboMaNV.SelectedValue?.ToString() ?? cboMaNV.Text.Trim();
            string tieude = txtTieuDe.Text.Trim();
            string noidung = txtNoiDung.Text.Trim();
            DateTime ngay = dtpNgayDang.Value;
            decimal nhu = decimal.TryParse(txtNhuanBut.Text, out var tmp) ? tmp : 0m;

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKH=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maKH);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand("INSERT INTO KhachHang(MaKH) VALUES(@x)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@x", maKH);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Theloai WHERE MaTheLoai=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maTheLoai);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Theloai(MaTheLoai,TenTheLoai) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maTheLoai);
                        ins.Parameters.AddWithValue("@t", maTheLoai);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Bao WHERE MaBao=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maBao);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Bao(MaBao,TenBao) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maBao);
                        ins.Parameters.AddWithValue("@t", maBao);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Nhanvien WHERE MaNV=@x", DAO.con))
            {
                cmd.Parameters.AddWithValue("@x", maNV);
                if ((int)cmd.ExecuteScalar() == 0)
                {
                    using (var ins = new SqlCommand(
                        "INSERT INTO Nhanvien(MaNV,TenNV) VALUES(@m,@t)", DAO.con))
                    {
                        ins.Parameters.AddWithValue("@m", maNV);
                        ins.Parameters.AddWithValue("@t", maNV);
                        ins.ExecuteNonQuery();
                    }
                }
            }

            string sql = @"
UPDATE KhachGuiBai
SET MaKH      = @MaKH,
    MaBao     = @MaBao,
    MaTheLoai = @MaTheLoai,
    MaNV      = @MaNV,
    Tieude    = @Tieude,
    Noidung   = @NoiDung,
    Ngaydang  = @NgayDang,
    NhuanBut  = @NhuanBut
WHERE MaLanGui = @MaLanGui";

            using (var cmd = new SqlCommand(sql, DAO.con))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@MaBao", maBao);
                cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@Tieude", tieude);
                cmd.Parameters.AddWithValue("@NoiDung", noidung);
                cmd.Parameters.AddWithValue("@NgayDang", ngay);
                cmd.Parameters.AddWithValue("@NhuanBut", nhu);
                cmd.Parameters.AddWithValue("@MaLanGui", currentMaLanGui);
                cmd.ExecuteNonQuery();
            }

            LoadGrid();
            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvGuiBai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi trong danh sách để xóa.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMaLanGui = dgvGuiBai.SelectedRows[0].Cells["MaLanGui"].Value.ToString();

            var dr = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này không?",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            string sql = "DELETE FROM Khachguibai WHERE Malangui = @MaLanGui";
            using (var cmd = new SqlCommand(sql, DAO.con))
            {
                cmd.Parameters.AddWithValue("@MaLanGui", currentMaLanGui);
                cmd.ExecuteNonQuery();
            }

            LoadGrid();
            currentMaLanGui = "";
        }
        private void dgvGuiBai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvGuiBai.Rows[e.RowIndex];

            currentMaLanGui = row.Cells["MaLanGui"].Value.ToString();

            cboMaKH.SelectedValue = row.Cells["MaKH"].Value;
            cboMaBao.SelectedValue = row.Cells["MaBao"].Value;
            cboMaTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;
            cboMaNV.SelectedValue = row.Cells["MaNV"].Value;

            txtTieuDe.Text = row.Cells["TieuDe"].Value?.ToString();
            txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();
            dtpNgayDang.Value = Convert.ToDateTime(row.Cells["NgayDang"].Value);
            txtNhuanBut.Text = row.Cells["NhuanBut"].Value?.ToString();
        }
    }
}
