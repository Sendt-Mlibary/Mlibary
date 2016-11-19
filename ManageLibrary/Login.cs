using ManageLibrary.BLL;
using ManageLibrary.DAO;
using ManageLibrary.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class Login : Form
    {
        private NhanVienDb nvDb;
        private NhanVienBLL nvBLL;
        private Home homeDlg;
        public NhanVienDb NvDb
        {
            get { return nvDb; }
            set { nvDb = value; }
        }

        public Login()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            nvDb = new NhanVienDb();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NvDb.TenDangNhap = txtUsername.Text.ToUpper();
            NvDb.MatKhau = txtPassword.Text;
            if (!validateLogin(NvDb))
            {
                return;
            }
            if (nvBLL.DangNhap(NvDb))
            {
                homeDlg = new Home(this);
                homeDlg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool validateLogin(NhanVienDb nv)
        {
            if (String.IsNullOrEmpty(nv.TenDangNhap))
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(nv.MatKhau))
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
