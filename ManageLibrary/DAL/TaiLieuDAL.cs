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
                String sql = "Select * from TaiLieu tl where tl.id = @ID ";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[] {
                        new DatabaseParamCls("ID", ID)});
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
                    return document;
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
                document.Gia = (float)Convert.ToDouble(item["Gia"].ToString());
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
                    + " VALUES(@TenSach,@TacGia,@NamXuatBan ,@Gia,@ID_TheLoaiSach,@ID_NganhHoc,@ID_NgonNguSach,@TaiBan,@SoLuong,@SoNgayMuon,@TrangThai)";
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

        public DataTable GetAll()
        {
            try
            {
                String sql = "select tl.*, nh.TenNganhHoc, nns.TenNgonNguSach, tls.TenTheLoai,  "
                            + " case tl.TrangThai when 1 then N'Được cho mượn' else N'Không được mượn' end as TrangThaiStr"        
                            + " from TaiLieu tl"
                            + " left join NganhHoc nh on nh.ID = tl.ID_NganhHoc"
                            + " left join NgonNguSach nns on nns.ID = tl.ID_NgonNguSach"
                            + " left join TheLoaiSach tls on tls.ID = tl.ID_TheLoaiSach";
                return dpro.GetRecordSet(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool SuaTaiLieu(TaiLieuDb tl)
        {
            try
            {
                String sql = "UPDATE [TaiLieu] "
                          +" SET [TenSach] = @TenSach "
                          +" ,[TacGia] = @TacGia"
                          +" ,[NamXuatBan] = @NamXuatBan"
                          +" ,[Gia] = @Gia"
                          +" ,[ID_TheLoaiSach] = @ID_TheLoaiSach"
                          +" ,[ID_NganhHoc] =@ID_NganhHoc"
                          +" ,[ID_NgonNguSach] = @ID_NgonNguSach"
                          +" ,[TaiBan] = @TaiBan"
                          +" ,[SoLuong] = @SoLuong"
                          +" ,[SoNgayMuon] = @SoNgayMuon"
                          +" ,[TrangThai] = @TrangThai"
                          + " WHERE TaiLieu.ID = @ID";
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
                        new DatabaseParamCls("TrangThai", tl.TrangThai),
                        new DatabaseParamCls("ID", tl.Id)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool XoaTaiLieu(int id)
        {
            try
            {
                String sql = "DELETE FROM [TaiLieu] WHERE TaiLieu.ID = @ID";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("ID", id)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public DataTable Search(string tenSach)
        {
            try
            {
                tenSach = Common.convertParamLike(tenSach);
                String sql = "select tl.*, nh.TenNganhHoc, nns.TenNgonNguSach, tls.TenTheLoai,  "
                            + " case tl.TrangThai when 1 then N'Được cho mượn' else N'Không được mượn' end as TrangThaiStr"
                            + " from TaiLieu tl"
                            + " left join NganhHoc nh on nh.ID = tl.ID_NganhHoc"
                            + " left join NgonNguSach nns on nns.ID = tl.ID_NgonNguSach"
                            + " left join TheLoaiSach tls on tls.ID = tl.ID_TheLoaiSach";
                if (!String.IsNullOrWhiteSpace(tenSach))
                {
                    sql += " where tl.TenSach like @TenSach";
                    return dpro.GetRecordSet(sql,
                   new DatabaseParamCls[]{
                        new DatabaseParamCls("TenSach", tenSach)
                    });
                }
                else
                {
                    return GetAll();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }
    }
}
