namespace Quan_Ly_May_Bay
{
    partial class FormPhiCong
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
            System.Windows.Forms.Label iDNHANVIENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label iD_BANGLAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhiCong));
            this.DS = new Quan_Ly_May_Bay.DS();
            this.bdsDSPhiCong = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachPhiCongTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachPhiCongTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcDSPhiCong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_BANGLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAINGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barMgr = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsCTBangLai = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CT_BangLaiTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_CT_BangLaiTableAdapter();
            this.gcCTBangLai = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelPhiCong = new DevExpress.XtraEditors.PanelControl();
            this.btnChonNV = new System.Windows.Forms.Button();
            this.CBNghi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayCap = new DevExpress.XtraEditors.DateEdit();
            this.txtIDBangLai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtIDNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCTBangLai = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaMB = new System.Windows.Forms.Button();
            this.btnThemMB = new System.Windows.Forms.Button();
            iDNHANVIENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            iD_BANGLAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhiCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSPhiCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBangLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTBangLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhiCong)).BeginInit();
            this.panelPhiCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBangLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTBangLai)).BeginInit();
            this.panelCTBangLai.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDNHANVIENLabel
            // 
            iDNHANVIENLabel.AutoSize = true;
            iDNHANVIENLabel.Location = new System.Drawing.Point(26, 35);
            iDNHANVIENLabel.Name = "iDNHANVIENLabel";
            iDNHANVIENLabel.Size = new System.Drawing.Size(75, 13);
            iDNHANVIENLabel.TabIndex = 1;
            iDNHANVIENLabel.Text = "Mã nhân viên:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(26, 76);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(40, 13);
            cMNDLabel.TabIndex = 3;
            cMNDLabel.Text = "CMND:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(28, 102);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 13);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "Họ tên:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(26, 129);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(73, 13);
            sDTLabel.TabIndex = 7;
            sDTLabel.Text = "Số điện thoại:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(26, 155);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 9;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // iD_BANGLAILabel
            // 
            iD_BANGLAILabel.AutoSize = true;
            iD_BANGLAILabel.Location = new System.Drawing.Point(26, 215);
            iD_BANGLAILabel.Name = "iD_BANGLAILabel";
            iD_BANGLAILabel.Size = new System.Drawing.Size(65, 13);
            iD_BANGLAILabel.TabIndex = 11;
            iD_BANGLAILabel.Text = "Mã bằng lái:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(26, 246);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(56, 13);
            nGAYCAPLabel.TabIndex = 13;
            nGAYCAPLabel.Text = "Ngày cấp:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPhiCong
            // 
            this.bdsDSPhiCong.DataMember = "sp_DanhSachPhiCong";
            this.bdsDSPhiCong.DataSource = this.DS;
            // 
            // sp_DanhSachPhiCongTableAdapter
            // 
            this.sp_DanhSachPhiCongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CANHANTableAdapter = null;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_BANGLAITableAdapter = null;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = null;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDSPhiCong
            // 
            this.gcDSPhiCong.DataSource = this.bdsDSPhiCong;
            this.gcDSPhiCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSPhiCong.Location = new System.Drawing.Point(0, 24);
            this.gcDSPhiCong.MainView = this.gridView1;
            this.gcDSPhiCong.Name = "gcDSPhiCong";
            this.gcDSPhiCong.Size = new System.Drawing.Size(1112, 304);
            this.gcDSPhiCong.TabIndex = 5;
            this.gcDSPhiCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDSPhiCong.Click += new System.EventHandler(this.gcDSPhiCong_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNHANVIEN,
            this.colCMND,
            this.colTEN,
            this.colSDT,
            this.colDIACHI,
            this.colID_BANGLAI,
            this.colNGAYCAP,
            this.colTRANGTHAINGHI});
            this.gridView1.GridControl = this.gcDSPhiCong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách phi công";
            // 
            // colIDNHANVIEN
            // 
            this.colIDNHANVIEN.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN.Name = "colIDNHANVIEN";
            this.colIDNHANVIEN.Visible = true;
            this.colIDNHANVIEN.VisibleIndex = 0;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colID_BANGLAI
            // 
            this.colID_BANGLAI.FieldName = "ID_BANGLAI";
            this.colID_BANGLAI.Name = "colID_BANGLAI";
            this.colID_BANGLAI.Visible = true;
            this.colID_BANGLAI.VisibleIndex = 5;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 6;
            // 
            // colTRANGTHAINGHI
            // 
            this.colTRANGTHAINGHI.FieldName = "TRANGTHAINGHI";
            this.colTRANGTHAINGHI.Name = "colTRANGTHAINGHI";
            this.colTRANGTHAINGHI.Visible = true;
            this.colTRANGTHAINGHI.VisibleIndex = 7;
            // 
            // barMgr
            // 
            this.barMgr.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barMgr.DockControls.Add(this.barDockControl1);
            this.barMgr.DockControls.Add(this.barDockControlBottom);
            this.barMgr.DockControls.Add(this.barDockControlLeft);
            this.barMgr.DockControls.Add(this.barDockControlRight);
            this.barMgr.Form = this;
            this.barMgr.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnSua,
            this.btnThoat});
            this.barMgr.MaxItemId = 13;
            this.barMgr.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNguoi_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 5;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Hủy";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barMgr;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1112, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 647);
            this.barDockControlBottom.Manager = this.barMgr;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1112, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barMgr;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 623);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1112, 24);
            this.barDockControlRight.Manager = this.barMgr;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 623);
            // 
            // bdsCTBangLai
            // 
            this.bdsCTBangLai.DataMember = "FK_sp_DanhSachPhiCong_sp_CT_BangLai";
            this.bdsCTBangLai.DataSource = this.bdsDSPhiCong;
            // 
            // sp_CT_BangLaiTableAdapter
            // 
            this.sp_CT_BangLaiTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTBangLai
            // 
            this.gcCTBangLai.DataSource = this.bdsCTBangLai;
            this.gcCTBangLai.Location = new System.Drawing.Point(29, 35);
            this.gcCTBangLai.MainView = this.gridView2;
            this.gcCTBangLai.MenuManager = this.barMgr;
            this.gcCTBangLai.Name = "gcCTBangLai";
            this.gcCTBangLai.Size = new System.Drawing.Size(300, 242);
            this.gcCTBangLai.TabIndex = 9;
            this.gcCTBangLai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLOAI,
            this.colTENLOAI});
            this.gridView2.GridControl = this.gcCTBangLai;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Danh sách máy bay trong bằng lái";
            // 
            // colIDLOAI
            // 
            this.colIDLOAI.FieldName = "IDLOAI";
            this.colIDLOAI.Name = "colIDLOAI";
            this.colIDLOAI.Visible = true;
            this.colIDLOAI.VisibleIndex = 0;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            // 
            // panelPhiCong
            // 
            this.panelPhiCong.Controls.Add(this.btnChonNV);
            this.panelPhiCong.Controls.Add(this.CBNghi);
            this.panelPhiCong.Controls.Add(this.label2);
            this.panelPhiCong.Controls.Add(nGAYCAPLabel);
            this.panelPhiCong.Controls.Add(this.dateNgayCap);
            this.panelPhiCong.Controls.Add(iD_BANGLAILabel);
            this.panelPhiCong.Controls.Add(this.txtIDBangLai);
            this.panelPhiCong.Controls.Add(dIACHILabel);
            this.panelPhiCong.Controls.Add(this.txtDiaChi);
            this.panelPhiCong.Controls.Add(sDTLabel);
            this.panelPhiCong.Controls.Add(this.txtSDT);
            this.panelPhiCong.Controls.Add(tENLabel);
            this.panelPhiCong.Controls.Add(this.txtTen);
            this.panelPhiCong.Controls.Add(cMNDLabel);
            this.panelPhiCong.Controls.Add(this.txtCMND);
            this.panelPhiCong.Controls.Add(iDNHANVIENLabel);
            this.panelPhiCong.Controls.Add(this.txtIDNhanVien);
            this.panelPhiCong.Controls.Add(this.label1);
            this.panelPhiCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPhiCong.Location = new System.Drawing.Point(0, 328);
            this.panelPhiCong.Name = "panelPhiCong";
            this.panelPhiCong.Size = new System.Drawing.Size(476, 319);
            this.panelPhiCong.TabIndex = 10;
            // 
            // btnChonNV
            // 
            this.btnChonNV.Location = new System.Drawing.Point(220, 20);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(101, 42);
            this.btnChonNV.TabIndex = 18;
            this.btnChonNV.Text = "Chọn nhân viên";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // CBNghi
            // 
            this.CBNghi.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsDSPhiCong, "TRANGTHAINGHI", true));
            this.CBNghi.Location = new System.Drawing.Point(337, 30);
            this.CBNghi.Name = "CBNghi";
            this.CBNghi.Size = new System.Drawing.Size(104, 24);
            this.CBNghi.TabIndex = 17;
            this.CBNghi.Text = "Đã nghỉ";
            this.CBNghi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bằng lái";
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "NGAYCAP", true));
            this.dateNgayCap.EditValue = null;
            this.dateNgayCap.Location = new System.Drawing.Point(105, 243);
            this.dateNgayCap.MenuManager = this.barMgr;
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayCap.Size = new System.Drawing.Size(100, 20);
            this.dateNgayCap.TabIndex = 14;
            // 
            // txtIDBangLai
            // 
            this.txtIDBangLai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "ID_BANGLAI", true));
            this.txtIDBangLai.Location = new System.Drawing.Point(107, 212);
            this.txtIDBangLai.MenuManager = this.barMgr;
            this.txtIDBangLai.Name = "txtIDBangLai";
            this.txtIDBangLai.Size = new System.Drawing.Size(143, 20);
            this.txtIDBangLai.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(105, 152);
            this.txtDiaChi.MenuManager = this.barMgr;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(278, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(105, 126);
            this.txtSDT.MenuManager = this.barMgr;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(145, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(105, 99);
            this.txtTen.MenuManager = this.barMgr;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(145, 20);
            this.txtTen.TabIndex = 6;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(105, 73);
            this.txtCMND.MenuManager = this.barMgr;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(145, 20);
            this.txtCMND.TabIndex = 4;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSPhiCong, "IDNHANVIEN", true));
            this.txtIDNhanVien.Location = new System.Drawing.Point(105, 32);
            this.txtIDNhanVien.MenuManager = this.barMgr;
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Properties.ReadOnly = true;
            this.txtIDNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtIDNhanVien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phi công";
            // 
            // panelCTBangLai
            // 
            this.panelCTBangLai.Controls.Add(this.label3);
            this.panelCTBangLai.Controls.Add(this.btnXoaMB);
            this.panelCTBangLai.Controls.Add(this.btnThemMB);
            this.panelCTBangLai.Controls.Add(this.gcCTBangLai);
            this.panelCTBangLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCTBangLai.Location = new System.Drawing.Point(476, 328);
            this.panelCTBangLai.Name = "panelCTBangLai";
            this.panelCTBangLai.Size = new System.Drawing.Size(636, 319);
            this.panelCTBangLai.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chi tiết bằng lái";
            // 
            // btnXoaMB
            // 
            this.btnXoaMB.Location = new System.Drawing.Point(363, 163);
            this.btnXoaMB.Name = "btnXoaMB";
            this.btnXoaMB.Size = new System.Drawing.Size(87, 41);
            this.btnXoaMB.TabIndex = 11;
            this.btnXoaMB.Text = "Xoá";
            this.btnXoaMB.UseVisualStyleBackColor = true;
            this.btnXoaMB.Click += new System.EventHandler(this.btnXoaMB_Click);
            // 
            // btnThemMB
            // 
            this.btnThemMB.Location = new System.Drawing.Point(363, 90);
            this.btnThemMB.Name = "btnThemMB";
            this.btnThemMB.Size = new System.Drawing.Size(87, 41);
            this.btnThemMB.TabIndex = 10;
            this.btnThemMB.Text = "Thêm";
            this.btnThemMB.UseVisualStyleBackColor = true;
            this.btnThemMB.Click += new System.EventHandler(this.btnThemMB_Click);
            // 
            // FormPhiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 667);
            this.Controls.Add(this.panelCTBangLai);
            this.Controls.Add(this.panelPhiCong);
            this.Controls.Add(this.gcDSPhiCong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormPhiCong";
            this.Text = "Quản lý phi công";
            this.Load += new System.EventHandler(this.FormPhiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhiCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSPhiCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBangLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTBangLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhiCong)).EndInit();
            this.panelPhiCong.ResumeLayout(false);
            this.panelPhiCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBangLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTBangLai)).EndInit();
            this.panelCTBangLai.ResumeLayout(false);
            this.panelCTBangLai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsDSPhiCong;
        private DS DS;
        private DSTableAdapters.sp_DanhSachPhiCongTableAdapter sp_DanhSachPhiCongTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSPhiCong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colID_BANGLAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAINGHI;
        private DevExpress.XtraBars.BarManager barMgr;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsCTBangLai;
        private DSTableAdapters.sp_CT_BangLaiTableAdapter sp_CT_BangLaiTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTBangLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelPhiCong;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraEditors.DateEdit dateNgayCap;
        private DevExpress.XtraEditors.TextEdit txtIDBangLai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtIDNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonNV;
        private System.Windows.Forms.CheckBox CBNghi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelCTBangLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaMB;
        private System.Windows.Forms.Button btnThemMB;
    }
}