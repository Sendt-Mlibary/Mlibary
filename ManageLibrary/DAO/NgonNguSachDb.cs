using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class NgonNguSachDb
    {
        public NgonNguSachDb() {
        }
        private int _iD;
        private string _tenNgonNguSach;

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

        public string TenNgonNguSach
        {
            get
            {
                return _tenNgonNguSach;
            }

            set
            {
                _tenNgonNguSach = value;
            }
        }
    }
}
