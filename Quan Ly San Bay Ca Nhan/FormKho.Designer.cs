namespace Quan_Ly_May_Bay
{
    partial class FormKho
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
            System.Windows.Forms.Label iDKHOLabel;
            System.Windows.Forms.Label sUCCHUALabel;
            System.Windows.Forms.Label vITRILabel;
            System.Windows.Forms.Label iDKHOLabel1;
            System.Windows.Forms.Label iDMAYBAYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.ds = new Quan_Ly_May_Bay.DS();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.kHOTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.KHOTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.cT_KHOTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_KHOTableAdapter();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUCCHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVITRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.nudSucChua = new DevExpress.XtraEditors.SpinEdit();
            this.txtIdKho = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTKho = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTKho = new DevExpress.XtraGrid.GridControl();
            this.gvCTKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsCTKho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.gcChucNangCT = new DevExpress.XtraEditors.GroupControl();
            this.txtIDKhoCT = new DevExpress.XtraEditors.TextEdit();
            this.btnThoatCT = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiCTKho = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDMayBay = new DevExpress.XtraEditors.ButtonEdit();
            iDKHOLabel = new System.Windows.Forms.Label();
            sUCCHUALabel = new System.Windows.Forms.Label();
            vITRILabel = new System.Windows.Forms.Label();
            iDKHOLabel1 = new System.Windows.Forms.Label();
            iDMAYBAYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTKho)).BeginInit();
            this.cmsCTKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNangCT)).BeginInit();
            this.gcChucNangCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKhoCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMayBay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iDKHOLabel
            // 
            iDKHOLabel.AutoSize = true;
            iDKHOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDKHOLabel.Location = new System.Drawing.Point(53, 55);
            iDKHOLabel.Name = "iDKHOLabel";
            iDKHOLabel.Size = new System.Drawing.Size(76, 24);
            iDKHOLabel.TabIndex = 0;
            iDKHOLabel.Text = "ID kho:";
            // 
            // sUCCHUALabel
            // 
            sUCCHUALabel.AutoSize = true;
            sUCCHUALabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sUCCHUALabel.Location = new System.Drawing.Point(53, 146);
            sUCCHUALabel.Name = "sUCCHUALabel";
            sUCCHUALabel.Size = new System.Drawing.Size(98, 24);
            sUCCHUALabel.TabIndex = 2;
            sUCCHUALabel.Text = "Sức chứa:";
            // 
            // vITRILabel
            // 
            vITRILabel.AutoSize = true;
            vITRILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vITRILabel.Location = new System.Drawing.Point(53, 231);
            vITRILabel.Name = "vITRILabel";
            vITRILabel.Size = new System.Drawing.Size(59, 24);
            vITRILabel.TabIndex = 4;
            vITRILabel.Text = "Vị trí:";
            // 
            // iDKHOLabel1
            // 
            iDKHOLabel1.AutoSize = true;
            iDKHOLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDKHOLabel1.Location = new System.Drawing.Point(51, 77);
            iDKHOLabel1.Name = "iDKHOLabel1";
            iDKHOLabel1.Size = new System.Drawing.Size(76, 24);
            iDKHOLabel1.TabIndex = 0;
            iDKHOLabel1.Text = "ID kho:";
            // 
            // iDMAYBAYLabel
            // 
            iDMAYBAYLabel.AutoSize = true;
            iDMAYBAYLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDMAYBAYLabel.Location = new System.Drawing.Point(51, 146);
            iDMAYBAYLabel.Name = "iDMAYBAYLabel";
            iDMAYBAYLabel.Size = new System.Drawing.Size(120, 24);
            iDMAYBAYLabel.TabIndex = 2;
            iDMAYBAYLabel.Text = "ID máy bay:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnCTKho,
            this.btnThoat,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(179, 248);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCTKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.AllowRightClickInMenu = false;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 9;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.AllowRightClickInMenu = false;
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnCTKho
            // 
            this.btnCTKho.Caption = "Danh sách máy bay trong kho";
            this.btnCTKho.Id = 7;
            this.btnCTKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCTKho.ImageOptions.SvgImage")));
            this.btnCTKho.Name = "btnCTKho";
            this.btnCTKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCTKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTKho_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1343, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 695);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1343, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 665);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1343, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 665);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "KHO";
            this.bdsKho.DataSource = this.ds;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CANHANTableAdapter = null;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_BANGLAITableAdapter = null;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = this.cT_KHOTableAdapter;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = this.kHOTableAdapter;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_KHOTableAdapter
            // 
            this.cT_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.bdsKho;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKho.Location = new System.Drawing.Point(0, 30);
            this.gcKho.MainView = this.gridView1;
            this.gcKho.MenuManager = this.barManager1;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(1343, 388);
            this.gcKho.TabIndex = 5;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKHO,
            this.colSUCCHUA,
            this.colVITRI});
            this.gridView1.GridControl = this.gcKho;
            this.gridView1.Name = "gridView1";
            // 
            // colIDKHO
            // 
            this.colIDKHO.Caption = "ID kho";
            this.colIDKHO.FieldName = "IDKHO";
            this.colIDKHO.MinWidth = 25;
            this.colIDKHO.Name = "colIDKHO";
            this.colIDKHO.OptionsColumn.AllowEdit = false;
            this.colIDKHO.Visible = true;
            this.colIDKHO.VisibleIndex = 0;
            this.colIDKHO.Width = 94;
            // 
            // colSUCCHUA
            // 
            this.colSUCCHUA.Caption = "Sức chứa";
            this.colSUCCHUA.FieldName = "SUCCHUA";
            this.colSUCCHUA.MinWidth = 25;
            this.colSUCCHUA.Name = "colSUCCHUA";
            this.colSUCCHUA.OptionsColumn.AllowEdit = false;
            this.colSUCCHUA.Visible = true;
            this.colSUCCHUA.VisibleIndex = 1;
            this.colSUCCHUA.Width = 94;
            // 
            // colVITRI
            // 
            this.colVITRI.Caption = "Vị trí kho";
            this.colVITRI.FieldName = "VITRI";
            this.colVITRI.MinWidth = 25;
            this.colVITRI.Name = "colVITRI";
            this.colVITRI.OptionsColumn.AllowEdit = false;
            this.colVITRI.Visible = true;
            this.colVITRI.VisibleIndex = 2;
            this.colVITRI.Width = 94;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(vITRILabel);
            this.gcChucNang.Controls.Add(this.txtViTri);
            this.gcChucNang.Controls.Add(sUCCHUALabel);
            this.gcChucNang.Controls.Add(this.nudSucChua);
            this.gcChucNang.Controls.Add(iDKHOLabel);
            this.gcChucNang.Controls.Add(this.txtIdKho);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcChucNang.Enabled = false;
            this.gcChucNang.Location = new System.Drawing.Point(0, 418);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(575, 277);
            this.gcChucNang.TabIndex = 6;
            this.gcChucNang.Text = "Nhập liệu kho";
            // 
            // txtViTri
            // 
            this.txtViTri.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "VITRI", true));
            this.txtViTri.Location = new System.Drawing.Point(175, 225);
            this.txtViTri.MenuManager = this.barManager1;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Properties.Appearance.Options.UseFont = true;
            this.txtViTri.Size = new System.Drawing.Size(322, 30);
            this.txtViTri.TabIndex = 5;
            // 
            // nudSucChua
            // 
            this.nudSucChua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "SUCCHUA", true));
            this.nudSucChua.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSucChua.Location = new System.Drawing.Point(175, 143);
            this.nudSucChua.MenuManager = this.barManager1;
            this.nudSucChua.Name = "nudSucChua";
            this.nudSucChua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSucChua.Properties.Appearance.Options.UseFont = true;
            this.nudSucChua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudSucChua.Properties.IsFloatValue = false;
            this.nudSucChua.Properties.MaskSettings.Set("mask", "N00");
            this.nudSucChua.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSucChua.Size = new System.Drawing.Size(322, 30);
            this.nudSucChua.TabIndex = 3;
            // 
            // txtIdKho
            // 
            this.txtIdKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "IDKHO", true));
            this.txtIdKho.Location = new System.Drawing.Point(175, 52);
            this.txtIdKho.MenuManager = this.barManager1;
            this.txtIdKho.Name = "txtIdKho";
            this.txtIdKho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKho.Properties.Appearance.Options.UseFont = true;
            this.txtIdKho.Size = new System.Drawing.Size(322, 30);
            this.txtIdKho.TabIndex = 1;
            // 
            // bdsCTKho
            // 
            this.bdsCTKho.DataMember = "FK_CT_KHO_KHO";
            this.bdsCTKho.DataSource = this.bdsKho;
            // 
            // gcCTKho
            // 
            this.gcCTKho.DataSource = this.bdsCTKho;
            this.gcCTKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTKho.Enabled = false;
            this.gcCTKho.Location = new System.Drawing.Point(1019, 418);
            this.gcCTKho.MainView = this.gvCTKho;
            this.gcCTKho.MenuManager = this.barManager1;
            this.gcCTKho.Name = "gcCTKho";
            this.gcCTKho.Size = new System.Drawing.Size(324, 277);
            this.gcCTKho.TabIndex = 6;
            this.gcCTKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTKho});
            // 
            // gvCTKho
            // 
            this.gvCTKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKHO1,
            this.colIDMAYBAY});
            this.gvCTKho.GridControl = this.gcCTKho;
            this.gvCTKho.Name = "gvCTKho";
            this.gvCTKho.OptionsView.ShowViewCaption = true;
            this.gvCTKho.ViewCaption = "Click chuột phải để thêm, xóa, sửa chi tiết kho";
            this.gvCTKho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvCTKho_MouseDown);
            // 
            // colIDKHO1
            // 
            this.colIDKHO1.Caption = "ID kho";
            this.colIDKHO1.FieldName = "IDKHO";
            this.colIDKHO1.MinWidth = 25;
            this.colIDKHO1.Name = "colIDKHO1";
            this.colIDKHO1.OptionsColumn.AllowEdit = false;
            this.colIDKHO1.Visible = true;
            this.colIDKHO1.VisibleIndex = 0;
            this.colIDKHO1.Width = 94;
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.Caption = "ID máy bay";
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.MinWidth = 25;
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.OptionsColumn.AllowEdit = false;
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 1;
            this.colIDMAYBAY.Width = 94;
            // 
            // cmsCTKho
            // 
            this.cmsCTKho.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTKho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiSua,
            this.tsmiXoa,
            this.tsmiReload});
            this.cmsCTKho.Name = "cmsCTKho";
            this.cmsCTKho.Size = new System.Drawing.Size(281, 108);
            // 
            // tsmiThem
            // 
            this.tsmiThem.Image = global::Quan_Ly_May_Bay.Properties.Resources.add_240px;
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(280, 26);
            this.tsmiThem.Text = "Thêm máy bay vào kho";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiSua
            // 
            this.tsmiSua.Image = global::Quan_Ly_May_Bay.Properties.Resources.edit_row_512px;
            this.tsmiSua.Name = "tsmiSua";
            this.tsmiSua.Size = new System.Drawing.Size(280, 26);
            this.tsmiSua.Text = "Hiệu chỉnh máy bay trong kho";
            this.tsmiSua.Click += new System.EventHandler(this.tsmiSua_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = global::Quan_Ly_May_Bay.Properties.Resources.remove_512px;
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(280, 26);
            this.tsmiXoa.Text = "Xóa máy bay khỏi kho";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = global::Quan_Ly_May_Bay.Properties.Resources.synchronize_512px;
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(280, 26);
            this.tsmiReload.Text = "Reload máy bay trong kho";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // gcChucNangCT
            // 
            this.gcChucNangCT.Controls.Add(this.txtIDKhoCT);
            this.gcChucNangCT.Controls.Add(this.btnThoatCT);
            this.gcChucNangCT.Controls.Add(this.btnGhiCTKho);
            this.gcChucNangCT.Controls.Add(iDMAYBAYLabel);
            this.gcChucNangCT.Controls.Add(this.txtIDMayBay);
            this.gcChucNangCT.Controls.Add(iDKHOLabel1);
            this.gcChucNangCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcChucNangCT.Enabled = false;
            this.gcChucNangCT.Location = new System.Drawing.Point(575, 418);
            this.gcChucNangCT.Name = "gcChucNangCT";
            this.gcChucNangCT.Size = new System.Drawing.Size(444, 277);
            this.gcChucNangCT.TabIndex = 11;
            this.gcChucNangCT.Text = "Nhập liệu chi tiết kho";
            this.gcChucNangCT.Visible = false;
            // 
            // txtIDKhoCT
            // 
            this.txtIDKhoCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "IDKHO", true));
            this.txtIDKhoCT.Location = new System.Drawing.Point(177, 74);
            this.txtIDKhoCT.MenuManager = this.barManager1;
            this.txtIDKhoCT.Name = "txtIDKhoCT";
            this.txtIDKhoCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKhoCT.Properties.Appearance.Options.UseFont = true;
            this.txtIDKhoCT.Properties.ReadOnly = true;
            this.txtIDKhoCT.Size = new System.Drawing.Size(170, 30);
            this.txtIDKhoCT.TabIndex = 6;
            // 
            // btnThoatCT
            // 
            this.btnThoatCT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCT.Appearance.Options.UseFont = true;
            this.btnThoatCT.Location = new System.Drawing.Point(253, 222);
            this.btnThoatCT.Name = "btnThoatCT";
            this.btnThoatCT.Size = new System.Drawing.Size(94, 32);
            this.btnThoatCT.TabIndex = 5;
            this.btnThoatCT.Text = "Thoát";
            this.btnThoatCT.Click += new System.EventHandler(this.btnThoatCT_Click);
            // 
            // btnGhiCTKho
            // 
            this.btnGhiCTKho.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiCTKho.Appearance.Options.UseFont = true;
            this.btnGhiCTKho.Location = new System.Drawing.Point(74, 225);
            this.btnGhiCTKho.Name = "btnGhiCTKho";
            this.btnGhiCTKho.Size = new System.Drawing.Size(106, 29);
            this.btnGhiCTKho.TabIndex = 4;
            this.btnGhiCTKho.Text = "Ghi";
            this.btnGhiCTKho.Click += new System.EventHandler(this.btnGhiCTKho_Click);
            // 
            // txtIDMayBay
            // 
            this.txtIDMayBay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTKho, "IDMAYBAY", true));
            this.txtIDMayBay.Location = new System.Drawing.Point(177, 143);
            this.txtIDMayBay.MenuManager = this.barManager1;
            this.txtIDMayBay.Name = "txtIDMayBay";
            this.txtIDMayBay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMayBay.Properties.Appearance.Options.UseFont = true;
            this.txtIDMayBay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIDMayBay.Properties.ReadOnly = true;
            this.txtIDMayBay.Size = new System.Drawing.Size(170, 30);
            this.txtIDMayBay.TabIndex = 3;
            this.txtIDMayBay.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtIDMayBay_ButtonClick);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 695);
            this.Controls.Add(this.gcCTKho);
            this.Controls.Add(this.gcChucNangCT);
            this.Controls.Add(this.gcChucNang);
            this.Controls.Add(this.gcKho);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKho";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            this.gcChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTKho)).EndInit();
            this.cmsCTKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNangCT)).EndInit();
            this.gcChucNangCT.ResumeLayout(false);
            this.gcChucNangCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKhoCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMayBay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnCTKho;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsKho;
        private DS ds;
        private DSTableAdapters.KHOTableAdapter kHOTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colSUCCHUA;
        private DevExpress.XtraGrid.Columns.GridColumn colVITRI;
        private DSTableAdapters.CT_KHOTableAdapter cT_KHOTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTKho;
        private DevExpress.XtraGrid.GridControl gcCTKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTKho;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKHO1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraEditors.TextEdit txtViTri;
        private DevExpress.XtraEditors.SpinEdit nudSucChua;
        private DevExpress.XtraEditors.TextEdit txtIdKho;
        private System.Windows.Forms.ContextMenuStrip cmsCTKho;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSua;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private DevExpress.XtraEditors.GroupControl gcChucNangCT;
        private DevExpress.XtraEditors.ButtonEdit txtIDMayBay;
        private DevExpress.XtraEditors.SimpleButton btnGhiCTKho;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
        private DevExpress.XtraEditors.SimpleButton btnThoatCT;
        private DevExpress.XtraEditors.TextEdit txtIDKhoCT;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
    }
}