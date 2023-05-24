﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace Quan_Ly_May_Bay
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void hienThiMenu()
        {
            tslblMaNV.Text = "Mã nhân viên: " + Program.userName;
            tslblHoTen.Text = "Họ và tên: " + Program.mHoten;
            tslblNhom.Text = "Nhóm quyền: " + Program.mGroup;

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            if (Program.mGroup == "MANAGER")
            {
                ribDanhMuc.Visible = true;
                ribNhanVien.Visible = true;
                btnTaoTk.Enabled = true;
            }
            else
            {
                ribBaoTri.Visible = true;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();

            tslblMaNV.Text = "Mã nhân viên: ";
            tslblHoTen.Text = "Họ và tên: ";
            tslblNhom.Text = "Nhóm: ";

            //Hiện Chức Năng
            btnDangNhap.Enabled = true;
            //Ẩn Đăng Nhập
            ribDanhMuc.Visible = false;
            ribNhanVien.Visible = false;
            ribBaoTri.Visible = false;
            btnDangXuat.Enabled = false;
            btnTaoTk.Enabled = false;
        }
    }
}