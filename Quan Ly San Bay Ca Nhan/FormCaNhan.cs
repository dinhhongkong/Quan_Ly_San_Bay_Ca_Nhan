using DevExpress.XtraEditors;
using Quan_Ly_May_Bay.DSTableAdapters;
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


            

            this.panelCANHAN.Enabled = false;
            this.gvCANHAN.OptionsBehavior.Editable = false;
            this.gvDSMAYBAY.OptionsBehavior.Editable = false;
            this.btnGhi.Enabled = this.btnUndo.Enabled = false;
            if (bdsCANHAN.Count == 0) this.btnThemMayBay.Enabled = false;
            
        }

        private void TruyVanNhanh(string query)
        {
            SqlConnection connection = new SqlConnection(Program.connstr);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChonMayBay frmChonMayBay = new FormChonMayBay();
            
            frmChonMayBay.TopMost = true;
            frmChonMayBay.ShowDialog();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionCaNhan = this.bdsCANHAN.Position;
            bdsNGUOI.AddNew();
            ActionBeforeEdit();
            isAdd = true;
            validateAction += ValidateThemCaNhan;
            this.txtOWNER_ID.Enabled = true;

        }

        private void ActionBeforeEdit()
        {
            gcCANHAN.Enabled = gcDSMAYBAY.Enabled = false;
            this.btnThemNguoi.Enabled = this.btnXoa.Enabled 
                = this.btnSua.Enabled = this.btnReload.Enabled 
                = this.btnThemMayBay.Enabled = false;
            this.btnUndo.Enabled = this.btnGhi.Enabled = true;
            this.panelCANHAN.Enabled = true;
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
                MessageBox.Show("Mã Chủ cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtOWNER_ID.Focus();
                return;
            }

            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên Chủ cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("SĐT Chủ cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND Chủ cá nhân không được để trống!", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }


            if (validateAction != null)
                if (validateAction.Invoke() == false)
                    return;

            try
            {
                string ownerID = txtOWNER_ID.Text.Trim();
                bdsNGUOI.EndEdit();
                bdsNGUOI.ResetCurrentItem();

                // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.NGUOITableAdapter.Update(this.DS.NGUOI);

                if (isAdd)
                {
                    TruyVanNhanh($"INSERT INTO CHUMAYBAY VALUES('{ownerID}', 0)");
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        SqlCommand command = new SqlCommand("Select MAX(IDNGUOI) AS ID FROM NGUOI", connection);
                        connection.Open();
                        SqlDataReader read = command.ExecuteReader();
                        read.Read();
                        string idNguoi = read.GetValue(0).ToString();
                        TruyVanNhanh($"INSERT INTO CANHAN VALUES('{ownerID}', {idNguoi})");
                        connection.Close();
                    }
                }


                // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_CHUMAYBAYTableAdapter.Update(this.DS.CT_CHUMAYBAY);

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
                return;
            }

            ActionAfterEdit();
        }
        private void ActionAfterEdit()
        {
            gcCANHAN.Enabled = gcDSMAYBAY.Enabled = true;
            this.btnThemNguoi.Enabled = this.btnXoa.Enabled 
                = this.btnSua.Enabled = this.btnReload.Enabled 
                = this.btnThemMayBay.Enabled = true;
            this.btnUndo.Enabled = this.btnGhi.Enabled = false;
            this.panelCANHAN.Enabled = false;
            validateAction -= this.ValidateThemCaNhan;
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(bdsCT_CHUMAYBAY.Count > 0)
            {
                MessageBox.Show("Không thể xóa Cá nhân này vì Cá nhân này đã hoặc đang sở hữu máy bay!");
                return;
            }
            String maCaNhan = "";
            if (MessageBox.Show("Bạn có muốn xóa Cá nhân này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maCaNhan = ((DataRowView)bdsCANHAN[bdsCANHAN.Position])["OWNER_ID"].ToString();
                    
                    TruyVanNhanh($"DELETE FROM CANHAN WHERE OWNER_ID = '{maCaNhan}'");
                    TruyVanNhanh($"DELETE FROM CHUMAYBAY WHERE OWNER_ID = '{maCaNhan}'");
                    bdsNGUOI.RemoveCurrent();

                    // TODO: This line of code loads data into the 'DS.NGUOI' table. You can move, or remove it, as needed.
                    this.NGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NGUOITableAdapter.Update(this.DS.NGUOI);

                    // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                    this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_CHUMAYBAYTableAdapter.Update(this.DS.CT_CHUMAYBAY);

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
                    this.NGUOITableAdapter.Update(this.DS.NGUOI);

                    // TODO: This line of code loads data into the 'dS.sp_DanhSachCaNhan' table. You can move, or remove it, as needed.
                    this.sp_DanhSachCaNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachCaNhanTableAdapter.Fill(this.DS.sp_DanhSachCaNhan);

                    // TODO: This line of code loads data into the 'DS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
                    this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);

                    bdsCANHAN.Position = bdsCANHAN.Find("maCaNhan", maCaNhan);
                }
            }
            if (bdsCT_CHUMAYBAY.Count == 0) this.btnXoa.Enabled = false;
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
            FormChonMayBay frmChonMayBay = new FormChonMayBay();
            frmChonMayBay.ShowDialog();
            String maCaNhan = ((DataRowView)bdsCANHAN[bdsCANHAN.Position])["OWNER_ID"].ToString();
            String maMayBay = frmChonMayBay.getMaMayBay();
            if(maMayBay != "")
            {
                try
                {
                    TruyVanNhanh($"INSERT INTO CT_CHUMAYBAY VALUES('{maCaNhan}', '{maMayBay}', GETDATE())");
                    MessageBox.Show("Thêm  máy bay sỡ hữu thành công!", "", MessageBoxButtons.OK);
                    

                    // TODO: This line of code loads data into the 'DS.CT_CHUMAYBAY' table. You can move, or remove it, as needed.
                    this.CT_CHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_CHUMAYBAYTableAdapter.Update(this.DS.CT_CHUMAYBAY);

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
    }
}