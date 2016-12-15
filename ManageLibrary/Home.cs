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
using ManageLibrary.Util;

namespace ManageLibrary
{
    public partial class Home : Form
    {
        private NhanVienDb loginUser;

        public NhanVienDb LoginUser
        {
            get
            {
                return loginUser;
            }

            set
            {
                loginUser = value;
            }
        }

        public void setData(NhanVienDb LoginUser)
        {
            // Kiem tra viec Login he thong
            if (LoginUser != null)
            {
                this.LoginUser = LoginUser;
                this.navBarGroup2.Caption = "Home - " + LoginUser.HoTen + " (" + LoginUser.PhanQuyenStr + ")";
                addUsercontrol(new ucHome());
                if(LoginUser.PhanQuyen != null
                    && LoginUser.PhanQuyen ==Constants.PHAN_QUYEN.ADMIN)
                {
                    bntManagerUser.Visible = true;
                }
                else
                {
                    bntManagerUser.Visible = false;
                }
            }
        }
        public Home()
        {
              InitializeComponent();
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

        private void bntUcManagerUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addUsercontrol(new ucManagerUsers(this));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            addUsercontrol(new ucHome());
            Login frmlog = new Login(this);
            frmlog.ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            //loginDlg.Dispose();
        }

        private void ucManagerDocuments_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addUsercontrol(new ucManagerDocuments(this));
        }

        private void bntManagerMember_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addUsercontrol(new ucManagerMember(this));
        }

        private void bntLogout_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Login frmlog = new Login(this);
            frmlog.ShowDialog();
        }
    }
}
