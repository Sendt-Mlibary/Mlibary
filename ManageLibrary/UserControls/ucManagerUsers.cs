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
    public partial class ucManagerUsers : UserControl
    {
        private Home home;
        private FormDialog form;
        private NhanVienBLL nvBll;
        private int idUserSelect;
        private string userNameSelect;
        private string isActive;

        public string IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public int IdUserSelect
        {
            get { return idUserSelect; }
            set { idUserSelect = value; }
        }

        public ucManagerUsers(Home home)
        {
            InitializeComponent();
            this.home = home;
            this.nvBll = new NhanVienBLL();
            LoadGridView();
        }

        private void gridViewNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object item = gridViewNhanVien.GetRow(e.FocusedRowHandle);
            DataRowView row = (DataRowView)item;
            if (row != null)
            {
                idUserSelect = Convert.ToInt16(row["Id"].ToString());
                userNameSelect = row["TenDangNhap"].ToString();
            }
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            IsActive = Constants.IsActive.CREATE;
            ucUserDialog uc = new ucUserDialog(this);
            form = new FormDialog(uc);
            form.Show();
        }
        private void bntEdit_Click(object sender, EventArgs e)
        {
            if (gridViewNhanVien.SelectedRowsCount > 0 && idUserSelect > 0)
            {
                IsActive = Constants.IsActive.UPDATE;
                ucUserDialog uc = new ucUserDialog(this);
                form = new FormDialog(uc);
                form.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (gridViewNhanVien.SelectedRowsCount >0 && idUserSelect > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bỏ Tên đăng nhập: " + userNameSelect, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Validate xoa du lieu
                    if (true)
                    {
                        if (nvBll.XoaNhanVien(idUserSelect))
                        {
                            LoadGridView();
                            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên này có dữ liệu trong lịch sử mượn-trả sách nên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadGridView()
        {
            DataTable dt = nvBll.GetAllNhanVien();
            grwNhanVien.DataSource = dt;
        }

        public void DisposeDialog()
        {
            if (form != null)
            {
                form.Dispose();
            }
        }
        private void sctSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = nvBll.TimKiem(sctSearch.Text);
            grwNhanVien.DataSource = dt;
        }
    }
}
