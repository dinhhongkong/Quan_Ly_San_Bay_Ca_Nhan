namespace Quan_Ly_May_Bay
{
    partial class FormDoanhNghiep
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
            System.Windows.Forms.Label tENDNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tENNGUOIDAIDIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhNghiep));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemDoanhNghiep = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemMayBay = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnHienTaiSoHuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLichSuSoHuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new Quan_Ly_May_Bay.DS();
            this.bdsDOANHNGHIEP = new System.Windows.Forms.BindingSource(this.components);
            this.DOANHNGHIEPTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.DOANHNGHIEPTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcDOANHNGHIEP = new DevExpress.XtraGrid.GridControl();
            this.gvDOANHNGHIEP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOWNER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNGUOIDAIDIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDOANHNGHIEP = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDAIDIEN = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtOWNER_ID = new DevExpress.XtraEditors.TextEdit();
            this.bdsDSMAYBAY = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachChuMayBayTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachChuMayBayTableAdapter();
            this.gcDSMAYBAY = new DevExpress.XtraGrid.GridControl();
            this.gvDSMAYBAY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCT_CHUMAYBAY = new System.Windows.Forms.BindingSource(this.components);
            this.CT_CHUMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_CHUMAYBAYTableAdapter();
            this.gcCT_CHUMAYBAY = new DevExpress.XtraGrid.GridControl();
            this.gvCT_CHUMAYBAY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsChucNang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            oWNER_IDLabel = new System.Windows.Forms.Label();
            tENDNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tENNGUOIDAIDIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDOANHNGHIEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDOANHNGHIEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDOANHNGHIEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDOANHNGHIEP)).BeginInit();
            this.panelDOANHNGHIEP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDAIDIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOWNER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_CHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_CHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCT_CHUMAYBAY)).BeginInit();
            this.cmsChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // oWNER_IDLabel
            // 
            oWNER_IDLabel.AutoSize = true;
            oWNER_IDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oWNER_IDLabel.Location = new System.Drawing.Point(139, 87);
            oWNER_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oWNER_IDLabel.Name = "oWNER_IDLabel";
            oWNER_IDLabel.Size = new System.Drawing.Size(76, 24);
            oWNER_IDLabel.TabIndex = 0;
            oWNER_IDLabel.Text = "Mã DN:";
            // 
            // tENDNLabel
            // 
            tENDNLabel.AutoSize = true;
            tENDNLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENDNLabel.Location = new System.Drawing.Point(139, 134);
            tENDNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENDNLabel.Name = "tENDNLabel";
            tENDNLabel.Size = new System.Drawing.Size(84, 24);
            tENDNLabel.TabIndex = 2;
            tENDNLabel.Text = "Tên DN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(139, 183);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(78, 24);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(139, 234);
            sDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(54, 24);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SĐT:";
            // 
            // tENNGUOIDAIDIENLabel
            // 
            tENNGUOIDAIDIENLabel.AutoSize = true;
            tENNGUOIDAIDIENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENNGUOIDAIDIENLabel.Location = new System.Drawing.Point(139, 281);
            tENNGUOIDAIDIENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENNGUOIDAIDIENLabel.Name = "tENNGUOIDAIDIENLabel";
            tENNGUOIDAIDIENLabel.Size = new System.Drawing.Size(146, 24);
            tENNGUOIDAIDIENLabel.TabIndex = 8;
            tENNGUOIDAIDIENLabel.Text = "Người đại diện:";
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
            this.btnThemDoanhNghiep,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnSua,
            this.btnThemMayBay,
            this.btnThoat,
            this.barSubItem1,
            this.btnHienTaiSoHuu,
            this.btnLichSuSoHuu});
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemDoanhNghiep, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMayBay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemDoanhNghiep
            // 
            this.btnThemDoanhNghiep.Caption = "Thêm";
            this.btnThemDoanhNghiep.Id = 0;
            this.btnThemDoanhNghiep.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemDoanhNghiep.ImageOptions.SvgImage")));
            this.btnThemDoanhNghiep.Name = "btnThemDoanhNghiep";
            this.btnThemDoanhNghiep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDoanhNghiep_ItemClick);
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
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Chế độ xem sở hữu máy bay";
            this.barSubItem1.Id = 8;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHienTaiSoHuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLichSuSoHuu)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHienTaiSoHuu
            // 
            this.btnHienTaiSoHuu.Caption = "Máy bay hiện tại đang sở hữu";
            this.btnHienTaiSoHuu.Id = 9;
            this.btnHienTaiSoHuu.Name = "btnHienTaiSoHuu";
            this.btnHienTaiSoHuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHienTaiSoHuu_ItemClick);
            // 
            // btnLichSuSoHuu
            // 
            this.btnLichSuSoHuu.Caption = "Lịch sử đã sở hữu máy bay";
            this.btnLichSuSoHuu.Id = 10;
            this.btnLichSuSoHuu.Name = "btnLichSuSoHuu";
            this.btnLichSuSoHuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLichSuSoHuu_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
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
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1906, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 641);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1906, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 611);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1906, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 611);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDOANHNGHIEP
            // 
            this.bdsDOANHNGHIEP.DataMember = "DOANHNGHIEP";
            this.bdsDOANHNGHIEP.DataSource = this.DS;
            // 
            // DOANHNGHIEPTableAdapter
            // 
            this.DOANHNGHIEPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CANHANTableAdapter = null;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_BANGLAITableAdapter = null;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = null;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = this.DOANHNGHIEPTableAdapter;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDOANHNGHIEP
            // 
            this.gcDOANHNGHIEP.DataSource = this.bdsDOANHNGHIEP;
            this.gcDOANHNGHIEP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDOANHNGHIEP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDOANHNGHIEP.Location = new System.Drawing.Point(0, 30);
            this.gcDOANHNGHIEP.MainView = this.gvDOANHNGHIEP;
            this.gcDOANHNGHIEP.Margin = new System.Windows.Forms.Padding(4);
            this.gcDOANHNGHIEP.MenuManager = this.barManager1;
            this.gcDOANHNGHIEP.Name = "gcDOANHNGHIEP";
            this.gcDOANHNGHIEP.Size = new System.Drawing.Size(1906, 271);
            this.gcDOANHNGHIEP.TabIndex = 5;
            this.gcDOANHNGHIEP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDOANHNGHIEP});
            // 
            // gvDOANHNGHIEP
            // 
            this.gvDOANHNGHIEP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOWNER_ID,
            this.colTENDN,
            this.colSDT,
            this.colDIACHI,
            this.colTENNGUOIDAIDIEN});
            this.gvDOANHNGHIEP.DetailHeight = 431;
            this.gvDOANHNGHIEP.GridControl = this.gcDOANHNGHIEP;
            this.gvDOANHNGHIEP.Name = "gvDOANHNGHIEP";
            // 
            // colOWNER_ID
            // 
            this.colOWNER_ID.Caption = "Mã doanh nghiệp";
            this.colOWNER_ID.FieldName = "OWNER_ID";
            this.colOWNER_ID.MinWidth = 23;
            this.colOWNER_ID.Name = "colOWNER_ID";
            this.colOWNER_ID.Visible = true;
            this.colOWNER_ID.VisibleIndex = 0;
            this.colOWNER_ID.Width = 87;
            // 
            // colTENDN
            // 
            this.colTENDN.Caption = "Tên doanh nghiệp";
            this.colTENDN.FieldName = "TENDN";
            this.colTENDN.MinWidth = 23;
            this.colTENDN.Name = "colTENDN";
            this.colTENDN.Visible = true;
            this.colTENDN.VisibleIndex = 1;
            this.colTENDN.Width = 87;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 23;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 87;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 23;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 87;
            // 
            // colTENNGUOIDAIDIEN
            // 
            this.colTENNGUOIDAIDIEN.Caption = "Họ và tên người đại diện";
            this.colTENNGUOIDAIDIEN.FieldName = "TENNGUOIDAIDIEN";
            this.colTENNGUOIDAIDIEN.MinWidth = 23;
            this.colTENNGUOIDAIDIEN.Name = "colTENNGUOIDAIDIEN";
            this.colTENNGUOIDAIDIEN.Visible = true;
            this.colTENNGUOIDAIDIEN.VisibleIndex = 4;
            this.colTENNGUOIDAIDIEN.Width = 87;
            // 
            // panelDOANHNGHIEP
            // 
            this.panelDOANHNGHIEP.Controls.Add(this.labelControl1);
            this.panelDOANHNGHIEP.Controls.Add(tENNGUOIDAIDIENLabel);
            this.panelDOANHNGHIEP.Controls.Add(this.txtDAIDIEN);
            this.panelDOANHNGHIEP.Controls.Add(sDTLabel);
            this.panelDOANHNGHIEP.Controls.Add(this.txtSDT);
            this.panelDOANHNGHIEP.Controls.Add(dIACHILabel);
            this.panelDOANHNGHIEP.Controls.Add(this.txtDIACHI);
            this.panelDOANHNGHIEP.Controls.Add(tENDNLabel);
            this.panelDOANHNGHIEP.Controls.Add(this.txtTEN);
            this.panelDOANHNGHIEP.Controls.Add(oWNER_IDLabel);
            this.panelDOANHNGHIEP.Controls.Add(this.txtOWNER_ID);
            this.panelDOANHNGHIEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDOANHNGHIEP.Location = new System.Drawing.Point(0, 301);
            this.panelDOANHNGHIEP.Margin = new System.Windows.Forms.Padding(4);
            this.panelDOANHNGHIEP.Name = "panelDOANHNGHIEP";
            this.panelDOANHNGHIEP.Size = new System.Drawing.Size(346, 340);
            this.panelDOANHNGHIEP.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(230, 25);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Thông tin Doanh Nghiệp";
            // 
            // txtDAIDIEN
            // 
            this.txtDAIDIEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDOANHNGHIEP, "TENNGUOIDAIDIEN", true));
            this.txtDAIDIEN.Location = new System.Drawing.Point(292, 278);
            this.txtDAIDIEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtDAIDIEN.MenuManager = this.barManager1;
            this.txtDAIDIEN.Name = "txtDAIDIEN";
            this.txtDAIDIEN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAIDIEN.Properties.Appearance.Options.UseFont = true;
            this.txtDAIDIEN.Size = new System.Drawing.Size(423, 30);
            this.txtDAIDIEN.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDOANHNGHIEP, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(292, 231);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(423, 30);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDOANHNGHIEP, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(292, 180);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Properties.Appearance.Options.UseFont = true;
            this.txtDIACHI.Size = new System.Drawing.Size(423, 30);
            this.txtDIACHI.TabIndex = 5;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDOANHNGHIEP, "TENDN", true));
            this.txtTEN.Location = new System.Drawing.Point(292, 131);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEN.Properties.Appearance.Options.UseFont = true;
            this.txtTEN.Size = new System.Drawing.Size(423, 30);
            this.txtTEN.TabIndex = 3;
            // 
            // txtOWNER_ID
            // 
            this.txtOWNER_ID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDOANHNGHIEP, "OWNER_ID", true));
            this.txtOWNER_ID.Location = new System.Drawing.Point(292, 84);
            this.txtOWNER_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOWNER_ID.MenuManager = this.barManager1;
            this.txtOWNER_ID.Name = "txtOWNER_ID";
            this.txtOWNER_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOWNER_ID.Properties.Appearance.Options.UseFont = true;
            this.txtOWNER_ID.Size = new System.Drawing.Size(117, 30);
            this.txtOWNER_ID.TabIndex = 1;
            // 
            // bdsDSMAYBAY
            // 
            this.bdsDSMAYBAY.DataMember = "FK_DOANHNGHIEP_sp_DanhSachChuMayBay";
            this.bdsDSMAYBAY.DataSource = this.bdsDOANHNGHIEP;
            // 
            // sp_DanhSachChuMayBayTableAdapter
            // 
            this.sp_DanhSachChuMayBayTableAdapter.ClearBeforeFill = true;
            // 
            // gcDSMAYBAY
            // 
            this.gcDSMAYBAY.DataSource = this.bdsDSMAYBAY;
            this.gcDSMAYBAY.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcDSMAYBAY.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSMAYBAY.Location = new System.Drawing.Point(1109, 301);
            this.gcDSMAYBAY.MainView = this.gvDSMAYBAY;
            this.gcDSMAYBAY.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSMAYBAY.MenuManager = this.barManager1;
            this.gcDSMAYBAY.Name = "gcDSMAYBAY";
            this.gcDSMAYBAY.Size = new System.Drawing.Size(797, 340);
            this.gcDSMAYBAY.TabIndex = 6;
            this.gcDSMAYBAY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSMAYBAY});
            // 
            // gvDSMAYBAY
            // 
            this.gvDSMAYBAY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY,
            this.colTENLOAI,
            this.colNGAYBATDAU});
            this.gvDSMAYBAY.DetailHeight = 431;
            this.gvDSMAYBAY.GridControl = this.gcDSMAYBAY;
            this.gvDSMAYBAY.Name = "gvDSMAYBAY";
            this.gvDSMAYBAY.OptionsView.ShowViewCaption = true;
            this.gvDSMAYBAY.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAYBATDAU, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvDSMAYBAY.ViewCaption = "Danh sách máy bay sở hữu";
            this.gvDSMAYBAY.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDSMAYBAY_RowCellClick);
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.Caption = "Mã máy bay";
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.MinWidth = 23;
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 0;
            this.colIDMAYBAY.Width = 87;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 23;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            this.colTENLOAI.Width = 87;
            // 
            // colNGAYBATDAU
            // 
            this.colNGAYBATDAU.Caption = "Ngày sở hữu";
            this.colNGAYBATDAU.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colNGAYBATDAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU.MinWidth = 23;
            this.colNGAYBATDAU.Name = "colNGAYBATDAU";
            this.colNGAYBATDAU.Visible = true;
            this.colNGAYBATDAU.VisibleIndex = 2;
            this.colNGAYBATDAU.Width = 87;
            // 
            // bdsCT_CHUMAYBAY
            // 
            this.bdsCT_CHUMAYBAY.DataMember = "FK_DOANHNGHIEP_CT_CHUMAYBAY";
            this.bdsCT_CHUMAYBAY.DataSource = this.bdsDOANHNGHIEP;
            // 
            // CT_CHUMAYBAYTableAdapter
            // 
            this.CT_CHUMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // gcCT_CHUMAYBAY
            // 
            this.gcCT_CHUMAYBAY.DataSource = this.bdsCT_CHUMAYBAY;
            this.gcCT_CHUMAYBAY.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcCT_CHUMAYBAY.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_CHUMAYBAY.Location = new System.Drawing.Point(346, 301);
            this.gcCT_CHUMAYBAY.MainView = this.gvCT_CHUMAYBAY;
            this.gcCT_CHUMAYBAY.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_CHUMAYBAY.MenuManager = this.barManager1;
            this.gcCT_CHUMAYBAY.Name = "gcCT_CHUMAYBAY";
            this.gcCT_CHUMAYBAY.Size = new System.Drawing.Size(763, 340);
            this.gcCT_CHUMAYBAY.TabIndex = 10;
            this.gcCT_CHUMAYBAY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCT_CHUMAYBAY});
            this.gcCT_CHUMAYBAY.Visible = false;
            // 
            // gvCT_CHUMAYBAY
            // 
            this.gvCT_CHUMAYBAY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY1,
            this.colNGAYBATDAU1});
            this.gvCT_CHUMAYBAY.DetailHeight = 431;
            this.gvCT_CHUMAYBAY.GridControl = this.gcCT_CHUMAYBAY;
            this.gvCT_CHUMAYBAY.Name = "gvCT_CHUMAYBAY";
            this.gvCT_CHUMAYBAY.OptionsView.ShowViewCaption = true;
            this.gvCT_CHUMAYBAY.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAYBATDAU1, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvCT_CHUMAYBAY.ViewCaption = "Lịch sử sở hữu máy bay";
            // 
            // colIDMAYBAY1
            // 
            this.colIDMAYBAY1.Caption = "Mã máy bay";
            this.colIDMAYBAY1.FieldName = "IDMAYBAY";
            this.colIDMAYBAY1.MinWidth = 23;
            this.colIDMAYBAY1.Name = "colIDMAYBAY1";
            this.colIDMAYBAY1.Visible = true;
            this.colIDMAYBAY1.VisibleIndex = 0;
            this.colIDMAYBAY1.Width = 87;
            // 
            // colNGAYBATDAU1
            // 
            this.colNGAYBATDAU1.Caption = "Ngày sở hữu";
            this.colNGAYBATDAU1.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colNGAYBATDAU1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU1.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU1.MinWidth = 23;
            this.colNGAYBATDAU1.Name = "colNGAYBATDAU1";
            this.colNGAYBATDAU1.Visible = true;
            this.colNGAYBATDAU1.VisibleIndex = 1;
            this.colNGAYBATDAU1.Width = 87;
            // 
            // cmsChucNang
            // 
            this.cmsChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa,
            this.tsmiReload});
            this.cmsChucNang.Name = "cmsChucNang";
            this.cmsChucNang.Size = new System.Drawing.Size(130, 56);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = global::Quan_Ly_May_Bay.Properties.Resources.remove_512px;
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(214, 26);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = global::Quan_Ly_May_Bay.Properties.Resources.synchronize_512px;
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(214, 26);
            this.tsmiReload.Text = "Reload";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // FormDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 661);
            this.Controls.Add(this.panelDOANHNGHIEP);
            this.Controls.Add(this.gcCT_CHUMAYBAY);
            this.Controls.Add(this.gcDSMAYBAY);
            this.Controls.Add(this.gcDOANHNGHIEP);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoanhNghiep";
            this.Text = "Quản lý chủ máy bay doanh nghiệp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoanhNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDOANHNGHIEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDOANHNGHIEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDOANHNGHIEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDOANHNGHIEP)).EndInit();
            this.panelDOANHNGHIEP.ResumeLayout(false);
            this.panelDOANHNGHIEP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDAIDIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOWNER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_CHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_CHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCT_CHUMAYBAY)).EndInit();
            this.cmsChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemDoanhNghiep;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThemMayBay;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDOANHNGHIEP;
        private DS DS;
        private DSTableAdapters.DOANHNGHIEPTableAdapter DOANHNGHIEPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelDOANHNGHIEP;
        private DevExpress.XtraGrid.GridControl gcDOANHNGHIEP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDOANHNGHIEP;
        private DevExpress.XtraGrid.Columns.GridColumn colOWNER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNGUOIDAIDIEN;
        private System.Windows.Forms.BindingSource bdsDSMAYBAY;
        private DSTableAdapters.sp_DanhSachChuMayBayTableAdapter sp_DanhSachChuMayBayTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDSMAYBAY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU;
        private DevExpress.XtraEditors.TextEdit txtDAIDIEN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtOWNER_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsCT_CHUMAYBAY;
        private DSTableAdapters.CT_CHUMAYBAYTableAdapter CT_CHUMAYBAYTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCT_CHUMAYBAY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCT_CHUMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnHienTaiSoHuu;
        private DevExpress.XtraBars.BarButtonItem btnLichSuSoHuu;
        private System.Windows.Forms.ContextMenuStrip cmsChucNang;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}