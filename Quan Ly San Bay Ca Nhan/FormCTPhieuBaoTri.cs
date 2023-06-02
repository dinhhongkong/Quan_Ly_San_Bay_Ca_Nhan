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
    public partial class FormCTPhieuBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public string IdMayBay { private set; get; }
        public string IdNhanVien { set; get; }
        public string MaPhieu { private set; get; }
        public string MoTa {  set; get; }
        public TrangThai trangThai { set; get; }

        public FormCTPhieuBaoTri(string idMayBay, string maPhieu, TrangThai trangThai)
        {
            InitializeComponent();
            this.IdMayBay = idMayBay;
            this.MaPhieu = maPhieu;
            this.trangThai = trangThai;
        }


        private void FormCTPhieuBaoTri_Load(object sender, EventArgs e)
        {
            this.sp_DanhSachNVBaoTriMBLoaiTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            {
                this.sp_DanhSachNVBaoTriMBLoaiTableAdapter.Fill(this.dS.sp_DanhSachNVBaoTriMBLoai, IdMayBay);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.txtMaPhieu.Text = MaPhieu;
            
            if ( trangThai == TrangThai.HIEUCHINH)
            {
                txtIDNhanVien.Text = IdNhanVien;
                txtMoTa.Text = MoTa;
                gcNhanVien.Enabled = false;

            }
        }

        private void gvNhanVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtIDNhanVien.Text = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["IDNHANVIEN"].ToString();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtIDNhanVien.Text) )
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để bảo trì", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả không được để trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            IdNhanVien = txtIDNhanVien.Text;
            MoTa = txtMoTa.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}