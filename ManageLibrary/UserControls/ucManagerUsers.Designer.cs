namespace ManageLibrary.UserControls
{
    partial class ucManagerUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManagerUsers));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grwNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sctSearch = new DevExpress.XtraEditors.SearchControl();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.imgCol16x = new DevExpress.Utils.ImageCollection(this.components);
            this.bntEdit = new DevExpress.XtraEditors.SimpleButton();
            this.bntNew = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol16x)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 436);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lý người dùng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grwNhanVien);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 127);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(867, 307);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách nhân viên";
            // 
            // grwNhanVien
            // 
            this.grwNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grwNhanVien.Location = new System.Drawing.Point(2, 20);
            this.grwNhanVien.MainView = this.gridViewNhanVien;
            this.grwNhanVien.Name = "grwNhanVien";
            this.grwNhanVien.Size = new System.Drawing.Size(863, 285);
            this.grwNhanVien.TabIndex = 1;
            this.grwNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenDangNhap,
            this.HoTen,
            this.NamSinh,
            this.MatKhau,
            this.SoDienThoai,
            this.Email,
            this.DiaChi,
            this.QueQuan,
            this.PhanQuyen});
            this.gridViewNhanVien.GridControl = this.grwNhanVien;
            this.gridViewNhanVien.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", this.TenDangNhap, "Tổng bản ghi")});
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.Editable = false;
            this.gridViewNhanVien.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridViewNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhanVien_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Caption = "Tên đăng nhập";
            this.TenDangNhap.FieldName = "TenDangNhap";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Visible = true;
            this.TenDangNhap.VisibleIndex = 0;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            // 
            // NamSinh
            // 
            this.NamSinh.Caption = "Năm sinh";
            this.NamSinh.FieldName = "NamSinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Visible = true;
            this.NamSinh.VisibleIndex = 2;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật Khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Sô điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 6;
            // 
            // QueQuan
            // 
            this.QueQuan.Caption = "Quê quán";
            this.QueQuan.FieldName = "QueQuan";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Visible = true;
            this.QueQuan.VisibleIndex = 5;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.Caption = "Quyền người dùng";
            this.PhanQuyen.FieldName = "phanQuyenStr";
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.Visible = true;
            this.PhanQuyen.VisibleIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.sctSearch);
            this.groupControl2.Controls.Add(this.bntDelete);
            this.groupControl2.Controls.Add(this.bntEdit);
            this.groupControl2.Controls.Add(this.bntNew);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(867, 107);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // sctSearch
            // 
            this.sctSearch.EditValue = "";
            this.sctSearch.Location = new System.Drawing.Point(109, 26);
            this.sctSearch.Name = "sctSearch";
            this.sctSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.sctSearch.Properties.NullValuePromptShowForEmptyValue = false;
            this.sctSearch.Size = new System.Drawing.Size(450, 20);
            this.sctSearch.TabIndex = 20;
            this.sctSearch.ToolTip = "Tìm kiếm theo Tên đăng nhập, Họ tên, Email";
            this.sctSearch.TextChanged += new System.EventHandler(this.sctSearch_Enter);
            // 
            // bntDelete
            // 
            this.bntDelete.ImageIndex = 12;
            this.bntDelete.ImageList = this.imgCol16x;
            this.bntDelete.Location = new System.Drawing.Point(290, 59);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(69, 29);
            this.bntDelete.TabIndex = 19;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // imgCol16x
            // 
            this.imgCol16x.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCol16x.ImageStream")));
            this.imgCol16x.Images.SetKeyName(0, "address.png");
            this.imgCol16x.Images.SetKeyName(1, "administrative-docs.png");
            this.imgCol16x.Images.SetKeyName(2, "advertising.png");
            this.imgCol16x.Images.SetKeyName(3, "archives.png");
            this.imgCol16x.Images.SetKeyName(4, "attibutes.png");
            this.imgCol16x.Images.SetKeyName(5, "bank.png");
            this.imgCol16x.Images.SetKeyName(6, "basket.png");
            this.imgCol16x.Images.SetKeyName(7, "bestseller.png");
            this.imgCol16x.Images.SetKeyName(8, "billing.png");
            this.imgCol16x.Images.SetKeyName(9, "bookmark.png");
            this.imgCol16x.Images.SetKeyName(10, "brainstorming.png");
            this.imgCol16x.Images.SetKeyName(11, "business-contact.png");
            this.imgCol16x.Images.SetKeyName(12, "busy.png");
            this.imgCol16x.Images.SetKeyName(13, "calendar.png");
            this.imgCol16x.Images.SetKeyName(14, "category.png");
            this.imgCol16x.Images.SetKeyName(15, "collaboration.png");
            this.imgCol16x.Images.SetKeyName(16, "comment.png");
            this.imgCol16x.Images.SetKeyName(17, "communication.png");
            this.imgCol16x.Images.SetKeyName(18, "config.png");
            this.imgCol16x.Images.SetKeyName(19, "consulting.png");
            this.imgCol16x.Images.SetKeyName(20, "contact.png");
            this.imgCol16x.Images.SetKeyName(21, "cost.png");
            this.imgCol16x.Images.SetKeyName(22, "credit.png");
            this.imgCol16x.Images.SetKeyName(23, "credit-card.png");
            this.imgCol16x.Images.SetKeyName(24, "current-work.png");
            this.imgCol16x.Images.SetKeyName(25, "customers.png");
            this.imgCol16x.Images.SetKeyName(26, "cv.png");
            this.imgCol16x.Images.SetKeyName(27, "check.png");
            this.imgCol16x.Images.SetKeyName(28, "database.png");
            this.imgCol16x.Images.SetKeyName(29, "date.png");
            this.imgCol16x.Images.SetKeyName(30, "delicious.png");
            this.imgCol16x.Images.SetKeyName(31, "document-library.png");
            this.imgCol16x.Images.SetKeyName(32, "donate.png");
            this.imgCol16x.Images.SetKeyName(33, "drawings.png");
            this.imgCol16x.Images.SetKeyName(34, "edit.png");
            this.imgCol16x.Images.SetKeyName(35, "email.png");
            this.imgCol16x.Images.SetKeyName(36, "featured.png");
            this.imgCol16x.Images.SetKeyName(37, "feed.png");
            this.imgCol16x.Images.SetKeyName(38, "finished-work.png");
            this.imgCol16x.Images.SetKeyName(39, "flag.png");
            this.imgCol16x.Images.SetKeyName(40, "folder.png");
            this.imgCol16x.Images.SetKeyName(41, "free-for-job.png");
            this.imgCol16x.Images.SetKeyName(42, "freelance.png");
            this.imgCol16x.Images.SetKeyName(43, "full-time.png");
            this.imgCol16x.Images.SetKeyName(44, "future-projects.png");
            this.imgCol16x.Images.SetKeyName(45, "graphic-design.png");
            this.imgCol16x.Images.SetKeyName(46, "heart.png");
            this.imgCol16x.Images.SetKeyName(47, "hire-me.png");
            this.imgCol16x.Images.SetKeyName(48, "home.png");
            this.imgCol16x.Images.SetKeyName(49, "illustration.png");
            this.imgCol16x.Images.SetKeyName(50, "invoice.png");
            this.imgCol16x.Images.SetKeyName(51, "issue.png");
            this.imgCol16x.Images.SetKeyName(52, "library.png");
            this.imgCol16x.Images.SetKeyName(53, "lightbulb.png");
            this.imgCol16x.Images.SetKeyName(54, "limited-edition.png");
            this.imgCol16x.Images.SetKeyName(55, "link.png");
            this.imgCol16x.Images.SetKeyName(56, "lock.png");
            this.imgCol16x.Images.SetKeyName(57, "logout.png");
            this.imgCol16x.Images.SetKeyName(58, "login.png");
            this.imgCol16x.Images.SetKeyName(59, "milestone.png");
            this.imgCol16x.Images.SetKeyName(60, "my-account.png");
            this.imgCol16x.Images.SetKeyName(61, "networking.png");
            this.imgCol16x.Images.SetKeyName(62, "old-versions.png");
            this.imgCol16x.Images.SetKeyName(63, "order.png");
            this.imgCol16x.Images.SetKeyName(64, "order-192.png");
            this.imgCol16x.Images.SetKeyName(65, "payment-card.png");
            this.imgCol16x.Images.SetKeyName(66, "paypal.png");
            this.imgCol16x.Images.SetKeyName(67, "pen.png");
            this.imgCol16x.Images.SetKeyName(68, "pencil.png");
            this.imgCol16x.Images.SetKeyName(69, "plus.png");
            this.imgCol16x.Images.SetKeyName(70, "premium.png");
            this.imgCol16x.Images.SetKeyName(71, "print.png");
            this.imgCol16x.Images.SetKeyName(72, "process.png");
            this.imgCol16x.Images.SetKeyName(73, "product.png");
            this.imgCol16x.Images.SetKeyName(74, "product-193.png");
            this.imgCol16x.Images.SetKeyName(75, "product-design.png");
            this.imgCol16x.Images.SetKeyName(76, "project.png");
            this.imgCol16x.Images.SetKeyName(77, "publish.png");
            this.imgCol16x.Images.SetKeyName(78, "phone.png");
            this.imgCol16x.Images.SetKeyName(79, "photography.png");
            this.imgCol16x.Images.SetKeyName(80, "refresh.png");
            this.imgCol16x.Images.SetKeyName(81, "save.png");
            this.imgCol16x.Images.SetKeyName(82, "search.png");
            this.imgCol16x.Images.SetKeyName(83, "settings.png");
            this.imgCol16x.Images.SetKeyName(84, "shipping.png");
            this.imgCol16x.Images.SetKeyName(85, "showreel.png");
            this.imgCol16x.Images.SetKeyName(86, "sign-in.png");
            this.imgCol16x.Images.SetKeyName(87, "sign-out.png");
            this.imgCol16x.Images.SetKeyName(88, "sign-up.png");
            this.imgCol16x.Images.SetKeyName(89, "sitemap.png");
            this.imgCol16x.Images.SetKeyName(90, "special-offer.png");
            this.imgCol16x.Images.SetKeyName(91, "star.png");
            this.imgCol16x.Images.SetKeyName(92, "statistics.png");
            this.imgCol16x.Images.SetKeyName(93, "suppliers.png");
            this.imgCol16x.Images.SetKeyName(94, "tag.png");
            this.imgCol16x.Images.SetKeyName(95, "ticket.png");
            this.imgCol16x.Images.SetKeyName(96, "twitter.png");
            this.imgCol16x.Images.SetKeyName(97, "upcoming-work.png");
            this.imgCol16x.Images.SetKeyName(98, "user.png");
            this.imgCol16x.Images.SetKeyName(99, "world.png");
            this.imgCol16x.Images.SetKeyName(100, "zoom.png");
            // 
            // bntEdit
            // 
            this.bntEdit.ImageIndex = 34;
            this.bntEdit.ImageList = this.imgCol16x;
            this.bntEdit.Location = new System.Drawing.Point(205, 59);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(79, 29);
            this.bntEdit.TabIndex = 18;
            this.bntEdit.Text = "Cập nhật";
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntNew
            // 
            this.bntNew.ImageIndex = 69;
            this.bntNew.ImageList = this.imgCol16x;
            this.bntNew.Location = new System.Drawing.Point(109, 58);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(90, 30);
            this.bntNew.TabIndex = 17;
            this.bntNew.Text = "Thêm mới";
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tìm kiếm:";
            // 
            // ucManagerUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucManagerUsers";
            this.Size = new System.Drawing.Size(871, 436);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grwNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCol16x)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grwNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn QueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn PhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraEditors.SimpleButton bntEdit;
        private DevExpress.XtraEditors.SimpleButton bntNew;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SearchControl sctSearch;
        private DevExpress.Utils.ImageCollection imgCol16x;
    }
}
