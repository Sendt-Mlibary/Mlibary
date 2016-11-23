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
    class TaiLieuBLL
    {
        TaiLieuDAL tailieuDAL;
        public TaiLieuBLL()
        {
            tailieuDAL = new TaiLieuDAL();  // khoi tao truoc khi su dung
        }
        public bool ThemTaiLieu(TaiLieuDb tl)
        {
            return tailieuDAL.ThemTaiLieu(tl);
        }
        public TaiLieuDb getTaiLieuById(int iD)
        {
            return tailieuDAL.getTaiLieuById(iD);
        }
        public DataTable GetAll()
        {
            return tailieuDAL.GetAll();
        }

        public bool SuaTaiLieu(TaiLieuDb tl)
        {
            return tailieuDAL.SuaTaiLieu(tl);
        }
        public bool XoaTaiLieu(int id)
        {
            return tailieuDAL.XoaTaiLieu(id);
        }

        public DataTable Search(string p)
        {
            return tailieuDAL.Search(p);
        }
    }
}
