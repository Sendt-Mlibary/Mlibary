namespace ManageLibrary.UserControls
{
    partial class ucDialogAddBookForBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDialogAddBookForBorrow));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcLstBooks = new DevExpress.XtraGrid.GridControl();
            this.grvLstBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bntCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bntAddBook = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLstBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLstBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(684, 391);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thêm sách vào phiếu mượn";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grcLstBooks);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 92);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(680, 297);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách tìm kiếm";
            // 
            // grcLstBooks
            // 
            this.grcLstBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLstBooks.Location = new System.Drawing.Point(2, 20);
            this.grcLstBooks.MainView = this.grvLstBooks;
            this.grcLstBooks.Name = "grcLstBooks";
            this.grcLstBooks.Size = new System.Drawing.Size(676, 275);
            this.grcLstBooks.TabIndex = 2;
            this.grcLstBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLstBooks});
            // 
            // grvLstBooks
            // 
            this.grvLstBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.grvLstBooks.GridControl = this.grcLstBooks;
            this.grvLstBooks.Name = "grvLstBooks";
            this.grvLstBooks.OptionsView.ShowGroupPanel = false;
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
            this.TenNganhHoc.VisibleIndex = 7;
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
            this.TaiBan.VisibleIndex = 9;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 6;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.Caption = "Số ngày mượn tối đa";
            this.SoNgayMuon.FieldName = "SoNgayMuon";
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.Visible = true;
            this.SoNgayMuon.VisibleIndex = 8;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThaiStr";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bntCancel);
            this.panelControl1.Controls.Add(this.bntAddBook);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(680, 72);
            this.panelControl1.TabIndex = 0;
            // 
            // bntCancel
            // 
            this.bntCancel.Image = ((System.Drawing.Image)(resources.GetObject("bntCancel.Image")));
            this.bntCancel.Location = new System.Drawing.Point(190, 37);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(60, 30);
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Thoát";
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntAddBook
            // 
            this.bntAddBook.Image = ((System.Drawing.Image)(resources.GetObject("bntAddBook.Image")));
            this.bntAddBook.Location = new System.Drawing.Point(102, 37);
            this.bntAddBook.Name = "bntAddBook";
            this.bntAddBook.Size = new System.Drawing.Size(82, 30);
            this.bntAddBook.TabIndex = 2;
            this.bntAddBook.Text = "Lựa chọn";
            this.bntAddBook.Click += new System.EventHandler(this.bntAddBook_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tìm kiêm";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(102, 11);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(449, 20);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.ToolTip = "Tìm kiếm theo mã tài liệu hoặc theo tên tài liệu";
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            // 
            // ucDialogAddBookForBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDialogAddBookForBorrow";
            this.Size = new System.Drawing.Size(684, 391);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLstBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLstBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl grcLstBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLstBooks;
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
        private DevExpress.XtraEditors.SimpleButton bntCancel;
        private DevExpress.XtraEditors.SimpleButton bntAddBook;
    }
}
