using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.Util
{
    public static class Constants
    {
        public static class PHAN_QUYEN
        {
            public static int ADMIN = 1;// gia han toi da 15 ngay 
            public static int UERS = 1;// gia han toi da 15 ngay 
        }

        public static class BOOKS
        {
            public static int GIA_HAN_MUON_SACH = 15;// gia han toi da 15 ngay 
        }

        public static class STATUS
        {
            public static int ACTIVE = 1;
            public static int NOT_ACTIVE = 2;
            public static int SUPPEN = 3;
        }

        public static class CT_PHIEUMUON_TRANGTHAI
        {
            public static int DANG_MUON = 1;
            public static int DA_TRA = 2;
            public static int DANG_GIA_HAN = 3;
            public static int VI_PHAM = 4;
        }

    }
}
