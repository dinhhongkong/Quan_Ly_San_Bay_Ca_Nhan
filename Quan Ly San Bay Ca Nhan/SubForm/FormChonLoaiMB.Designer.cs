namespace Quan_Ly_May_Bay.SubForm
{
    partial class FormChonLoaiMB
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
            this.dS = new Quan_Ly_May_Bay.DS();
            this.bdsLoaiMB = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcloai = new DevExpress.XtraGrid.GridControl();
            this.gvLoai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcloai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLoaiMB
            // 
            this.bdsLoaiMB.DataMember = "LOAIMAYBAY";
            this.bdsLoaiMB.DataSource = this.dS;
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
            this.tableAdapterManager.CT_BANGLAITableAdapter = null;
            this.tableAdapterManager.CT_CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CT_KHOTableAdapter = null;
            this.tableAdapterManager.CT_NVBAOTRITableAdapter = null;
            this.tableAdapterManager.CT_PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = this.lOAIMAYBAYTableAdapter;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOTRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcloai
            // 
            this.gcloai.DataSource = this.bdsLoaiMB;
            this.gcloai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcloai.Location = new System.Drawing.Point(0, 0);
            this.gcloai.MainView = this.gvLoai;
            this.gcloai.Name = "gcloai";
            this.gcloai.Size = new System.Drawing.Size(831, 475);
            this.gcloai.TabIndex = 1;
            this.gcloai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoai});
            // 
            // gvLoai
            // 
            this.gvLoai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLOAI,
            this.colTENLOAI});
            this.gvLoai.GridControl = this.gcloai;
            this.gvLoai.Name = "gvLoai";
            this.gvLoai.OptionsView.ShowViewCaption = true;
            this.gvLoai.ViewCaption = "Vui lòng chọn một loại máy bay";
            this.gvLoai.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvLoai_RowCellClick);
            // 
            // colIDLOAI
            // 
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
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 25;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.OptionsColumn.AllowEdit = false;
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            this.colTENLOAI.Width = 94;
            // 
            // FormChonLoaiMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 475);
            this.Controls.Add(this.gcloai);
            this.Name = "FormChonLoaiMB";
            this.Text = "Chọn ID loại máy bay";
            this.Load += new System.EventHandler(this.FormChonLoaiMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcloai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsLoaiMB;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcloai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
    }
}