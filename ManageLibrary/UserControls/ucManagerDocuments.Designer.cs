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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_TheLoaiSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NganhHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NgonNguSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaiBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete_Click = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit_Click = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew_Click = new DevExpress.XtraEditors.SimpleButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 120);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(706, 353);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách tài liệu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(702, 331);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenSach,
            this.TacGia,
            this.NamXuatBan,
            this.Gia,
            this.ID_TheLoaiSach,
            this.ID_NganhHoc,
            this.ID_NgonNguSach,
            this.TaiBan,
            this.SoLuong,
            this.SoNgayMuon,
            this.TrangThai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // ID_TheLoaiSach
            // 
            this.ID_TheLoaiSach.Caption = "Thể loại sách";
            this.ID_TheLoaiSach.FieldName = "ID_TheLoaiSach";
            this.ID_TheLoaiSach.Name = "ID_TheLoaiSach";
            this.ID_TheLoaiSach.Visible = true;
            this.ID_TheLoaiSach.VisibleIndex = 4;
            // 
            // ID_NganhHoc
            // 
            this.ID_NganhHoc.Caption = "Ngành học";
            this.ID_NganhHoc.FieldName = "ID_NganhHoc";
            this.ID_NganhHoc.Name = "ID_NganhHoc";
            this.ID_NganhHoc.Visible = true;
            this.ID_NganhHoc.VisibleIndex = 5;
            // 
            // ID_NgonNguSach
            // 
            this.ID_NgonNguSach.Caption = "Ngôn ngữ sách";
            this.ID_NgonNguSach.FieldName = "ID_NgonNguSach";
            this.ID_NgonNguSach.Name = "ID_NgonNguSach";
            this.ID_NgonNguSach.Visible = true;
            this.ID_NgonNguSach.VisibleIndex = 6;
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
            this.SoLuong.VisibleIndex = 8;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.Caption = "Số ngày mượn";
            this.SoNgayMuon.FieldName = "SoNgayMuon";
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.Visible = true;
            this.SoNgayMuon.VisibleIndex = 9;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 10;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDelete_Click);
            this.groupControl2.Controls.Add(this.btnEdit_Click);
            this.groupControl2.Controls.Add(this.btnNew_Click);
            this.groupControl2.Controls.Add(this.searchControl1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(706, 100);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_Click.Image")));
            this.btnDelete_Click.Location = new System.Drawing.Point(261, 56);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(75, 30);
            this.btnDelete_Click.TabIndex = 4;
            this.btnDelete_Click.Text = "Xóa";
            // 
            // btnEdit_Click
            // 
            this.btnEdit_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_Click.Image")));
            this.btnEdit_Click.Location = new System.Drawing.Point(180, 56);
            this.btnEdit_Click.Name = "btnEdit_Click";
            this.btnEdit_Click.Size = new System.Drawing.Size(75, 30);
            this.btnEdit_Click.TabIndex = 3;
            this.btnEdit_Click.Text = "Cập nhật";
            // 
            // btnNew_Click
            // 
            this.btnNew_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnNew_Click.Image")));
            this.btnNew_Click.Location = new System.Drawing.Point(99, 56);
            this.btnNew_Click.Name = "btnNew_Click";
            this.btnNew_Click.Size = new System.Drawing.Size(75, 30);
            this.btnNew_Click.TabIndex = 2;
            this.btnNew_Click.Text = "Thêm mới";
            this.btnNew_Click.Click += new System.EventHandler(this.btnNew_Click_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(99, 25);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(383, 20);
            this.searchControl1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnNew_Click;
        private DevExpress.XtraEditors.SimpleButton btnDelete_Click;
        private DevExpress.XtraEditors.SimpleButton btnEdit_Click;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn TacGia;
        private DevExpress.XtraGrid.Columns.GridColumn NamXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TheLoaiSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NganhHoc;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NgonNguSach;
        private DevExpress.XtraGrid.Columns.GridColumn TaiBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}
