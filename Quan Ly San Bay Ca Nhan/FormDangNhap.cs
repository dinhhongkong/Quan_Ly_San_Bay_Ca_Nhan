using DevExpress.XtraEditors;
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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtTaiKhoan.Text.Trim();
            Program.password = txtMatKhau.Text.Trim();

            if (Program.KetNoi() == false)
                return;

            //sp_DangNhap Dung De Lay Thong Tin Nhan Vien
            String statement = "EXEC sp_DangNhap '" + Program.mlogin + "'";

            SqlDataReader myReader = Program.ExecSqlDataReader(statement);
            if (myReader == null)
                return;

            myReader.Read();


            Program.userName = myReader.GetString(0);
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy xem lại Username và Password", "", MessageBoxButtons.OK);
            }

            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);

            myReader.Close();
            Program.conn.Close();
            Program.frmMain.hienThiMenu();
            this.Dispose();

        }
    }
}