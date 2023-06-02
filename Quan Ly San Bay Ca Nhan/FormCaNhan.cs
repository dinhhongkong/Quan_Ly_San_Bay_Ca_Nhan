using DevExpress.XtraEditors;
using Quan_Ly_May_Bay.DSTableAdapters;
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
    public partial class FormCaNhan : DevExpress.XtraEditors.XtraForm
    {
        bool isAdd = false;
        int positionCaNhan = 0;
        Func<bool> validateAction;

        public FormCaNhan()
        {
            InitializeComponent();
        }


        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.NGUOITableAdapter.Fill(this.DS.NGUOI);

            this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

            this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

            this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

            this.panelCANHAN.Enabled = false;
            this.gvCANHAN.OptionsBehavior.Editable = false;
            this.gvDSMAYBAY.OptionsBehavior.Editable = false;
            this.gvCT_CHUMAYBAY.OptionsBehavior.Editable = false;
            this.btnGhi.Enabled = this.btnUndo.Enabled = false;
            if (bdsCANHAN.Count == 0)
                this.btnXoa.Enabled = this.btnSua.Enabled = this.btnThemMayBay.Enabled = false; 
        }


        private void TruyVanNhanh(string query)
        {
            SqlConnection connection = new SqlConnection(Program.connstr);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionCaNhan = this.bdsCANHAN.Position;
            isAdd = true;
            ActionBeforeEdit();
            validateAction += ValidateThemCaNhan;
            this.txtOWNER_ID.Enabled = true;
        }


        private void ActionBeforeEdit()
        {
            gcCANHAN.Enabled = gcDSMAYBAY.Enabled = gcCT_CHUMAYBAY.Enabled = false;
            this.btnThemNguoi.Enabled = this.btnXoa.Enabled 
                = this.btnSua.Enabled = this.btnReload.Enabled 
                = this.btnThemMayBay.Enabled = this.btnThoat.Enabled = false;
            this.btnUndo.Enabled = this.btnGhi.Enabled = true;
            this.panelCANHAN.Enabled = true;

            if(isAdd == true)
                txtOWNER_ID.Text = txtTEN.Text = txtCMND.Text = txtSDT.Text = txtDIACHI.Text = "";
        }


        private bool ValidateThemCaNhan()
        {
            string maCaNhan = txtOWNER_ID.Text.Trim();

            if(bdsCANHAN.Find("OWNER_ID", maCaNhan) > -1)
            {
                MessageBox.Show("Đã có mã Chủ cá nhân tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                txtOWNER_ID.Focus();
                return false;
            }
            return true;
        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(txtOWNER_ID.Text.Trim() == "")
            {
                MessageBox.Show("Mã cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtOWNER_ID.Focus();
                return;
            }

            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Họ và tên cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }

            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("CMND cá nhân chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("SĐT cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("SĐT cá nhân chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
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
                    String idNguoi= txtOWNER_ID.Text.Trim();
                    String ten = txtTEN.Text;
                    String cmnd = txtCMND.Text;
                    String diaChi = txtDIACHI.Text;
                    String sdt = txtSDT.Text;
                    TruyVanNhanh($"EXEC sp_ThemCaNhan '{idNguoi}', N'{ten}', {cmnd}, N'{diaChi}', '{sdt}'");

                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NGUOITableAdapter.Fill(this.DS.NGUOI);

                }
                else
                {
                    bdsNGUOI.EndEdit();
                    bdsNGUOI.ResetCurrentItem();
                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NGUOITableAdapter.Update(this.DS.NGUOI);
                }

                // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

                // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                if(isAdd == true)
                    MessageBox.Show("Thêm cá nhân thành công!", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Sửa cá nhân thành công!", "", MessageBoxButtons.OK);
                
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
            gcCANHAN.Enabled = gcDSMAYBAY.Enabled = gcCT_CHUMAYBAY.Enabled = true;
            this.btnThemNguoi.Enabled = this.btnXoa.Enabled 
                = this.btnSua.Enabled = this.btnReload.Enabled 
                = this.btnThemMayBay.Enabled = this.btnThoat.Enabled = true;
            this.btnUndo.Enabled = this.btnGhi.Enabled = false;
            this.panelCANHAN.Enabled = false;
            validateAction -= this.ValidateThemCaNhan;

            if (bdsCANHAN.Count == 0)
                this.btnXoa.Enabled = this.btnSua.Enabled = this.btnThemMayBay.Enabled = false;

            if (isAdd == false)
                bdsCANHAN.Position = bdsCANHAN.Find("OWNER_ID", ((DataRowView)bdsCANHAN[positionCaNhan])["OWNER_ID"].ToString());
            isAdd = false;
        }


        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionCaNhan = this.bdsCANHAN.Position;
            ActionBeforeEdit();
            this.txtOWNER_ID.Enabled = false;
        }


        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNGUOI.CancelEdit();
            if (!btnThemNguoi.Enabled) bdsCANHAN.Position = positionCaNhan;
            ActionAfterEdit();
            bdsCANHAN.Position = bdsCANHAN.Find("OWNER_ID", ((DataRowView)bdsCANHAN[positionCaNhan])["OWNER_ID"].ToString());
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCaNhan = "";

            if (bdsCT_CHUMAYBAY.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì cá nhân này đã hoặc đang sở hữu máy bay!");
                return;
            }
            
            if (MessageBox.Show("Bạn có muốn xóa Cá nhân này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maCaNhan = ((DataRowView)bdsCANHAN[bdsCANHAN.Position])["OWNER_ID"].ToString();
                    
                    TruyVanNhanh($"EXEC sp_XoaCaNhan '{maCaNhan}'");

                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NGUOITableAdapter.Fill(this.DS.NGUOI);

                    // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                    this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

                    // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                    this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                    // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                    this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NGUOITableAdapter.Fill(this.DS.NGUOI);

                    // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                    this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                    // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                    this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                    bdsCANHAN.Position = bdsCANHAN.Find("maCaNhan", maCaNhan);
                }
            }
            if (bdsCANHAN.Count == 0)
                this.btnXoa.Enabled = this.btnSua.Enabled = this.btnThemMayBay.Enabled = false;
        }


        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.NGUOITableAdapter.Fill(this.DS.NGUOI);

                // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

                // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Reloading", MessageBoxButtons.OK);
            }
        }

        private void btnThemMayBay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCaNhan = ((DataRowView)bdsCANHAN[bdsCANHAN.Position])["OWNER_ID"].ToString();
            FormLocMayBaySoHuu frmChonMayBay = new FormLocMayBaySoHuu(maCaNhan);
            String maMayBay = "";
            if (frmChonMayBay.ShowDialog() == DialogResult.OK)
                maMayBay = frmChonMayBay.getIDMayBay();
            else
                return;
            
            
            if(maMayBay != "")
            {
                try
                {
                    TruyVanNhanh($"INSERT INTO CT_CHUMAYBAY VALUES('{maCaNhan}', '{maMayBay}', GETDATE())");
                    MessageBox.Show("Thêm máy bay sỡ hữu thành công!", "", MessageBoxButtons.OK);
                    
                    // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                    this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_CHUMAYBAYTableAdapter.Fill(this.DS.CT_CHUMAYBAY);

                    // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                    this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                    // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                    this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                    bdsCANHAN.Position = bdsCANHAN.Find("OWNER_ID", maCaNhan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa máy bay sở hữu này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string ownerId = txtOWNER_ID.Text;
                string idMayBay = ((DataRowView)bdsDSCHUMAYBAY[bdsDSCHUMAYBAY.Position])["IDMAYBAY"].ToString();
                string ngayBatDau = ((DataRowView)bdsDSCHUMAYBAY[bdsDSCHUMAYBAY.Position])["NGAYBATDAU"].ToString();

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

        private void gvDSMAYBAY_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if ( e.Button == MouseButtons.Right ) 
            {
                gcDSMAYBAY.ContextMenuStrip = cmsChucNang;
            }
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
    }
}