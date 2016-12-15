using ManageLibrary.BLL;
using ManageLibrary.DAO;
using ManageLibrary.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary.UserControls
{
    public partial class ucDialogDocument : UserControl
    {
        private TaiLieuDb tl;
        private TaiLieuBLL tlBll;
        private ucManagerDocuments ucManagerDocuments;
        private int idDocumentSelect;
        public ucDialogDocument(ucManagerDocuments ucManagerDocuments)
        {
            InitializeComponent();
            tlBll = new TaiLieuBLL();
            this.ucManagerDocuments = ucManagerDocuments;
            idDocumentSelect = ucManagerDocuments.IdDocumentSelect;
            if (idDocumentSelect > 0)     // Id ban ghi cap nhat > 0 ==> Cap nhat
            {
                setInfoDialog(idDocumentSelect);
            }
            else
            {
                setResetData();
            }
        }

        private void setInfoDialog(int idDocumentSelect)
        {
            tl = tlBll.getTaiLieuById(idDocumentSelect);
            if (tl == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu tài liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //set info document in dialog
            txtTenSach.Text = tl.TenSach;
            txtTacGia.Text = tl.TacGia;
            txtNamXuatBan.Text = tl.NamXuatBan;
            txtGia.Text = Convert.ToString(tl.Gia);
            cboTheLoai.SelectedIndex = tl.ID_TheLoaiSach;
            cboNganhHoc.SelectedIndex = tl.ID_NganhHoc;
            cboNgonNguSach.SelectedIndex = tl.ID_NgonNguSach;
            txtTaiBan.Text = Convert.ToString(tl.TaiBan);
            txtSoLuong.Text = Convert.ToString(tl.SoLuong);
            txtSoNgayMuon.Text = Convert.ToString(tl.SoNgayMuon);
            cboTrangThai.SelectedIndex = tl.TrangThai == true ? 0 : 1;// 0: Được cho mượn, 1: không được cho mượn
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // id document ton tai ==> update document
            // else => create update document
            if (idDocumentSelect > 0)          // Id ban ghi cap nhat > 0 ==> Cap nhat
            {
                updateDocument(idDocumentSelect);
            }
            else
            {
                createDocument();
            }
        }

        private void updateDocument(int idDocumentSelect)
        {
            // validate
            if (!validateDocument())
            {
                return;
            }
            // Kiem tra lai nhan vien co ton tai khong?
            tl = tlBll.getTaiLieuById(idDocumentSelect);
            if (tl == null)
            {
                MessageBox.Show("Không tồn tại dữ liệu tài liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tl.TenSach = txtTenSach.Text;
            tl.TacGia = txtTacGia.Text;
            tl.NamXuatBan = txtNamXuatBan.Text;
            tl.Gia = (float)Convert.ToDouble(txtGia.Text);
            tl.ID_TheLoaiSach = Convert.ToInt32(cboTheLoai.SelectedIndex);
            tl.ID_NganhHoc = Convert.ToInt32(cboNganhHoc.SelectedIndex);
            tl.ID_NgonNguSach = Convert.ToInt32(cboNgonNguSach.SelectedIndex);
            tl.TaiBan = Convert.ToInt32(txtTaiBan.Text);
            tl.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            tl.SoNgayMuon = Convert.ToInt32(txtSoNgayMuon.Text);
            tl.TrangThai = cboTrangThai.SelectedIndex == 0 ? true : false;       //select index =="Được cho mượn" là true, còn ngược lại

            if (tlBll.SuaTaiLieu(tl))
            {
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucManagerDocuments.LoadGridView();
                ucManagerDocuments.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai thông tin tài liệu cần sửa, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setResetData()
        {
            txtTenSach.Text ="";
            txtTacGia.Text  = "";
            txtNamXuatBan.Text = "";
            txtGia.Text = "";
            cboTheLoai.SelectedIndex = 0;
            cboNganhHoc.SelectedIndex = 0;
            cboNgonNguSach.SelectedIndex = 0;
            txtTaiBan.Text = "";
            txtSoLuong.Text = "";
            txtSoNgayMuon.Text = "180";
            cboTrangThai.SelectedIndex = 0;//0: Được cho mượn
        }

        public bool validateDocument()
        {
            if (String.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Bạn phải nhập Tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return false;
            }
            if (cboTheLoai.SelectedIndex <= 0)
            {
                MessageBox.Show("Bạn phải nhập Thể loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTheLoai.Focus();
                return false;
            }
            if (cboNgonNguSach.SelectedIndex <= 0)
            {
                MessageBox.Show("Bạn phải nhập Ngôn ngữ sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNgonNguSach.Focus();
                return false;
            }
            if (cboNganhHoc.SelectedIndex <= 0)
            {
                MessageBox.Show("Bạn phải chọn Ngành học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNganhHoc.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn phải nhập Số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            return true;
        }

        private void createDocument()
        {
            // validate
            if (!validateDocument())
            {
                return;
            }
            tl = new TaiLieuDb();
            tl.TenSach = txtTenSach.Text;
            tl.TacGia = txtTacGia.Text;
            tl.NamXuatBan = txtNamXuatBan.Text;
            if(!String.IsNullOrWhiteSpace(txtGia.Text)) {
                tl.Gia = (float)Convert.ToDouble(txtGia.Text.Trim());
            }
            tl.ID_TheLoaiSach = cboTheLoai.SelectedIndex;
            tl.ID_NganhHoc = cboNganhHoc.SelectedIndex;
            tl.ID_NgonNguSach = cboNgonNguSach.SelectedIndex;
            tl.TaiBan = Convert.ToInt32(txtTaiBan.Text);
            tl.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            tl.SoNgayMuon = Convert.ToInt32(txtSoNgayMuon.Text);
            tl.TrangThai = cboTrangThai.SelectedIndex == 0 ? true : false;       //select index =="Được cho mượn" là true, còn ngược lại

            if (tlBll.ThemTaiLieu(tl))
            {
                MessageBox.Show("Đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucManagerDocuments.LoadGridView();
                ucManagerDocuments.DisposeDialog();
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (idDocumentSelect > 0)     // Id ban ghi cap nhat > 0 ==> Cap nhat
            {
                setInfoDialog(idDocumentSelect);
            }
            else
            {
                setResetData();
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Common.showParentForm(this.ucManagerDocuments);
            Common.disposeParentForm(this);
        }
    }
}
