using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ManageLibrary.BLL;
using ManageLibrary.Util;
using System.Windows.Forms;

namespace ManageLibrary.UserControls
{
    public partial class ucManagerDocuments : UserControl
    {
        private Home home;
        private FormDialog form;
        private TaiLieuBLL tlBll;
        private string isActive;
        private int idDocumentSelect;
        public ucManagerDocuments(Home home)
        {
            InitializeComponent();
            this.home = home;
        }


        public string IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }

        public int IdDocumentSelect
        {
            get
            {
                return idDocumentSelect;
            }

            set
            {
                idDocumentSelect = value;
            }
        }

        private void btnNew_Click_Click(object sender, EventArgs e)
        {
            IsActive = Constants.IsActive.CREATE;
            ucDocumentDialog document = new ucDocumentDialog();
            form = new FormDialog(document);
            form.Show();
        }

        public void LoadGridView()
        {
          //  DataTable dt = tlBll();
          //  gri.DataSource = dt;
        }

        public void DisposeDialog()
        {
            if (form != null)
            {
                form.Dispose();
            }
        }
    }
}
