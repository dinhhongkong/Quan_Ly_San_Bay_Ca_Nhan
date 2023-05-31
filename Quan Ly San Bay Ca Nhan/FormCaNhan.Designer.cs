﻿namespace Quan_Ly_May_Bay
{
    partial class FormCaNhan
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
            System.Windows.Forms.Label oWNER_IDLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaNhan));
            this.bdsCANHAN = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Quan_Ly_May_Bay.DS();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemNguoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemMayBay = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sp_DanhSachCaNhanTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachCaNhanTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcCANHAN = new DevExpress.XtraGrid.GridControl();
            this.gvCANHAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOWNER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCANHAN = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.bdsNGUOI = new System.Windows.Forms.BindingSource(this.components);
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtOWNER_ID = new DevExpress.XtraEditors.TextEdit();
            this.NGUOITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.NGUOITableAdapter();
            this.bdsCT_CHUMAYBAY = new System.Windows.Forms.BindingSource(this.components);
            this.CT_CHUMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_CHUMAYBAYTableAdapter();
            this.bdsDSCHUMAYBAY = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachChuMayBayTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachChuMayBayTableAdapter();
            this.gcDSMAYBAY = new DevExpress.XtraGrid.GridControl();
            this.gvDSMAYBAY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCT_CHUMAYBAY = new DevExpress.XtraGrid.GridControl();
            this.gvCT_CHUMAYBAY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            oWNER_IDLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCANHAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCANHAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCANHAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCANHAN)).BeginInit();
            this.panelCANHAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNGUOI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOWNER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_CHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSCHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_CHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCT_CHUMAYBAY)).BeginInit();
            this.SuspendLayout();
            // 
            // oWNER_IDLabel
            // 
            oWNER_IDLabel.AutoSize = true;
            oWNER_IDLabel.Location = new System.Drawing.Point(4, 44);
            oWNER_IDLabel.Name = "oWNER_IDLabel";
            oWNER_IDLabel.Size = new System.Drawing.Size(42, 13);
            oWNER_IDLabel.TabIndex = 0;
            oWNER_IDLabel.Text = "Mã CN:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(5, 70);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(58, 13);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Họ và tên:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(5, 96);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(40, 13);
            cMNDLabel.TabIndex = 4;
            cMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(5, 122);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(5, 148);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(31, 13);
            sDTLabel.TabIndex = 8;
            sDTLabel.Text = "SĐT:";
            // 
            // bdsCANHAN
            // 
            this.bdsCANHAN.DataMember = "sp_DanhSachCaNhan";
            this.bdsCANHAN.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1142, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemNguoi,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnSua,
            this.btnThemMayBay,
            this.btnThoat});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNguoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMayBay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Caption = "Thêm";
            this.btnThemNguoi.Id = 0;
            this.btnThemNguoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNguoi.ImageOptions.SvgImage")));
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            // btnThemMayBay
            // 
            this.btnThemMayBay.Caption = "Thêm máy bay sở hữu";
            this.btnThemMayBay.Id = 6;
            this.btnThemMayBay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemMayBay.ImageOptions.SvgImage")));
            this.btnThemMayBay.Name = "btnThemMayBay";
            this.btnThemMayBay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMayBay_ItemClick);
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
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1142, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1142, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1142, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 577);
            // 
            // sp_DanhSachCaNhanTableAdapter
            // 
            this.sp_DanhSachCaNhanTableAdapter.ClearBeforeFill = true;
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
            // gcCANHAN
            // 
            this.gcCANHAN.DataSource = this.bdsCANHAN;
            this.gcCANHAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCANHAN.Location = new System.Drawing.Point(0, 24);
            this.gcCANHAN.MainView = this.gvCANHAN;
            this.gcCANHAN.MenuManager = this.barManager1;
            this.gcCANHAN.Name = "gcCANHAN";
            this.gcCANHAN.Size = new System.Drawing.Size(1142, 220);
            this.gcCANHAN.TabIndex = 6;
            this.gcCANHAN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCANHAN});
            // 
            // gvCANHAN
            // 
            this.gvCANHAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOWNER_ID,
            this.colCMND,
            this.colTEN,
            this.colDIACHI,
            this.colSDT});
            this.gvCANHAN.GridControl = this.gcCANHAN;
            this.gvCANHAN.Name = "gvCANHAN";
            // 
            // colOWNER_ID
            // 
            this.colOWNER_ID.Caption = "Mã cá nhân";
            this.colOWNER_ID.FieldName = "OWNER_ID";
            this.colOWNER_ID.Name = "colOWNER_ID";
            this.colOWNER_ID.Visible = true;
            this.colOWNER_ID.VisibleIndex = 0;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Họ và tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelCANHAN
            // 
            this.panelCANHAN.Controls.Add(this.labelControl1);
            this.panelCANHAN.Controls.Add(sDTLabel);
            this.panelCANHAN.Controls.Add(this.txtSDT);
            this.panelCANHAN.Controls.Add(dIACHILabel);
            this.panelCANHAN.Controls.Add(this.txtDIACHI);
            this.panelCANHAN.Controls.Add(cMNDLabel);
            this.panelCANHAN.Controls.Add(this.txtCMND);
            this.panelCANHAN.Controls.Add(tENLabel);
            this.panelCANHAN.Controls.Add(this.txtTEN);
            this.panelCANHAN.Controls.Add(oWNER_IDLabel);
            this.panelCANHAN.Controls.Add(this.txtOWNER_ID);
            this.panelCANHAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCANHAN.Location = new System.Drawing.Point(0, 244);
            this.panelCANHAN.Name = "panelCANHAN";
            this.panelCANHAN.Size = new System.Drawing.Size(387, 357);
            this.panelCANHAN.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Thông tin cá nhân";
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNGUOI, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(73, 145);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 9;
            // 
            // bdsNGUOI
            // 
            this.bdsNGUOI.DataMember = "FK_sp_DanhSachCaNhan_NGUOI";
            this.bdsNGUOI.DataSource = this.bdsCANHAN;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNGUOI, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(73, 119);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(223, 20);
            this.txtDIACHI.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNGUOI, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(73, 93);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 20);
            this.txtCMND.TabIndex = 5;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNGUOI, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(73, 67);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(223, 20);
            this.txtTEN.TabIndex = 3;
            // 
            // txtOWNER_ID
            // 
            this.txtOWNER_ID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCANHAN, "OWNER_ID", true));
            this.txtOWNER_ID.Location = new System.Drawing.Point(73, 41);
            this.txtOWNER_ID.MenuManager = this.barManager1;
            this.txtOWNER_ID.Name = "txtOWNER_ID";
            this.txtOWNER_ID.Size = new System.Drawing.Size(100, 20);
            this.txtOWNER_ID.TabIndex = 1;
            // 
            // NGUOITableAdapter
            // 
            this.NGUOITableAdapter.ClearBeforeFill = true;
            // 
            // bdsCT_CHUMAYBAY
            // 
            this.bdsCT_CHUMAYBAY.DataMember = "FK_sp_DanhSachCaNhan_CT_CHUMAYBAY";
            this.bdsCT_CHUMAYBAY.DataSource = this.bdsCANHAN;
            // 
            // CT_CHUMAYBAYTableAdapter
            // 
            this.CT_CHUMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDSCHUMAYBAY
            // 
            this.bdsDSCHUMAYBAY.DataMember = "FK_sp_DanhSachCaNhan_sp_DanhSachChuMayBay";
            this.bdsDSCHUMAYBAY.DataSource = this.bdsCANHAN;
            // 
            // sp_DanhSachChuMayBayTableAdapter
            // 
            this.sp_DanhSachChuMayBayTableAdapter.ClearBeforeFill = true;
            // 
            // gcDSMAYBAY
            // 
            this.gcDSMAYBAY.DataSource = this.bdsDSCHUMAYBAY;
            this.gcDSMAYBAY.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDSMAYBAY.Location = new System.Drawing.Point(387, 244);
            this.gcDSMAYBAY.MainView = this.gvDSMAYBAY;
            this.gcDSMAYBAY.MenuManager = this.barManager1;
            this.gcDSMAYBAY.Name = "gcDSMAYBAY";
            this.gcDSMAYBAY.Size = new System.Drawing.Size(416, 357);
            this.gcDSMAYBAY.TabIndex = 28;
            this.gcDSMAYBAY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSMAYBAY});
            // 
            // gvDSMAYBAY
            // 
            this.gvDSMAYBAY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY,
            this.colTENLOAI,
            this.colNGAYBATDAU});
            this.gvDSMAYBAY.GridControl = this.gcDSMAYBAY;
            this.gvDSMAYBAY.Name = "gvDSMAYBAY";
            this.gvDSMAYBAY.OptionsView.ShowViewCaption = true;
            this.gvDSMAYBAY.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAYBATDAU, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvDSMAYBAY.ViewCaption = "Danh sách máy bay sở hữu";
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 0;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            // 
            // colNGAYBATDAU
            // 
            this.colNGAYBATDAU.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colNGAYBATDAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU.Name = "colNGAYBATDAU";
            this.colNGAYBATDAU.Visible = true;
            this.colNGAYBATDAU.VisibleIndex = 2;
            // 
            // gcCT_CHUMAYBAY
            // 
            this.gcCT_CHUMAYBAY.DataSource = this.bdsCT_CHUMAYBAY;
            this.gcCT_CHUMAYBAY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCT_CHUMAYBAY.Location = new System.Drawing.Point(803, 244);
            this.gcCT_CHUMAYBAY.MainView = this.gvCT_CHUMAYBAY;
            this.gcCT_CHUMAYBAY.MenuManager = this.barManager1;
            this.gcCT_CHUMAYBAY.Name = "gcCT_CHUMAYBAY";
            this.gcCT_CHUMAYBAY.Size = new System.Drawing.Size(339, 357);
            this.gcCT_CHUMAYBAY.TabIndex = 33;
            this.gcCT_CHUMAYBAY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCT_CHUMAYBAY});
            // 
            // gvCT_CHUMAYBAY
            // 
            this.gvCT_CHUMAYBAY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY1,
            this.colNGAYBATDAU1});
            this.gvCT_CHUMAYBAY.GridControl = this.gcCT_CHUMAYBAY;
            this.gvCT_CHUMAYBAY.Name = "gvCT_CHUMAYBAY";
            this.gvCT_CHUMAYBAY.OptionsView.ShowViewCaption = true;
            this.gvCT_CHUMAYBAY.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAYBATDAU1, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvCT_CHUMAYBAY.ViewCaption = "Lịch sử sở hữu máy bay";
            // 
            // colIDMAYBAY1
            // 
            this.colIDMAYBAY1.FieldName = "IDMAYBAY";
            this.colIDMAYBAY1.Name = "colIDMAYBAY1";
            this.colIDMAYBAY1.Visible = true;
            this.colIDMAYBAY1.VisibleIndex = 0;
            // 
            // colNGAYBATDAU1
            // 
            this.colNGAYBATDAU1.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colNGAYBATDAU1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU1.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU1.Name = "colNGAYBATDAU1";
            this.colNGAYBATDAU1.Visible = true;
            this.colNGAYBATDAU1.VisibleIndex = 1;
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
            // FormCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 621);
            this.Controls.Add(this.gcCT_CHUMAYBAY);
            this.Controls.Add(this.gcDSMAYBAY);
            this.Controls.Add(this.panelCANHAN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gcCANHAN);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormCaNhan";
            this.Text = "Quản lý chủ máy bay cá nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCANHAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCANHAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCANHAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCANHAN)).EndInit();
            this.panelCANHAN.ResumeLayout(false);
            this.panelCANHAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNGUOI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOWNER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_CHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSCHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_CHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCT_CHUMAYBAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemNguoi;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS DS;
        private DSTableAdapters.sp_DanhSachCaNhanTableAdapter sp_DanhSachCaNhanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcCANHAN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCANHAN;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PanelControl panelCANHAN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtOWNER_ID;
        private System.Windows.Forms.BindingSource bdsNGUOI;
        private DSTableAdapters.NGUOITableAdapter NGUOITableAdapter;
        private System.Windows.Forms.BindingSource bdsCANHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colOWNER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraBars.BarButtonItem btnThemMayBay;
        private System.Windows.Forms.BindingSource bdsCT_CHUMAYBAY;
        private DSTableAdapters.CT_CHUMAYBAYTableAdapter CT_CHUMAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsDSCHUMAYBAY;
        private DSTableAdapters.sp_DanhSachChuMayBayTableAdapter sp_DanhSachChuMayBayTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDSMAYBAY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSMAYBAY;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcCT_CHUMAYBAY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCT_CHUMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
    }
}