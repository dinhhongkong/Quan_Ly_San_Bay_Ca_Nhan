using DevExpress.XtraEditors;
using Quan_Ly_May_Bay.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_May_Bay
{
    public partial class FormPhieuBaoTri : DevExpress.XtraEditors.XtraForm
    {
        private TrangThai trangThai;
        public FormPhieuBaoTri()
        {
            InitializeComponent();
        }
        
        private bool kiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Mã phiếu không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtMaPhieu.Text.Length > 10)
            {
                MessageBox.Show("Mã phiếu không được có độ dài > 10", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (string.IsNullOrEmpty(txtIDMayBay.Text))
            {
                MessageBox.Show("ID máy bay không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if ( nudSoGio.Value == 0 )
            {
                MessageBox.Show("Số giờ không được bằng 0", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if ( trangThai == TrangThai.THEM && bdsPhieuBaoTri.Find("IDPHIEU", txtMaPhieu.Text) > -1)
            {
                MessageBox.Show("Mã phiếu đã tồn tại, vui lòng nhập mã phiếu khác", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void FormPhieuBaoTri_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.pHIEUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHIEUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUBAOTRITableAdapter.Fill(this.ds.PHIEUBAOTRI);
            this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChucNang.Enabled = true;
            bdsPhieuBaoTri.AddNew();
            txtNgayLap.EditValue = DateTime.Today;
            txtIDNhanVien.Text = Program.userName;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcPhieuBaoTri.Enabled = false;
            gcCTPhieuBaoTri.Enabled = false;
            trangThai = TrangThai.THEM;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                bdsPhieuBaoTri.RemoveCurrent();
                bdsPhieuBaoTri.CancelEdit();
            }
            else if (trangThai == TrangThai.HIEUCHINH)
            {
                bdsPhieuBaoTri.CancelEdit();
            }

            gcPhieuBaoTri.Enabled = true;
            gcChucNang.Enabled = false;
            gcCTPhieuBaoTri.Enabled = true;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtMaPhieu.Enabled = true;
            txtMaPhieu.Enabled = true;
            trangThai = TrangThai.NONE;

           
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraNguoiLap() == false)
            {
                return;
            }
            gcChucNang.Enabled = true;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcPhieuBaoTri.Enabled = false;
            txtMaPhieu.Enabled = false;
            txtMaPhieu.Enabled = false;
            gcPhieuBaoTri.Enabled = false;
            gcCTPhieuBaoTri.Enabled = false;
            trangThai = TrangThai.HIEUCHINH;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraNhapLieu() == false)
            {
                return;
            }

            try
            {
                bdsPhieuBaoTri.EndEdit();
                bdsPhieuBaoTri.ResetCurrentItem();
                this.pHIEUBAOTRITableAdapter.Update(this.ds.PHIEUBAOTRI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu bảo trì \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }
            gcPhieuBaoTri.Enabled = true;
            gcChucNang.Enabled = false;
            gcCTPhieuBaoTri.Enabled = true;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtMaPhieu.Enabled = true;
            txtMaPhieu.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private bool kiemTraNguoiLap()
        {
            if (Program.userName != ((DataRowView)bdsPhieuBaoTri[bdsPhieuBaoTri.Position])["IDNHANVIEN"].ToString())
            {
                MessageBox.Show("Chỉ người lập phiếu mới có quyền thực hiện", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( kiemTraNguoiLap() == false)
            {
                return;
            }
            
            if (bdsCTPhieuBaoTri.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì đã có chi tiết phiếu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu bảo trì này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsPhieuBaoTri.RemoveCurrent();
                    this.pHIEUBAOTRITableAdapter.Update(this.ds.PHIEUBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu bảo trì này.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pHIEUBAOTRITableAdapter.Fill(this.ds.PHIEUBAOTRI);
            this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void txtIDMayBay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ( trangThai == TrangThai.HIEUCHINH)
            {
                return;
            }
            FormChonMayBay frmChonMayBay = new FormChonMayBay();
            if (frmChonMayBay.ShowDialog() == DialogResult.OK)
            {
                txtIDMayBay.Text = frmChonMayBay.getIDMayBay();
            }
            frmChonMayBay.Dispose();
        }

        private void gridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gcCTPhieuBaoTri.ContextMenuStrip = cmsCTPhieuBaoTri;
            }
        }

        private bool kiemTraNhanVien(string idNhanVien)
        {
            for ( int i = 0; i < bdsCTPhieuBaoTri.Count; i++ )
            {
                string iDNvTrongPhieu = ((DataRowView)bdsCTPhieuBaoTri[i])["IDNHANVIEN"].ToString();
                if (idNhanVien == iDNvTrongPhieu)
                {
                    return false;
                }
            }
            return true;
        }

        private void tsmiThem_Click(object sender, EventArgs e)
        {
            if (kiemTraNguoiLap() == false)
            {
                return;
            }
            FormCTPhieuBaoTri frmCTPhieu = new FormCTPhieuBaoTri(txtIDMayBay.Text, txtMaPhieu.Text, TrangThai.THEM);
            while (frmCTPhieu.ShowDialog() == DialogResult.OK)
            {

                if (kiemTraNhanVien(frmCTPhieu.IdNhanVien))
                {
                    frmCTPhieu.Close();
                    string maPhieu = txtMaPhieu.Text;
                    string idNhanVien = frmCTPhieu.IdNhanVien;
                    string moTa = frmCTPhieu.MoTa;
                    string lenh = $"INSERT INTO CT_PHIEUBAOTRI VALUES ('{maPhieu}',{idNhanVien},N'{moTa}')";
                    if (Program.ExecSqlNonQuery(lenh) == 0)
                    {
                        this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Nhân viên này đã bảo trì máy bay này, vui lòng chọn nhân viên khác", "Thông báo", MessageBoxButtons.OK);
                }
            }
            frmCTPhieu.Dispose();

        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (kiemTraNguoiLap() == false)
            {
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu bảo trì này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTPhieuBaoTri.RemoveCurrent();
                    this.cT_PHIEUBAOTRITableAdapter.Update(this.ds.CT_PHIEUBAOTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu bảo trì này.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void tsmiHieuChinh_Click(object sender, EventArgs e)
        {
            if (kiemTraNguoiLap() == false)
            {
                return;
            }

            FormCTPhieuBaoTri frmCTPhieu = new FormCTPhieuBaoTri(txtIDMayBay.Text, txtMaPhieu.Text, TrangThai.HIEUCHINH);
            frmCTPhieu.MoTa = ((DataRowView)bdsCTPhieuBaoTri[bdsCTPhieuBaoTri.Position])["CONGVIEC"].ToString();
            frmCTPhieu.IdNhanVien = ((DataRowView)bdsCTPhieuBaoTri[bdsCTPhieuBaoTri.Position])["IDNHANVIEN"].ToString();
            if (frmCTPhieu.ShowDialog() == DialogResult.OK)
            {
                frmCTPhieu.Close();
                string maPhieu = txtMaPhieu.Text;
                string idNhanVien = frmCTPhieu.IdNhanVien;
                string moTa = frmCTPhieu.MoTa;
                string lenh = $"UPDATE CT_PHIEUBAOTRI SET CONGVIEC = N'{moTa}' WHERE IDPHIEU = '{maPhieu}' AND IDNHANVIEN = {idNhanVien}";
                if (Program.ExecSqlNonQuery(lenh) == 0)
                {
                    this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);
                }
            }
            frmCTPhieu.Dispose();

        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            this.cT_PHIEUBAOTRITableAdapter.Fill(this.ds.CT_PHIEUBAOTRI);
        }

        
    }
}