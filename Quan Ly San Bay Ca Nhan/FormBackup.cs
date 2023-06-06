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
    public partial class FormBackup : DevExpress.XtraEditors.XtraForm
    {
        private string default_folder_path = @"C:\QLSanBayDisk";
        public FormBackup()
        {
            InitializeComponent();
            txtFolderPath.Text = default_folder_path;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath;
            }
            else
            {
                txtFolderPath.Text = default_folder_path;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if(txtFolderPath.Text == "")
            {
                MessageBox.Show("Đường dẫn không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            string createFileName = "QL_SANBAY_CN " + DateTime.UtcNow.ToString("yyyy-MM-dd HH-mm-ss");
            string path = txtFolderPath.Text + @"\" + createFileName + ".bak";

            //Console.WriteLine(path);
            
            if (Program.ExecSqlNonQuery($"Exec sp_Backup '{path}'") == 0)
            {
                MessageBox.Show("Sao lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sao lưu thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}