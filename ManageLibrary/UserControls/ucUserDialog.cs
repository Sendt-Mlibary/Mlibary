using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageLibrary.DAO;
using ManageLibrary.BLL;
using ManageLibrary.Util;

namespace ManageLibrary.UserControls
{
    public partial class ucUserDialog : UserControl
    {
        private NhanVienDb nv;
        private NhanVienBLL nvBll;
        private ucManagerUsers ucManagerUsers;
        private int idUserSelect;
        private string isActive;
        public ucUserDialog(ucManagerUsers ucManagerUsers)
        {
            InitializeComponent();
            nvBll = new NhanVienBLL();
            this.ucManagerUsers = ucManagerUsers;
            this.isActive = ucManagerUsers.IsActive;
            idUserSelect = ucManagerUsers.IdUserSelect;
            if (idUserSelect > 0)                         // idUserSelect > 0 ==> cap nhat
            {
                setInfoDialog(idUserSelect);
                enableControl(false);
                chkResetPassword.Show();
            }
            else
            {
                enableControl(true);
                chkResetPassword.Hide();
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            // id user ton tai ==> update user
            // else => create user
            if (idUserSelect > 0)                         // idUserSelect > 0 ==> cap nhat
            {
                updateUser(idUserSelect);
            }
            else
            {
                createUser();
            }
        }


        private void updateUser(int idUserSelect)
        {
            // validate
            if (!validateUser())
            {
                return;
            }
            // Kiem tra lai nhan vien co ton tai khong?
            nv = nvBll.GetNhanVienById(idUserSelect);
            if (nv == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nv.TenDangNhap = txtTenDangNhap.Text.ToUpper();

            List<NhanVienDb> dt = nvBll.GetAllNhanVienNotIdUpdate(nv.Id);
            for (int i = 0; i < dt.Count; i++)
            {
                if (nv.TenDangNhap == (dt[i].TenDangNhap.ToUpper()))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            nv.HoTen = txtHoTen.Text;
            if (chkResetPassword.Checked == true)
            {
                nv.MatKhau = Common.md5(txtMatKhau.Text);       // Reset lai mat khau
            }
            else {
                nv.MatKhau = "";//Khong reset lai mat khau
            }
            nv.SoDienThoai = txtSoDienThoai.Text;
            nv.QueQuan = txtQueQuan.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NamSinh = DateTime.Parse(dateNamSinh.Text).Date;
            nv.PhanQuyen = cboPhanQuyen.SelectedIndex;   //selectbox co 2 item:1: Người quản lý, 0: Nhân viên
            if (nvBll.SuaNhanVien(nv))
            {
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucManagerUsers.LoadGridView();
                ucManagerUsers.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai thông tin nhân viên cần sửa, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void createUser()
        {
            // validate
            if (!validateUser())
            {
                return;
            }
            nv = new NhanVienDb();
            nv.HoTen = txtHoTen.Text;
            nv.TenDangNhap = txtTenDangNhap.Text.ToUpper();
            DataTable dt = nvBll.GetAllNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (nv.TenDangNhap.Equals((dt.Rows[i]["TenDangNhap"]).ToString().ToUpper()))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            nv.MatKhau = Common.md5(txtMatKhau.Text);
            nv.SoDienThoai = txtSoDienThoai.Text;
            nv.QueQuan = txtQueQuan.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NamSinh = DateTime.Parse(dateNamSinh.Text).Date;
            nv.PhanQuyen = cboPhanQuyen.SelectedIndex;   //selectbox co 2 item:1: Người quản lý, 0: Nhân viên
            if (nvBll.ThemNhanVien(nv))
            {
                MessageBox.Show("Đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucManagerUsers.LoadGridView();
                ucManagerUsers.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool validateUser()
        {
            if (String.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn phải nhập Tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn phải nhập Họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrWhiteSpace(dateNamSinh.Text))
            {
                MessageBox.Show("Bạn phải nhập Năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chkResetPassword.Checked == true
                || idUserSelect <= 0)
            {
                if (String.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (String.IsNullOrWhiteSpace(txtMatKhau2.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                } if (!txtMatKhau.Text.Equals(txtMatKhau2.Text))
                {
                    MessageBox.Show("Trường mật khẩu mới và trường nhập lại mật khẩu không khớp nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            //if (cboPhanQuyen.SelectedIndex < 1)
            //{
            //    MessageBox.Show("Phải phân quyền cho người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }

        private void setInfoDialog(int idUser)
        {
            nv = nvBll.GetNhanVienById(idUser);
            if (nv == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //set info user in dialog
            txtTenDangNhap.Text = nv.TenDangNhap;
            dateNamSinh.Text = nv.NamSinh != null ? nv.NamSinh.Day + "/" + nv.NamSinh.Month + "/" + nv.NamSinh.Year : "";
            txtDiaChi.Text = nv.DiaChi;
            txtQueQuan.Text = nv.QueQuan;
            txtSoDienThoai.Text = nv.SoDienThoai;
            txtEmail.Text = nv.Email;
            txtMatKhau.Text = nv.MatKhau;
            txtHoTen.Text = nv.HoTen;
            cboPhanQuyen.SelectedIndex = nv.PhanQuyen;
        }

        private void setEmptyData()
        {
            txtTenDangNhap.Text = "";
            dateNamSinh.EditValue = DateTime.Now;
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            cboPhanQuyen.SelectedIndex = 0;
        }

        private void enableControl(bool isEnabel)
        {
            txtMatKhau.Enabled = isEnabel;
            txtMatKhau2.Enabled = isEnabel;
        }

        private void bntReset_Click(object sender, EventArgs e)
        {

            if (idUserSelect > 0)// idUserSelect>0 ==> cap nhat
            {
                setInfoDialog(idUserSelect);
            }
            else
            {
                setEmptyData();
            }
        }

        private void chkResetPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResetPassword.Checked == true)
            {
                enableControl(true);
            }
            else
            {
                enableControl(false);
            }
        }
    }
}
