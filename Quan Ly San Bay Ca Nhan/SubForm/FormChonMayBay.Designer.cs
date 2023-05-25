namespace Quan_Ly_May_Bay.SubForm
{
    partial class FormChonMayBay
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
            this.ds = new Quan_Ly_May_Bay.DS();
            this.bdsMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.mAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.MAYBAYTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.mAYBAYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvMayBay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMAYBAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bdsLoaiMB = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = null;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAYBAYGridControl
            // 
            this.mAYBAYGridControl.DataSource = this.bdsMayBay;
            this.mAYBAYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mAYBAYGridControl.Location = new System.Drawing.Point(0, 0);
            this.mAYBAYGridControl.MainView = this.gvMayBay;
            this.mAYBAYGridControl.Name = "mAYBAYGridControl";
            this.mAYBAYGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.mAYBAYGridControl.Size = new System.Drawing.Size(809, 494);
            this.mAYBAYGridControl.TabIndex = 1;
            this.mAYBAYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMayBay});
            // 
            // gvMayBay
            // 
            this.gvMayBay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMAYBAY,
            this.colIDLOAI});
            this.gvMayBay.GridControl = this.mAYBAYGridControl;
            this.gvMayBay.Name = "gvMayBay";
            this.gvMayBay.OptionsView.ShowViewCaption = true;
            this.gvMayBay.ViewCaption = "Vui lòng chọn một máy bay";
            this.gvMayBay.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvMayBay_RowCellClick);
            // 
            // colIDMAYBAY
            // 
            this.colIDMAYBAY.Caption = "ID máy bay";
            this.colIDMAYBAY.FieldName = "IDMAYBAY";
            this.colIDMAYBAY.MinWidth = 25;
            this.colIDMAYBAY.Name = "colIDMAYBAY";
            this.colIDMAYBAY.OptionsColumn.AllowEdit = false;
            this.colIDMAYBAY.Visible = true;
            this.colIDMAYBAY.VisibleIndex = 0;
            this.colIDMAYBAY.Width = 94;
            // 
            // colIDLOAI
            // 
            this.colIDLOAI.Caption = "Loại máy bay";
            this.colIDLOAI.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDLOAI.FieldName = "IDLOAI";
            this.colIDLOAI.MinWidth = 25;
            this.colIDLOAI.Name = "colIDLOAI";
            this.colIDLOAI.OptionsColumn.AllowEdit = false;
            this.colIDLOAI.Visible = true;
            this.colIDLOAI.VisibleIndex = 1;
            this.colIDLOAI.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            // FormChonMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 494);
            this.Controls.Add(this.mAYBAYGridControl);
            this.Name = "FormChonMayBay";
            this.Text = "Vui lòng chọn một máy bay";
            this.Load += new System.EventHandler(this.FormChonMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYBAYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS ds;
        private System.Windows.Forms.BindingSource bdsMayBay;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mAYBAYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMayBay;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMAYBAY;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bdsLoaiMB;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
    }
}