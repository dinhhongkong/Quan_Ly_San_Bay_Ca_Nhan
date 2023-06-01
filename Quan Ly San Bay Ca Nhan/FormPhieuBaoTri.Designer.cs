namespace Quan_Ly_May_Bay
{
    partial class FormPhieuBaoTri
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
            System.Windows.Forms.Label iDPHIEULabel;
            System.Windows.Forms.Label iDMAYBAYLabel;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label sOGIOLabel;
            System.Windows.Forms.Label iDNHANVIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuBaoTri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ds = new Quan_Ly_May_Bay.DS();
            this.bdsPhieuBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.PHIEUBAOTRITableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.cT_PHIEUBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_PHIEUBAOTRITableAdapter();
            this.gcPhieuBaoTri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.txtIDNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.nudSoGio = new DevExpress.XtraEditors.SpinEdit();
            this.txtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtIDMayBay = new DevExpress.XtraEditors.ButtonEdit();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPhieuBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTPhieuBaoTri = new DevExpress.XtraGrid.GridControl();
            this.gvCTPhieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPHIEU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNHANVIEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONGVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsCTPhieuBaoTri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHieuChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            iDPHIEULabel = new System.Windows.Forms.Label();
            iDMAYBAYLabel = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            sOGIOLabel = new System.Windows.Forms.Label();
            iDNHANVIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMayBay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPhieu)).BeginInit();
            this.cmsCTPhieuBaoTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDPHIEULabel
            // 
            iDPHIEULabel.AutoSize = true;
            iDPHIEULabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDPHIEULabel.Location = new System.Drawing.Point(9, 117);
            iDPHIEULabel.Name = "iDPHIEULabel";
            iDPHIEULabel.Size = new System.Drawing.Size(98, 24);
            iDPHIEULabel.TabIndex = 0;
            iDPHIEULabel.Text = "Mã phiếu:";
            // 
            // iDMAYBAYLabel
            // 
            iDMAYBAYLabel.AutoSize = true;
            iDMAYBAYLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDMAYBAYLabel.Location = new System.Drawing.Point(329, 117);
            iDMAYBAYLabel.Name = "iDMAYBAYLabel";
            iDMAYBAYLabel.Size = new System.Drawing.Size(120, 24);
            iDMAYBAYLabel.TabIndex = 2;
            iDMAYBAYLabel.Text = "ID máy bay:";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLAPLabel.Location = new System.Drawing.Point(7, 182);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(95, 24);
            nGAYLAPLabel.TabIndex = 4;
            nGAYLAPLabel.Text = "Ngày lập:";
            // 
            // sOGIOLabel
            // 
            sOGIOLabel.AutoSize = true;
            sOGIOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOGIOLabel.Location = new System.Drawing.Point(372, 178);
            sOGIOLabel.Name = "sOGIOLabel";
            sOGIOLabel.Size = new System.Drawing.Size(72, 24);
            sOGIOLabel.TabIndex = 6;
            sOGIOLabel.Text = "Số giờ:";
            // 
            // iDNHANVIENLabel
            // 
            iDNHANVIENLabel.AutoSize = true;
            iDNHANVIENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDNHANVIENLabel.Location = new System.Drawing.Point(11, 247);
            iDNHANVIENLabel.Name = "iDNHANVIENLabel";
            iDNHANVIENLabel.Size = new System.Drawing.Size(219, 24);
            iDNHANVIENLabel.TabIndex = 8;
            iDNHANVIENLabel.Text = "ID nhân viên lập phiếu:";
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
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
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
            this.barDockControlTop.Size = new System.Drawing.Size(1112, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 672);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1112, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 642);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1112, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 642);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuBaoTri
            // 
            this.bdsPhieuBaoTri.DataMember = "PHIEUBAOTRI";
            this.bdsPhieuBaoTri.DataSource = this.ds;
            // 
            // pHIEUBAOTRITableAdapter
            // 
            this.pHIEUBAOTRITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = this.cT_PHIEUBAOTRITableAdapter;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = this.pHIEUBAOTRITableAdapter;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_PHIEUBAOTRITableAdapter
            // 
            this.cT_PHIEUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // gcPhieuBaoTri
            // 
            this.gcPhieuBaoTri.DataSource = this.bdsPhieuBaoTri;
            this.gcPhieuBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuBaoTri.Location = new System.Drawing.Point(0, 30);
            this.gcPhieuBaoTri.MainView = this.gridView1;
            this.gcPhieuBaoTri.MenuManager = this.barManager1;
            this.gcPhieuBaoTri.Name = "gcPhieuBaoTri";
            this.gcPhieuBaoTri.Size = new System.Drawing.Size(1112, 328);
            this.gcPhieuBaoTri.TabIndex = 5;
            this.gcPhieuBaoTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPHIEU,
            this.colIDMAYBAY,
            this.colIDNHANVIEN,
            this.colNGAYLAP,
            this.colSOGIO});
            this.gridView1.GridControl = this.gcPhieuBaoTri;
            this.gridView1.Name = "gridView1";
            // 
            // colIDPHIEU
            // 
            this.colIDPHIEU.Caption = "Mã phiếu";
            this.colIDPHIEU.FieldName = "IDPHIEU";
            this.colIDPHIEU.MinWidth = 25;
            this.colIDPHIEU.Name = "colIDPHIEU";
            this.colIDPHIEU.OptionsColumn.AllowEdit = false;
            this.colIDPHIEU.Visible = true;
            this.colIDPHIEU.VisibleIndex = 0;
            this.colIDPHIEU.Width = 94;
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.Caption = "ID Máy bay";
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.MinWidth = 25;
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.OptionsColumn.AllowEdit = false;
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 1;
            this.colIDMAYBAY.Width = 94;
            // 
            // colIDNHANVIEN
            // 
            this.colIDNHANVIEN.Caption = "ID Nhân viên";
            this.colIDNHANVIEN.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN.MinWidth = 25;
            this.colIDNHANVIEN.Name = "colIDNHANVIEN";
            this.colIDNHANVIEN.OptionsColumn.AllowEdit = false;
            this.colIDNHANVIEN.Visible = true;
            this.colIDNHANVIEN.VisibleIndex = 2;
            this.colIDNHANVIEN.Width = 94;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.Caption = "Ngày lập phiếu";
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.MinWidth = 25;
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.OptionsColumn.AllowEdit = false;
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 3;
            this.colNGAYLAP.Width = 94;
            // 
            // colSOGIO
            // 
            this.colSOGIO.Caption = "Số giờ";
            this.colSOGIO.FieldName = "SOGIO";
            this.colSOGIO.MinWidth = 25;
            this.colSOGIO.Name = "colSOGIO";
            this.colSOGIO.OptionsColumn.AllowEdit = false;
            this.colSOGIO.Visible = true;
            this.colSOGIO.VisibleIndex = 4;
            this.colSOGIO.Width = 94;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(iDNHANVIENLabel);
            this.gcChucNang.Controls.Add(this.txtIDNhanVien);
            this.gcChucNang.Controls.Add(sOGIOLabel);
            this.gcChucNang.Controls.Add(this.nudSoGio);
            this.gcChucNang.Controls.Add(nGAYLAPLabel);
            this.gcChucNang.Controls.Add(this.txtNgayLap);
            this.gcChucNang.Controls.Add(iDMAYBAYLabel);
            this.gcChucNang.Controls.Add(this.txtIDMayBay);
            this.gcChucNang.Controls.Add(iDPHIEULabel);
            this.gcChucNang.Controls.Add(this.txtMaPhieu);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcChucNang.Enabled = false;
            this.gcChucNang.Location = new System.Drawing.Point(0, 358);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(615, 314);
            this.gcChucNang.TabIndex = 6;
            this.gcChucNang.Text = "Nhập liệu";
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuBaoTri, "IDNHANVIEN", true));
            this.txtIDNhanVien.Location = new System.Drawing.Point(236, 244);
            this.txtIDNhanVien.MenuManager = this.barManager1;
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtIDNhanVien.Properties.ReadOnly = true;
            this.txtIDNhanVien.Size = new System.Drawing.Size(125, 30);
            this.txtIDNhanVien.TabIndex = 9;
            // 
            // nudSoGio
            // 
            this.nudSoGio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuBaoTri, "SOGIO", true));
            this.nudSoGio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSoGio.Location = new System.Drawing.Point(455, 175);
            this.nudSoGio.MenuManager = this.barManager1;
            this.nudSoGio.Name = "nudSoGio";
            this.nudSoGio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoGio.Properties.Appearance.Options.UseFont = true;
            this.nudSoGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudSoGio.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoGio.Size = new System.Drawing.Size(125, 30);
            this.nudSoGio.TabIndex = 7;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuBaoTri, "NGAYLAP", true));
            this.txtNgayLap.EditValue = null;
            this.txtNgayLap.Location = new System.Drawing.Point(108, 179);
            this.txtNgayLap.MenuManager = this.barManager1;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Properties.Appearance.Options.UseFont = true;
            this.txtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(182, 30);
            this.txtNgayLap.TabIndex = 5;
            // 
            // txtIDMayBay
            // 
            this.txtIDMayBay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuBaoTri, "IDMAYBAY", true));
            this.txtIDMayBay.Location = new System.Drawing.Point(455, 114);
            this.txtIDMayBay.MenuManager = this.barManager1;
            this.txtIDMayBay.Name = "txtIDMayBay";
            this.txtIDMayBay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMayBay.Properties.Appearance.Options.UseFont = true;
            this.txtIDMayBay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIDMayBay.Properties.ReadOnly = true;
            this.txtIDMayBay.Size = new System.Drawing.Size(125, 30);
            this.txtIDMayBay.TabIndex = 3;
            this.txtIDMayBay.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtIDMayBay_ButtonClick);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuBaoTri, "IDPHIEU", true));
            this.txtMaPhieu.Location = new System.Drawing.Point(108, 114);
            this.txtMaPhieu.MenuManager = this.barManager1;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(182, 30);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // bdsCTPhieuBaoTri
            // 
            this.bdsCTPhieuBaoTri.DataMember = "FK_CT_PHIEUBAOTRI_PHIEUBAOTRI";
            this.bdsCTPhieuBaoTri.DataSource = this.bdsPhieuBaoTri;
            // 
            // gcCTPhieuBaoTri
            // 
            this.gcCTPhieuBaoTri.DataSource = this.bdsCTPhieuBaoTri;
            this.gcCTPhieuBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPhieuBaoTri.Location = new System.Drawing.Point(615, 358);
            this.gcCTPhieuBaoTri.MainView = this.gvCTPhieu;
            this.gcCTPhieuBaoTri.MenuManager = this.barManager1;
            this.gcCTPhieuBaoTri.Name = "gcCTPhieuBaoTri";
            this.gcCTPhieuBaoTri.Size = new System.Drawing.Size(497, 314);
            this.gcCTPhieuBaoTri.TabIndex = 6;
            this.gcCTPhieuBaoTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPhieu});
            // 
            // gvCTPhieu
            // 
            this.gvCTPhieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPHIEU1,
            this.colIDNHANVIEN1,
            this.colCONGVIEC});
            this.gvCTPhieu.GridControl = this.gcCTPhieuBaoTri;
            this.gvCTPhieu.Name = "gvCTPhieu";
            this.gvCTPhieu.OptionsView.ShowViewCaption = true;
            this.gvCTPhieu.ViewCaption = "Danh sách chi tiết phiếu bảo trì";
            this.gvCTPhieu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView2_MouseDown);
            // 
            // colIDPHIEU1
            // 
            this.colIDPHIEU1.Caption = "Mã phiếu";
            this.colIDPHIEU1.FieldName = "IDPHIEU";
            this.colIDPHIEU1.MinWidth = 25;
            this.colIDPHIEU1.Name = "colIDPHIEU1";
            this.colIDPHIEU1.OptionsColumn.AllowEdit = false;
            this.colIDPHIEU1.Visible = true;
            this.colIDPHIEU1.VisibleIndex = 0;
            this.colIDPHIEU1.Width = 94;
            // 
            // colIDNHANVIEN1
            // 
            this.colIDNHANVIEN1.Caption = "ID Nhân viên";
            this.colIDNHANVIEN1.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN1.MinWidth = 25;
            this.colIDNHANVIEN1.Name = "colIDNHANVIEN1";
            this.colIDNHANVIEN1.OptionsColumn.AllowEdit = false;
            this.colIDNHANVIEN1.Visible = true;
            this.colIDNHANVIEN1.VisibleIndex = 1;
            this.colIDNHANVIEN1.Width = 94;
            // 
            // colCONGVIEC
            // 
            this.colCONGVIEC.Caption = "Môt tả công việc";
            this.colCONGVIEC.FieldName = "CONGVIEC";
            this.colCONGVIEC.MinWidth = 25;
            this.colCONGVIEC.Name = "colCONGVIEC";
            this.colCONGVIEC.OptionsColumn.AllowEdit = false;
            this.colCONGVIEC.Visible = true;
            this.colCONGVIEC.VisibleIndex = 2;
            this.colCONGVIEC.Width = 94;
            // 
            // cmsCTPhieuBaoTri
            // 
            this.cmsCTPhieuBaoTri.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTPhieuBaoTri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa,
            this.tsmiHieuChinh,
            this.tsmiReload});
            this.cmsCTPhieuBaoTri.Name = "cmsCTPhieuBaoTri";
            this.cmsCTPhieuBaoTri.Size = new System.Drawing.Size(215, 136);
            // 
            // tsmiThem
            // 
            this.tsmiThem.Image = global::Quan_Ly_May_Bay.Properties.Resources.add_240px;
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(214, 26);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = global::Quan_Ly_May_Bay.Properties.Resources.remove_512px;
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(214, 26);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiHieuChinh
            // 
            this.tsmiHieuChinh.Image = global::Quan_Ly_May_Bay.Properties.Resources.edit_row_512px;
            this.tsmiHieuChinh.Name = "tsmiHieuChinh";
            this.tsmiHieuChinh.Size = new System.Drawing.Size(214, 26);
            this.tsmiHieuChinh.Text = "Hiệu chỉnh";
            this.tsmiHieuChinh.Click += new System.EventHandler(this.tsmiHieuChinh_Click);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = global::Quan_Ly_May_Bay.Properties.Resources.synchronize_512px;
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(214, 26);
            this.tsmiReload.Text = "Reload";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // FormPhieuBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 672);
            this.Controls.Add(this.gcCTPhieuBaoTri);
            this.Controls.Add(this.gcChucNang);
            this.Controls.Add(this.gcPhieuBaoTri);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieuBaoTri";
            this.Text = "Quản lý phiếu bảo trì";
            this.Load += new System.EventHandler(this.FormPhieuBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            this.gcChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMayBay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPhieu)).EndInit();
            this.cmsCTPhieuBaoTri.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPhieuBaoTri;
        private DS ds;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DSTableAdapters.PHIEUBAOTRITableAdapter pHIEUBAOTRITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraGrid.GridControl gcPhieuBaoTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIO;
        private DSTableAdapters.CT_PHIEUBAOTRITableAdapter cT_PHIEUBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPhieuBaoTri;
        private DevExpress.XtraGrid.GridControl gcCTPhieuBaoTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPHIEU1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colCONGVIEC;
        private DevExpress.XtraEditors.SpinEdit nudSoGio;
        private DevExpress.XtraEditors.DateEdit txtNgayLap;
        private DevExpress.XtraEditors.ButtonEdit txtIDMayBay;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.TextEdit txtIDNhanVien;
        private System.Windows.Forms.ContextMenuStrip cmsCTPhieuBaoTri;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiHieuChinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}