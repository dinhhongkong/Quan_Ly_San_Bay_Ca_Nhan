namespace Quan_Ly_May_Bay
{
    partial class FormNVBaoTri
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
            System.Windows.Forms.Label cALAMVIECLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label iDNHANVIENLabel;
            System.Windows.Forms.Label tRANGTHAINGHILabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNVBaoTri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiMayBay = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ds = new Quan_Ly_May_Bay.DS();
            this.bdsDsNVBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.dsNVBaoTriTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.DsNVBaoTriTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcDSNVBaoTri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALAMVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAINGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTNVBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NVBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_NVBAOTRITableAdapter();
            this.gcCTNVBaoTri = new DevExpress.XtraGrid.GridControl();
            this.gvCTNVBaoTri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNHANVIEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bdsLoaiMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.txtIdNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.nudLuong = new DevExpress.XtraEditors.SpinEdit();
            this.nudCaLamViec = new DevExpress.XtraEditors.SpinEdit();
            this.chkTrangThaiNghi = new DevExpress.XtraEditors.CheckEdit();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.btnChonNV = new DevExpress.XtraEditors.SimpleButton();
            this.cmsNVBaoTri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            cALAMVIECLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            iDNHANVIENLabel = new System.Windows.Forms.Label();
            tRANGTHAINGHILabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDsNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaLamViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThaiNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            this.cmsNVBaoTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cALAMVIECLabel
            // 
            cALAMVIECLabel.AutoSize = true;
            cALAMVIECLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cALAMVIECLabel.Location = new System.Drawing.Point(25, 268);
            cALAMVIECLabel.Name = "cALAMVIECLabel";
            cALAMVIECLabel.Size = new System.Drawing.Size(120, 24);
            cALAMVIECLabel.TabIndex = 19;
            cALAMVIECLabel.Text = "Ca làm việc:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(91, 204);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(54, 24);
            sDTLabel.TabIndex = 18;
            sDTLabel.Text = "SĐT:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(74, 138);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(71, 24);
            cMNDLabel.TabIndex = 17;
            cMNDLabel.Text = "CMND:";
            // 
            // iDNHANVIENLabel
            // 
            iDNHANVIENLabel.AutoSize = true;
            iDNHANVIENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDNHANVIENLabel.Location = new System.Drawing.Point(12, 82);
            iDNHANVIENLabel.Name = "iDNHANVIENLabel";
            iDNHANVIENLabel.Size = new System.Drawing.Size(133, 24);
            iDNHANVIENLabel.TabIndex = 16;
            iDNHANVIENLabel.Text = "ID Nhân viên:";
            // 
            // tRANGTHAINGHILabel
            // 
            tRANGTHAINGHILabel.AutoSize = true;
            tRANGTHAINGHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRANGTHAINGHILabel.Location = new System.Drawing.Point(503, 268);
            tRANGTHAINGHILabel.Name = "tRANGTHAINGHILabel";
            tRANGTHAINGHILabel.Size = new System.Drawing.Size(153, 24);
            tRANGTHAINGHILabel.TabIndex = 23;
            tRANGTHAINGHILabel.Text = "Trạng thái nghỉ:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lUONGLabel.Location = new System.Drawing.Point(449, 201);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(72, 24);
            lUONGLabel.TabIndex = 22;
            lUONGLabel.Text = "Lương:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(444, 139);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(78, 24);
            dIACHILabel.TabIndex = 21;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(444, 82);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(77, 24);
            tENLabel.TabIndex = 20;
            tENLabel.Text = "Họ tên:";
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
            this.btnReload,
            this.btnLoaiMayBay,
            this.btnThoat,
            this.btnPhucHoi});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoaiMayBay),
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 9;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnLoaiMayBay
            // 
            this.btnLoaiMayBay.Caption = "Thêm máy bay nhân viên có thể bảo trì";
            this.btnLoaiMayBay.Id = 7;
            this.btnLoaiMayBay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiMayBay.ImageOptions.SvgImage")));
            this.btnLoaiMayBay.Name = "btnLoaiMayBay";
            this.btnLoaiMayBay.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLoaiMayBay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiMayBay_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1197, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 778);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1197, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 748);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1197, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 748);
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
            // bdsDsNVBaoTri
            // 
            this.bdsDsNVBaoTri.DataMember = "sp_DanhSachNhanVienBaoTri";
            this.bdsDsNVBaoTri.DataSource = this.ds;
            // 
            // dsNVBaoTriTableAdapter
            // 
            this.dsNVBaoTriTableAdapter.ClearBeforeFill = true;
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
            // gcDSNVBaoTri
            // 
            this.gcDSNVBaoTri.DataSource = this.bdsDsNVBaoTri;
            this.gcDSNVBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSNVBaoTri.Location = new System.Drawing.Point(0, 30);
            this.gcDSNVBaoTri.MainView = this.gridView1;
            this.gcDSNVBaoTri.MenuManager = this.barManager1;
            this.gcDSNVBaoTri.Name = "gcDSNVBaoTri";
            this.gcDSNVBaoTri.Size = new System.Drawing.Size(1197, 403);
            this.gcDSNVBaoTri.TabIndex = 10;
            this.gcDSNVBaoTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNHANVIEN,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colSDT,
            this.colLUONG,
            this.colCALAMVIEC,
            this.colTRANGTHAINGHI});
            this.gridView1.GridControl = this.gcDSNVBaoTri;
            this.gridView1.Name = "gridView1";
            // 
            // colIDNHANVIEN
            // 
            this.colIDNHANVIEN.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN.MinWidth = 25;
            this.colIDNHANVIEN.Name = "colIDNHANVIEN";
            this.colIDNHANVIEN.OptionsColumn.AllowEdit = false;
            this.colIDNHANVIEN.Visible = true;
            this.colIDNHANVIEN.VisibleIndex = 0;
            this.colIDNHANVIEN.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            this.colTEN.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            this.colCMND.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 94;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            this.colLUONG.Width = 94;
            // 
            // colCALAMVIEC
            // 
            this.colCALAMVIEC.FieldName = "CALAMVIEC";
            this.colCALAMVIEC.MinWidth = 25;
            this.colCALAMVIEC.Name = "colCALAMVIEC";
            this.colCALAMVIEC.OptionsColumn.AllowEdit = false;
            this.colCALAMVIEC.Visible = true;
            this.colCALAMVIEC.VisibleIndex = 6;
            this.colCALAMVIEC.Width = 94;
            // 
            // colTRANGTHAINGHI
            // 
            this.colTRANGTHAINGHI.FieldName = "TRANGTHAINGHI";
            this.colTRANGTHAINGHI.MinWidth = 25;
            this.colTRANGTHAINGHI.Name = "colTRANGTHAINGHI";
            this.colTRANGTHAINGHI.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAINGHI.Visible = true;
            this.colTRANGTHAINGHI.VisibleIndex = 7;
            this.colTRANGTHAINGHI.Width = 94;
            // 
            // bdsCTNVBaoTri
            // 
            this.bdsCTNVBaoTri.DataMember = "FK_sp_DanhSachNhanVienBaoTri_CT_NVBAOTRI";
            this.bdsCTNVBaoTri.DataSource = this.bdsDsNVBaoTri;
            // 
            // cT_NVBAOTRITableAdapter
            // 
            this.cT_NVBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // gcCTNVBaoTri
            // 
            this.gcCTNVBaoTri.DataSource = this.bdsCTNVBaoTri;
            this.gcCTNVBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTNVBaoTri.Location = new System.Drawing.Point(849, 433);
            this.gcCTNVBaoTri.MainView = this.gvCTNVBaoTri;
            this.gcCTNVBaoTri.MenuManager = this.barManager1;
            this.gcCTNVBaoTri.Name = "gcCTNVBaoTri";
            this.gcCTNVBaoTri.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit});
            this.gcCTNVBaoTri.Size = new System.Drawing.Size(348, 345);
            this.gcCTNVBaoTri.TabIndex = 15;
            this.gcCTNVBaoTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTNVBaoTri});
            // 
            // gvCTNVBaoTri
            // 
            this.gvCTNVBaoTri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNHANVIEN1,
            this.colIDLOAI});
            this.gvCTNVBaoTri.GridControl = this.gcCTNVBaoTri;
            this.gvCTNVBaoTri.Name = "gvCTNVBaoTri";
            this.gvCTNVBaoTri.OptionsView.ShowViewCaption = true;
            this.gvCTNVBaoTri.ViewCaption = "Danh sách loại máy bay nhân viên có thể bảo trì";
            this.gvCTNVBaoTri.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvCTNVBaoTri_RowCellClick);
            // 
            // colIDNHANVIEN1
            // 
            this.colIDNHANVIEN1.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN1.MinWidth = 25;
            this.colIDNHANVIEN1.Name = "colIDNHANVIEN1";
            this.colIDNHANVIEN1.OptionsColumn.AllowEdit = false;
            this.colIDNHANVIEN1.Visible = true;
            this.colIDNHANVIEN1.VisibleIndex = 0;
            this.colIDNHANVIEN1.Width = 94;
            // 
            // colIDLOAI
            // 
            this.colIDLOAI.ColumnEdit = this.repositoryItemLookUpEdit;
            this.colIDLOAI.FieldName = "IDLOAI";
            this.colIDLOAI.MinWidth = 25;
            this.colIDLOAI.Name = "colIDLOAI";
            this.colIDLOAI.OptionsColumn.AllowEdit = false;
            this.colIDLOAI.Visible = true;
            this.colIDLOAI.VisibleIndex = 1;
            this.colIDLOAI.Width = 94;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            // 
            // bdsLoaiMayBay
            // 
            this.bdsLoaiMayBay.DataMember = "LOAIMAYBAY";
            this.bdsLoaiMayBay.DataSource = this.ds;
            // 
            // lOAIMAYBAYTableAdapter
            // 
            this.lOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdNhanVien
            // 
            this.txtIdNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "IDNHANVIEN", true));
            this.txtIdNhanVien.Location = new System.Drawing.Point(159, 76);
            this.txtIdNhanVien.MenuManager = this.barManager1;
            this.txtIdNhanVien.Name = "txtIdNhanVien";
            this.txtIdNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtIdNhanVien.Properties.ReadOnly = true;
            this.txtIdNhanVien.Size = new System.Drawing.Size(64, 30);
            this.txtIdNhanVien.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "TEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(531, 79);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(272, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(159, 132);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Properties.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(209, 30);
            this.txtCMND.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(531, 136);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(272, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(159, 198);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(209, 30);
            this.txtSDT.TabIndex = 9;
            // 
            // nudLuong
            // 
            this.nudLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "LUONG", true));
            this.nudLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLuong.Location = new System.Drawing.Point(531, 201);
            this.nudLuong.MenuManager = this.barManager1;
            this.nudLuong.Name = "nudLuong";
            this.nudLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLuong.Properties.Appearance.Options.UseFont = true;
            this.nudLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudLuong.Properties.IsFloatValue = false;
            this.nudLuong.Properties.MaskSettings.Set("mask", "N00");
            this.nudLuong.Properties.ReadOnly = true;
            this.nudLuong.Size = new System.Drawing.Size(272, 30);
            this.nudLuong.TabIndex = 11;
            // 
            // nudCaLamViec
            // 
            this.nudCaLamViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "CALAMVIEC", true));
            this.nudCaLamViec.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCaLamViec.Location = new System.Drawing.Point(159, 262);
            this.nudCaLamViec.MenuManager = this.barManager1;
            this.nudCaLamViec.Name = "nudCaLamViec";
            this.nudCaLamViec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCaLamViec.Properties.Appearance.Options.UseFont = true;
            this.nudCaLamViec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudCaLamViec.Properties.IsFloatValue = false;
            this.nudCaLamViec.Properties.MaskSettings.Set("mask", "N00");
            this.nudCaLamViec.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCaLamViec.Properties.ReadOnly = true;
            this.nudCaLamViec.Size = new System.Drawing.Size(209, 30);
            this.nudCaLamViec.TabIndex = 13;
            // 
            // chkTrangThaiNghi
            // 
            this.chkTrangThaiNghi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNVBaoTri, "TRANGTHAINGHI", true));
            this.chkTrangThaiNghi.Location = new System.Drawing.Point(683, 268);
            this.chkTrangThaiNghi.MenuManager = this.barManager1;
            this.chkTrangThaiNghi.Name = "chkTrangThaiNghi";
            this.chkTrangThaiNghi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThaiNghi.Properties.Appearance.Options.UseFont = true;
            this.chkTrangThaiNghi.Properties.Caption = "";
            this.chkTrangThaiNghi.Properties.ReadOnly = true;
            this.chkTrangThaiNghi.Size = new System.Drawing.Size(94, 24);
            this.chkTrangThaiNghi.TabIndex = 15;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(this.btnChonNV);
            this.gcChucNang.Controls.Add(tRANGTHAINGHILabel);
            this.gcChucNang.Controls.Add(lUONGLabel);
            this.gcChucNang.Controls.Add(dIACHILabel);
            this.gcChucNang.Controls.Add(tENLabel);
            this.gcChucNang.Controls.Add(cALAMVIECLabel);
            this.gcChucNang.Controls.Add(sDTLabel);
            this.gcChucNang.Controls.Add(cMNDLabel);
            this.gcChucNang.Controls.Add(iDNHANVIENLabel);
            this.gcChucNang.Controls.Add(this.chkTrangThaiNghi);
            this.gcChucNang.Controls.Add(this.nudCaLamViec);
            this.gcChucNang.Controls.Add(this.nudLuong);
            this.gcChucNang.Controls.Add(this.txtSDT);
            this.gcChucNang.Controls.Add(this.txtDiaChi);
            this.gcChucNang.Controls.Add(this.txtCMND);
            this.gcChucNang.Controls.Add(this.txtHoTen);
            this.gcChucNang.Controls.Add(this.txtIdNhanVien);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcChucNang.Location = new System.Drawing.Point(0, 433);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(849, 345);
            this.gcChucNang.TabIndex = 15;
            this.gcChucNang.Text = "Nhập liệu";
            // 
            // btnChonNV
            // 
            this.btnChonNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNV.Appearance.Options.UseFont = true;
            this.btnChonNV.Enabled = false;
            this.btnChonNV.Location = new System.Drawing.Point(255, 77);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(113, 29);
            this.btnChonNV.TabIndex = 24;
            this.btnChonNV.Text = "Chọn nhân viên";
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // cmsNVBaoTri
            // 
            this.cmsNVBaoTri.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNVBaoTri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa,
            this.tsmiReload});
            this.cmsNVBaoTri.Name = "cmsNVBaoTri";
            this.cmsNVBaoTri.Size = new System.Drawing.Size(130, 56);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = global::Quan_Ly_May_Bay.Properties.Resources.remove_512px;
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(129, 26);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Image = global::Quan_Ly_May_Bay.Properties.Resources.synchronize_512px;
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(129, 26);
            this.tsmiReload.Text = "Reload";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // FormNVBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 778);
            this.Controls.Add(this.gcCTNVBaoTri);
            this.Controls.Add(this.gcChucNang);
            this.Controls.Add(this.gcDSNVBaoTri);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNVBaoTri";
            this.Text = "Quản lý nhân viên bảo trì";
            this.Load += new System.EventHandler(this.FormNVBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDsNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaLamViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThaiNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            this.gcChucNang.PerformLayout();
            this.cmsNVBaoTri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnLoaiMayBay;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsDsNVBaoTri;
        private DS ds;
        private DSTableAdapters.DsNVBaoTriTableAdapter dsNVBaoTriTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSNVBaoTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCALAMVIEC;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAINGHI;
        private System.Windows.Forms.BindingSource bdsCTNVBaoTri;
        private DSTableAdapters.CT_NVBAOTRITableAdapter cT_NVBAOTRITableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTNVBaoTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTNVBaoTri;
        private System.Windows.Forms.BindingSource bdsLoaiMayBay;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraEditors.CheckEdit chkTrangThaiNghi;
        private DevExpress.XtraEditors.SpinEdit nudCaLamViec;
        private DevExpress.XtraEditors.SpinEdit nudLuong;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtIdNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnChonNV;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private System.Windows.Forms.ContextMenuStrip cmsNVBaoTri;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}