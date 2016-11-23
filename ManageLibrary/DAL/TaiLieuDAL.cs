using ManageLibrary.ConnectDB;
using ManageLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAL
{
    class TaiLieuDAL
    {
        SqlDataProvider dpro;
        DataTable dt;
        public TaiLieuDAL()
        {
            dpro = new SqlDataProvider();
            dt = new DataTable();
        }

        public TaiLieuDb getTaiLieuById(int ID)
        {
            try
            {
                String sql = "Select * from TaiLieu ";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[] {
                        new DatabaseParamCls("id", ID)});
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    TaiLieuDb document = new TaiLieuDb();
                    document.Id = Convert.ToInt16(item["id"].ToString());
                    document.TenSach = item["TenSach"].ToString();
                    document.TacGia = item["TacGia"].ToString();
                    document.NamXuatBan = item["NamXuatBan"].ToString();
                    document.Gia = (float)Convert.ToDouble(item["Gia"].ToString());
                    document.ID_TheLoaiSach = Convert.ToInt16(item["ID_TheLoaiSach"].ToString());
                    document.ID_NganhHoc = Convert.ToUInt16(item["ID_NganhHoc"].ToString());
                    document.ID_NgonNguSach = Convert.ToInt16(item["ID_NgonNguSach"].ToString());
                    document.TaiBan = Convert.ToInt16(item["ID_NgonNguSach"].ToString());
                    document.SoLuong = Convert.ToInt16(item["SoLuong"].ToString());
                    document.SoNgayMuon = Convert.ToInt16(item["SoNgayMuon"].ToString());
                    document.TrangThai = Convert.ToBoolean(item["TrangThai"].ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public List<TaiLieuDb> GetAllTaiLieuNotIdUpdate(int iD)
        {
                List<TaiLieuDb> lstTl = new List<TaiLieuDb>();
                String sql = "select * form TaiLieu where id != @id";
                dt = dpro.GetRecordSet(sql,
                   new DatabaseParamCls[] {
                        new DatabaseParamCls("id", iD)});
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var item = dt.Rows[0];
                TaiLieuDb document = new TaiLieuDb();
                document.Id = Convert.ToInt16(item["id"].ToString());
                document.TenSach = item["TenSach"].ToString();
                document.TacGia = item["TacGia"].ToString();
                document.NamXuatBan = item["NamXuatBan"].ToString();
                // document.Gia = Convert.float(item["Gia"].ToString());
                document.ID_TheLoaiSach = Convert.ToInt16(item["ID_TheLoaiSach"].ToString());
                document.ID_NganhHoc = Convert.ToUInt16(item["ID_NganhHoc"].ToString());
                document.ID_NgonNguSach = Convert.ToInt16(item["ID_NgonNguSach"].ToString());
                document.TaiBan = Convert.ToInt16(item["ID_NgonNguSach"].ToString());
                document.SoLuong = Convert.ToInt16(item["SoLuong"].ToString());
                document.SoNgayMuon = Convert.ToInt16(item["SoNgayMuon"].ToString());
                document.TrangThai = Convert.ToBoolean(item["TrangThai"].ToString());
                lstTl.Add(document);
            }

            return lstTl;
        }

        public bool ThemTaiLieu(TaiLieuDb tl)
        {
            try
            {
                String sql = "INSERT INTO [MLibary].[dbo].[TaiLieu]([TenSach],[TacGia],[NamXuatBan],[Gia],[ID_TheLoaiSach],[ID_NganhHoc],[ID_NgonNguSach],[TaiBan],[SoLuong],[SoNgayMuon],[TrangThai]) "
                    + " VALUES(@TenDangNhap,@MatKhau,@HoTen ,@Email,@DiaChi,@NamSinh,@QueQuan,@PhanQuyen,@SoDienThoai)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenSach", tl.TenSach),
                        new DatabaseParamCls("TacGia", tl.TacGia),
                        new DatabaseParamCls("NamXuatBan", tl.NamXuatBan),
                        new DatabaseParamCls("Gia", tl.Gia),
                        new DatabaseParamCls("ID_TheLoaiSach", tl.ID_TheLoaiSach),
                        new DatabaseParamCls("ID_NganhHoc", tl.ID_NganhHoc),
                        new DatabaseParamCls("ID_NgonNguSach", tl.ID_NgonNguSach),
                        new DatabaseParamCls("TaiBan", tl.TaiBan),
                        new DatabaseParamCls("SoLuong", tl.SoLuong),            
                        new DatabaseParamCls("SoNgayMuon", tl.SoNgayMuon),
                        new DatabaseParamCls("TrangThai", tl.TrangThai)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }
    }
}
