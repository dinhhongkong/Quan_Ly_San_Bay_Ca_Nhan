namespace Quan_Ly_May_Bay
{
    partial class FormMayBay
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
            System.Windows.Forms.Label iDMAYBAYLabel;
            System.Windows.Forms.Label iDLOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMayBay));
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
            this.bdsMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.mAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.MAYBAYTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.cT_CHUMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_CHUMAYBAYTableAdapter();
            this.cT_KHOTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.CT_KHOTableAdapter();
            this.pHIEUBAOTRITableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.PHIEUBAOTRITableAdapter();
            this.pHIEUBAOTRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTKho = new System.Windows.Forms.BindingSource(this.components);
            this.bdsChuMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLoaiMB = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.txtIdMayBay = new DevExpress.XtraEditors.TextEdit();
            this.txtLoai = new DevExpress.XtraEditors.ButtonEdit();
            this.pcChucNang = new DevExpress.XtraEditors.PanelControl();
            this.gcMayBay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            iDMAYBAYLabel = new System.Windows.Forms.Label();
            iDLOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUBAOTRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMayBay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChucNang)).BeginInit();
            this.pcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // iDMAYBAYLabel
            // 
            iDMAYBAYLabel.AutoSize = true;
            iDMAYBAYLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDMAYBAYLabel.Location = new System.Drawing.Point(81, 74);
            iDMAYBAYLabel.Name = "iDMAYBAYLabel";
            iDMAYBAYLabel.Size = new System.Drawing.Size(119, 24);
            iDMAYBAYLabel.TabIndex = 0;
            iDMAYBAYLabel.Text = "ID Máy Bay:";
            // 
            // iDLOAILabel
            // 
            iDLOAILabel.AutoSize = true;
            iDLOAILabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLOAILabel.Location = new System.Drawing.Point(409, 74);
            iDLOAILabel.Name = "iDLOAILabel";
            iDLOAILabel.Size = new System.Drawing.Size(163, 24);
            iDLOAILabel.TabIndex = 2;
            iDLOAILabel.Text = "ID Loại máy bay:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1104, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1104, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1104, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
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
            // bdsMayBay
            // 
            this.bdsMayBay.DataMember = "MAYBAY";
            this.bdsMayBay.DataSource = this.ds;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CANHANTableAdapter = null;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_BANGLAITableAdapter = null;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = this.cT_CHUMAYBAYTableAdapter;
            this.tableAdapterManager.CT_KHOTableAdapter = this.cT_KHOTableAdapter;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = this.pHIEUBAOTRITableAdapter;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_CHUMAYBAYTableAdapter
            // 
            this.cT_CHUMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // cT_KHOTableAdapter
            // 
            this.cT_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUBAOTRITableAdapter
            // 
            this.pHIEUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUBAOTRIBindingSource
            // 
            this.pHIEUBAOTRIBindingSource.DataMember = "FK_PHIEUBAOTRI_MAYBAY";
            this.pHIEUBAOTRIBindingSource.DataSource = this.bdsMayBay;
            // 
            // bdsCTKho
            // 
            this.bdsCTKho.DataMember = "FK_CT_KHO_MAYBAY";
            this.bdsCTKho.DataSource = this.bdsMayBay;
            // 
            // bdsChuMayBay
            // 
            this.bdsChuMayBay.DataMember = "FK_CT_CHUMAYBAY_MAYBAY";
            this.bdsChuMayBay.DataSource = this.bdsMayBay;
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
            // txtIdMayBay
            // 
            this.txtIdMayBay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMayBay, "IDMAYBAY", true));
            this.txtIdMayBay.Location = new System.Drawing.Point(206, 68);
            this.txtIdMayBay.MenuManager = this.barManager1;
            this.txtIdMayBay.Name = "txtIdMayBay";
            this.txtIdMayBay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMayBay.Properties.Appearance.Options.UseFont = true;
            this.txtIdMayBay.Size = new System.Drawing.Size(125, 30);
            this.txtIdMayBay.TabIndex = 1;
            // 
            // txtLoai
            // 
            this.txtLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMayBay, "IDLOAI", true));
            this.txtLoai.Location = new System.Drawing.Point(599, 71);
            this.txtLoai.MenuManager = this.barManager1;
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoai.Properties.Appearance.Options.UseFont = true;
            this.txtLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtLoai.Properties.ReadOnly = true;
            this.txtLoai.Size = new System.Drawing.Size(150, 30);
            this.txtLoai.TabIndex = 3;
            this.txtLoai.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLoai_ButtonClick);
            // 
            // pcChucNang
            // 
            this.pcChucNang.Controls.Add(iDLOAILabel);
            this.pcChucNang.Controls.Add(this.txtLoai);
            this.pcChucNang.Controls.Add(iDMAYBAYLabel);
            this.pcChucNang.Controls.Add(this.txtIdMayBay);
            this.pcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcChucNang.Enabled = false;
            this.pcChucNang.Location = new System.Drawing.Point(0, 423);
            this.pcChucNang.Name = "pcChucNang";
            this.pcChucNang.Size = new System.Drawing.Size(1104, 157);
            this.pcChucNang.TabIndex = 6;
            // 
            // gcMayBay
            // 
            this.gcMayBay.DataSource = this.bdsMayBay;
            this.gcMayBay.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMayBay.Location = new System.Drawing.Point(0, 30);
            this.gcMayBay.MainView = this.gridView1;
            this.gcMayBay.MenuManager = this.barManager1;
            this.gcMayBay.Name = "gcMayBay";
            this.gcMayBay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit});
            this.gcMayBay.Size = new System.Drawing.Size(1104, 393);
            this.gcMayBay.TabIndex = 10;
            this.gcMayBay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colIDLOAI});
            this.gridView1.GridControl = this.gcMayBay;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách máy bay";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID máy bay";
            this.gridColumn1.FieldName = "IDMAYBAY";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // colIDLOAI
            // 
            this.colIDLOAI.Caption = "Loại máy bay";
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
            // FormMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 580);
            this.Controls.Add(this.pcChucNang);
            this.Controls.Add(this.gcMayBay);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMayBay";
            this.Text = " Quản lý máy bay";
            this.Load += new System.EventHandler(this.FormMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUBAOTRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChuMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMayBay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChucNang)).EndInit();
            this.pcChucNang.ResumeLayout(false);
            this.pcChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMayBay;
        private DS ds;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.PHIEUBAOTRITableAdapter pHIEUBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource pHIEUBAOTRIBindingSource;
        private DSTableAdapters.CT_KHOTableAdapter cT_KHOTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTKho;
        private DSTableAdapters.CT_CHUMAYBAYTableAdapter cT_CHUMAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsChuMayBay;
        private System.Windows.Forms.BindingSource bdsLoaiMB;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private DevExpress.XtraEditors.PanelControl pcChucNang;
        private DevExpress.XtraEditors.ButtonEdit txtLoai;
        private DevExpress.XtraEditors.TextEdit txtIdMayBay;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.GridControl gcMayBay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
    }
}