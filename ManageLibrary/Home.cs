using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageLibrary.DAO;
using ManageLibrary.UserControls;

namespace ManageLibrary
{
    public partial class Home : Form
    {
        private NhanVienDb nvDb;
        private NhanVienDb loginUser;
        private Login loginDlg;
        public NhanVienDb NvDb
        {
            get { return nvDb; }
            set { nvDb = value; }
        }

        public Home(Login loginDlg)
        {
            // Kiem tra viec Login he thong
            if (loginDlg.NvDb != null)
            {
                InitializeComponent();
                this.nvDb = loginDlg.NvDb;
                this.loginDlg = loginDlg;
                this.loginUser = loginDlg.NvDb;
                this.navBarGroup2.Caption = "Home - " + loginDlg.NvDb.HoTen + " (" + loginDlg.NvDb.PhanQuyenStr + ")";
                addUsercontrol(new ucHome());
            }
        }

        public void addUsercontrol(UserControl uc)
        {
            try
            {
                pnlUsercontrol.Controls.Clear();
                pnlUsercontrol.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addUsercontrol(new ucManagerUsers(this));
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginDlg.Dispose();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addUsercontrol(new ucManagerDocuments(this));
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Dispose();
            loginDlg.Logout();
        }
    }
}
