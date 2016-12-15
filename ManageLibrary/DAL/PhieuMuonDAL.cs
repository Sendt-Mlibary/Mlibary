using ManageLibrary.ConnectDB;
using ManageLibrary.DAO;
using ManageLibrary.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAL
{

    class PhieuMuonDAL
    {
        SqlDataProvider dpro;
        DataTable dt;
        public PhieuMuonDAL()
        {
            dpro = new SqlDataProvider();
        }
        public int ThemPhieuMuon(PhieuMuonDb pm)
        {
            try
            {
                String sql = "INSERT INTO PhieuMuon(NgayMuon,GhiChu,ID_BanDoc,ID_NhanVien) "
                    + " VALUES(@NgayMuon,@GhiChu,@ID_BanDoc,@ID_NhanVien);SELECT SCOPE_IDENTITY();";
                return dpro.InsertGenId(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("NgayMuon", DateTime.Now),
                        new DatabaseParamCls("GhiChu", pm.GhiChu),
                        new DatabaseParamCls("Id_BanDoc", pm.Id_BanDoc),
                        new DatabaseParamCls("Id_NhanVien", pm.Id_NhanVien),
                    });
            }
            catch (Exception e)
            {
                throw e;
            }
            return -1;
        }

        public DataTable getTaiLieuByChiTietPhieuMuonId(int selectBookHistoryId)
        {
            try
            {
                String sql = "select ctpm.ID, ctpm.hantra, ctpm.SoLuong, ctpm.trangthai,"
                            + " case ctpm.trangthai when 1 then N'Đang mượn' "
                            + " when 2 then N'Đã trả' "
                            + " when 3 then N'Đang gia hạn' "
                            + " when 4 then N'Vi phạm' "
                            + " else 'N/A' "
                            + " end as TrangThaiStr , "
                            + " FORMAT(ThoiGianTraSach,'dd/MM/yyyy hh:mm:ss tt') as thoiGianTraSachStr, "
                            + " pm.Id idPhieuMuon, pm.NgayMuon, "
                            + " tl.Id idTaiLieu, tl.TacGia, tl.NamXuatBan, tl.Gia, tl.TaiBan, tl.SoNgayMuon,"
                            + " tl.TenSach, nh.TenNganhHoc, nns.TenNgonNguSach, tls.TenTheLoai, tl.NamXuatBan, "
                            + " case tl.TrangThai when 1 then N'Được cho mượn' "
                            + " when 2 then N'Không được mượn' "
                            + " else 'N/A' "
                            + " end as TrangThaiTaiLieuStr "
                            + " from ChiTietPhieuMuon ctpm "
                            + " inner join PhieuMuon pm on ctpm.ID_PhieuMuon = pm.ID "
                            + " inner join TaiLieu tl on ctpm.ID_TaiLieu = tl.ID "
                            + " left join NganhHoc nh on nh.ID = tl.ID_NganhHoc  "
                            + " left join NgonNguSach nns on nns.ID = tl.ID_NgonNguSach "
                            + " left join TheLoaiSach tls on tls.ID = tl.ID_TheLoaiSach "
                            + " where  ctpm.ID = @ID";
                return dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{ new DatabaseParamCls("ID", selectBookHistoryId)});
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ThuHoi(int selectBookHistoryId)
        {
            try
            {
                String sql = "update ChiTietPhieuMuon set trangthai = @trangthai, ThoiGianTraSach = @ThoiGianTraSach  where id  = @id";
                dpro.ExecuteUpdateQuery("ChiTietPhieuMuon", "id", selectBookHistoryId.ToString(),
                   new DatabaseParamCls[]{
                        new DatabaseParamCls("ThoiGianTraSach",DateTime.Now),
                        new DatabaseParamCls("trangthai", Constants.CT_PHIEUMUON_TRANGTHAI.DA_TRA),
                   });
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public bool GiaHan(int maCtPhieuMuon, DateTime value, string mota)
        {
            try
            {
                String sql = "update ChiTietPhieuMuon set hantra = @hantra, mota = @mota , trangthai = @trangthai, ThoiGianTraSach = @ThoiGianTraSach where id  = @id";
                dpro.ExecuteUpdateQuery("ChiTietPhieuMuon", "id", maCtPhieuMuon.ToString(),
                   new DatabaseParamCls[]{
                        new DatabaseParamCls("hantra",value),
                        new DatabaseParamCls("ThoiGianTraSach",null),
                        new DatabaseParamCls("trangthai", Constants.CT_PHIEUMUON_TRANGTHAI.DANG_GIA_HAN),
                        new DatabaseParamCls("mota", mota)
                   });
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public DataTable GetHistoryBooks(int memberId)
        {
            try
            {
                String sql = "select ctpm.ID, ctpm.hantra, ctpm.SoLuong, ctpm.trangthai, "
                            + " case ctpm.trangthai when 1 then N'Đang mượn' "
                            + " when 2 then N'Đã trả' "
                            + " when 3 then N'Đang gia hạn' "
                            + " when 4 then N'Vi phạm' "
                            + " else 'N/A' "
                            + " end as TrangThaiStr , "
                            + " FORMAT(ThoiGianTraSach,'dd/MM/yyyy hh:mm:ss tt') as thoiGianTraSachStr, "
                            + " pm.Id idPhieuMuon, pm.NgayMuon, "
                            + " tl.Id idTaiLieu, tl.TenSach, nh.TenNganhHoc, nns.TenNgonNguSach, tls.TenTheLoai, tl.NamXuatBan, "
                            + " case tl.TrangThai when 1 then N'Được cho mượn' "
                            + " when 2 then N'Không được mượn' "
                            + " else 'N/A' "
                            + " end as TrangThaiTaiLieuStr "
                            + " from ChiTietPhieuMuon ctpm "
                            + " inner join PhieuMuon pm on ctpm.ID_PhieuMuon = pm.ID "
                            + " inner join TaiLieu tl on ctpm.ID_TaiLieu = tl.ID "
                            + " left join NganhHoc nh on nh.ID = tl.ID_NganhHoc  "
                            + " left join NgonNguSach nns on nns.ID = tl.ID_NgonNguSach "
                            + " left join TheLoaiSach tls on tls.ID = tl.ID_TheLoaiSach "
                            + " where pm.ID_BanDoc = @memberId"
                            + " ORDER BY ctpm.ID DESC";
                            return dpro.GetRecordSet(sql,
                                new DatabaseParamCls[]{
                                    new DatabaseParamCls("memberId", memberId)
                                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ThemChiTietPhieuMuon(List<ChiTietPhieuMuonDb> lstChiTietPhieuMuonDb)
        {
            try
            {
                String sql = "INSERT INTO ChiTietPhieuMuon(MoTa,SoLuong,ID_PhieuMuon,ID_TaiLieu,hantra,trangthai)"
                        + " VALUES(@MoTa, @SoLuong, @ID_PhieuMuon, @ID_TaiLieu, @hantra, @trangthai)";
                foreach(ChiTietPhieuMuonDb lstCtpm in lstChiTietPhieuMuonDb){ 
                dpro.ExecuteInsertQuery("ChiTietPhieuMuon",
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("MoTa", lstCtpm.MoTa),
                        new DatabaseParamCls("SoLuong", lstCtpm.SoLuong),
                        new DatabaseParamCls("ID_PhieuMuon", lstCtpm.Id_PhieuMuon),
                        new DatabaseParamCls("ID_TaiLieu", lstCtpm.Id_TaiLieu),
                        new DatabaseParamCls("hantra", Common.convertDateFormat(lstCtpm.HanTra,"")),
                        new DatabaseParamCls("trangthai", lstCtpm.TrangThai)
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
