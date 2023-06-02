namespace Quan_Ly_May_Bay
{
    partial class FormLoaiMayBay
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
            System.Windows.Forms.Label iDLOAILabel;
            System.Windows.Forms.Label tENLOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiMayBay));
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
            this.bdsLoaiMB = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.cT_BANGLAITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_BANGLAITableAdapter();
            this.cT_NVBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_NVBAOTRITableAdapter();
            this.mAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.MAYBAYTableAdapter();
            this.gcLoaiMB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtIDLoai = new DevExpress.XtraEditors.TextEdit();
            this.bdsMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNVBaoTri = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTBangLai = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            iDLOAILabel = new System.Windows.Forms.Label();
            tENLOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNVBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBangLai)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLOAILabel
            // 
            iDLOAILabel.AutoSize = true;
            iDLOAILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLOAILabel.Location = new System.Drawing.Point(59, 109);
            iDLOAILabel.Name = "iDLOAILabel";
            iDLOAILabel.Size = new System.Drawing.Size(158, 24);
            iDLOAILabel.TabIndex = 0;
            iDLOAILabel.Text = "ID loại máy bay:";
            // 
            // tENLOAILabel
            // 
            tENLOAILabel.AutoSize = true;
            tENLOAILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOAILabel.Location = new System.Drawing.Point(585, 106);
            tENLOAILabel.Name = "tENLOAILabel";
            tENLOAILabel.Size = new System.Drawing.Size(171, 24);
            tENLOAILabel.TabIndex = 2;
            tENLOAILabel.Text = "Tên loại máy bay:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1109, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 759);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1109, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 729);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1109, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 729);
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
            // bdsLoaiMB
            // 
            this.bdsLoaiMB.DataMember = "LOAIMAYBAY";
            this.bdsLoaiMB.DataSource = this.ds;
            // 
            // lOAIMAYBAYTableAdapter
            // 
            this.lOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CANHANTableAdapter = null;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_BANGLAITableAdapter = this.cT_BANGLAITableAdapter;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = null;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = this.cT_NVBAOTRITableAdapter;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = this.lOAIMAYBAYTableAdapter;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_BANGLAITableAdapter
            // 
            this.cT_BANGLAITableAdapter.ClearBeforeFill = true;
            // 
            // cT_NVBAOTRITableAdapter
            // 
            this.cT_NVBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // gcLoaiMB
            // 
            this.gcLoaiMB.DataSource = this.bdsLoaiMB;
            this.gcLoaiMB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLoaiMB.Location = new System.Drawing.Point(0, 30);
            this.gcLoaiMB.MainView = this.gridView1;
            this.gcLoaiMB.MenuManager = this.barManager1;
            this.gcLoaiMB.Name = "gcLoaiMB";
            this.gcLoaiMB.Size = new System.Drawing.Size(1109, 351);
            this.gcLoaiMB.TabIndex = 5;
            this.gcLoaiMB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLOAI,
            this.colTENLOAI});
            this.gridView1.GridControl = this.gcLoaiMB;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách loại máy bay";
            // 
            // colIDLOAI
            // 
            this.colIDLOAI.Caption = "ID loại máy bay";
            this.colIDLOAI.FieldName = "IDLOAI";
            this.colIDLOAI.MinWidth = 25;
            this.colIDLOAI.Name = "colIDLOAI";
            this.colIDLOAI.OptionsColumn.AllowEdit = false;
            this.colIDLOAI.Visible = true;
            this.colIDLOAI.VisibleIndex = 0;
            this.colIDLOAI.Width = 94;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại máy bay";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 25;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.OptionsColumn.AllowEdit = false;
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            this.colTENLOAI.Width = 94;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(tENLOAILabel);
            this.gcChucNang.Controls.Add(this.txtTenLoai);
            this.gcChucNang.Controls.Add(iDLOAILabel);
            this.gcChucNang.Controls.Add(this.txtIDLoai);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChucNang.Enabled = false;
            this.gcChucNang.Location = new System.Drawing.Point(0, 381);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(1109, 378);
            this.gcChucNang.TabIndex = 6;
            this.gcChucNang.Text = "Nhập liệu";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLoaiMB, "TENLOAI", true));
            this.txtTenLoai.Location = new System.Drawing.Point(787, 103);
            this.txtTenLoai.MenuManager = this.barManager1;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoai.Size = new System.Drawing.Size(298, 30);
            this.txtTenLoai.TabIndex = 3;
            // 
            // txtIDLoai
            // 
            this.txtIDLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLoaiMB, "IDLOAI", true));
            this.txtIDLoai.Location = new System.Drawing.Point(223, 106);
            this.txtIDLoai.MenuManager = this.barManager1;
            this.txtIDLoai.Name = "txtIDLoai";
            this.txtIDLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLoai.Properties.Appearance.Options.UseFont = true;
            this.txtIDLoai.Size = new System.Drawing.Size(201, 30);
            this.txtIDLoai.TabIndex = 1;
            // 
            // bdsMayBay
            // 
            this.bdsMayBay.DataMember = "FK_MAYBAY_LOAIMAYBAY";
            this.bdsMayBay.DataSource = this.bdsLoaiMB;
            // 
            // bdsNVBaoTri
            // 
            this.bdsNVBaoTri.DataMember = "FK_CT_NVBAOTRI_LOAIMAYBAY";
            this.bdsNVBaoTri.DataSource = this.bdsLoaiMB;
            // 
            // bdsCTBangLai
            // 
            this.bdsCTBangLai.DataMember = "FK_CT_BANGLAI_LOAIMAYBAY";
            this.bdsCTBangLai.DataSource = this.bdsLoaiMB;
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
            // FormLoaiMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 759);
            this.Controls.Add(this.gcChucNang);
            this.Controls.Add(this.gcLoaiMB);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLoaiMayBay";
            this.Text = "Quản lý loại máy bay";
            this.Load += new System.EventHandler(this.FormLoaiMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            this.gcChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNVBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBangLai)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsLoaiMB;
        private DS ds;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.TextEdit txtIDLoai;
        private DevExpress.XtraGrid.GridControl gcLoaiMB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMayBay;
        private DSTableAdapters.CT_NVBAOTRITableAdapter cT_NVBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bdsNVBaoTri;
        private DSTableAdapters.CT_BANGLAITableAdapter cT_BANGLAITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTBangLai;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
    }
}