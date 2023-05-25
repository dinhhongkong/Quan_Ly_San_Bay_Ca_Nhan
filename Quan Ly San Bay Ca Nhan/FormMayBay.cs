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
    public partial class FormMayBay : DevExpress.XtraEditors.XtraForm
    {
        private TrangThai trangThai;

        public FormMayBay()
        {
            InitializeComponent();
        }

        private void FormMayBay_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.ds.LOAIMAYBAY);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.ds.MAYBAY);
            this.cT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_CHUMAYBAYTableAdapter.Fill(this.ds.CT_CHUMAYBAY);
            this.cT_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_KHOTableAdapter.Fill(this.ds.CT_KHO);
            this.pHIEUBAOTRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUBAOTRITableAdapter.Fill(this.ds.PHIEUBAOTRI);
            
            repositoryItemLookUpEdit.DataSource = bdsLoaiMB;
            repositoryItemLookUpEdit.DisplayMember = "TENLOAI";
            repositoryItemLookUpEdit.ValueMember = "IDLOAI";
            trangThai = TrangThai.NONE;


        }

        private bool kiemTraNhapLieu()
        {
            if ( string.IsNullOrEmpty(txtIdMayBay.Text ) )
            {
                MessageBox.Show("ID máy bay không được bỏ trống","Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(txtLoai.Text))
            {
                MessageBox.Show("Loại máy bay không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if ( txtIdMayBay.Text.Length > 10)
            {
                MessageBox.Show("ID máy bay không được có độ dài > 10", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (Regex.IsMatch(txtIdMayBay.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("ID máy bay chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if ( trangThai == TrangThai.THEM && bdsMayBay.Find("IDMAYBAY", txtIdMayBay.Text) >= 0 )
            {
                MessageBox.Show("ID máy bay đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pcChucNang.Enabled = true;
            bdsMayBay.AddNew();
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcMayBay.Enabled = false;
            trangThai = TrangThai.THEM;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pcChucNang.Enabled = true;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            gcMayBay.Enabled = false;
            txtIdMayBay.Enabled = false;
            trangThai = TrangThai.HIEUCHINH;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( kiemTraNhapLieu() == false)
            {
                return;
            }
            
            try
            {
                bdsMayBay.EndEdit();
                bdsMayBay.ResetCurrentItem();
                this.mAYBAYTableAdapter.Update(this.ds.MAYBAY);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi máy bay \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }
            gcMayBay.Enabled = true;
            pcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtIdMayBay.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( bdsMayBay.Count == 0)
            {
                MessageBox.Show("Không có gì để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTKho.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì máy bay đang có trong kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if ( bdsChuMayBay.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì máy bay đang có chủ sở hữu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa máy bay này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMayBay.RemoveCurrent();
                    this.mAYBAYTableAdapter.Update(this.ds.MAYBAY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa máy bay. Bạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mAYBAYTableAdapter.Fill(this.ds.MAYBAY);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( trangThai == TrangThai.THEM)
            {
                bdsMayBay.RemoveCurrent();
                bdsMayBay.CancelEdit();
            }
            else if ( trangThai == TrangThai.HIEUCHINH)
            {
                bdsMayBay.CancelEdit();
            }
            else
            {
                this.Dispose();
            }
            gcMayBay.Enabled = true;
            pcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            txtIdMayBay.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private void txtLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormChonLoaiMB frmLoaiMB = new FormChonLoaiMB();
            if (frmLoaiMB.ShowDialog() == DialogResult.OK )
            {
                txtLoai.Text = frmLoaiMB.getIdLoai();
            }
            frmLoaiMB.Dispose();
        }
    }
}