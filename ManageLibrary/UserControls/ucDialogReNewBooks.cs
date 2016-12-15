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
using ManageLibrary.DAO;
using ManageLibrary.Util;

namespace ManageLibrary.UserControls
{
    public partial class ucDialogReNewBooks : UserControl
    {
        private PhieuMuonBLL pmBLL;
        private TaiLieuBLL tlBll;
        private ucDialogBill ucBooksDialog;
        private int selectBookHistoryId;
        public ucDialogReNewBooks(ucDialogBill ucBooksDialog)
        {
            InitializeComponent();
            this.pmBLL = new PhieuMuonBLL();
            this.tlBll = new TaiLieuBLL();
            this.ucBooksDialog = ucBooksDialog;
            this.selectBookHistoryId = ucBooksDialog.SelectBookHistoryId;
            setInfoDialog(selectBookHistoryId);
        }

        private void setInfoDialog(int selectBookHistoryId)
        {
            DataTable dt = pmBLL.getTaiLieuByChiTietPhieuMuonId(selectBookHistoryId);
            if (dt == null && dt.Rows.Count<=0)
            {
                MessageBox.Show("Không tồn tại dữ liệu tài liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Common.disposeParentForm(this);
                return;
            }
            //set info document in dialog
            txtMaTaiLieu.Text = Convert.ToString(dt.Rows[0]["ID"]);
            txtTenSach.Text = dt.Rows[0]["TenSach"].ToString();
            txtTacGia.Text = dt.Rows[0]["TacGia"].ToString();
            txtNamXuatBan.Text = dt.Rows[0]["NamXuatBan"].ToString();
            txtGia.Text = Convert.ToString(dt.Rows[0]["Gia"].ToString());
            txtTenTheLoai.Text = dt.Rows[0]["TenTheLoai"].ToString();
            txtTenNganhHoc.Text = dt.Rows[0]["TenNganhHoc"].ToString();
            txtTenNgonNgu.Text = dt.Rows[0]["TenNgonNguSach"].ToString();
            txtTaiBan.Text = dt.Rows[0]["TaiBan"].ToString();
            txtSoLuong.Text = Convert.ToString(dt.Rows[0]["SoLuong"].ToString());
            txtSoNgayMuonToiDa.Text = Convert.ToString(dt.Rows[0]["SoNgayMuon"].ToString());
            dateGiaHan.DateTime = Common.addDay(Constants.BOOKS.GIA_HAN_MUON_SACH);
            txtMoTa.Text = "";
        }

        private void bntGiaHan_Click(object sender, EventArgs e)
        {
            if(dateGiaHan.DateTime == null || dateGiaHan.DateTime <= DateTime.Now)
            {
                MessageBox.Show("Ngày gia hạn mượn tài liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pmBLL.GiaHan(selectBookHistoryId, dateGiaHan.DateTime, txtMoTa.Text))
            {
                MessageBox.Show("Đã gia hạn mượn tài liệu thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Common.showParentForm(this.ucBooksDialog);
                Common.disposeParentForm(this);
            }
            else
            {
                MessageBox.Show("Không gia hạn mượn tài liệu được, Xin vui lòng liên hệ vói Administrator", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Common.showParentForm(this.ucBooksDialog);
            Common.disposeParentForm(this);
        }
    }
}
