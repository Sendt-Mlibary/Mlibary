using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary.UserControls
{
    public partial class FormDialog : Form
    {
        private UserControl uc;
        public FormDialog(UserControl uc)
        {
            InitializeComponent();
            this.uc = uc;
            pnlUsercontrol.Controls.Clear();
            pnlUsercontrol.Controls.Add(this.uc);
            this.uc.Dock = DockStyle.Fill;
        }
        
        private void FormDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
