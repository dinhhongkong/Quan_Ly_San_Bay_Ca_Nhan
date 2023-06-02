using DevExpress.XtraEditors;
using Quan_Ly_May_Bay.SubForm;
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

namespace Quan_Ly_May_Bay
{
    public partial class FormNVBaoTri : DevExpress.XtraEditors.XtraForm
    {
        private TrangThai trangThai;

        public FormNVBaoTri()
        {
            InitializeComponent();
        }

        private void FormNVBaoTri_Load(object sender, EventArgs e)
        {
            
            ds.EnforceConstraints = false;
            this.dsNVBaoTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsNVBaoTriTableAdapter.Fill(this.ds.sp_DanhSachNhanVienBaoTri);
            this.cT_NVBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.ds.LOAIMAYBAY);

            repositoryItemLookUpEdit.DataSource = bdsLoaiMayBay;
            repositoryItemLookUpEdit.DisplayMember = "TENLOAI";
            repositoryItemLookUpEdit.ValueMember = "IDLOAI";
            trangThai = TrangThai.NONE;
        }

        private void chinhSuaNutLenh(bool b)
        {
            txtHoTen.ReadOnly = b;
            txtCMND.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtSDT.ReadOnly = b;
            nudLuong.ReadOnly = b;
            nudCaLamViec.ReadOnly = b;
            chkTrangThaiNghi.ReadOnly = b;
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
            if (nudLuong.Value < 2000000)
            {
                MessageBox.Show("Vui lòng nhập lương, lương tối thiểu là 2.000.000 đồng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool kiemTraLoaiMayBay(string idLoaiMayBay)
        {
            for ( int i = 0; i < bdsCTNVBaoTri.Count; i++)
            {
                if (idLoaiMayBay == ((DataRowView)bdsCTNVBaoTri[i])["IDLOAI"].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private void  themCTNhanVienBaoTri()
        {
            FormChonLoaiMB frmChonLoaiMB = new FormChonLoaiMB();
            while (frmChonLoaiMB.ShowDialog() == DialogResult.OK) 
            {
                string idLoaiMayBay = frmChonLoaiMB.getIdLoai();
                if (kiemTraLoaiMayBay(idLoaiMayBay) == false)
                {
                    MessageBox.Show("Loại máy bay này đã có trong danh sách", "Thông báo", MessageBoxButtons.OK);
                    Program.conn.Close();
                    continue;
                }

                Program.conn.Close();
                string idNhanVien = txtIdNhanVien.Text;
                string LENH_INSERT = $"INSERT INTO CT_NVBAOTRI VALUES({idNhanVien}, '{idLoaiMayBay}')";
                Program.ExecSqlNonQuery(LENH_INSERT);
                this.dsNVBaoTriTableAdapter.Fill(this.ds.sp_DanhSachNhanVienBaoTri);
                this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);
                if (trangThai == TrangThai.THEM)
                {
                    chinhSuaNutLenh(true);
                    btnChonNV.Enabled = false;
                    gcDSNVBaoTri.Enabled = true;
                    btnThem.Enabled = true;
                    btnHieuChinh.Enabled = true;
                    btnReload.Enabled = true;
                    btnGhi.Enabled = false;
                    trangThai = TrangThai.NONE;
                }
                break;

            }
            
            frmChonLoaiMB.Dispose();
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            FormChonNhanVien frmChonNV = new FormChonNhanVien();
            if ( frmChonNV.ShowDialog() == DialogResult.OK)
            {
                txtIdNhanVien.Text = frmChonNV.IdNhanVien;
                txtHoTen.Text = frmChonNV.HoTen;
                txtCMND.Text = frmChonNV.CMND;
                txtDiaChi.Text = frmChonNV.DiaChi;
                txtSDT.Text = frmChonNV.SoDienThoai;
                nudLuong.Value = frmChonNV.Luong;
                nudCaLamViec.Value = frmChonNV.CaLamViec;
                chkTrangThaiNghi.Checked = frmChonNV.TrangThaiNghi;
                themCTNhanVienBaoTri();
            }
            frmChonNV.Dispose();
            
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDSNVBaoTri.Enabled = false;
            btnChonNV.Enabled = true;
            bdsDsNVBaoTri.AddNew();
            txtIdNhanVien.Text = "";
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnReload.Enabled = false;
            gcDSNVBaoTri.Enabled = false;
            trangThai = TrangThai.THEM;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chinhSuaNutLenh(false);
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcDSNVBaoTri.Enabled = false;
            txtIdNhanVien.Enabled = false;
            btnLoaiMayBay.Enabled = false;
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

            if (trangThai == TrangThai.HIEUCHINH)
            {
                int viTri = bdsDsNVBaoTri.Position;
                string idNV = txtIdNhanVien.Text;
                string idNguoi = ((DataRowView)bdsDsNVBaoTri[viTri])["IDNGUOI"].ToString();
                lenhTruyVan = $"EXEC sp_HieuChinhNhanVien '{idNV}','{idNguoi}','{cmnd}',N'{ten}',N'{diaChi}','{sdt}','{luong}','{calamviec}','{trangThaiNghi}'";
                if (Program.ExecSqlNonQuery(lenhTruyVan) != 0)
                {
                    MessageBox.Show("Hiệu chỉnh thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                this.dsNVBaoTriTableAdapter.Fill(this.ds.sp_DanhSachNhanVienBaoTri);
                this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);

            }
            chinhSuaNutLenh(true);
            gcDSNVBaoTri.Enabled = true;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            btnLoaiMayBay.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dsNVBaoTriTableAdapter.Fill(this.ds.sp_DanhSachNhanVienBaoTri);
            this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);
        }

        private void btnLoaiMayBay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                if (string.IsNullOrEmpty(txtIdNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            themCTNhanVienBaoTri();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            
        }

        private void gvCTNVBaoTri_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            gcCTNVBaoTri.ContextMenuStrip = cmsNVBaoTri;
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên bảo trì loại máy bay này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsCTNVBaoTri.RemoveCurrent();
                this.cT_NVBAOTRITableAdapter.Update(this.ds.CT_NVBAOTRI);
                this.dsNVBaoTriTableAdapter.Fill(this.ds.sp_DanhSachNhanVienBaoTri);
            }
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                bdsDsNVBaoTri.RemoveCurrent();
                bdsDsNVBaoTri.CancelEdit();
            }

            chinhSuaNutLenh(true);
            btnChonNV.Enabled = false;
            gcDSNVBaoTri.Enabled = true;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            trangThai = TrangThai.NONE;
        }
    }
}