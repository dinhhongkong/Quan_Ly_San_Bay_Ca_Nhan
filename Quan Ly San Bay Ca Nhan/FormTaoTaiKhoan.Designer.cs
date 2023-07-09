namespace Quan_Ly_May_Bay
{
    partial class FormTaoTaiKhoan
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
            this.panelTaoTK = new DevExpress.XtraEditors.PanelControl();
            this.btnChonNV = new System.Windows.Forms.Button();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.CBRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHieuChinh = new DevExpress.XtraEditors.PanelControl();
            this.CBCurrRole = new System.Windows.Forms.ComboBox();
            this.txtCurrUID = new DevExpress.XtraEditors.TextEdit();
            this.bdsDSTK = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Quan_Ly_May_Bay.DS();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtCurrIDNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHieuChinh = new System.Windows.Forms.Button();
            this.txtCurrPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.v_DanhSachTaiKhoanTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.V_DanhSachTaiKhoanTableAdapter();
            this.tableAdapterManager = new Quan_Ly_May_Bay.DSTableAdapters.TableAdapterManager();
            this.gcDSTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.bdsNhanvien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new Quan_Ly_May_Bay.DSTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelTaoTK)).BeginInit();
            this.panelTaoTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHieuChinh)).BeginInit();
            this.panelHieuChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrUID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrIDNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaoTK
            // 
            this.panelTaoTK.Controls.Add(this.btnChonNV);
            this.panelTaoTK.Controls.Add(this.txtIDNhanVien);
            this.panelTaoTK.Controls.Add(this.label10);
            this.panelTaoTK.Controls.Add(this.btnTaoTK);
            this.panelTaoTK.Controls.Add(this.CBRole);
            this.panelTaoTK.Controls.Add(this.label4);
            this.panelTaoTK.Controls.Add(this.txtPwd);
            this.panelTaoTK.Controls.Add(this.txtUID);
            this.panelTaoTK.Controls.Add(this.label3);
            this.panelTaoTK.Controls.Add(this.label2);
            this.panelTaoTK.Controls.Add(this.label1);
            this.panelTaoTK.Location = new System.Drawing.Point(40, 273);
            this.panelTaoTK.Name = "panelTaoTK";
            this.panelTaoTK.Size = new System.Drawing.Size(461, 254);
            this.panelTaoTK.TabIndex = 0;
            // 
            // btnChonNV
            // 
            this.btnChonNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChonNV.Location = new System.Drawing.Point(298, 74);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(146, 41);
            this.btnChonNV.TabIndex = 10;
            this.btnChonNV.Text = "Chọn nhân viên";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIDNhanVien.Location = new System.Drawing.Point(151, 82);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(141, 27);
            this.txtIDNhanVien.TabIndex = 9;
            this.txtIDNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNhanVien_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(32, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã nhân viên:";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTaoTK.Location = new System.Drawing.Point(85, 196);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(166, 40);
            this.btnTaoTK.TabIndex = 7;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // CBRole
            // 
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CBRole.FormattingEnabled = true;
            this.CBRole.Items.AddRange(new object[] {
            "MANAGER",
            "NVBAOTRI"});
            this.CBRole.Location = new System.Drawing.Point(129, 49);
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(166, 27);
            this.CBRole.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(31, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quyền hạn:";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPwd.Location = new System.Drawing.Point(151, 150);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(141, 27);
            this.txtPwd.TabIndex = 4;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUID.Location = new System.Drawing.Point(151, 115);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(141, 27);
            this.txtUID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // panelHieuChinh
            // 
            this.panelHieuChinh.Controls.Add(this.CBCurrRole);
            this.panelHieuChinh.Controls.Add(this.txtCurrUID);
            this.panelHieuChinh.Controls.Add(this.btnXoa);
            this.panelHieuChinh.Controls.Add(this.txtCurrIDNhanVien);
            this.panelHieuChinh.Controls.Add(this.label9);
            this.panelHieuChinh.Controls.Add(this.label8);
            this.panelHieuChinh.Controls.Add(this.btnHieuChinh);
            this.panelHieuChinh.Controls.Add(this.txtCurrPwd);
            this.panelHieuChinh.Controls.Add(this.label6);
            this.panelHieuChinh.Controls.Add(this.label7);
            this.panelHieuChinh.Controls.Add(this.label5);
            this.panelHieuChinh.Location = new System.Drawing.Point(40, 12);
            this.panelHieuChinh.Name = "panelHieuChinh";
            this.panelHieuChinh.Size = new System.Drawing.Size(461, 255);
            this.panelHieuChinh.TabIndex = 3;
            // 
            // CBCurrRole
            // 
            this.CBCurrRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurrRole.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CBCurrRole.FormattingEnabled = true;
            this.CBCurrRole.Items.AddRange(new object[] {
            "MANAGER",
            "NVBAOTRI"});
            this.CBCurrRole.Location = new System.Drawing.Point(139, 43);
            this.CBCurrRole.Name = "CBCurrRole";
            this.CBCurrRole.Size = new System.Drawing.Size(166, 27);
            this.CBCurrRole.TabIndex = 18;
            // 
            // txtCurrUID
            // 
            this.txtCurrUID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSTK, "TenDangNhap", true));
            this.txtCurrUID.Location = new System.Drawing.Point(164, 110);
            this.txtCurrUID.Name = "txtCurrUID";
            this.txtCurrUID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrUID.Properties.Appearance.Options.UseFont = true;
            this.txtCurrUID.Size = new System.Drawing.Size(141, 26);
            this.txtCurrUID.TabIndex = 17;
            // 
            // bdsDSTK
            // 
            this.bdsDSTK.DataMember = "V_DanhSachTaiKhoan";
            this.bdsDSTK.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnXoa.Location = new System.Drawing.Point(242, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 41);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtCurrIDNhanVien
            // 
            this.txtCurrIDNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSTK, "MaNhanVien", true));
            this.txtCurrIDNhanVien.Location = new System.Drawing.Point(164, 78);
            this.txtCurrIDNhanVien.Name = "txtCurrIDNhanVien";
            this.txtCurrIDNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrIDNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtCurrIDNhanVien.Size = new System.Drawing.Size(141, 26);
            this.txtCurrIDNhanVien.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(45, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(44, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quyền hạn:";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHieuChinh.Location = new System.Drawing.Point(48, 189);
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.Size = new System.Drawing.Size(166, 40);
            this.btnHieuChinh.TabIndex = 9;
            this.btnHieuChinh.Text = "Hiệu chỉnh";
            this.btnHieuChinh.UseVisualStyleBackColor = true;
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // txtCurrPwd
            // 
            this.txtCurrPwd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrPwd.Location = new System.Drawing.Point(164, 145);
            this.txtCurrPwd.Name = "txtCurrPwd";
            this.txtCurrPwd.PasswordChar = '*';
            this.txtCurrPwd.Size = new System.Drawing.Size(141, 27);
            this.txtCurrPwd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(44, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(41, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên đăng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hiệu chỉnh tài khoản";
            // 
            // v_DanhSachTaiKhoanTableAdapter
            // 
            this.v_DanhSachTaiKhoanTableAdapter.ClearBeforeFill = true;
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
            // gcDSTK
            // 
            this.gcDSTK.DataSource = this.bdsDSTK;
            this.gcDSTK.Location = new System.Drawing.Point(507, 12);
            this.gcDSTK.MainView = this.gridView1;
            this.gcDSTK.Name = "gcDSTK";
            this.gcDSTK.Size = new System.Drawing.Size(504, 515);
            this.gcDSTK.TabIndex = 3;
            this.gcDSTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDSTK.Click += new System.EventHandler(this.gcDSTK_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMaNhanVien,
            this.colQuyen});
            this.gridView1.GridControl = this.gcDSTK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách tài khoản";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên đăng nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 1;
            // 
            // colQuyen
            // 
            this.colQuyen.Caption = "Quyền hạn";
            this.colQuyen.FieldName = "Quyen";
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Visible = true;
            this.colQuyen.VisibleIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReload.Location = new System.Drawing.Point(1017, 40);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 37);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // bdsNhanvien
            // 
            this.bdsNhanvien.DataMember = "NHANVIEN";
            this.bdsNhanvien.DataSource = this.DS;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 550);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.gcDSTK);
            this.Controls.Add(this.panelHieuChinh);
            this.Controls.Add(this.panelTaoTK);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTaoTK)).EndInit();
            this.panelTaoTK.ResumeLayout(false);
            this.panelTaoTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHieuChinh)).EndInit();
            this.panelHieuChinh.ResumeLayout(false);
            this.panelHieuChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrUID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrIDNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTaoTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Button btnTaoTK;
        private DevExpress.XtraEditors.PanelControl panelHieuChinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHieuChinh;
        private System.Windows.Forms.TextBox txtCurrPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChonNV;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label label10;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSTK;
        private DSTableAdapters.V_DanhSachTaiKhoanTableAdapter v_DanhSachTaiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyen;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtCurrIDNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraEditors.TextEdit txtCurrUID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox CBCurrRole;
        private System.Windows.Forms.BindingSource bdsNhanvien;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}