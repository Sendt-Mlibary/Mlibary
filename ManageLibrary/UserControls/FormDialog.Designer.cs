namespace ManageLibrary.UserControls
{
    partial class FormDialog
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
            this.pnlUsercontrol = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlUsercontrol
            // 
            this.pnlUsercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsercontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlUsercontrol.Name = "pnlUsercontrol";
            this.pnlUsercontrol.Size = new System.Drawing.Size(387, 390);
            this.pnlUsercontrol.TabIndex = 0;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 390);
            this.Controls.Add(this.pnlUsercontrol);
            this.Name = "FormDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsercontrol;
    }
}