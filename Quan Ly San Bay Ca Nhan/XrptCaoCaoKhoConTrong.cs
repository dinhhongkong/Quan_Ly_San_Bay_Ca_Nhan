using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quan_Ly_May_Bay
{
    public partial class XrptCaoCaoKhoConTrong : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptCaoCaoKhoConTrong()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
