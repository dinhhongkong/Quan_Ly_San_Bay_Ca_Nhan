using DevExpress.XtraEditors;
using Quan_Ly_May_Bay.SubForm;
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
    public partial class FormDoanhNghiep : DevExpress.XtraEditors.XtraForm
    {
        bool isAdd = false;
        int positionDoanhNghiep = 0;
        Func<bool> validateAction;

        public FormDoanhNghiep()
        {
            InitializeComponent();
        }

        private void dOANHNGHIEPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDOANHNGHIEP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormDoanhNghiep_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.DOANHNGHIEP' table. You can move, or remove it, as needed.
            this.DOANHNGHIEPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);

            // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
            this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

            // TODO: This line of code loads data into the 'dS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
            this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

            this.panelDOANHNGHIEP.Enabled = false;
            this.gvDOANHNGHIEP.OptionsBehavior.Editable = false;
            this.gvDSMAYBAY.OptionsBehavior.Editable = false;
            this.gvCT_CHUMAYBAY.OptionsBehavior.Editable = false;
            this.btnGhi.Enabled = this.btnUndo.Enabled = false;
            if (bdsDOANHNGHIEP.Count == 0) this.btnThemMayBay.Enabled = false;
        }

        private void TruyVanNhanh(string query)
        {
            SqlConnection connection = new SqlConnection(Program.connstr);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnThemDoanhNghiep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionDoanhNghiep = this.bdsDOANHNGHIEP.Position;
            isAdd = true;
            ActionBeforeEdit();
            validateAction += ValidateThemCaNhan;
            this.txtOWNER_ID.Enabled = true;
        }

        private void ActionBeforeEdit()
        {
            gcDOANHNGHIEP.Enabled = gcDSMAYBAY.Enabled = gcCT_CHUMAYBAY.Enabled = false;
            this.btnThemDoanhNghiep.Enabled = this.btnXoa.Enabled
                = this.btnSua.Enabled = this.btnReload.Enabled
                = this.btnThemMayBay.Enabled = this.btnThoat.Enabled = false;
            this.btnUndo.Enabled = this.btnGhi.Enabled = true;
            this.panelDOANHNGHIEP.Enabled = true;

            if (isAdd == true)
                txtOWNER_ID.Text = txtTEN.Text = txtDIACHI.Text = txtSDT.Text = txtDAIDIEN.Text = "";
        }

        private bool ValidateThemCaNhan()
        {
            string maDoanhNghiep = txtOWNER_ID.Text.Trim();

            if (bdsDOANHNGHIEP.Find("OWNER_ID", maDoanhNghiep) > -1)
            {
                MessageBox.Show("Đã có mã Chủ doanh nghiệp tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                txtOWNER_ID.Focus();
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtOWNER_ID.Text.Trim() == "")
            {
                MessageBox.Show("Mã doanh nghiệp không được để trống!", "", MessageBoxButtons.OK);
                txtOWNER_ID.Focus();
                return;
            }

            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên doanh nghiệp không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }


            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ doanh nghiệp không được để trống!", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("SĐT doanh nghiệp không được để trống!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("SĐT doanh nghiệp chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (txtDAIDIEN.Text.Trim() == "")
            {
                MessageBox.Show("Họ và tên người đại diện doanh nghiệp không được để trống!", "", MessageBoxButtons.OK);
                txtDAIDIEN.Focus();
                return;
            }


            if (validateAction != null)
                if (validateAction.Invoke() == false)
                    return;

            try
            {
                string ownerID = txtOWNER_ID.Text.Trim();

                if (isAdd)
                {
                    String ten = txtTEN.Text;
                    String diaChi = txtDIACHI.Text;
                    String sdt = txtSDT.Text;
                    String daiDien = txtDAIDIEN.Text;
                    TruyVanNhanh($"EXEC sp_ThemDoanhNghiep " +
                        $"'{ownerID}'" +
                        $", N'{ten}'" +
                        $", N'{diaChi}'" +
                        $", '{sdt}'" +
                        $", N'{daiDien}'");

                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.DOANHNGHIEPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);

                }
                else
                {
                    bdsDOANHNGHIEP.EndEdit();
                    bdsDOANHNGHIEP.ResetCurrentItem();
                    this.DOANHNGHIEPTableAdapter.Update(this.DS.DOANHNGHIEP);
                }
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                if (isAdd == true)
                    MessageBox.Show("Thêm doanh nghiệp thành công!", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Sửa doanh nghiệp thành công!", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEdit();
        }

        private void ActionAfterEdit()
        {
            gcDOANHNGHIEP.Enabled = gcDSMAYBAY.Enabled = gcCT_CHUMAYBAY.Enabled = true;
            this.btnThemDoanhNghiep.Enabled = this.btnXoa.Enabled
                = this.btnSua.Enabled = this.btnReload.Enabled
                = this.btnThemMayBay.Enabled = this.btnThoat.Enabled = true;
            this.btnUndo.Enabled = this.btnGhi.Enabled = false;
            this.panelDOANHNGHIEP.Enabled = false;
            validateAction -= this.ValidateThemCaNhan;

            if (bdsDOANHNGHIEP.Count == 0)
                this.btnXoa.Enabled = this.btnSua.Enabled = this.btnThemMayBay.Enabled = false;
            if (isAdd == false)
                bdsDOANHNGHIEP.Position = bdsDOANHNGHIEP.Find("OWNER_ID", ((DataRowView)bdsDOANHNGHIEP[positionDoanhNghiep])["OWNER_ID"].ToString());
            isAdd = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionDoanhNghiep = this.bdsDOANHNGHIEP.Position;
            ActionBeforeEdit();
            this.txtOWNER_ID.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDOANHNGHIEP.CancelEdit();
            if (!btnThemDoanhNghiep.Enabled) bdsDOANHNGHIEP.Position = positionDoanhNghiep;
            ActionAfterEdit();
            bdsDOANHNGHIEP.Position = bdsDOANHNGHIEP.Find("OWNER_ID", ((DataRowView)bdsDOANHNGHIEP[positionDoanhNghiep])["OWNER_ID"].ToString());
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maDoanhNghiep = "";

            if (bdsCT_CHUMAYBAY.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì doanh nghiệp này đã hoặc đang sở hữu máy bay!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa doanh nghiệp này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maDoanhNghiep = ((DataRowView)bdsDOANHNGHIEP[bdsDOANHNGHIEP.Position])["OWNER_ID"].ToString();

                    TruyVanNhanh($"EXEC sp_XoaDoanhNghiep '{maDoanhNghiep}'");

                    this.DOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
                    this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.DOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
                    this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                }
            }
            if (bdsDOANHNGHIEP.Count == 0)
                this.btnXoa.Enabled = this.btnSua.Enabled = this.btnThemMayBay.Enabled = false;
        }


        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DOANHNGHIEPTableAdapter.Fill(this.DS.DOANHNGHIEP);
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Reloading", MessageBoxButtons.OK);
            }
        }


        private void btnThemMayBay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCaNhan = ((DataRowView)bdsDOANHNGHIEP[bdsDOANHNGHIEP.Position])["OWNER_ID"].ToString();
            FormLocMayBaySoHuu frmChonMayBay = new FormLocMayBaySoHuu(maCaNhan);
            String maMayBay = "";
            if (frmChonMayBay.ShowDialog() == DialogResult.OK)
                maMayBay = frmChonMayBay.getIDMayBay();
            else
                return;

            try
            {
                TruyVanNhanh($"INSERT INTO CT_CHUMAYBAY VALUES('{maCaNhan}', '{maMayBay}', GETDATE())");
                MessageBox.Show("Thêm máy bay sỡ hữu thành công!", "", MessageBoxButtons.OK);
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);
                bdsDOANHNGHIEP.Position = bdsDOANHNGHIEP.Find("OWNER_ID", maCaNhan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnHienTaiSoHuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDSMAYBAY.Visible = true;
            gcCT_CHUMAYBAY.Visible = false;
        }

        private void btnLichSuSoHuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDSMAYBAY.Visible = false;
            gcCT_CHUMAYBAY.Visible = true;
        }

        private void gvDSMAYBAY_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            gcDSMAYBAY.ContextMenuStrip = cmsChucNang;
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa máy bay sở hữu này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string ownerId = txtOWNER_ID.Text;
                string idMayBay = ((DataRowView)bdsDSMAYBAY[bdsDSMAYBAY.Position])["IDMAYBAY"].ToString();
                string ngayBatDau = ((DataRowView)bdsDSMAYBAY[bdsDSMAYBAY.Position])["NGAYBATDAU"].ToString();

                string lenh = $"DELETE FROM CT_CHUMAYBAY WHERE OWNER_ID = '{ownerId}' AND IDMAYBAY = '{idMayBay}' AND NGAYBATDAU = '{ngayBatDau}'";

                if (Program.ExecSqlNonQuery(lenh) != 0)
                {
                    MessageBox.Show("Lỗi xóa máy bay. Bạn hãy xem lại\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);
            }
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);
            this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);
        }
    }
}