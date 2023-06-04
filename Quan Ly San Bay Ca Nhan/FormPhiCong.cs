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
    public partial class FormPhiCong : DevExpress.XtraEditors.XtraForm
    {
        bool addMode = false;
        int currPosDSPhiCong = 0;

        public FormPhiCong()
        {
            InitializeComponent();
        }

        private void TruyVanNhanh(string query)
        {
            SqlConnection connection = new SqlConnection(Program.connstr);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlConnection connection = new SqlConnection(Program.connstr);
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = connection;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            if (connection.State == ConnectionState.Closed) connection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void UnEditingMode()
        {
            panelPhiCong.Enabled = false;
            panelCTBangLai.Enabled = true; 
            btnThem.Enabled = btnReload.Enabled = true;
            btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnUndo.Enabled = false;
            if (bdsDSPhiCong.Count > 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
            }
        }

        private void EditingMode()
        {
            panelPhiCong.Enabled = true;
            panelCTBangLai.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = btnThemMB.Enabled = true;

            if (bdsDSPhiCong.Count <= 0) btnXoaMB.Enabled = false;
            else btnXoaMB.Enabled = true;
        }

        private bool validateInput()
        {
            if (Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("CMND không được để trống", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtCMND.Text.Length > 13)
            {
                MessageBox.Show("CMND không được có độ dài > 13", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtTen.Text == "")
            {
                MessageBox.Show("Họ và tên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại không được để trống", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtSDT.Text.Length > 13)
            {
                MessageBox.Show("SĐT không được có độ dài > 13", "Thông báo", MessageBoxButtons.OK);
                return false;

            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không được có độ dài > 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtIDBangLai.Text == "")
            {
                MessageBox.Show("Mã bằng lái không được để trống", "", MessageBoxButtons.OK);
                return false;
            }

            if (txtIDBangLai.Text.Length > 10)
            {
                MessageBox.Show("Bằng lái không được có độ dài > 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (dateNgayCap.Text == "")
            {
                MessageBox.Show("Ngày cấp bằng lái không được để trống", "", MessageBoxButtons.OK);
            }

            return true;
        }
        private void Reload()
        {
            //Reload
            this.sp_DanhSachPhiCongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachPhiCongTableAdapter.Fill(this.DS.sp_DanhSachPhiCong);

            //Reload
            this.sp_CT_BangLaiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_CT_BangLaiTableAdapter.Fill(this.DS.sp_CT_BangLai);
        }

        private void FormPhiCong_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;
            Reload();
            UnEditingMode();
        }

        private void btnThemNguoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDSPhiCong.AddNew();
            EditingMode();

            currPosDSPhiCong = bdsDSPhiCong.Position;
            addMode = true;

            txtIDBangLai.Text = "";
            dateNgayCap.DateTime = DateTime.Now;
            btnChonNV.Enabled = true;

            panelCTBangLai.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currPosDSPhiCong = bdsDSPhiCong.Position;
            EditingMode();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phi công này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maNV = ((DataRowView)bdsDSPhiCong[bdsDSPhiCong.Position])["IDNHANVIEN"].ToString();
                string maBangLai = ((DataRowView)bdsDSPhiCong[bdsDSPhiCong.Position])["ID_BANGLAI"].ToString();
                try
                {
                    TruyVanNhanh($"EXEC sp_XoaPhiCong {maNV}");

                    bdsDSPhiCong.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    bdsDSPhiCong.Position = bdsDSPhiCong.Find("IDNHANVIEN", maNV);
                }
                finally
                {
                    Reload();
                }
            }
            UnEditingMode();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!validateInput()) return;

            try
            {
                string maNV = ((DataRowView)bdsDSPhiCong[bdsDSPhiCong.Position])["IDNHANVIEN"].ToString();
                if (maNV == "") maNV = txtIDNhanVien.Text;

                Console.WriteLine("\n\n\n" + maNV + "\n\n");

                SqlDataReader myReader = ExecSqlDataReader($"SELECT IDNGUOI FROM NHANVIEN WHERE IDNHANVIEN = {maNV}");
                myReader.Read();
                string maNguoi = myReader.GetValue(0).ToString(); 
                myReader.Close();

                int nghi = (CBNghi.Checked ? 1 : 0);
                TruyVanNhanh($"EXEC sp_CapNhatPhiCong {maNguoi}, '{txtCMND.Text}', N'{txtTen.Text}', N'{txtDiaChi.Text}', '{txtSDT.Text}', {maNV}, {nghi}");

                DateTime dateTime = dateNgayCap.DateTime;
                string date = dateTime.ToString("yyyy-MM-dd");

                if (addMode)
                {
                    TruyVanNhanh($"INSERT INTO PHICONG VALUES('{txtIDBangLai.Text}', {maNV}, '{date}')");
                    btnChonNV.Enabled = false;
                    addMode = false;

                    Reload();
                    bdsDSPhiCong.Position = bdsDSPhiCong.Find("IDNHANVIEN", maNV);
                }
                else
                {
                    TruyVanNhanh($"UPDATE PHICONG SET ID_BANGLAI = '{txtIDBangLai.Text}', NGAYCAP = '{date}' WHERE IDNHANVIEN = {maNV}");

                    Reload();
                    bdsDSPhiCong.Position = currPosDSPhiCong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }

            UnEditingMode();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDSPhiCong.CancelEdit();

            if (addMode) bdsDSPhiCong.Position = currPosDSPhiCong;

            UnEditingMode();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi Reload! Vui lòng thử lại!", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnThemMB_Click(object sender, EventArgs e)
        {
            currPosDSPhiCong = bdsDSPhiCong.Position;

            FormChonLoaiMB frmChonLoai = new FormChonLoaiMB();
            string maBangLai = ((DataRowView)bdsDSPhiCong[bdsDSPhiCong.Position])["ID_BANGLAI"].ToString();

            if (maBangLai == "") return;

            String maLoai = "";
            if (frmChonLoai.ShowDialog() == DialogResult.OK)
            {
                maLoai = frmChonLoai.getIdLoai();
            }
            else
            {
                return;
            }

            SqlDataReader myReader = ExecSqlDataReader($"SELECT ID_BANGLAI FROM CT_BANGLAI WHERE ID_BANGLAI = '{maBangLai}' AND IDLOAI = '{maLoai}'");
            myReader.Read();
            if (myReader.HasRows)
            {
                MessageBox.Show("Đã có máy bay trong bằng lái!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                TruyVanNhanh($"INSERT INTO CT_BANGLAI VALUES('{maBangLai}', '{maLoai}')");
                MessageBox.Show("Thêm máy bay vào bằng lái thành công!", "", MessageBoxButtons.OK);

                Reload();

                bdsDSPhiCong.Position = currPosDSPhiCong;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }

            if (bdsCTBangLai.Count <= 0) btnXoaMB.Enabled = false;
            else btnXoaMB.Enabled = true;
        }

        private void btnXoaMB_Click(object sender, EventArgs e)
        {
            currPosDSPhiCong = bdsDSPhiCong.Position;
            if (MessageBox.Show("Bạn có muốn xóa máy bay trong bằng lái này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maBangLai = ((DataRowView)bdsCTBangLai[bdsCTBangLai.Position])["ID_BANGLAI"].ToString();
                string maLoai = ((DataRowView)bdsCTBangLai[bdsCTBangLai.Position])["IDLOAI"].ToString();

                try
                {
                    TruyVanNhanh($"DELETE FROM CT_BANGLAI WHERE ID_BANGLAI = '{maBangLai}' AND IDLOAI = '{maLoai}'");
                    bdsCTBangLai.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                }
            }

            Reload();
            bdsDSPhiCong.Position = currPosDSPhiCong;

            if (bdsCTBangLai.Count <= 0) btnXoaMB.Enabled = false;
            else btnXoaMB.Enabled = true;
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            FormChonNhanVien frmChonNV = new FormChonNhanVien();
            if (frmChonNV.ShowDialog() == DialogResult.OK)
            {
                txtIDNhanVien.Text = frmChonNV.IdNhanVien;
                txtTen.Text = frmChonNV.HoTen;
                txtCMND.Text = frmChonNV.CMND;
                txtDiaChi.Text = frmChonNV.DiaChi;
                txtSDT.Text = frmChonNV.SoDienThoai;
                CBNghi.Checked = frmChonNV.TrangThaiNghi;
            }

            frmChonNV.Dispose();
        }

        private void gcDSPhiCong_Click(object sender, EventArgs e)
        {
            if (bdsCTBangLai.Count <= 0) btnXoaMB.Enabled = false;
            else btnXoaMB.Enabled = true;
        }
    }
}