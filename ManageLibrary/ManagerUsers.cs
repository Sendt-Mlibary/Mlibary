using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageLibrary.UserControls;
using ManageLibrary.DAO;
using ManageLibrary.BLL;

namespace ManageLibrary
{
    public partial class ManagerUsers : Form
    {
        NhanVienDb nv;
        NhanVienBLL nvBll;
        // private int _MaNhanVien;
      public  int idUser = -1;
        FormDialog form;
        public ManagerUsers()
        {
            nv = new NhanVienDb();
            nvBll = new NhanVienBLL();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mLibraryDataSet1.hienthinhanvien' table. You can move, or remove it, as needed.
            //this.hienthinhanvienTableAdapter.Fill(this.mLibraryDataSet1.hienthinhanvien);
            // TODO: This line of code loads data into the 'mLibraryDataSet1.hienthinhanvien' table. You can move, or remove it, as needed.
            //this.hienthinhanvienTableAdapter.Fill(this.mLibraryDataSet1.hienthinhanvien);
            //cboNguoiQuanLy.DataSource = nvBll.GetAllNhanVien();
            //cboNguoiQuanLy.ValueMember = "ID";
            //cboNguoiQuanLy.DisplayMember = "HoTen";

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            //idUser = -1;
            //ucUserDialog uc = new ucUserDialog(this);
            //form = new FormDialog(uc);
            //form.Show();
        }
        public void HienThiDanhSachNhanVien()
        {
            //this.hienthinhanvienTableAdapter.Fill(this.mLibraryDataSet1.hienthinhanvien);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (idUser > 0) { 
            //    ucUserDialog uc = new ucUserDialog(this);
            //    form = new FormDialog(uc);
            //    form.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        //private void btnCapNhat_Click(object sender, EventArgs e)
        //{
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Thực hiện việc xóa
                int[] selRows = gridView1.GetSelectedRows();
                if (selRows == null)
                {
                    return;
                }
                int idnv = int.Parse(gridView1.GetFocusedDataRow()["ID"].ToString());
                //  int NhanVienChon = 
                //Gọi hàm xóa
                nvBll.XoaNhanVien(idnv);
                HienThiDanhSachNhanVien();
            }
        }

        private void GridNhanVien_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void GridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                idUser = Int32.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                idUser = Int32.Parse(gridView1.GetDataRow(e.FocusedRowHandle)["ID"].ToString());
            }
        }
        public void DisposeDialog()
        {
            form.Dispose();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                idUser = Int32.Parse(gridView1.GetDataRow(e.RowHandle)["ID"].ToString());
            }
        }
    }
}
