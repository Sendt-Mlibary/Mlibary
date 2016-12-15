namespace ManageLibrary.UserControls
{
    partial class ucManagerMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManagerMember));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grcBanDoc = new DevExpress.XtraGrid.GridControl();
            this.grvBanDoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbbSearchType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bntBooksManager = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.srcSearchMember = new DevExpress.XtraEditors.SearchControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bntReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBanDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBanDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSearchType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcSearchMember.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(660, 453);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lí Bạn đọc";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grcBanDoc);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 114);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(656, 337);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách bạn đọc";
            // 
            // grcBanDoc
            // 
            this.grcBanDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBanDoc.Location = new System.Drawing.Point(2, 20);
            this.grcBanDoc.MainView = this.grvBanDoc;
            this.grcBanDoc.Name = "grcBanDoc";
            this.grcBanDoc.Size = new System.Drawing.Size(652, 315);
            this.grcBanDoc.TabIndex = 0;
            this.grcBanDoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBanDoc});
            // 
            // grvBanDoc
            // 
            this.grvBanDoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.HoTen,
            this.Email,
            this.DiaChi,
            this.NamSinh,
            this.SoDienThoai});
            this.grvBanDoc.GridControl = this.grcBanDoc;
            this.grvBanDoc.Name = "grvBanDoc";
            this.grvBanDoc.OptionsView.ShowGroupPanel = false;
            this.grvBanDoc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvBanDoc_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "Mã bạn đọc";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            // 
            // NamSinh
            // 
            this.NamSinh.Caption = "Năm sinh";
            this.NamSinh.FieldName = "NamSinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Visible = true;
            this.NamSinh.VisibleIndex = 4;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.bntReport);
            this.groupControl2.Controls.Add(this.cbbSearchType);
            this.groupControl2.Controls.Add(this.bntBooksManager);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Controls.Add(this.srcSearchMember);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(656, 94);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.EditValue = "Tất cả";
            this.cbbSearchType.Location = new System.Drawing.Point(85, 25);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSearchType.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Sách quá hạn",
            "Đang mượn sách"});
            this.cbbSearchType.Size = new System.Drawing.Size(126, 20);
            this.cbbSearchType.TabIndex = 7;
            // 
            // bntBooksManager
            // 
            this.bntBooksManager.Image = ((System.Drawing.Image)(resources.GetObject("bntBooksManager.Image")));
            this.bntBooksManager.Location = new System.Drawing.Point(349, 56);
            this.bntBooksManager.Name = "bntBooksManager";
            this.bntBooksManager.Size = new System.Drawing.Size(113, 32);
            this.bntBooksManager.TabIndex = 5;
            this.bntBooksManager.Text = "Mượn-Trả tài liệu";
            this.bntBooksManager.Click += new System.EventHandler(this.bntbntBooksManager_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(261, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(173, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(85, 56);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 32);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // srcSearchMember
            // 
            this.srcSearchMember.Location = new System.Drawing.Point(217, 25);
            this.srcSearchMember.Name = "srcSearchMember";
            this.srcSearchMember.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.srcSearchMember.Properties.NullValuePromptShowForEmptyValue = false;
            this.srcSearchMember.Size = new System.Drawing.Size(434, 20);
            this.srcSearchMember.TabIndex = 1;
            this.srcSearchMember.TextChanged += new System.EventHandler(this.srcSearchMember_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm:";
            // 
            // bntReport
            // 
            this.bntReport.Image = ((System.Drawing.Image)(resources.GetObject("bntReport.Image")));
            this.bntReport.Location = new System.Drawing.Point(469, 56);
            this.bntReport.Name = "bntReport";
            this.bntReport.Size = new System.Drawing.Size(79, 32);
            this.bntReport.TabIndex = 8;
            this.bntReport.Text = "Báo cáo";
            this.bntReport.Click += new System.EventHandler(this.bntReport_click);
            // 
            // ucManagerMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucManagerMember";
            this.Size = new System.Drawing.Size(660, 453);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBanDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBanDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSearchType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcSearchMember.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl srcSearchMember;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grcBanDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBanDoc;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton bntBooksManager;
        private DevExpress.XtraEditors.ComboBoxEdit cbbSearchType;
        private DevExpress.XtraEditors.SimpleButton bntReport;
    }
}
