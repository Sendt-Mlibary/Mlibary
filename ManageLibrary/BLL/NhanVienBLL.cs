using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using ManageLibrary.DAL;
using ManageLibrary.Util;
using ManageLibrary.DAO;
namespace ManageLibrary.BLL
{
    class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL;
        public NhanVienBLL()
        {
            nhanVienDAL = new NhanVienDAL();
        }

        public bool DangNhap(NhanVienDb nv)
        {
            nv.MatKhau = Common.md5(nv.MatKhau);
            Console.WriteLine(nv.MatKhau);
            return nhanVienDAL.DangNhap(nv);
        }
        public bool ThemNhanVien(NhanVienDb nv)
        {
            return nhanVienDAL.ThemNhanVien(nv);
        }
        public bool SuaNhanVien(NhanVienDb nv)
        {
            return nhanVienDAL.SuaNhanVien(nv);
        }
        public bool XoaNhanVien(int NhanVienID)
        {
            return nhanVienDAL.XoaNhanVien(NhanVienID);
        }
        public DataTable GetAllNhanVien()
        {
            return nhanVienDAL.GetAllNhanVien();
        }

        public NhanVienDb GetNhanVienById(int iD)
        {
            return nhanVienDAL.GetNhanVienById(iD);
        }

        public List<NhanVienDb> GetAllNhanVienNotIdUpdate(int iD)
        {
            return nhanVienDAL.GetAllNhanVienNotIdUpdate(iD);
        }

        internal DataTable TimKiem(string p)
        {
            return nhanVienDAL.TimKiem(p);
        }
    }
}
