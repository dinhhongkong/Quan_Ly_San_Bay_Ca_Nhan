namespace Quan_Ly_May_Bay
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label cALAMVIECLabel;
            System.Windows.Forms.Label tRANGTHAINGHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
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
            this.bdsDsNV = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachNhanVienTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachNhanVienTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALAMVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAINGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.bdsPhiCong = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.chkTrangThaiNghi = new DevExpress.XtraEditors.CheckEdit();
            this.nudCaLamViec = new DevExpress.XtraEditors.SpinEdit();
            this.nudLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtIdNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.nHANVIENTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.NHANVIENTableAdapter();
            this.bdsPhieuBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.PHIEUBAOTRITableAdapter();
            this.bdsNVBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NVBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_NVBAOTRITableAdapter();
            this.bdsCTPhieuBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHIEUBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_PHIEUBAOTRITableAdapter();
            this.pHICONGTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.PHICONGTableAdapter();
            iDNHANVIENLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            cALAMVIECLabel = new System.Windows.Forms.Label();
            tRANGTHAINGHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhiCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThaiNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaLamViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuBaoTri)).BeginInit();
            this.SuspendLayout();
            // 
            // iDNHANVIENLabel
            // 
            iDNHANVIENLabel.AutoSize = true;
            iDNHANVIENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDNHANVIENLabel.Location = new System.Drawing.Point(46, 69);
            iDNHANVIENLabel.Name = "iDNHANVIENLabel";
            iDNHANVIENLabel.Size = new System.Drawing.Size(133, 24);
            iDNHANVIENLabel.TabIndex = 0;
            iDNHANVIENLabel.Text = "ID Nhân viên:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(565, 69);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(77, 24);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Họ tên:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(108, 125);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(71, 24);
            cMNDLabel.TabIndex = 4;
            cMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(565, 126);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(78, 24);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(125, 191);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(54, 24);
            sDTLabel.TabIndex = 8;
            sDTLabel.Text = "SĐT:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lUONGLabel.Location = new System.Drawing.Point(570, 188);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(72, 24);
            lUONGLabel.TabIndex = 10;
            lUONGLabel.Text = "Lương:";
            // 
            // cALAMVIECLabel
            // 
            cALAMVIECLabel.AutoSize = true;
            cALAMVIECLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cALAMVIECLabel.Location = new System.Drawing.Point(59, 255);
            cALAMVIECLabel.Name = "cALAMVIECLabel";
            cALAMVIECLabel.Size = new System.Drawing.Size(120, 24);
            cALAMVIECLabel.TabIndex = 12;
            cALAMVIECLabel.Text = "Ca làm việc:";
            // 
            // tRANGTHAINGHILabel
            // 
            tRANGTHAINGHILabel.AutoSize = true;
            tRANGTHAINGHILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRANGTHAINGHILabel.Location = new System.Drawing.Point(624, 255);
            tRANGTHAINGHILabel.Name = "tRANGTHAINGHILabel";
            tRANGTHAINGHILabel.Size = new System.Drawing.Size(153, 24);
            tRANGTHAINGHILabel.TabIndex = 14;
            tRANGTHAINGHILabel.Text = "Trạng thái nghỉ:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1215, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 725);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1215, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 695);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1215, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 695);
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
            // bdsDsNV
            // 
            this.bdsDsNV.DataMember = "sp_DanhSachNhanVien";
            this.bdsDsNV.DataSource = this.ds;
            // 
            // sp_DanhSachNhanVienTableAdapter
            // 
            this.sp_DanhSachNhanVienTableAdapter.ClearBeforeFill = true;
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
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsDsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 30);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1215, 314);
            this.gcNhanVien.TabIndex = 5;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNHANVIEN,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colSDT,
            this.colLUONG,
            this.colCALAMVIEC,
            this.colTRANGTHAINGHI});
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            // 
            // colIDNHANVIEN
            // 
            this.colIDNHANVIEN.Caption = "ID Nhân viên";
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
            this.colTEN.Caption = "Họ và tên";
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
            this.colCMND.Caption = "CMND";
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
            this.colDIACHI.Caption = "Địa chỉ";
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
            this.colSDT.Caption = "SĐT";
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
            this.colLUONG.Caption = "Lương";
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
            this.colCALAMVIEC.Caption = "Ca làm việc";
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
            this.colTRANGTHAINGHI.Caption = "Trạng thái nghỉ";
            this.colTRANGTHAINGHI.FieldName = "TRANGTHAINGHI";
            this.colTRANGTHAINGHI.MinWidth = 25;
            this.colTRANGTHAINGHI.Name = "colTRANGTHAINGHI";
            this.colTRANGTHAINGHI.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAINGHI.Visible = true;
            this.colTRANGTHAINGHI.VisibleIndex = 7;
            this.colTRANGTHAINGHI.Width = 94;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(tRANGTHAINGHILabel);
            this.gcChucNang.Controls.Add(this.chkTrangThaiNghi);
            this.gcChucNang.Controls.Add(cALAMVIECLabel);
            this.gcChucNang.Controls.Add(this.nudCaLamViec);
            this.gcChucNang.Controls.Add(lUONGLabel);
            this.gcChucNang.Controls.Add(this.nudLuong);
            this.gcChucNang.Controls.Add(sDTLabel);
            this.gcChucNang.Controls.Add(this.txtSDT);
            this.gcChucNang.Controls.Add(dIACHILabel);
            this.gcChucNang.Controls.Add(this.txtDiaChi);
            this.gcChucNang.Controls.Add(cMNDLabel);
            this.gcChucNang.Controls.Add(this.txtCMND);
            this.gcChucNang.Controls.Add(tENLabel);
            this.gcChucNang.Controls.Add(this.txtHoTen);
            this.gcChucNang.Controls.Add(iDNHANVIENLabel);
            this.gcChucNang.Controls.Add(this.txtIdNhanVien);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChucNang.Enabled = false;
            this.gcChucNang.Location = new System.Drawing.Point(0, 344);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(1215, 381);
            this.gcChucNang.TabIndex = 10;
            this.gcChucNang.Text = "Nhập liệu";
            // 
            // bdsPhiCong
            // 
            this.bdsPhiCong.DataMember = "FK_PHICONG_NHANVIEN1";
            this.bdsPhiCong.DataSource = this.bdsNhanVien;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "FK_sp_DanhSachNhanVien_NHANVIEN";
            this.bdsNhanVien.DataSource = this.bdsDsNV;
            // 
            // chkTrangThaiNghi
            // 
            this.chkTrangThaiNghi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "TRANGTHAINGHI", true));
            this.chkTrangThaiNghi.Location = new System.Drawing.Point(800, 255);
            this.chkTrangThaiNghi.MenuManager = this.barManager1;
            this.chkTrangThaiNghi.Name = "chkTrangThaiNghi";
            this.chkTrangThaiNghi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThaiNghi.Properties.Appearance.Options.UseFont = true;
            this.chkTrangThaiNghi.Properties.Caption = "";
            this.chkTrangThaiNghi.Size = new System.Drawing.Size(94, 24);
            this.chkTrangThaiNghi.TabIndex = 15;
            // 
            // nudCaLamViec
            // 
            this.nudCaLamViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "CALAMVIEC", true));
            this.nudCaLamViec.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCaLamViec.Location = new System.Drawing.Point(202, 249);
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
            this.nudCaLamViec.Size = new System.Drawing.Size(205, 30);
            this.nudCaLamViec.TabIndex = 13;
            // 
            // nudLuong
            // 
            this.nudLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "LUONG", true));
            this.nudLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLuong.Location = new System.Drawing.Point(659, 185);
            this.nudLuong.MenuManager = this.barManager1;
            this.nudLuong.Name = "nudLuong";
            this.nudLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLuong.Properties.Appearance.Options.UseFont = true;
            this.nudLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudLuong.Properties.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLuong.Properties.IsFloatValue = false;
            this.nudLuong.Properties.MaskSettings.Set("mask", "N00");
            this.nudLuong.Properties.MaxValue = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudLuong.Size = new System.Drawing.Size(297, 30);
            this.nudLuong.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(202, 185);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(205, 30);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(659, 122);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(297, 30);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(202, 122);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Size = new System.Drawing.Size(205, 30);
            this.txtCMND.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "TEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(659, 66);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Size = new System.Drawing.Size(297, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtIdNhanVien
            // 
            this.txtIdNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDsNV, "IDNHANVIEN", true));
            this.txtIdNhanVien.Location = new System.Drawing.Point(202, 66);
            this.txtIdNhanVien.MenuManager = this.barManager1;
            this.txtIdNhanVien.Name = "txtIdNhanVien";
            this.txtIdNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtIdNhanVien.Properties.ReadOnly = true;
            this.txtIdNhanVien.Size = new System.Drawing.Size(205, 30);
            this.txtIdNhanVien.TabIndex = 1;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPhieuBaoTri
            // 
            this.bdsPhieuBaoTri.DataMember = "FK_PHIEUBAOTRI_NHANVIEN1";
            this.bdsPhieuBaoTri.DataSource = this.bdsNhanVien;
            // 
            // pHIEUBAOTRITableAdapter
            // 
            this.pHIEUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // bdsNVBaoTri
            // 
            this.bdsNVBaoTri.DataMember = "FK_CT_NVBAOTRI_NHANVIEN";
            this.bdsNVBaoTri.DataSource = this.bdsNhanVien;
            // 
            // cT_NVBAOTRITableAdapter
            // 
            this.cT_NVBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPhieuBaoTri
            // 
            this.bdsCTPhieuBaoTri.DataMember = "FK_CT_PHIEUBAOTRI_NHANVIEN1";
            this.bdsCTPhieuBaoTri.DataSource = this.bdsNhanVien;
            // 
            // cT_PHIEUBAOTRITableAdapter
            // 
            this.cT_PHIEUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // pHICONGTableAdapter
            // 
            this.pHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 725);
            this.Controls.Add(this.gcChucNang);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            this.gcChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhiCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThaiNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaLamViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuBaoTri)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsDsNV;
        private DS ds;
        private DSTableAdapters.sp_DanhSachNhanVienTableAdapter sp_DanhSachNhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCALAMVIEC;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAINGHI;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraEditors.CheckEdit chkTrangThaiNghi;
        private DevExpress.XtraEditors.SpinEdit nudCaLamViec;
        private DevExpress.XtraEditors.SpinEdit nudLuong;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtIdNhanVien;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuBaoTri;
        private DSTableAdapters.PHIEUBAOTRITableAdapter pHIEUBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bdsNVBaoTri;
        private DSTableAdapters.CT_NVBAOTRITableAdapter cT_NVBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPhieuBaoTri;
        private DSTableAdapters.CT_PHIEUBAOTRITableAdapter cT_PHIEUBAOTRITableAdapter;
        private DSTableAdapters.PHICONGTableAdapter pHICONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhiCong;
    }
}