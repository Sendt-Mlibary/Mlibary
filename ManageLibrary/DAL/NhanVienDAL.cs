using ManageLibrary.ConnectDB;
using ManageLibrary.DAO;
using ManageLibrary.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary.DAL
{
    class NhanVienDAL
    {
        SqlDataProvider dpro;
        DataTable dt;

        public NhanVienDAL()
        {
            dpro = new SqlDataProvider();
            dt = new DataTable();
        }

        public NhanVienDb GetNhanVienById(int iD)
        {
            try
            {
                String sql = "select * from NhanVien where id = @id";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("id", iD)
                    });
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    NhanVienDb user = new NhanVienDb();
                    user.Id = Convert.ToInt16(item["id"].ToString());
                    user.TenDangNhap = item["TenDangNhap"].ToString();
                    user.HoTen = item["HoTen"].ToString();
                    user.NamSinh = (item["NamSinh"] != null) ? Convert.ToDateTime(item["NamSinh"].ToString()) : DateTime.Now;
                    user.DiaChi = item["DiaChi"].ToString();
                    user.QueQuan = item["QueQuan"].ToString();
                    user.SoDienThoai = item["SoDienThoai"].ToString();
                    user.Email = item["Email"].ToString();
                    user.PhanQuyen = Convert.ToInt16(item["PhanQuyen"].ToString());
                    return user;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public List<NhanVienDb> GetAllNhanVienNotIdUpdate(int iD)
        {
            List<NhanVienDb> lstUser = new List<NhanVienDb>();
            String sql = "select * from NhanVien where id != @id";
            dt = dpro.GetRecordSet(sql,
                new DatabaseParamCls[]{
                        new DatabaseParamCls("id", iD)
                    });
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var item = dt.Rows[i];
                NhanVienDb user = new NhanVienDb();
                user.Id = Convert.ToInt16(item["id"].ToString());
                user.TenDangNhap = item["TenDangNhap"].ToString();
                user.HoTen = item["HoTen"].ToString();
                user.NamSinh = (item["NamSinh"] != null) ? Convert.ToDateTime(item["NamSinh"].ToString()) : DateTime.Now;
                user.DiaChi = item["DiaChi"].ToString();
                user.QueQuan = item["QueQuan"].ToString();
                user.SoDienThoai = item["SoDienThoai"].ToString();
                user.PhanQuyen = Convert.ToInt16(item["PhanQuyen"].ToString());
                lstUser.Add(user);
            }
            return lstUser;
        }
        public NhanVienDb DangNhap(NhanVienDb nv)
        {
            try
            {
                String sql = "select *, case PhanQuyen when 1 then N'Người quản lý' else N'Nhân viên' end as phanQuyenStr from NhanVien nv where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenDangNhap", nv.TenDangNhap),
                        new DatabaseParamCls("MatKhau", nv.MatKhau)
                    });
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    NhanVienDb user = new NhanVienDb();
                    user.Id = Convert.ToInt16(item["id"].ToString());
                    user.TenDangNhap = item["TenDangNhap"].ToString();
                    user.HoTen = item["HoTen"].ToString();
                    user.NamSinh = (item["NamSinh"] != null) ? Convert.ToDateTime(item["NamSinh"].ToString()) : DateTime.Now;
                    user.DiaChi = item["DiaChi"].ToString();
                    user.QueQuan = item["QueQuan"].ToString();
                    user.SoDienThoai = item["SoDienThoai"].ToString();
                    user.Email = item["Email"].ToString();
                    user.PhanQuyen = Convert.ToInt16(item["PhanQuyen"].ToString());
                    user.PhanQuyenStr =item["PhanQuyenStr"].ToString();
                    return user;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        //public bool quanly(NhanVien nv)
        //{
        //    int ketqua = 0;
        //    db.check_QuanLy(nv.TenDangNhap, ref ketqua);
        //    return (ketqua == 1) ? true:false;
        //}

        public bool ThemNhanVien(NhanVienDb nv)
        {
            try
            {
                String sql = "INSERT INTO [MLibary].[dbo].[NhanVien]([TenDangNhap],[MatKhau],[HoTen],[Email],[DiaChi],[NamSinh],[QueQuan],[PhanQuyen],[SoDienThoai]) "
                    + " VALUES(@TenDangNhap,@MatKhau,@HoTen ,@Email,@DiaChi,@NamSinh,@QueQuan,@PhanQuyen,@SoDienThoai)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenDangNhap", nv.TenDangNhap),
                        new DatabaseParamCls("MatKhau", nv.MatKhau),
                        new DatabaseParamCls("HoTen", nv.HoTen),
                        new DatabaseParamCls("Email", nv.Email),
                        new DatabaseParamCls("DiaChi", nv.DiaChi),
                        new DatabaseParamCls("NamSinh", Common.convertDateFormat(nv.NamSinh, "yyyy-MM-dd")),
                        new DatabaseParamCls("QueQuan", nv.QueQuan),
                        new DatabaseParamCls("PhanQuyen", nv.PhanQuyen),  
                        new DatabaseParamCls("SoDienThoai", nv.SoDienThoai)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool SuaNhanVien(NhanVienDb nv)
        {
            try
            {
                String sql = "UPDATE [NhanVien]"
                        + " SET [TenDangNhap] = @TenDangNhap";
                if (!String.IsNullOrWhiteSpace(nv.MatKhau))
                {
                    sql += " ,[MatKhau] = @MatKhau";
                }
                sql += " ,[HoTen] = @HoTen"
                  + " ,[Email] = @Email"
                  + " ,[DiaChi] = @DiaChi"
                  + " ,[NamSinh] = @NamSinh"
                  + " ,[QueQuan] = @QueQuan"
                  + " ,[PhanQuyen] = @PhanQuyen"
                  + " ,[SoDienThoai] = @SoDienThoai"
                  + " WHERE ID = @ID";
                DatabaseParamCls[] newVariable = null;
                if (!String.IsNullOrWhiteSpace(nv.MatKhau))
                {
                    newVariable = new DatabaseParamCls[]{
                                        new DatabaseParamCls("TenDangNhap", nv.TenDangNhap),
                                        new DatabaseParamCls("MatKhau", nv.MatKhau),
                                        new DatabaseParamCls("HoTen", nv.HoTen),
                                        new DatabaseParamCls("Email", nv.Email),
                                        new DatabaseParamCls("DiaChi", nv.DiaChi),
                                        new DatabaseParamCls("NamSinh", Common.convertDateFormat(nv.NamSinh, "yyyy-MM-dd")),
                                        new DatabaseParamCls("QueQuan", nv.QueQuan),
                                        new DatabaseParamCls("PhanQuyen", nv.PhanQuyen),  
                                        new DatabaseParamCls("SoDienThoai", nv.SoDienThoai),
                                        new DatabaseParamCls("ID", nv.Id)
                                    };
                }
                else
                {
                    newVariable = new DatabaseParamCls[]{
                                        new DatabaseParamCls("TenDangNhap", nv.TenDangNhap),
                                        new DatabaseParamCls("HoTen", nv.HoTen),
                                        new DatabaseParamCls("Email", nv.Email),
                                        new DatabaseParamCls("DiaChi", nv.DiaChi),
                                        new DatabaseParamCls("NamSinh", Common.convertDateFormat(nv.NamSinh, "yyyy-MM-dd")),
                                        new DatabaseParamCls("QueQuan", nv.QueQuan),
                                        new DatabaseParamCls("PhanQuyen", nv.PhanQuyen),  
                                        new DatabaseParamCls("SoDienThoai", nv.SoDienThoai),
                                        new DatabaseParamCls("ID", nv.Id)
                                    };
                }
                dt = dpro.GetRecordSet(sql, newVariable);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool XoaNhanVien(int id)
        {
            try
            {
                String sql = "delete from NhanVien where id = @id";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("id", id)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }
        public DataTable GetAllNhanVien()
        {
            try
            {
                String sql = "select *, case PhanQuyen when 1 then N'Người quản lý' else N'Nhân viên' end as phanQuyenStr  from NhanVien";
                dt = dpro.GetRecordSet(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable TimKiem(string p)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(p))
                {
                    return GetAllNhanVien();
                }
                else
                {
                    p = Common.convertParamLike(p);
                    String sql = "select *, case nv.PhanQuyen when 1 then N'Người quản lý' else N'Nhân viên' end as phanQuyenStr  from NhanVien nv"
                        + " where nv.TenDangNhap like @param1 "
                        + " or nv.HoTen like @param2 "
                        + " or nv.Email like @param3 ";
                    dt = dpro.GetRecordSet(sql,
                       new DatabaseParamCls[]{
                        new DatabaseParamCls("param1", p),
                        new DatabaseParamCls("param2", p),
                        new DatabaseParamCls("param3", p)
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
    }
}
