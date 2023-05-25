using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class FormChonMayBay : DevExpress.XtraEditors.XtraForm
    {
        private string IDMayBay;
        public FormChonMayBay()
        {
            InitializeComponent();
        }

        private void mAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMayBay.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormChonMayBay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.LOAIMAYBAY' table. You can move, or remove it, as needed.
            
            ds.EnforceConstraints = false;
            this.lOAIMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIMAYBAYTableAdapter.Fill(this.ds.LOAIMAYBAY);
            this.mAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAYBAYTableAdapter.Fill(this.ds.MAYBAY);
            repositoryItemLookUpEdit1.DataSource = bdsLoaiMB;
            repositoryItemLookUpEdit1.DisplayMember = "TENLOAI";
            repositoryItemLookUpEdit1.ValueMember = "IDLOAI";

        }

        public string getIDMayBay()
        {
            return IDMayBay;
        }

        private void gvMayBay_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.IDMayBay = ((DataRowView)bdsMayBay[bdsMayBay.Position])["IDMAYBAY"].ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}