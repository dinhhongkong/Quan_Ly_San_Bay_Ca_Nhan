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
            this.panelTaoTK.Location = new System.Drawing.Point(47, 336);
            this.panelTaoTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTaoTK.Name = "panelTaoTK";
            this.panelTaoTK.Size = new System.Drawing.Size(538, 313);
            this.panelTaoTK.TabIndex = 0;
            // 
            // btnChonNV
            // 
            this.btnChonNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChonNV.Location = new System.Drawing.Point(348, 91);
            this.btnChonNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(170, 50);
            this.btnChonNV.TabIndex = 10;
            this.btnChonNV.Text = "Chọn nhân viên";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIDNhanVien.Location = new System.Drawing.Point(176, 101);
            this.txtIDNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(164, 32);
            this.txtIDNhanVien.TabIndex = 9;
            this.txtIDNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNhanVien_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(37, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã nhân viên:";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTaoTK.Location = new System.Drawing.Point(99, 241);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(194, 49);
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
            this.CBRole.Location = new System.Drawing.Point(150, 60);
            this.CBRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(193, 32);
            this.CBRole.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(36, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quyền hạn:";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPwd.Location = new System.Drawing.Point(176, 185);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(164, 32);
            this.txtPwd.TabIndex = 4;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUID.Location = new System.Drawing.Point(176, 142);
            this.txtUID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(164, 32);
            this.txtUID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(36, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
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
            this.panelHieuChinh.Location = new System.Drawing.Point(47, 15);
            this.panelHieuChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHieuChinh.Name = "panelHieuChinh";
            this.panelHieuChinh.Size = new System.Drawing.Size(538, 314);
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
            this.CBCurrRole.Location = new System.Drawing.Point(162, 53);
            this.CBCurrRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBCurrRole.Name = "CBCurrRole";
            this.CBCurrRole.Size = new System.Drawing.Size(193, 32);
            this.CBCurrRole.TabIndex = 18;
            // 
            // txtCurrUID
            // 
            this.txtCurrUID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSTK, "TenDangNhap", true));
            this.txtCurrUID.Location = new System.Drawing.Point(191, 135);
            this.txtCurrUID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrUID.Name = "txtCurrUID";
            this.txtCurrUID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrUID.Properties.Appearance.Options.UseFont = true;
            this.txtCurrUID.Size = new System.Drawing.Size(164, 30);
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
            this.btnXoa.Location = new System.Drawing.Point(282, 233);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(194, 50);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtCurrIDNhanVien
            // 
            this.txtCurrIDNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSTK, "MaNhanVien", true));
            this.txtCurrIDNhanVien.Location = new System.Drawing.Point(191, 96);
            this.txtCurrIDNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrIDNhanVien.Name = "txtCurrIDNhanVien";
            this.txtCurrIDNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrIDNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtCurrIDNhanVien.Size = new System.Drawing.Size(164, 30);
            this.txtCurrIDNhanVien.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(52, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(51, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quyền hạn:";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHieuChinh.Location = new System.Drawing.Point(56, 233);
            this.btnHieuChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.Size = new System.Drawing.Size(194, 49);
            this.btnHieuChinh.TabIndex = 9;
            this.btnHieuChinh.Text = "Hiệu chỉnh";
            this.btnHieuChinh.UseVisualStyleBackColor = true;
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // txtCurrPwd
            // 
            this.txtCurrPwd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCurrPwd.Location = new System.Drawing.Point(191, 178);
            this.txtCurrPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrPwd.Name = "txtCurrPwd";
            this.txtCurrPwd.PasswordChar = '*';
            this.txtCurrPwd.Size = new System.Drawing.Size(164, 32);
            this.txtCurrPwd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(51, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(48, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên đăng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
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
            this.gcDSTK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDSTK.Location = new System.Drawing.Point(592, 15);
            this.gcDSTK.MainView = this.gridView1;
            this.gcDSTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDSTK.Name = "gcDSTK";
            this.gcDSTK.Size = new System.Drawing.Size(498, 634);
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
            this.gridView1.DetailHeight = 431;
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
            this.colTenDangNhap.MinWidth = 23;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            this.colTenDangNhap.Width = 87;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 23;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 1;
            this.colMaNhanVien.Width = 87;
            // 
            // colQuyen
            // 
            this.colQuyen.Caption = "Quyền hạn";
            this.colQuyen.FieldName = "Quyen";
            this.colQuyen.MinWidth = 23;
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Visible = true;
            this.colQuyen.VisibleIndex = 2;
            this.colQuyen.Width = 87;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReload.Location = new System.Drawing.Point(1097, 49);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(88, 46);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 737);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.gcDSTK);
            this.Controls.Add(this.panelHieuChinh);
            this.Controls.Add(this.panelTaoTK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}