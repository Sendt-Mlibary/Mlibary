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
    public partial class ucManagerMember : UserControl
    {
        private Home home;
        private FormDialog form;
        private MemberBLL bdBll;
        private int idMemberSelect;
        private string memberNameSelect;
        private string isActive;

        public int IdMemberSelect
        {
            get
            {
                return idMemberSelect;
            }

            set
            {
                idMemberSelect = value;
            }
        }

        public string MemberNameSelect
        {
            get
            {
                return memberNameSelect;
            }

            set
            {
                memberNameSelect = value;
            }
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

        public Home Home
        {
            get
            {
                return home;
            }

            set
            {
                home = value;
            }
        }

        public ucManagerMember(Home home)
        {
            InitializeComponent();
            this.Home = home;
            bdBll = new MemberBLL();
            LoadGridView();
        }

        public void LoadGridView()
        {
            DataTable dt = bdBll.GetAllBanDoc();
           grcBanDoc.DataSource = dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            idMemberSelect = 0;
            ucDialogMember uc = new ucDialogMember(this);
            form = new FormDialog(uc);
            form.Size = new Size(450, 270);
            form.Show();
        }

        public void DisposeDialog()
        {
            if (form != null)
            {
                form.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvBanDoc.SelectedRowsCount > 0 && idMemberSelect > 0)
            {
                ucDialogMember uc = new ucDialogMember(this);
                form = new FormDialog(uc);
                form.Size = new Size(450, 270);
                form.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grvBanDoc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object item = grvBanDoc.GetRow(e.FocusedRowHandle);
            DataRowView row = (DataRowView)item;
            if (row != null)
            {
                idMemberSelect = Convert.ToInt32(row["Id"].ToString());
                memberNameSelect = row["HoTen"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grvBanDoc.SelectedRowsCount > 0 && idMemberSelect > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bỏ bạn đọc: " + memberNameSelect + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Validate xoa du lieu
                    if (true)
                    {
                        if (bdBll.XoaBanDoc(idMemberSelect))
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
                        MessageBox.Show("Bạn đọc này có dữ liệu trong lịch sử mượn-trả sách nên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void srcSearchMember_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bdBll.TimKiem(srcSearchMember.Text);
            grcBanDoc.DataSource = dt;
        }

        private void bntbntBooksManager_Click(object sender, EventArgs e)
        {
            if (grvBanDoc.SelectedRowsCount > 0 && idMemberSelect > 0)
            {
                Common.hidenParentForm(this);
                ucDialogBill uc = new ucDialogBill(this);
                form = new FormDialog(uc);
                form.WindowState = FormWindowState.Maximized;
                form.Size = new Size(uc.Width, uc.Height);
                form.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntReport_click(object sender, EventArgs e)
        {

        }
    }
}
