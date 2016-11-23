using ManageLibrary.DAL;
using ManageLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.BLL
{
    class TaiLieuBLL
    {
        TaiLieuDAL tailieuDAL;
        public TaiLieuBLL()
        {
            tailieuDAL = new TaiLieuDAL();
        }
        public bool ThemTaiLieu(TaiLieuDb tl)
        {
            return tailieuDAL.ThemTaiLieu(tl);
        }
        public TaiLieuDb getTaiLieuById(int iD)
        {
            return tailieuDAL.getTaiLieuById(iD);
        }
    }
}
