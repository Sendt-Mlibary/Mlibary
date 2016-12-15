namespace ManageLibrary.UserControls
{
    partial class ucDialogCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDialogCategory));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgonNgu = new DevExpress.XtraEditors.TextEdit();
            this.txtTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtNganh = new DevExpress.XtraEditors.TextEdit();
            this.cboLuaChon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnReset_Click = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave_Click = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgonNgu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLuaChon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtNgonNgu);
            this.groupControl1.Controls.Add(this.txtTheLoai);
            this.groupControl1.Controls.Add(this.txtNganh);
            this.groupControl1.Controls.Add(this.cboLuaChon);
            this.groupControl1.Controls.Add(this.btnReset_Click);
            this.groupControl1.Controls.Add(this.btnSave_Click);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 200);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin danh mục";
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(134, 120);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(211, 20);
            this.txtNgonNgu.TabIndex = 9;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(134, 94);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(211, 20);
            this.txtTheLoai.TabIndex = 8;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(134, 68);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(211, 20);
            this.txtNganh.TabIndex = 7;
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.Location = new System.Drawing.Point(134, 42);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLuaChon.Properties.Items.AddRange(new object[] {
            "---Lựa chọn---",
            "Ngành",
            "Thể loại",
            "Ngôn ngữ"});
            this.cboLuaChon.Size = new System.Drawing.Size(211, 20);
            this.cboLuaChon.TabIndex = 6;
            // 
            // btnReset_Click
            // 
            this.btnReset_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnReset_Click.Image")));
            this.btnReset_Click.Location = new System.Drawing.Point(205, 151);
            this.btnReset_Click.Name = "btnReset_Click";
            this.btnReset_Click.Size = new System.Drawing.Size(66, 36);
            this.btnReset_Click.TabIndex = 5;
            this.btnReset_Click.Text = "Làm lại";
            this.btnReset_Click.Click += new System.EventHandler(this.btnReset_Click_Click);
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_Click.Image")));
            this.btnSave_Click.Location = new System.Drawing.Point(134, 151);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(65, 36);
            this.btnSave_Click.TabIndex = 4;
            this.btnSave_Click.Text = "Lưu lại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tên ngôn ngữ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên thể loại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên ngành:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh mục(*):";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(277, 151);
            this.simpleButton1.Name = "bntExit";
            this.simpleButton1.Size = new System.Drawing.Size(57, 36);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // ucDialogCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDialogCategory";
            this.Size = new System.Drawing.Size(378, 200);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgonNgu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLuaChon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNganh;
        private DevExpress.XtraEditors.ComboBoxEdit cboLuaChon;
        private DevExpress.XtraEditors.SimpleButton btnReset_Click;
        private DevExpress.XtraEditors.SimpleButton btnSave_Click;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNgonNgu;
        private DevExpress.XtraEditors.TextEdit txtTheLoai;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
