using DevExpress.XtraEditors;
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
    public partial class FormLoaiMayBay : DevExpress.XtraEditors.XtraForm
    {
        private TrangThai trangThai;
        public FormLoaiMayBay()
        {
            InitializeComponent();
        }


        private void FormLoaiMayBay_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.ds.LOAIMAYBAY);
            this.cT_BANGLAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BANGLAITableAdapter.Fill(this.ds.CT_BANGLAI);
            this.cT_NVBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NVBAOTRITableAdapter.Fill(this.ds.CT_NVBAOTRI);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.ds.MAYBAY);
            trangThai = TrangThai.NONE;
        }

        private bool kiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtIDLoai.Text))
            {
                MessageBox.Show("ID loại máy bay không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Tên loại máy bay không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtIDLoai.Text.Length > 10)
            {
                MessageBox.Show("ID loại máy bay không được có độ dài > 10", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (txtTenLoai.Text.Length > 50)
            {
                MessageBox.Show("Tên loại máy bay không được có độ dài > 50", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (Regex.IsMatch(txtIDLoai.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("ID máy bay chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (trangThai == TrangThai.THEM && bdsLoaiMB.Find("IDLOAI", txtIDLoai.Text) >= 0)
            {
                MessageBox.Show("ID loại máy bay đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChucNang.Enabled = true;
            bdsLoaiMB.AddNew();
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcLoaiMB.Enabled = false;
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
            gcLoaiMB.Enabled = false;
            txtIDLoai.Enabled = false;
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
                bdsLoaiMB.EndEdit();
                bdsLoaiMB.ResetCurrentItem();
                this.lOAIMAYBAYTableAdapter.Update(this.ds.LOAIMAYBAY);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi loại máy bay \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }
            gcLoaiMB.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtIDLoai.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( bdsLoaiMB.Count == 0)
            {
                return;
            }
            if ( bdsMayBay.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì loại máy bay này có trong danh sách máy bay", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsNVBaoTri.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì loại máy bay này có trong danh sách nhân viên bảo trì", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTBangLai.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì loại máy bay này có trong danh sách bằng lái của phi công", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa loại máy bay này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLoaiMB.RemoveCurrent();
                    this.lOAIMAYBAYTableAdapter.Update(this.ds.LOAIMAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa loại máy bay. Bạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOAIMAYBAYTableAdapter.Fill(this.ds.LOAIMAYBAY);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                bdsLoaiMB.RemoveCurrent();
                bdsLoaiMB.CancelEdit();
            }
            else if (trangThai == TrangThai.HIEUCHINH)
            {
                bdsLoaiMB.CancelEdit();
            }
            else
            {
                this.Dispose();
            }
            gcLoaiMB.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtIDLoai.Enabled = true;
            trangThai = TrangThai.NONE;
        }
    }
}