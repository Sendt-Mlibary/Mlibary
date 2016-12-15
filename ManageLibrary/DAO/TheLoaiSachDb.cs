using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class TheLoaiSachDb
    {
        public TheLoaiSachDb() {
        }
        private int _iD;
        private string _theLoaiSach;

        public int ID
        {
            get
            {
                return _iD;
            }

            set
            {
                _iD = value;
            }
        }

        public string TheLoaiSach
        {
            get
            {
                return _theLoaiSach;
            }

            set
            {
                _theLoaiSach = value;
            }
        }
    }
}
