using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class ManagerBooks : Form
    {
        //TaiLieu tl;
        //BLL.ThuThu ttBll;
        public ManagerBooks()
        {
            //tl = new TaiLieu();
            //ttBll = new BLL.ThuThu();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hienThiTaiLieu.TaiLieu' table. You can move, or remove it, as needed.
            //this.taiLieuTableAdapter.Fill(this.hienThiTaiLieu.TaiLieu);

        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    tl.TenSach = txtTenTaiLieu.Text.ToString();
        //    tl.TacGia = txtTenTacGia.Text.ToString();
        //    tl.NamXuatBan = dtNamXuatBan.Value;
        //    tl.Gia = float.Parse(txtGia.Text);
        //    tl.TheLoai = txtTheLoai.Text.ToString();
        //    tl.Nganh = txtNganh.Text.ToString();
        //    tl.NgonNgu = txtNgonNgu.Text.ToString();
        //    tl.KichThuoc = float.Parse(txtKichThuoc.Text);
        //    tl.TaiBan = int.Parse(txtTaiBan.Text);
        //    tl.SoLuong = int.Parse(txtSoLuong.Text);
        //    tl.TrangThai = null;
        //    if(ttBll.ThemSach(tl))
        //    {
        //        this.Show();
        //        HienThiDanhSachTaiLieu();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bạn đã nhập sai thông tin yêu cầu nhập lại !", "Thông báo");
        //    }

        //}
        //public void HienThiDanhSachTaiLieu()
        //{
        //    this.taiLieuTableAdapter.Fill(this.hienThiTaiLieu.TaiLieu);
        //}
    }
}
