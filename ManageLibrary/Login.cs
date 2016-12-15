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
        private NhanVienDb loginUser;
        private NhanVienBLL nvBLL;
        private Home homeDlg;
        public NhanVienDb LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public Login(Home homeDlg)
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            loginUser = new NhanVienDb();
            this.homeDlg = homeDlg;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser.TenDangNhap = txtUsername.Text.ToUpper();
            LoginUser.MatKhau = txtPassword.Text;
            if (validateLogin(LoginUser))
            {
                LoginUser = nvBLL.DangNhap(LoginUser);
                if (LoginUser != null)
                {
                    homeDlg.setData(LoginUser);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        public void Logout()
        {
            this.loginUser = new NhanVienDb();
            this.nvBLL = new NhanVienBLL();
            txtPassword.Text = "";
            txtUsername.Text = "";
            this.Show();
        }
    }
}
