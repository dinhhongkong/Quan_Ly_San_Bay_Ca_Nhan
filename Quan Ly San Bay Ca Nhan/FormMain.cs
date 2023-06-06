using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace Quan_Ly_May_Bay
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void hienThiMenu()
        {
            tslblMaNV.Text = "Mã nhân viên: " + Program.userName;
            tslblHoTen.Text = "Họ và tên: " + Program.mHoten;
            tslblNhom.Text = "Nhóm quyền: " + Program.mGroup;

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            if (Program.mGroup == "MANAGER")
            {
                ribDanhMuc.Visible = true;
                ribNhanVien.Visible = true;
                btnTaoTk.Enabled = true;
                ribSaoLuu.Visible = true; 
            }
            else
            {
                ribBaoTri.Visible = true;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();

            tslblMaNV.Text = "Mã nhân viên: ";
            tslblHoTen.Text = "Họ và tên: ";
            tslblNhom.Text = "Nhóm: ";

            //Hiện Chức Năng
            btnDangNhap.Enabled = true;
            //Ẩn Đăng Nhập
            ribDanhMuc.Visible = false;
            ribNhanVien.Visible = false;
            ribBaoTri.Visible = false;
            ribSaoLuu.Visible = false;
            btnDangXuat.Enabled = false;
            btnTaoTk.Enabled = false;
        }

        private void btnMayBay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMayBay));
            if (frm != null) frm.Activate();
            else
            {
                FormMayBay frmMayBay = new FormMayBay();
                frmMayBay.MdiParent = this;
                frmMayBay.Show();
            }
        }

        private void btnLoaiMB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLoaiMayBay));
            if (frm != null) frm.Activate();
            else
            {
                FormLoaiMayBay frmLoaiMayBay = new FormLoaiMayBay();
                frmLoaiMayBay.MdiParent = this;
                frmLoaiMayBay.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKho));
            if (frm != null) frm.Activate();
            else
            {
                FormKho frmKho = new FormKho();
                frmKho.MdiParent = this;
                frmKho.Show();
            }
        }

        private void btnCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormCaNhan));
            if (frm != null) frm.Activate();
            else
            {
                FormCaNhan frmCaNhan = new FormCaNhan();
                frmCaNhan.MdiParent = this;
                frmCaNhan.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanVien frmNhanVien = new FormNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
        }

        private void btnNvBaoTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNVBaoTri));
            if (frm != null) frm.Activate();
            else
            {
                FormNVBaoTri frmNVBaoTri = new FormNVBaoTri();
                frmNVBaoTri.MdiParent = this;
                frmNVBaoTri.Show();
            }
        }

        private void btnBaoTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuBaoTri));
            if (frm != null) frm.Activate();
            else
            {
                FormPhieuBaoTri frmPhieuBaoTri = new FormPhieuBaoTri();
                frmPhieuBaoTri.MdiParent = this;
                frmPhieuBaoTri.Show();
            }
        }

        private void btnDoanhNghiep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDoanhNghiep));
            if (frm != null) frm.Activate();
            else
            {
                FormDoanhNghiep frmDoanhNghiep = new FormDoanhNghiep();
                frmDoanhNghiep.MdiParent = this;
                frmDoanhNghiep.Show();
            }
        }

        private void btnTaoTk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan frmTaoTaiKhoan = new FormTaoTaiKhoan();
                frmTaoTaiKhoan.MdiParent = this;
                frmTaoTaiKhoan.Show();
            }

        }

        private void btnPhiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhiCong));
            if (frm != null) frm.Activate();
            else
            {
                FormPhiCong frmPhiCong = new FormPhiCong();
                frmPhiCong.MdiParent = this;
                frmPhiCong.Show();
            }
        }

        private void btnBaoCaoMB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBaoCaoBaoTri));
            if (frm != null) frm.Activate();
            else
            {
                FormBaoCaoBaoTri frmBaoCaoBaoTri = new FormBaoCaoBaoTri();
                frmBaoCaoBaoTri.MdiParent = this;
                frmBaoCaoBaoTri.Show();
            }
        }

        private void btnBaoCaoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XrptCaoCaoKhoConTrong rpt = new XrptCaoCaoKhoConTrong();

            rpt.lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss tt");
            rpt.lblMaNV.Text = Program.userName;
            rpt.lblHoTenNV.Text = Program.mHoten;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
