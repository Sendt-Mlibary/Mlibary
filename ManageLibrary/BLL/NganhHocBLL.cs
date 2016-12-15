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
    class NganhHocBLL
    {
        NganhHocDAL nganhhocDAL;
        public NganhHocBLL() {
            nganhhocDAL = new NganhHocDAL();
        }

        public NganhHocDb getNganhHocById(int ID) {
            return nganhhocDAL.getNganhHocById(ID);
        }

        public bool ThemNganhHoc(NganhHocDb nh) {
            return nganhhocDAL.ThemNganhHoc(nh);
        }

        public bool SuaNganhHoc(NganhHocDb nh) {
            return nganhhocDAL.SuaNganhHoc(nh);
        }

        public bool XoaNganhHoc(int id) {
            return nganhhocDAL.XoaNganhHoc(id);
        }

        public DataTable GetAllNganhHoc() {
            return nganhhocDAL.GetAllNganhHoc();
        }

        public DataTable TimKiem(string p) {
            return nganhhocDAL.TimKiem(p);
        }
    }
}
