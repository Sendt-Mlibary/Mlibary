using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class TaiLieuDb
    {
        public TaiLieuDb()
        {

        }
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        private String _tenSach;
        public string TenSach
        {
            get
            {
                return _tenSach;
            }

            set
            {
                _tenSach = value;
            }
        }
        private String _tacGia;
        public string TacGia
        {
            get
            {
                return _tacGia;
            }

            set
            {
                _tacGia = value;
            }
        }

        private String _namXuatBan;
        public string NamXuatBan
        {
            get
            {
                return _namXuatBan;
            }

            set
            {
                _namXuatBan = value;
            }
        }

        private float _gia;
        public float Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        private int _iD_TheLoaiSach;
        public int ID_TheLoaiSach
        {
            get
            {
                return _iD_TheLoaiSach;
            }

            set
            {
                _iD_TheLoaiSach = value;
            }
        }


        private int _iD_NganhHoc;
        public int ID_NganhHoc
        {
            get
            {
                return _iD_NganhHoc;
            }

            set
            {
                _iD_NganhHoc = value;
            }
        }


        private int _iD_NgonNguSach;
        public int ID_NgonNguSach
        {
            get
            {
                return _iD_NgonNguSach;
            }

            set
            {
                _iD_NgonNguSach = value;
            }
        }

        private int _taiBan;
        public int TaiBan
        {
            get
            {
                return _taiBan;
            }

            set
            {
                _taiBan = value;
            }
        }


        private int _soLuong;
        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        private int _soNgayMuon;
        public int SoNgayMuon
        {
            get
            {
                return _soNgayMuon;
            }

            set
            {
                _soNgayMuon = value;
            }
        }


        private bool _trangThai;
        public bool TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
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

        public string TenTheLoai
        {
            get
            {
                return _tenTheLoai;
            }

            set
            {
                _tenTheLoai = value;
            }
        }

        private string _tenNganhHoc;
        private string _tenNgonNguSach;     
        private string _tenTheLoai;
    }
}
