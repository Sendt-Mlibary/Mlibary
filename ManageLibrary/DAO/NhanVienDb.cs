using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    public class NhanVienDb
    {
        public NhanVienDb()
        {
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _tenDangNhap;

        public String TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        private String _matKhau;

        public String MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private String _hoTen;

        public String HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private DateTime _namSinh;

        public DateTime NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }
        private String _queQuan;

        public String QueQuan
        {
            get { return _queQuan; }
            set { _queQuan = value; }
        }
        private int _phanQuyen;

        public int PhanQuyen
        {
            get { return _phanQuyen; }
            set { _phanQuyen = value; }
        }
        private String _soDienThoai;

        public String SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        private String phanQuyenStr;

        public String PhanQuyenStr
        {
            get { return PhanQuyen == 1 || PhanQuyen == 2 ? "Người quản lý" : "Nhân viên"; }
            set { phanQuyenStr = value; }
        }

    }
}
