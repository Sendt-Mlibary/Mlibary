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
    public partial class ucDialogAddBookForBorrow : UserControl
    {
        private TaiLieuBLL tlBll;
        private ucDialogBill ucBillDialog;
        public ucDialogAddBookForBorrow(ucDialogBill ucBillDialog)
        {
            InitializeComponent();
            this.tlBll = new TaiLieuBLL();
            this.ucBillDialog = ucBillDialog;
            setDataForGridView(ucBillDialog.getDtCreateBorrows());
        }

        public void setDataForGridView(DataTable dtCreateBorrows)
        {
            int idLogin = this.ucBillDialog.UcManagerMember.Home.LoginUser.Id;
            DataTable dt = tlBll.SearchAddBookForBorrow(searchControl1.Text, idLogin);
            DataTable dtRow = new DataTable();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    if(dtCreateBorrows!=null) { 
                        for (int j = 0; j < dtCreateBorrows.Rows.Count ; j++) {
                            if (dt.Rows[i]["Id"]!=null 
                                && dtCreateBorrows.Rows[j]["Id"] !=null 
                                && dt.Rows[i]["Id"].ToString().Equals(dtCreateBorrows.Rows[j]["Id"].ToString()))
                            {
                                dt.Rows.RemoveAt(i);
                                i--;
                                break;
                            } 
                        }
                    }
                }
                grcLstBooks.DataSource = dt;
            }
        }
        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            setDataForGridView(ucBillDialog.getDtCreateBorrows());
        }


        private void bntAddBook_Click(object sender, EventArgs e)
        {
            if (grvLstBooks.SelectedRowsCount > 0)
            {
                int rowHandle = grvLstBooks.GetDataRowHandleByGroupRowHandle(grvLstBooks.FocusedRowHandle);
                DataRow dt = grvLstBooks.GetDataRow(rowHandle);
                ucBillDialog.addNewRowInGroupMode(dt);
                MessageBox.Show("Đã thêm tài liệu vào phiếu mượn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Common.showParentForm(this.ucBillDialog);
                Common.disposeParentForm(this);
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Common.showParentForm(this.ucBillDialog);
            Common.disposeParentForm(this);
        }
    }
}
