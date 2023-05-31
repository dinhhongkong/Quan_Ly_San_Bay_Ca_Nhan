namespace Quan_Ly_May_Bay.SubForm
{
    partial class FormLocMayBaySoHuu
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
            this.bdsDSCHUMAYBAY = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DanhSachChuMayBayTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.sp_DanhSachChuMayBayTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcDSCHUMAYBAY = new DevExpress.XtraGrid.GridControl();
            this.gvDSCHUMAYBAY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOWNER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSCHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCHUMAYBAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCHUMAYBAY)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSCHUMAYBAY
            // 
            this.bdsDSCHUMAYBAY.DataMember = "sp_DanhSachChuMayBay";
            this.bdsDSCHUMAYBAY.DataSource = this.DS;
            // 
            // sp_DanhSachChuMayBayTableAdapter
            // 
            this.sp_DanhSachChuMayBayTableAdapter.ClearBeforeFill = true;
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
            // gcDSCHUMAYBAY
            // 
            this.gcDSCHUMAYBAY.DataSource = this.bdsDSCHUMAYBAY;
            this.gcDSCHUMAYBAY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSCHUMAYBAY.Location = new System.Drawing.Point(0, 0);
            this.gcDSCHUMAYBAY.MainView = this.gvDSCHUMAYBAY;
            this.gcDSCHUMAYBAY.Name = "gcDSCHUMAYBAY";
            this.gcDSCHUMAYBAY.Size = new System.Drawing.Size(964, 472);
            this.gcDSCHUMAYBAY.TabIndex = 1;
            this.gcDSCHUMAYBAY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSCHUMAYBAY});
            // 
            // gvDSCHUMAYBAY
            // 
            this.gvDSCHUMAYBAY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY,
            this.colTENLOAI,
            this.colOWNER_ID,
            this.colNGAYBATDAU});
            this.gvDSCHUMAYBAY.GridControl = this.gcDSCHUMAYBAY;
            this.gvDSCHUMAYBAY.Name = "gvDSCHUMAYBAY";
            this.gvDSCHUMAYBAY.OptionsView.ShowViewCaption = true;
            this.gvDSCHUMAYBAY.ViewCaption = "Vui lòng chọn máy bay";
            this.gvDSCHUMAYBAY.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDSCHUMAYBAY_RowCellClick);
            this.gvDSCHUMAYBAY.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gvDSCHUMAYBAY_CustomRowFilter);
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.Caption = "Mã máy bay";
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 0;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại máy bay";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            // 
            // colOWNER_ID
            // 
            this.colOWNER_ID.Caption = "Tên chủ sở hữu";
            this.colOWNER_ID.FieldName = "OWNER_ID";
            this.colOWNER_ID.Name = "colOWNER_ID";
            this.colOWNER_ID.Visible = true;
            this.colOWNER_ID.VisibleIndex = 2;
            // 
            // colNGAYBATDAU
            // 
            this.colNGAYBATDAU.Caption = "Ngày sở hữu";
            this.colNGAYBATDAU.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.colNGAYBATDAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYBATDAU.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU.Name = "colNGAYBATDAU";
            this.colNGAYBATDAU.Visible = true;
            this.colNGAYBATDAU.VisibleIndex = 3;
            // 
            // FormLocMayBaySoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 472);
            this.Controls.Add(this.gcDSCHUMAYBAY);
            this.Name = "FormLocMayBaySoHuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLocMayBaySoHuu";
            this.Load += new System.EventHandler(this.FormLocMayBaySoHuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSCHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCHUMAYBAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCHUMAYBAY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSCHUMAYBAY;
        private DSTableAdapters.sp_DanhSachChuMayBayTableAdapter sp_DanhSachChuMayBayTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSCHUMAYBAY;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSCHUMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colOWNER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU;
    }
}