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
    public partial class ucDocumentDialog : UserControl
    {
        public ucDocumentDialog()
        {
            InitializeComponent();
        }

        private TaiLieuDb tl;
        private TaiLieuBLL tlBll;
        private ucManagerDocuments ucManagerDocuments;
        private int idDocumentSelect;
        private string isActive;
        public ucDocumentDialog(ucManagerDocuments ucManagerDocuments)
        {
            InitializeComponent();
            tlBll = new TaiLieuBLL();
            this.ucManagerDocuments = ucManagerDocuments;
            this.isActive = ucManagerDocuments.IsActive;
            if (Constants.IsActive.UPDATE.Equals(isActive))
            {
                idDocumentSelect = ucManagerDocuments.IdDocumentSelect;
                setInfoDialog(idDocumentSelect);
            }
            else
            {

            }
        }

        private void setInfoDialog(int idUser)
        {
            tl = tlBll.getTaiLieuById(idUser);
            if (tl == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu tài liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //set info user in dialog
            txtTenSach.Text = tl.TenSach;
            txtTacGia.Text = tl.TacGia;
            txtNamXuatBan.Text = tl.NamXuatBan;
            txtGia.Text = Convert.ToString(tl.Gia);
            cboTheLoai.EditValue = tl.ID_TheLoaiSach;
            cboNganhHoc.EditValue = tl.ID_NgonNguSach;
            cboNgonNguSach.EditValue = tl.ID_NgonNguSach;
            txtTaiBan.Text = Convert.ToString(tl.TaiBan);
            txtSoLuong.Text = Convert.ToString(tl.TaiBan);
            txtSoNgayMuon.Text = Convert.ToString(tl.SoNgayMuon);
            cboTrangThai.EditValue = tl.TrangThai;
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            // id user ton tai ==> update user
            // else => create user
            if (Constants.IsActive.UPDATE.Equals(isActive))
            {
                //updateUser(idUserSelect);
            }
            else
            {
                createUser();
            }
        }

        public bool validateDocument()
        {
            return true;
        }

        private void createUser()
        {
            // validate
            if (!validateDocument())
            {
                return;
            }
            tl = new TaiLieuDb();
            tl.TenSach = txtTenSach.ToString();
            tl.TacGia = txtTacGia.Text;
            tl.NamXuatBan = txtNamXuatBan.Text;
            tl.Gia =(float) Convert.ToDouble(txtGia.Text);
            tl.ID_TheLoaiSach = Convert.ToInt16(cboTheLoai.EditValue);
            tl.ID_NganhHoc = Convert.ToInt16(cboNganhHoc.EditValue);
            tl.ID_NgonNguSach = Convert.ToInt16(cboNgonNguSach.EditValue);
            tl.TaiBan = Convert.ToInt16(txtTaiBan.Text);
            tl.SoLuong = Convert.ToInt16(txtSoLuong.Text);
            tl.SoNgayMuon = Convert.ToInt16(txtSoNgayMuon.Text);
            tl.TrangThai = Convert.ToInt16(cboTrangThai.EditValue) == 1? true :false;

            if (tlBll.ThemTaiLieu(tl))
            {
                MessageBox.Show("Đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucManagerDocuments.LoadGridView();
                ucManagerDocuments.DisposeDialog();
                return;
            }
            else
            {
                return;
            }
        }
    }
}
