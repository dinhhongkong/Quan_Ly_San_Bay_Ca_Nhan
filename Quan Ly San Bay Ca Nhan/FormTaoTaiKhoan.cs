using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using Quan_Ly_May_Bay.SubForm;
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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private bool validateTaoTaiKhoan()
        {
            if (txtIDNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtUID.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPwd.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (bdsDSTK.Find("MaNhanVien", txtIDNhanVien.Text) != -1)
            {
                MessageBox.Show("Nhân viên với mã " + txtIDNhanVien.Text + " đã có tài khoản!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (bdsDSTK.Find("TenDangNhap", txtUID.Text) != -1)
            {
                MessageBox.Show("Tên đăng nhập " + txtUID.Text + " đã có trong hệ thống!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if(bdsNhanvien.Find("IDNHANVIEN", Int32.Parse(txtIDNhanVien.Text)) == -1)
            {
                MessageBox.Show("Không có nhân viên nào với mã " + txtIDNhanVien.Text + " trong hệ thống!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool validateHieuChinh()
        {
            return true;
        }

        private void Reload()
        {
            this.v_DanhSachTaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DanhSachTaiKhoanTableAdapter.Fill(this.DS.V_DanhSachTaiKhoan);

            if (Program.mGroup == "NVBAOTRI")
            {
                CBCurrRole.Text = Program.mGroup;
                txtCurrUID.Text = ((DataRowView)bdsDSTK[bdsDSTK.Find("MaNhanVien", Program.userName)])["TenDangNhap"].ToString();
            }    
  
            CBRole.SelectedIndex = 0;
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'DS.NHANVIEN' table. You can move, or remove it, as needed.
            this.v_DanhSachTaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            
            Reload();
            
            if(Program.mGroup == "NVBAOTRI")
            {
                panelTaoTK.Enabled = false;
                panelTaoTK.Visible = false;

                btnXoa.Enabled = false;
                btnXoa.Visible = false;

                gcDSTK.Visible = false;

                panelHieuChinh.Enabled = true;
                CBCurrRole.Enabled = false;
                CBCurrRole.Visible = false;
                txtCurrUID.Enabled = false;
            }

            txtCurrIDNhanVien.Enabled = false;
            txtCurrUID.Enabled = false;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (!validateTaoTaiKhoan()) return;

            string sqlCmd = $"Exec sp_TaoTaiKhoan '{txtUID.Text}', '{txtPwd.Text}', '{CBRole.Text}', '{txtIDNhanVien.Text}'";

            int success = Program.ExecSqlNonQuery(sqlCmd);
            if (success == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                Reload();
            }
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            FormDSNhanVien frmChonNV = new FormDSNhanVien();
            if (frmChonNV.ShowDialog() == DialogResult.OK)
            {
                txtIDNhanVien.Text = frmChonNV.IdNhanVien;
            }

            frmChonNV.Dispose();

            if (bdsDSTK.Find("MaNhanVien", txtIDNhanVien.Text) != -1)
            {
                MessageBox.Show("Nhân viên với mã " + txtIDNhanVien.Text + " đã có tài khoản", "", MessageBoxButtons.OK);
                txtIDNhanVien.Text = "";
            }
        }

        private void txtIDNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtCurrUID.Text;
            string pwd = txtCurrPwd.Text;
            string curr_role = ((DataRowView)bdsDSTK[bdsDSTK.Position])["Quyen"].ToString();
            string new_role = CBCurrRole.Text;
            string manv = txtCurrIDNhanVien.Text;

            string sqlCmd = $"Exec sp_HieuChinhTaiKhoan '{tendangnhap}', '{pwd}', '{curr_role}', '{new_role}', '{manv}'";

            int success = Program.ExecSqlNonQuery(sqlCmd);
            if (success == 0)
            {
                MessageBox.Show("Hiệu chỉnh tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                Reload();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtCurrIDNhanVien.Text == Program.userName)
            {
                MessageBox.Show("Không thể xoá tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa tài khoản này không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string tendangnhap = txtCurrUID.Text;
                string manv = txtCurrIDNhanVien.Text;

                string sqlCmd = $"Exec sp_XoaTaiKhoan '{tendangnhap}', '{manv}'";

                int success = Program.ExecSqlNonQuery(sqlCmd);
                if (success == 0)
                {
                    MessageBox.Show("Xoá tài khoản thành công", "", MessageBoxButtons.OK);
                    Reload();
                }
            }      
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void gcDSTK_Click(object sender, EventArgs e)
        {
            string curr_role = ((DataRowView)bdsDSTK[bdsDSTK.Position])["Quyen"].ToString();
            CBCurrRole.Text = curr_role;
        }
    }
}