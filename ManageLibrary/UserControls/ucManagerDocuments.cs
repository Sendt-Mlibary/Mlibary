using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageLibrary.BLL;
using ManageLibrary.Util;

namespace ManageLibrary.UserControls
{
    public partial class ucManagerDocuments : UserControl
    {
        private Home home;
        private FormDialog form;
        private TaiLieuBLL tlBll;
        private string isActive;
        public ucManagerDocuments()
        {
            InitializeComponent();
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

        private void btnNew_Click_Click(object sender, EventArgs e)
        {
            IsActive = Constants.IsActive.CREATE;
            ucDocumentDialog document = new ucDocumentDialog();
            form = new FormDialog(document);
            form.Show();
        }
    }
}
