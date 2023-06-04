namespace Quan_Ly_May_Bay.SubForm
{
    partial class FormDSNhanVien
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
            this.DS = new Quan_Ly_May_Bay.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachNhanVienTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachNhanVienTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.sp_DanhSachNhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNGUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALAMVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAINGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachNhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "sp_DanhSachNhanVien";
            this.bdsNhanVien.DataSource = this.DS;
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
            // sp_DanhSachNhanVienGridControl
            // 
            this.sp_DanhSachNhanVienGridControl.DataSource = this.bdsNhanVien;
            this.sp_DanhSachNhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_DanhSachNhanVienGridControl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sp_DanhSachNhanVienGridControl.Location = new System.Drawing.Point(0, 0);
            this.sp_DanhSachNhanVienGridControl.MainView = this.gridView1;
            this.sp_DanhSachNhanVienGridControl.Name = "sp_DanhSachNhanVienGridControl";
            this.sp_DanhSachNhanVienGridControl.Size = new System.Drawing.Size(1002, 525);
            this.sp_DanhSachNhanVienGridControl.TabIndex = 1;
            this.sp_DanhSachNhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNHANVIEN,
            this.colIDNGUOI,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colSDT,
            this.colLUONG,
            this.colCALAMVIEC,
            this.colTRANGTHAINGHI});
            this.gridView1.GridControl = this.sp_DanhSachNhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách nhân viên";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewNhanVien_RowCellClick);
            // 
            // colIDNHANVIEN
            // 
            this.colIDNHANVIEN.FieldName = "IDNHANVIEN";
            this.colIDNHANVIEN.Name = "colIDNHANVIEN";
            this.colIDNHANVIEN.Visible = true;
            this.colIDNHANVIEN.VisibleIndex = 0;
            // 
            // colIDNGUOI
            // 
            this.colIDNGUOI.FieldName = "IDNGUOI";
            this.colIDNGUOI.Name = "colIDNGUOI";
            this.colIDNGUOI.Visible = true;
            this.colIDNGUOI.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 5;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            // 
            // colCALAMVIEC
            // 
            this.colCALAMVIEC.FieldName = "CALAMVIEC";
            this.colCALAMVIEC.Name = "colCALAMVIEC";
            this.colCALAMVIEC.Visible = true;
            this.colCALAMVIEC.VisibleIndex = 7;
            // 
            // colTRANGTHAINGHI
            // 
            this.colTRANGTHAINGHI.FieldName = "TRANGTHAINGHI";
            this.colTRANGTHAINGHI.Name = "colTRANGTHAINGHI";
            this.colTRANGTHAINGHI.Visible = true;
            this.colTRANGTHAINGHI.VisibleIndex = 8;
            // 
            // FormDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 525);
            this.Controls.Add(this.sp_DanhSachNhanVienGridControl);
            this.Name = "FormDSNhanVien";
            this.Text = "FormDSNhanVien";
            this.Load += new System.EventHandler(this.FormDSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachNhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DSTableAdapters.sp_DanhSachNhanVienTableAdapter sp_DanhSachNhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_DanhSachNhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNGUOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCALAMVIEC;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAINGHI;
    }
}