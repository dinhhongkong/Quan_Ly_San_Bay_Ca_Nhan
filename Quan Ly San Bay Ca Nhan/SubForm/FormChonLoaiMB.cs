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

namespace Quan_Ly_May_Bay.SubForm
{
    public partial class FormChonLoaiMB : DevExpress.XtraEditors.XtraForm
    {
        private string maLoaiMayBay;
        public FormChonLoaiMB()
        {
            InitializeComponent();
        }


        private void FormChonLoaiMB_Load(object sender, EventArgs e)
        {
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.dS.LOAIMAYBAY);
        }

        public string getIdLoai()
        {
            return maLoaiMayBay;
        }

        private void gvLoai_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.maLoaiMayBay = ((DataRowView)bdsLoaiMB[bdsLoaiMB.Position])["IDLOAI"].ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}