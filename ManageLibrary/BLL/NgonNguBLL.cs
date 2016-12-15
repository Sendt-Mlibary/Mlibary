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
    class NgonNguBLL
    {
        NgonNguDAL ngonnguDAL;
        public NgonNguBLL() {
            ngonnguDAL = new NgonNguDAL();
        }

        public NgonNguSachDb getNgonNguById(int ID) {
            return ngonnguDAL.getNgonNguById(ID);
        }

        public bool ThemNgonNgu(NgonNguSachDb nn) {
            return ngonnguDAL.ThemNgonNgu(nn);
        }

        public bool SuaNgonNgu(NgonNguSachDb nn) {
            return ngonnguDAL.SuaNgonNgu(nn);
        }

        public bool XoaNgonNgu(int id) {
            return ngonnguDAL.XoaNgonNgu(id);
        }

        public DataTable GetAllNgonNgu() {
            return ngonnguDAL.GetAllNgonNgu();
        }

        public DataTable TimKiem(string p) {
            return ngonnguDAL.TimKiem(p);
        }


    }
}
