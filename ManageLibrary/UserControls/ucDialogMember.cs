using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManageLibrary.DAO;
using ManageLibrary.BLL;
using ManageLibrary.Util;

namespace ManageLibrary.UserControls
{
    public partial class ucDialogMember : UserControl
    {
        MemberDb bd;
        MemberBLL bdBLL;
        private ucManagerMember ucMangerMember;
        private int idMemberSelect;
        private string isActive;

        public string IsActive
        {
            get
            {
                return IsActive1;
            }

            set
            {
                IsActive1 = value;
            }
        }

        public string IsActive1
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

        public ucDialogMember(ucManagerMember ucManagerMember)
        {
            InitializeComponent();
            bdBLL = new MemberBLL();
            this.ucMangerMember = ucManagerMember;
            idMemberSelect = ucManagerMember.IdMemberSelect;
            if (idMemberSelect > 0)                         // idUserSelect > 0 ==> cap nhat
            {
                setInfoDialog(idMemberSelect);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // else => create user
            if (idMemberSelect > 0)// idUserSelect > 0 ==> cap nhat
            {
                updateUser(idMemberSelect);
            }
            else
            {
                createMember();
            }
        }
        private void createMember()
        {
            // validate
            if (!validateMember())
            {
                return;
            }
            bd = new MemberDb();
            bd.HoTen = txtHoTen.Text;
            bd.Email = txtEmail.Text;
            bd.DiaChi = txtDiaChi.Text;
            bd.NamSinh = dtNamSinh.DateTime;
            bd.SoDienThoai = txtSoDienThoai.Text;
            if (bdBLL.ThemBanDoc(bd))
            {
                //MessageBox.Show("Đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucMangerMember.LoadGridView();
                ucMangerMember.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (idMemberSelect > 0)// idUserSelect>0 ==> cap nhat
            {
                setInfoDialog(idMemberSelect);
            }
            else
            {
                setEmptyData();
            }
        }

        private void setInfoDialog(int idMember)
        {
            bd = bdBLL.GetMemberById(idMember);
            if (bd == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu bạn đọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //set info user in dialog
            txtHoTen.Text = bd.HoTen;
            dtNamSinh.Text = bd.NamSinh != null ? bd.NamSinh.Day + "/" + bd.NamSinh.Month + "/" + bd.NamSinh.Year : "";
            txtDiaChi.Text = bd.DiaChi;
            txtSoDienThoai.Text = bd.SoDienThoai;
            txtEmail.Text = bd.Email;
        }

        private void setEmptyData()
        {
            txtHoTen.Text = "";
            dtNamSinh.EditValue = DateTime.Now;
            txtDiaChi.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void updateUser(int idMemberSelect)
        {
            // validate
            if (!validateMember())
            {
                return;
            }
            // Kiem tra lai ban doc co ton tai khong?
            bd = bdBLL.GetMemberById(idMemberSelect);
            if (bd == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bd.HoTen = txtHoTen.Text;
            bd.SoDienThoai = txtSoDienThoai.Text;
            bd.DiaChi = txtDiaChi.Text;
            bd.Email = txtEmail.Text;
            bd.NamSinh = DateTime.Parse(dtNamSinh.Text).Date;
            if (bdBLL.SuaBanDoc(bd))
            {
                //MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucMangerMember.LoadGridView();
                ucMangerMember.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai thông tin nhân viên cần sửa, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validateMember() {

            if (String.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn phải nhập Họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn phải nhập Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            if (dtNamSinh.DateTime==null || dtNamSinh.DateTime > DateTime.Now)
            {
                MessageBox.Show("Bạn phải nhập Năm sinh và Năm sinh phải nhở hơn thời gian hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNamSinh.Focus();
                return false;
            }
            return true;
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Common.showParentForm(this.ucMangerMember);
            Common.disposeParentForm(this);
        }
    }
}
