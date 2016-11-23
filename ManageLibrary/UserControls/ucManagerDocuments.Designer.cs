namespace ManageLibrary.UserControls
{
    partial class ucManagerDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManagerDocuments));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grcDocument = new DevExpress.XtraGrid.GridControl();
            this.gridViewDocuments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNganhHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNgonNguSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaiBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(710, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lý tài liệu";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grcDocument);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 120);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(706, 353);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách tài liệu";
            // 
            // grcDocument
            // 
            this.grcDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDocument.Location = new System.Drawing.Point(2, 20);
            this.grcDocument.MainView = this.gridViewDocuments;
            this.grcDocument.Name = "grcDocument";
            this.grcDocument.Size = new System.Drawing.Size(702, 331);
            this.grcDocument.TabIndex = 0;
            this.grcDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocuments});
            // 
            // gridViewDocuments
            // 
            this.gridViewDocuments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenSach,
            this.TacGia,
            this.NamXuatBan,
            this.Gia,
            this.TenTheLoai,
            this.TenNganhHoc,
            this.TenNgonNguSach,
            this.TaiBan,
            this.SoLuong,
            this.SoNgayMuon,
            this.TrangThai});
            this.gridViewDocuments.GridControl = this.grcDocument;
            this.gridViewDocuments.Name = "gridViewDocuments";
            this.gridViewDocuments.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDocuments_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "TenSach";
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 0;
            // 
            // TacGia
            // 
            this.TacGia.Caption = "Tác Giả";
            this.TacGia.FieldName = "TacGia";
            this.TacGia.Name = "TacGia";
            this.TacGia.Visible = true;
            this.TacGia.VisibleIndex = 1;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Caption = "Năm xuất bản";
            this.NamXuatBan.FieldName = "NamXuatBan";
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Visible = true;
            this.NamXuatBan.VisibleIndex = 2;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá";
            this.Gia.FieldName = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 3;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.Caption = "Thể loại sách";
            this.TenTheLoai.FieldName = "TenTheLoai";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.Visible = true;
            this.TenTheLoai.VisibleIndex = 5;
            // 
            // TenNganhHoc
            // 
            this.TenNganhHoc.Caption = "Ngành học";
            this.TenNganhHoc.FieldName = "TenNganhHoc";
            this.TenNganhHoc.Name = "TenNganhHoc";
            this.TenNganhHoc.Visible = true;
            this.TenNganhHoc.VisibleIndex = 6;
            // 
            // TenNgonNguSach
            // 
            this.TenNgonNguSach.Caption = "Ngôn ngữ sách";
            this.TenNgonNguSach.FieldName = "TenNgonNguSach";
            this.TenNgonNguSach.Name = "TenNgonNguSach";
            this.TenNgonNguSach.Visible = true;
            this.TenNgonNguSach.VisibleIndex = 4;
            // 
            // TaiBan
            // 
            this.TaiBan.Caption = "Tái bản";
            this.TaiBan.FieldName = "TaiBan";
            this.TaiBan.Name = "TaiBan";
            this.TaiBan.Visible = true;
            this.TaiBan.VisibleIndex = 7;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.Caption = "Số ngày mượn tối đa";
            this.SoNgayMuon.FieldName = "SoNgayMuon";
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.Visible = true;
            this.SoNgayMuon.VisibleIndex = 6;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThaiStr";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(706, 100);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(281, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(190, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(99, 59);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(99, 25);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePromptShowForEmptyValue = false;
            this.searchControl1.Size = new System.Drawing.Size(531, 20);
            this.searchControl1.TabIndex = 1;
            this.searchControl1.ToolTip = "Tìm kiếm theo tên sách";
            this.searchControl1.TextChanged += new System.EventHandler(this.searchControl1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm:";
            // 
            // ucManagerDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucManagerDocuments";
            this.Size = new System.Drawing.Size(710, 475);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.GridControl grcDocument;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDocuments;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn TacGia;
        private DevExpress.XtraGrid.Columns.GridColumn NamXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn TenTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenNganhHoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenNgonNguSach;
        private DevExpress.XtraGrid.Columns.GridColumn TaiBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}
