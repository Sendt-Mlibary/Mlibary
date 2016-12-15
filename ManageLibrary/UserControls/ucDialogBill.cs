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
    public partial class ucDialogBill : UserControl
    {
        private PhieuMuonDb pm;
        private PhieuMuonBLL pmBLL;
        private ucManagerMember ucManagerMember;
        private MemberBLL bdBll;
        private int memberId;
        private int selectBookHistoryId;

        public int SelectBookHistoryId
        {
            get
            {
                return selectBookHistoryId;
            }

            set
            {
                selectBookHistoryId = value;
            }
        }

        public ucManagerMember UcManagerMember
        {
            get
            {
                return ucManagerMember;
            }

            set
            {
                ucManagerMember = value;
            }
        }

        public DataTable getDtCreateBorrows()
        {
            return grcCreateBrorrow.DataSource as DataTable;
        }

        public ucDialogBill(ucManagerMember ucManagerMember)
        {
            InitializeComponent();
            this.UcManagerMember = ucManagerMember;
            this.memberId = ucManagerMember.IdMemberSelect;
            this.pmBLL = new PhieuMuonBLL();
            this.pm = new PhieuMuonDb();
            this.bdBll = new MemberBLL();
            setDataInfo(memberId);
        }

        private void setDataInfo(int memberId)
        {
            MemberDb memberDb = bdBll.GetMemberById(memberId);
            txtMemberId.Text = memberDb.ID.ToString();
            txtMemberName.Text = memberDb.HoTen;
            txtMemberBirthday.Text = Common.convertDateFormat(memberDb.NamSinh, "dd/MM/yyyy");
            txtMemberEmail.Text = memberDb.Email;
            txtMemberAddr.Text = memberDb.HoTen;
            removeDataTab1();
            setDataTab2(memberId);
        }

        private void setDataTab2(int memberId)
        {
            DataTable dt = pmBLL.GetHistoryBooks(memberId);
            grcBookHistory.DataSource = dt;
            checkTaiLieuViPham(dt);
            bntTab2AddDay.Enabled = false;
            bntTab2Receive.Enabled = false;
        }

        public void checkTaiLieuViPham(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                int viPham = 0;
                for (int i = 0, total = dt.Rows.Count; i < total; i++)
                {
                    DataRow row = dt.Rows[i];
                    DateTime dateNow = DateTime.Now.Date;
                    if ((row["trangthai"] != null
                        && int.Parse(row["trangthai"].ToString()) == Constants.CT_PHIEUMUON_TRANGTHAI.VI_PHAM)
                        || (row["hantra"] != null && Convert.ToDateTime(row["hantra"].ToString()) < dateNow))
                    {
                        viPham++;
                    }
                }
                if (viPham > 0)
                {
                    xtraTabControl1.TabPages[0].PageVisible = false;
                    MessageBox.Show("Có " + viPham + " tài liệu đang bị vi phạm hoặc quá hạn", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //remove ds phieu muon
        private void removeDataTab1()
        {
            grvCreateBrorrow.SelectAll();
            grvCreateBrorrow.DeleteSelectedRows();
        }

        public void addNewRowInGroupMode(DataRow dataRow)
        {
            DataTable sourceTable = grcCreateBrorrow.DataSource as DataTable;
            if (sourceTable == null)
            {
                sourceTable = new DataTable();
                sourceTable.Columns.Add(new DataColumn("ID"));
                sourceTable.Columns.Add(new DataColumn("TenSach"));
                sourceTable.Columns.Add(new DataColumn("TacGia"));
                sourceTable.Columns.Add(new DataColumn("NamXuatBan"));
                sourceTable.Columns.Add(new DataColumn("Gia"));
                sourceTable.Columns.Add(new DataColumn("TenTheLoai"));
                sourceTable.Columns.Add(new DataColumn("TenNganhHoc"));
                sourceTable.Columns.Add(new DataColumn("TenNgonNguSach"));
                sourceTable.Columns.Add(new DataColumn("TaiBan"));
                sourceTable.Columns.Add(new DataColumn("SoLuong"));
                sourceTable.Columns.Add(new DataColumn("SoNgayMuon"));
                sourceTable.Columns.Add(new DataColumn("TrangThai"));
            }
            DataRow row = sourceTable.NewRow();
            row["ID"] = dataRow["ID"];
            row["TenSach"] = dataRow["TenSach"];
            row["TacGia"] = dataRow["TacGia"];
            row["NamXuatBan"] = dataRow["NamXuatBan"];
            row["Gia"] = dataRow["Gia"];
            row["TenTheLoai"] = dataRow["TenTheLoai"];
            row["TenNganhHoc"] = dataRow["TenNganhHoc"];
            row["TenNgonNguSach"] = dataRow["TenNgonNguSach"];
            row["TaiBan"] = dataRow["TaiBan"];
            row["SoLuong"] = dataRow["SoLuong"];
            row["SoNgayMuon"] = dataRow["SoNgayMuon"];
            row["TrangThai"] = dataRow["TrangThai"];
            sourceTable.Rows.Add(row);
            grcCreateBrorrow.DataSource = sourceTable;
        }

        private void bntTab1AddDocument_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Hide();
            ucDialogAddBookForBorrow uc = new ucDialogAddBookForBorrow(this);
            FormDialog form = new FormDialog(uc);
            form.WindowState = FormWindowState.Maximized;
            form.Size = new Size(uc.Width, uc.Height);
            form.Show();
        }

        private void bntTab1RemoveDocument_Click(object sender, EventArgs e)
        {
            if (grvCreateBrorrow.SelectedRowsCount > 0)
            {
                DataRow[] rows = new DataRow[grvCreateBrorrow.SelectedRowsCount];
                for (int i = 0; i < grvCreateBrorrow.SelectedRowsCount; i++)
                {
                    rows[i] = grvCreateBrorrow.GetDataRow(grvCreateBrorrow.GetSelectedRows()[i]);
                }
                grvCreateBrorrow.BeginSort();
                try
                {
                    foreach (DataRow row in rows)
                        row.Delete();
                }
                finally
                {
                    grvCreateBrorrow.EndSort();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn bản ghi để xóa bỏ", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntTab1Reset_Click(object sender, EventArgs e)
        {
            removeDataTab1();
        }

        private void bntTab1Save_Click(object sender, EventArgs e)
        {
            if (grvCreateBrorrow.RowCount <= 0)
            {
                MessageBox.Show("Không có bản ghi nào để tạo phiếu mượn", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tạo phiếu mượn tài liệu và in phiếu mượn tài liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable sourceTable = grcCreateBrorrow.DataSource as DataTable;
                PhieuMuonDb phieuMuonDb = new PhieuMuonDb();
                phieuMuonDb.Id_NhanVien = UcManagerMember.Home.LoginUser.Id;
                phieuMuonDb.Id_BanDoc = Int32.Parse(txtMemberId.Text);
                phieuMuonDb.GhiChu = "";
                phieuMuonDb.Id = pmBLL.ThemPhieuMuon(phieuMuonDb);

                //chi tiet phieu muon
                List<ChiTietPhieuMuonDb> lstChiTietPhieuMuonDb = new List<ChiTietPhieuMuonDb>();
                for (int i = 0; i < sourceTable.Rows.Count; i++)
                {
                    ChiTietPhieuMuonDb ctpm = new ChiTietPhieuMuonDb();
                    ctpm.Id_PhieuMuon = phieuMuonDb.Id;
                    ctpm.Id_TaiLieu = Int32.Parse(sourceTable.Rows[i]["ID"].ToString());
                    ctpm.HanTra = Common.addDay(Int32.Parse(sourceTable.Rows[i]["SoNgayMuon"].ToString()));
                    ctpm.MoTa = "";
                    ctpm.SoLuong = 1;// mac dinh muon 1 cuon duy nhat
                    ctpm.TrangThai = Constants.CT_PHIEUMUON_TRANGTHAI.DANG_MUON;
                    lstChiTietPhieuMuonDb.Add(ctpm);
                }

                pmBLL.ThemChiTietPhieuMuon(lstChiTietPhieuMuonDb);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeDataTab1();
            }
        }

        private void bntTab2Reset_Click(object sender, EventArgs e)
        {
            setDataTab2(memberId);
        }

        //Gia han muon tai lieu
        private void bntTab2AddDay_Click(object sender, EventArgs e)
        {
            if (grvBookHistory.SelectedRowsCount > 0 && SelectBookHistoryId > 0)
            {
                ucDialogReNewBooks uc = new ucDialogReNewBooks(this);
                FormDialog form = new FormDialog(uc);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size(uc.Width + 30, uc.Height + 120);
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một bản ghi", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grvBookHistory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object item = grvBookHistory.GetRow(e.FocusedRowHandle);
            DataRowView row = (DataRowView)item;
            if (row != null)
            {
                SelectBookHistoryId = Convert.ToInt32(row["ID"].ToString());
                DataTable dt = pmBLL.getTaiLieuByChiTietPhieuMuonId(SelectBookHistoryId);
                if (dt != null
                    && dt.Rows.Count > 0
                    && (int.Parse(dt.Rows[0]["trangthai"].ToString()) == Constants.CT_PHIEUMUON_TRANGTHAI.DANG_GIA_HAN
                    || int.Parse(dt.Rows[0]["trangthai"].ToString()) == Constants.CT_PHIEUMUON_TRANGTHAI.DANG_MUON))
                {
                    bntTab2AddDay.Enabled = true;
                    bntTab2Receive.Enabled = true;
                    bntTab2Warning.Enabled = true;
                }
                else if (dt != null
                    && dt.Rows.Count > 0
                    && (int.Parse(dt.Rows[0]["trangthai"].ToString()) == Constants.CT_PHIEUMUON_TRANGTHAI.VI_PHAM
                    || int.Parse(dt.Rows[0]["trangthai"].ToString()) == Constants.CT_PHIEUMUON_TRANGTHAI.DA_TRA))
                {
                    bntTab2AddDay.Enabled = false;
                    bntTab2Receive.Enabled = false;
                    bntTab2Warning.Enabled = false;
                }
            }

        }

        private void bntTab2Receive_Click(object sender, EventArgs e)
        {
            if (grvBookHistory.SelectedRowsCount <= 0)
            {
                MessageBox.Show("Phải chọn một bản ghi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Thu hồi tài liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pmBLL.ThuHoi(SelectBookHistoryId))
                {
                    setDataTab2(memberId);
                    MessageBox.Show("Đã thu hồi tài liệu thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thu hồi tài liệu được, Xin vui lòng liên hệ vói Administrator", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bntTab2Warning_Click(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Common.showParentForm(this.ucManagerMember);
            Common.disposeParentForm(this);
        }
    }
}
