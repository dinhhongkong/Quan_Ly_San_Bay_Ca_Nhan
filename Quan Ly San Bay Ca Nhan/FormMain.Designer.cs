namespace Quan_Ly_May_Bay
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTk = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnMayBay = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiMB = new DevExpress.XtraBars.BarButtonItem();
            this.btnCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNvBaoTri = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoTri = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhNghiep = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoMB = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBaoTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribSaoLuu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTk,
            this.btnDangXuat,
            this.btnMayBay,
            this.btnLoaiMB,
            this.btnCaNhan,
            this.btnKho,
            this.btnNhanVien,
            this.btnNvBaoTri,
            this.btnPhiCong,
            this.btnBaoTri,
            this.btnDoanhNghiep,
            this.btnBaoCaoMB,
            this.btnBaoCaoKho,
            this.btnSaoLuu,
            this.btnPhucHoi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribTaiKhoan,
            this.ribDanhMuc,
            this.ribNhanVien,
            this.ribBaoTri,
            this.ribSaoLuu});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 193);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTk
            // 
            this.btnTaoTk.Caption = "Quản lý tài khoản";
            this.btnTaoTk.Enabled = false;
            this.btnTaoTk.Id = 2;
            this.btnTaoTk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTk.ImageOptions.Image")));
            this.btnTaoTk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTk.ImageOptions.LargeImage")));
            this.btnTaoTk.Name = "btnTaoTk";
            this.btnTaoTk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnTaoTk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTk_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnMayBay
            // 
            this.btnMayBay.Caption = "Máy bay";
            this.btnMayBay.Id = 4;
            this.btnMayBay.ImageOptions.Image = global::Quan_Ly_May_Bay.Properties.Resources.airplane_192px;
            this.btnMayBay.Name = "btnMayBay";
            this.btnMayBay.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMayBay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMayBay_ItemClick);
            // 
            // btnLoaiMB
            // 
            this.btnLoaiMB.Caption = "Loại máy bay";
            this.btnLoaiMB.Id = 5;
            this.btnLoaiMB.ImageOptions.Image = global::Quan_Ly_May_Bay.Properties.Resources.jet_engine_480px;
            this.btnLoaiMB.Name = "btnLoaiMB";
            this.btnLoaiMB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiMB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiMB_ItemClick);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.Caption = "Cá nhân chủ máy bay";
            this.btnCaNhan.Id = 6;
            this.btnCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCaNhan.ImageOptions.Image")));
            this.btnCaNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaNhan.ImageOptions.LargeImage")));
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCaNhan_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 7;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 8;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnNvBaoTri
            // 
            this.btnNvBaoTri.Caption = "Nhân viên bảo trì";
            this.btnNvBaoTri.Id = 9;
            this.btnNvBaoTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNvBaoTri.ImageOptions.Image")));
            this.btnNvBaoTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNvBaoTri.ImageOptions.LargeImage")));
            this.btnNvBaoTri.Name = "btnNvBaoTri";
            this.btnNvBaoTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNvBaoTri_ItemClick);
            // 
            // btnPhiCong
            // 
            this.btnPhiCong.Caption = "Phi công";
            this.btnPhiCong.Id = 10;
            this.btnPhiCong.ImageOptions.Image = global::Quan_Ly_May_Bay.Properties.Resources.man_pilot_192px_1;
            this.btnPhiCong.Name = "btnPhiCong";
            this.btnPhiCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhiCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhiCong_ItemClick);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.Caption = "Phiếu bảo trì";
            this.btnBaoTri.Id = 11;
            this.btnBaoTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoTri.ImageOptions.Image")));
            this.btnBaoTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoTri.ImageOptions.LargeImage")));
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoTri_ItemClick);
            // 
            // btnDoanhNghiep
            // 
            this.btnDoanhNghiep.Caption = "Doanh nghiệp chủ máy bay";
            this.btnDoanhNghiep.Id = 12;
            this.btnDoanhNghiep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhNghiep.ImageOptions.Image")));
            this.btnDoanhNghiep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoanhNghiep.ImageOptions.LargeImage")));
            this.btnDoanhNghiep.Name = "btnDoanhNghiep";
            this.btnDoanhNghiep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanhNghiep_ItemClick);
            // 
            // btnBaoCaoMB
            // 
            this.btnBaoCaoMB.Caption = "Máy bay bảo trì trong khoảng thời gian";
            this.btnBaoCaoMB.Id = 13;
            this.btnBaoCaoMB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoMB.ImageOptions.Image")));
            this.btnBaoCaoMB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoMB.ImageOptions.LargeImage")));
            this.btnBaoCaoMB.Name = "btnBaoCaoMB";
            // 
            // btnBaoCaoKho
            // 
            this.btnBaoCaoKho.Caption = "Các kho còn chỗ trống cho máy bay";
            this.btnBaoCaoKho.Id = 14;
            this.btnBaoCaoKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoKho.ImageOptions.Image")));
            this.btnBaoCaoKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoKho.ImageOptions.LargeImage")));
            this.btnBaoCaoKho.Name = "btnBaoCaoKho";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 15;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 16;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "Tài khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTk);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý tài khoản";
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "Danh mục";
            this.ribDanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMayBay);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoaiMB);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCaNhan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDoanhNghiep);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribNhanVien
            // 
            this.ribNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribNhanVien.Name = "ribNhanVien";
            this.ribNhanVien.Text = "Nhân viên";
            this.ribNhanVien.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNvBaoTri);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPhiCong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribBaoTri
            // 
            this.ribBaoTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribBaoTri.Name = "ribBaoTri";
            this.ribBaoTri.Text = "Nghiệp vụ";
            this.ribBaoTri.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBaoTri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Lập phiếu bảo trì";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup5.ImageOptions.Image")));
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBaoCaoMB);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBaoCaoKho);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Lập báo cáo";
            // 
            // ribSaoLuu
            // 
            this.ribSaoLuu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribSaoLuu.Name = "ribSaoLuu";
            this.ribSaoLuu.Text = "Sao lưu và phục hồi";
            this.ribSaoLuu.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnSaoLuu);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPhucHoi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Sao lưu và phục hồi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblMaNV,
            this.tslblHoTen,
            this.tslblNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblMaNV
            // 
            this.tslblMaNV.Name = "tslblMaNV";
            this.tslblMaNV.Size = new System.Drawing.Size(100, 20);
            this.tslblMaNV.Text = "Mã nhân viên:";
            // 
            // tslblHoTen
            // 
            this.tslblHoTen.Name = "tslblHoTen";
            this.tslblHoTen.Size = new System.Drawing.Size(76, 20);
            this.tslblHoTen.Text = "Họ và tên:";
            // 
            // tslblNhom
            // 
            this.tslblNhom.Name = "tslblNhom";
            this.tslblNhom.Size = new System.Drawing.Size(97, 20);
            this.tslblNhom.Text = "Nhóm quyền:";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý sân bay cá nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnTaoTk;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnMayBay;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiMB;
        private DevExpress.XtraBars.BarButtonItem btnCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhiCong;
        private DevExpress.XtraBars.BarButtonItem btnNvBaoTri;
        private DevExpress.XtraBars.BarButtonItem btnBaoTri;
        private DevExpress.XtraBars.BarButtonItem btnDoanhNghiep;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBaoTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblMaNV;
        private System.Windows.Forms.ToolStripStatusLabel tslblHoTen;
        private System.Windows.Forms.ToolStripStatusLabel tslblNhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoMB;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoKho;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribSaoLuu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

