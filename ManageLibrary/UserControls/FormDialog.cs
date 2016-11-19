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
        public FormDialog(UserControl uc)
        {
            InitializeComponent();
            pnlUsercontrol.Controls.Clear();
            pnlUsercontrol.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
