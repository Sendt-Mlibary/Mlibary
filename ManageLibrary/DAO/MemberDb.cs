using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class MemberDb
    {
        public MemberDb() {

        }
        private int _iD;
        private string _hoTen;
        private string _email;
        private string _diaChi;
        private DateTime _namSinh;
        private string _soDienThoai;

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

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public DateTime NamSinh
        {
            get
            {
                return _namSinh;
            }

            set
            {
                _namSinh = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return _soDienThoai;
            }

            set
            {
                _soDienThoai = value;
            }
        }
    }
}
