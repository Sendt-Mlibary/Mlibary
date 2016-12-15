using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class ChiTietPhieuMuonDb
    {
        public ChiTietPhieuMuonDb() {

        }

        private int _id;
        private string _moTa;
        private int _soLuong;
        private int _id_PhieuMuon;
        private int _id_TaiLieu;
        private DateTime _hanTra;
        private int _trangThai;
        private string _trangThaiStr;
        private string _idPhieuMuon;
        private DateTime _ngayMuon;
        private int _idTaiLieu;
        private string _tenSach;
        private string _tenNganhHoc;
        private string _tenNgonNguSach;
        private string _tenTheLoai;
        private string _trangThaiTaiLieuStr;
        private string thoiGianTraSachStr;
        private DateTime thoiGianTraSach;
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

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
            }
        }

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

        public int Id_PhieuMuon
        {
            get
            {
                return _id_PhieuMuon;
            }

            set
            {
                _id_PhieuMuon = value;
            }
        }

        public int Id_TaiLieu
        {
            get
            {
                return _id_TaiLieu;
            }

            set
            {
                _id_TaiLieu = value;
            }
        }

        public int TrangThai
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

        public DateTime HanTra
        {
            get
            {
                return _hanTra;
            }

            set
            {
                _hanTra = value;
            }
        }

        public string TrangThaiStr
        {
            get
            {
                return _trangThaiStr;
            }

            set
            {
                _trangThaiStr = value;
            }
        }

        public string IdPhieuMuon
        {
            get
            {
                return _idPhieuMuon;
            }

            set
            {
                _idPhieuMuon = value;
            }
        }

        public DateTime NgayMuon
        {
            get
            {
                return _ngayMuon;
            }

            set
            {
                _ngayMuon = value;
            }
        }

        public int IdTaiLieu
        {
            get
            {
                return _idTaiLieu;
            }

            set
            {
                _idTaiLieu = value;
            }
        }

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

        public string TrangThaiTaiLieuStr
        {
            get
            {
                return _trangThaiTaiLieuStr;
            }

            set
            {
                _trangThaiTaiLieuStr = value;
            }
        }

        public string ThoiGianTraSachStr
        {
            get
            {
                return thoiGianTraSachStr;
            }

            set
            {
                thoiGianTraSachStr = value;
            }
        }

        public DateTime ThoiGianTraSach
        {
            get
            {
                return thoiGianTraSach;
            }

            set
            {
                thoiGianTraSach = value;
            }
        }
    }
}
