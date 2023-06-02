using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_May_Bay
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {

        private TrangThai trangThai;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            ds.EnforceConstraints = false;
            this.sp_DanhSachNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachNhanVienTableAdapter.Fill(this.ds.sp_DanhSachNhanVien);

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.ds.NHANVIEN);

            this.cT_PHIEUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);

            this.cT_NVBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);

            this.pHICONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHICONGTableAdapter.Fill(this.ds.PHICONG);

            this.pHIEUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUBAOTRITableAdapter.Fill(this.ds.PHIEUBAOTRI);


            trangThai = TrangThai.NONE;

        }
        private bool kiemTraNhapLieu()
        {
            
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên nhân viên không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtHoTen.Text.Length > 50)
            {
                MessageBox.Show("Họ tên nhân viên không được có độ dài > 50", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (string.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("CMND không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtCMND.Text.Length > 13)
            {
                MessageBox.Show("CMND không được có độ dài > 13", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("CMND chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("SĐT không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtSDT.Text.Length > 13)
            {
                MessageBox.Show("SĐT không được có độ dài > 13", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("SĐT chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không được có độ dài > 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (nudCaLamViec.Value == 0)
            {
                MessageBox.Show("Không có ca làm việc 0", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if ( nudLuong.Value < 2000000)
            {
                MessageBox.Show("Vui lòng nhập lương, lương tối thiểu là 2.000.000 đồng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlDataReader myreader = Program.ExecSqlDataReader("SELECT IDENT_CURRENT('NHANVIEN') + 1 AS ID");
                
                
                if (myreader.Read())
                {
                    bdsDsNV.AddNew();
                    txtIdNhanVien.Text = myreader["ID"].ToString();
                }
                Program.conn.Close();

            }
            catch (Exception ex)
            {
                bdsDsNV.EndEdit();
                bdsDsNV.RemoveCurrent();
                MessageBox.Show("Không thể kết nối với server " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            gcChucNang.Enabled = true;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcNhanVien.Enabled = false;
            trangThai = TrangThai.THEM;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChucNang.Enabled = true;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcNhanVien.Enabled = false;
            txtIdNhanVien.Enabled = false;
            trangThai = TrangThai.HIEUCHINH;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraNhapLieu() == false)
            {
                return;
            }
            string lenhTruyVan = "";
            string cmnd = txtCMND.Text;
            string ten = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string luong = nudLuong.Value.ToString();
            string calamviec = nudCaLamViec.Value.ToString();
            bool trangThaiNghi = chkTrangThaiNghi.Checked;

            if (trangThai == TrangThai.THEM)
            {
                lenhTruyVan = $"EXEC sp_ThemNhanVien '{cmnd}', N'{ten}', N'{diaChi}', '{sdt}', '{luong}', '{calamviec}', '{trangThaiNghi}'";
                if (Program.ExecSqlNonQuery(lenhTruyVan) != 0)
                {
                    MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                
            }
            if ( trangThai == TrangThai.HIEUCHINH)
            {
                int viTri = bdsDsNV.Position;
                string idNV = txtIdNhanVien.Text;
                string idNguoi = ((DataRowView)bdsDsNV[viTri])["IDNGUOI"].ToString();
                lenhTruyVan = $"EXEC sp_HieuChinhNhanVien '{idNV}','{idNguoi}','{cmnd}',N'{ten}',N'{diaChi}','{sdt}','{luong}','{calamviec}','{trangThaiNghi}'";
                if (Program.ExecSqlNonQuery(lenhTruyVan) != 0)
                {
                    MessageBox.Show("Hiệu chỉnh thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            this.sp_DanhSachNhanVienTableAdapter.Fill(this.ds.sp_DanhSachNhanVien);
            gcNhanVien.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtIdNhanVien.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDsNV.Count == 0)
            {
                return;
            }
            if (bdsNVBaoTri.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì nhân viên này là nhân viên bảo trì", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhiCong.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì nhân viên này là phi công" , "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (bdsPhieuBaoTri.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì nhân viên này đã lập phiếu bảo trì", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPhieuBaoTri.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì nhân viên này đã bảo trì máy bay", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Program.userName == txtIdNhanVien.Text)
            {
                MessageBox.Show("Không tự xóa bản thân khi đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int viTri = bdsDsNV.Position;
                string idNV = txtIdNhanVien.Text;
                string idNguoi = ((DataRowView)bdsDsNV[viTri])["IDNGUOI"].ToString();
                string lenhTruyVan = $"EXEC sp_XoaNhanVien '{idNV}','{idNguoi}'";
                if (Program.ExecSqlNonQuery(lenhTruyVan) != 0)
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                bdsDsNV.RemoveCurrent();
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sp_DanhSachNhanVienTableAdapter.Fill(this.ds.sp_DanhSachNhanVien);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                bdsDsNV.RemoveCurrent();
                bdsDsNV.CancelEdit();
            }
            else if (trangThai == TrangThai.HIEUCHINH)
            {
                bdsDsNV.CancelEdit();
            }

            gcNhanVien.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            trangThai = TrangThai.NONE;
        }
    }
}