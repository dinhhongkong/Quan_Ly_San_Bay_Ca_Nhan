using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quan_Ly_May_Bay
{
    public partial class XrptBaoCaoMayBayBaoTri : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptBaoCaoMayBayBaoTri(string ngayBatDau, string ngayKetThuc )
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKetThuc;
            this.sqlDataSource1.Fill();
        }

    }
}
