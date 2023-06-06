using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_May_Bay
{
    public partial class FormRestore : DevExpress.XtraEditors.XtraForm
    {
        private string default_folder_path = @"C:\QLSanBayDisk";
        public FormRestore()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = default_folder_path;
            openFileDialog.Filter = "Backup File (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "")
            {
                MessageBox.Show("Đường dẫn không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            string path = @txtFilePath.Text;
            Console.WriteLine(path);
            
            int ketQua = Program.ExecSqlNonQuery("USE [master]\n" +
                "ALTER DATABASE [QL_SANBAY_CN] SET OFFLINE WITH ROLLBACK IMMEDIATE\n" +
                $"RESTORE DATABASE [QL_SANBAY_CN] FROM DISK = '{path}' WITH REPLACE\n" +
                "ALTER DATABASE [QL_SANBAY_CN] SET ONLINE");

            if (ketQua == 0)
            {
                MessageBox.Show("Phục hồi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Phục hồi thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}