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
    public enum KieuChonNhanVien
    {
        NV_BAOTRI,
        PHICONG,
    }

    public partial class FormChonNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public string IdNhanVien { get; private set; }
        public string IdNguoi { get; private set; }
        public string HoTen { get; private set; }
        public string CMND { get; private set; }
        public string DiaChi { get; private set; }
        public string SoDienThoai { get; private set; }
        public decimal Luong { get; private set; }
        public decimal CaLamViec { get; private set; }
        public bool TrangThaiNghi { get; private set; }

        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            this.sp_DanhSachChonNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DanhSachChonNhanVienTableAdapter.Fill(this.ds.sp_DanhSachChonNhanVien);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int viTri = bdsNhanVien.Position;
            this.DialogResult = DialogResult.OK;
            IdNhanVien = ((DataRowView)bdsNhanVien[viTri])["IDNHANVIEN"].ToString();
            IdNguoi = ((DataRowView)bdsNhanVien[viTri])["IDNGUOI"].ToString();
            HoTen = ((DataRowView)bdsNhanVien[viTri])["TEN"].ToString();
            CMND = ((DataRowView)bdsNhanVien[viTri])["CMND"].ToString();
            DiaChi = ((DataRowView)bdsNhanVien[viTri])["DIACHI"].ToString();
            SoDienThoai = ((DataRowView)bdsNhanVien[viTri])["SDT"].ToString();
            Luong = Convert.ToDecimal(((DataRowView)bdsNhanVien[viTri])["LUONG"]);
            CaLamViec = Convert.ToDecimal(((DataRowView)bdsNhanVien[viTri])["CALAMVIEC"]);
            TrangThaiNghi =  Convert.ToBoolean((((DataRowView)bdsNhanVien[viTri])["TRANGTHAINGHI"]));
            this.Close();
        }
    }
}