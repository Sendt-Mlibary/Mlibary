using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class NganhHocDb
    {
        public NganhHocDb() {
        }
        private int _iD;
            private string _tenNganhHoc;

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

        public string TenNganhHoc
        {
            get
            {
                return _tenNganhHoc;
            }

            set
            {
                _tenNganhHoc = value;
            }
        }
    }
}
