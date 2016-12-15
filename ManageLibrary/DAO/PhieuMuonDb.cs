using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAO
{
    class PhieuMuonDb
    {
        public PhieuMuonDb() {
        }
        private int _id;
        private DateTime _ngayMuon;
        private string _ghiChu;
        private int _id_BanDoc;
        private int _id_NhanVien;

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

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }

            set
            {
                _ghiChu = value;
            }
        }

        public int Id_BanDoc
        {
            get
            {
                return _id_BanDoc;
            }

            set
            {
                _id_BanDoc = value;
            }
        }

        public int Id_NhanVien
        {
            get
            {
                return _id_NhanVien;
            }

            set
            {
                _id_NhanVien = value;
            }
        }
    }
}
