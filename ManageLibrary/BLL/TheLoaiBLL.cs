using ManageLibrary.DAL;
using ManageLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.BLL
{
    class TheLoaiBLL
    {
        TheLoaiDAL theloaiDAL;
        public TheLoaiBLL() {
            theloaiDAL = new TheLoaiDAL();
        }

        public bool ThemTheLoai(TheLoaiSachDb tl) {
            return theloaiDAL.ThemTheLoai(tl);
        }

        public bool SuaTheLoai(TheLoaiSachDb tl) {
            return theloaiDAL.SuaTheLoai(tl);
        }

        public bool XoaTheLoai(int id) {
            return theloaiDAL.XoaTheLoai(id);
        }

        public DataTable TimKiem(string p) {
            return theloaiDAL.TimKiem(p);
        }

        public DataTable GetAllTheLoai() {
            return theloaiDAL.GetAllTheLoai();
        }

        public TheLoaiSachDb getTheLoaiById(int ID) {
            return theloaiDAL.getTheLoaiById(ID);
        }
    }
}
