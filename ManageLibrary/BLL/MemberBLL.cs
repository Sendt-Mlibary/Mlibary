using ManageLibrary.DAL;
using ManageLibrary.DAO;
using System.Collections.Generic;
using System.Data;

namespace ManageLibrary.BLL
{
    class MemberBLL
    {
        MemberDAL memberDAL;
        public MemberBLL() {
            memberDAL = new MemberDAL();
        }
        public bool ThemBanDoc(MemberDb bd) {
            return memberDAL.ThemBanDoc(bd);
        }
        public MemberDb GetMemberById(int iD) {
            return memberDAL.GetMemberById(iD);
        }
        public bool SuaBanDoc(MemberDb bd) {
            return memberDAL.SuaBanDoc(bd);
        }

        public bool XoaBanDoc(int id) {
            return memberDAL.XoaBanDoc(id);
        }

        public DataTable TimKiem(string p) {
            return memberDAL.TimKiem(p);
        }

        public DataTable GetAllBanDoc() {
            return memberDAL.GetAllBanDoc();
        }
    }
}
