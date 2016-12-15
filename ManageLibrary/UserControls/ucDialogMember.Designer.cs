namespace ManageLibrary.UserControls
{
    partial class ucDialogMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDialogMember));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bntExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtNamSinh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bntExit);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtSoDienThoai);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtNamSinh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(462, 231);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin bạn đọc";
            // 
            // bntExit
            // 
            this.bntExit.Image = ((System.Drawing.Image)(resources.GetObject("bntExit.Image")));
            this.bntExit.Location = new System.Drawing.Point(301, 173);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(64, 34);
            this.bntExit.TabIndex = 12;
            this.bntExit.Text = "Thoát";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(220, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Làm lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(139, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(139, 147);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Properties.Mask.BeepOnError = true;
            this.txtSoDienThoai.Properties.Mask.EditMask = "\\d{9,15}";
            this.txtSoDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoDienThoai.Size = new System.Drawing.Size(263, 20);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(139, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(263, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(139, 43);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(263, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(57, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Số điện thoại:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Năm sinh(*):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Địa chỉ(*):";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Email:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên(*):";
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.EditValue = null;
            this.dtNamSinh.Location = new System.Drawing.Point(139, 121);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamSinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamSinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtNamSinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNamSinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtNamSinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNamSinh.Properties.Mask.EditMask = "";
            this.dtNamSinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtNamSinh.Size = new System.Drawing.Size(263, 20);
            this.dtNamSinh.TabIndex = 8;
            // 
            // ucDialogMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDialogMember";
            this.Size = new System.Drawing.Size(462, 231);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.DateEdit dtNamSinh;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton bntExit;
    }
}
