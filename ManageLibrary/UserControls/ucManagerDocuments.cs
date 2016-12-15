using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using ManageLibrary.BLL;
using ManageLibrary.Util;
using System.Windows.Forms;

namespace ManageLibrary.UserControls
{
    public partial class ucManagerDocuments : UserControl
    {
        private Home home;
        private FormDialog form;
        private TaiLieuBLL tlBll;
        private string isActive;
        private int idDocumentSelect;
        public ucManagerDocuments(Home home)
        {
            InitializeComponent();
            this.home = home;
            tlBll = new TaiLieuBLL();       //Khoi tao truoc khi su dung
            LoadGridView();
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

        public int IdDocumentSelect
        {
            get
            {
                return idDocumentSelect;
            }

            set
            {
                idDocumentSelect = value;
            }
        }

        public void LoadGridView()
        {
            DataTable dt = tlBll.GetAll();
            grcDocument.DataSource = dt;//ten gridview
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
            if (gridViewDocuments.SelectedRowsCount > 0 && idDocumentSelect > 0)
            {
                ucDialogDocument document = new ucDialogDocument(this);
                form = new FormDialog(document);
                form.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để cập nhật", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridViewDocuments_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object item = gridViewDocuments.GetRow(e.FocusedRowHandle);
            DataRowView row = (DataRowView)item;
            if (row != null)
            {
                idDocumentSelect = Convert.ToInt16(row["Id"].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridViewDocuments.SelectedRowsCount > 0 && idDocumentSelect > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bỏ Tài liệu có mã: " + idDocumentSelect, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (validateDelete(idDocumentSelect))
                    {
                        if (tlBll.XoaTaiLieu(idDocumentSelect))
                        {
                            LoadGridView();
                            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra trong quá trình ", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được xóa tài liệu này do đã có trong lịch sử mượn tài liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn tài liệu nào để xóa", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            idDocumentSelect = 0;
            ucDialogDocument document = new ucDialogDocument(this);
            form = new FormDialog(document);
            form.Show();
        }

        private bool validateDelete(int idDocument) {
            return true;
        }

        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tlBll.Search(searchControl1.Text);
            grcDocument.DataSource = dt;//ten gridview
        }


    }
}
