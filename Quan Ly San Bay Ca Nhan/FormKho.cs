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
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        private TrangThai trangThai;
        public FormKho()
        {
            InitializeComponent();
        }


        private void FormKho_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOTableAdapter.Fill(this.ds.KHO);
            this.cT_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_KHOTableAdapter.Fill(this.ds.CT_KHO);
            trangThai = TrangThai.NONE;
        }
        private bool kiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtIdKho.Text))
            {
                MessageBox.Show("ID KHO không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(txtViTri.Text))
            {
                MessageBox.Show("Vị trí kho không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtIdKho.Text.Length > 10)
            {
                MessageBox.Show("ID kho không được có độ dài > 10", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (nudSucChua.Value == 0)
            {
                MessageBox.Show("Sức chứa của kho máy bay phải >0", "Thông báo", MessageBoxButtons.OK);
                return false;

            }
            if (Regex.IsMatch(txtIdKho.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("ID kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (trangThai == TrangThai.THEM && bdsKho.Find("IDKHO", txtIdKho.Text) >= 0)
            {
                MessageBox.Show("ID kho này đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChucNang.Enabled = true;
            bdsKho.AddNew();
            nudSucChua.Value = 0;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = true;
            btnCTKho.Enabled = false;
            gcKho.Enabled = false;
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
            btnCTKho.Enabled = false;
            gcKho.Enabled = false;
            txtIdKho.Enabled = false;
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
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem();
                this.kHOTableAdapter.Update(this.ds.KHO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi KHO \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }
            gcKho.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            btnCTKho.Enabled = true;
            txtIdKho.Enabled = true;
            trangThai = TrangThai.NONE;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKho.Count == 0)
            {
                return;
            }
            if (bdsCTKho.Count > 0)
            {
                MessageBox.Show("Không thể xóa, vì đã có máy bay chứa trong kho này", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại máy bay này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKho.RemoveCurrent();
                    this.kHOTableAdapter.Update(this.ds.KHO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho này. Bạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOTableAdapter.Fill(this.ds.KHO);
            this.cT_KHOTableAdapter.Fill(this.ds.CT_KHO);
        }

        private void btnCTKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcCTKho.Enabled = true;
            gcChucNang.Visible = false;
            gcChucNangCT.Visible = true;
            btnThem.Enabled = false;
            btnHieuChinh.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnGhi.Enabled = false;
            gcKho.Enabled = false;
            trangThai = TrangThai.CHITIET;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void gvCTKho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                gcCTKho.ContextMenuStrip = cmsCTKho;
            }
        }


        private void tsmiThem_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsKho[bdsKho.Position])["SUCCHUA"].ToString() == bdsCTKho.Count.ToString())
            {
                MessageBox.Show("Sức chứa kho đã đầy, không thể thêm máy bay vô", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bdsCTKho.AddNew();
            gcChucNangCT.Enabled = true;
            gcChucNangCT.Text = "Thêm chi tiết kho";
            gcCTKho.Enabled = false;
            
        }

        private void tsmiSua_Click(object sender, EventArgs e)
        {
            gcChucNangCT.Enabled = true;
            gcChucNangCT.Text = "Hiệu chỉnh chi tiết kho";
            gcCTKho.Enabled = false;
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            gcChucNangCT.Enabled = false;
            gcCTKho.Enabled = true;
            gcChucNangCT.Text = "Nhập liệu chi tiết kho";
            this.cT_KHOTableAdapter.Fill(this.ds.CT_KHO);
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa máy bay này ra khỏi kho", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTKho.RemoveCurrent();
                    this.cT_KHOTableAdapter.Update(this.ds.CT_KHO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết kho này. Bạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            this.cT_KHOTableAdapter.Fill(this.ds.CT_KHO);
        }

        private void btnGhiCTKho_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtIDMayBay.Text))
            {
                MessageBox.Show("ID Máy bay không được bỏ trống, vui lòng chọn 1 ID Máy bay", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            for ( int i = 0; i  < bdsCTKho.Count; i++)
            {
                if ( txtIDMayBay.Text == ((DataRowView)bdsCTKho[i])["IDMAYBAY"].ToString())
                {
                    MessageBox.Show("Máy bay này đã có trong trong kho, vui lòng chọn máy bay khác", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            

            try
            {
                bdsCTKho.EndEdit();
                bdsCTKho.ResetCurrentItem();
                this.cT_KHOTableAdapter.Update(this.ds.CT_KHO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi thêm máy bay vào kho \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }

        }

        private void txtIDMayBay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormChonMayBay formChonMayBay = new FormChonMayBay();
            if (formChonMayBay.ShowDialog() == DialogResult.OK)
            {
                txtIDMayBay.Text = formChonMayBay.getIDMayBay();
            }
            formChonMayBay.Dispose();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.THEM)
            {
                bdsKho.RemoveCurrent();
                bdsKho.CancelEdit();
            }
            else if (trangThai == TrangThai.HIEUCHINH)
            {
                bdsKho.CancelEdit();
            }
            else if (trangThai == TrangThai.CHITIET)
            {
                gcChucNang.Visible = true;
                gcChucNangCT.Visible = false;
                gcCTKho.Enabled = false;
            }

            gcKho.Enabled = true;
            gcChucNang.Enabled = false;
            btnThem.Enabled = true;
            btnHieuChinh.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnGhi.Enabled = false;
            btnCTKho.Enabled = true;
            txtIdKho.Enabled = true;
            trangThai = TrangThai.NONE;
        }
    }
}