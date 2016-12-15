using ManageLibrary.DAL;
using ManageLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ManageLibrary.BLL
{
    class PhieuMuonBLL
    {
        PhieuMuonDAL pmDAL;
        public PhieuMuonBLL() {
            pmDAL = new PhieuMuonDAL();
        }
        public int ThemPhieuMuon(PhieuMuonDb pm) {
            return pmDAL.ThemPhieuMuon(pm);
        }

        public void ThemChiTietPhieuMuon(List<ChiTietPhieuMuonDb> lstChiTietPhieuMuonDb)
        {
            pmDAL.ThemChiTietPhieuMuon(lstChiTietPhieuMuonDb);
        }

        public bool GiaHan(int maCtPhieuMuon, DateTime value, string mota)
        {
           return pmDAL.GiaHan(maCtPhieuMuon, value, mota);
        }

        public DataTable GetHistoryBooks(int memberId)
        {
            return pmDAL.GetHistoryBooks(memberId);
        }

        public bool ThuHoi(int selectBookHistoryId)
        {
            return pmDAL.ThuHoi(selectBookHistoryId);
        }

        public DataTable getTaiLieuByChiTietPhieuMuonId(int selectBookHistoryId)
        {
            return pmDAL.getTaiLieuByChiTietPhieuMuonId(selectBookHistoryId);
        }
    }
}
