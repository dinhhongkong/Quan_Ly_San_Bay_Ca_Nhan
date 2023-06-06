using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FormBaoCaoBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public FormBaoCaoBaoTri()
        {
            InitializeComponent();
        }

        private void FormBaoCaoBaoTri_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = Program.userName;
            txtTenNhanVien.Text = Program.mHoten;
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBatDau.Text))
            {
                MessageBox.Show("Thời gian bắt đầu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtKetThuc.Text))
            {
                MessageBox.Show("Thời gian kết thúc không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (DateTime.Compare(txtBatDau.DateTime, DateTime.Today) > 0)
            {
                MessageBox.Show("Thời gian bắt đầu không được lớn ngày hôm nay", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (DateTime.Compare(txtKetThuc.DateTime, DateTime.Today) > 0)
            {
                MessageBox.Show("Thời gian kết thúc không được lớn ngày hôm nay", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (DateTime.Compare(txtBatDau.DateTime, txtKetThuc.DateTime) > 0)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XrptBaoCaoMayBayBaoTri rpt = new XrptBaoCaoMayBayBaoTri(txtBatDau.DateTime.ToString(), txtKetThuc.DateTime.ToString());

            rpt.lblMaNV.Text = Program.userName;
            rpt.lblTenNV.Text = Program.mHoten;
            rpt.lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss tt");
            rpt.lblNgayBatDau.Text = txtBatDau.DateTime.ToString("dd/MM/yyyy");
            rpt.lblNgayKetThuc.Text = txtKetThuc.DateTime.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

            //MessageBox.Show(txtBatDau.DateTime.ToString() + "  " + txtKetThuc.DateTime.ToString(), "Thông báo", MessageBoxButtons.OK);
        }
    }
}