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
    public partial class FormLocMayBaySoHuu : DevExpress.XtraEditors.XtraForm
    {
        private string IDMayBay;
        private readonly string IDCaNhan;
        public FormLocMayBaySoHuu(string IDCaNhan)
        {
            InitializeComponent();
            this.IDCaNhan = IDCaNhan;
        }

        private void FormLocMayBaySoHuu_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.sp_DanhSachChuMayBay' table. You can move, or remove it, as needed.
            this.sp_DanhSachChuMayBayTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachChuMayBayTableAdapter.Fill(this.DS.sp_DanhSachChuMayBay);
            this.gvDSCHUMAYBAY.OptionsBehavior.Editable = false;
        }

        public string getIDMayBay()
        {
            return IDMayBay;
        }


        private void gvDSCHUMAYBAY_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            if (((DataRowView)bdsDSCHUMAYBAY[e.ListSourceRow])["OWNER_ID"].ToString() == IDCaNhan)
            { 
                e.Visible = false; 
                e.Handled = true;
            }
        }

        private void gvDSCHUMAYBAY_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chọn máy bay này không ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                this.IDMayBay = ((DataRowView)bdsDSCHUMAYBAY[bdsDSCHUMAYBAY.Position])["IDMAYBAY"].ToString();
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
}