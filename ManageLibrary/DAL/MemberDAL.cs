using ManageLibrary.ConnectDB;
using ManageLibrary.DAO;
using ManageLibrary.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace ManageLibrary.DAL
{
    class MemberDAL
    {
        SqlDataProvider dpro;
        DataTable dt;
        public MemberDAL()
        {
            dpro = new SqlDataProvider();
        }

        public MemberDb GetMemberById(int iD)
        {
            try
            {
                String sql = "select * from BanDoc where id = @id";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("id", iD)
                    });
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    MemberDb mem = new MemberDb();
                    mem.ID = Convert.ToInt16(item["id"].ToString());
                    mem.HoTen = item["HoTen"].ToString();
                    mem.Email = item["Email"].ToString();
                    mem.DiaChi = item["DiaChi"].ToString();
                    mem.NamSinh = (item["NamSinh"] != null) ? Convert.ToDateTime(item["NamSinh"].ToString()) : DateTime.Now;
                    mem.SoDienThoai = item["SoDienThoai"].ToString();
                    return mem;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public bool ThemBanDoc(MemberDb bd)
        {
            try
            {
                String sql = "INSERT INTO [BanDoc]([HoTen],[Email],[DiaChi],[NamSinh],[SoDienThoai]) "
                    + " VALUES(@HoTen,@Email,@DiaChi,@NamSinh,@SoDienThoai)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("HoTen", bd.HoTen),
                        new DatabaseParamCls("Email", bd.Email),
                        new DatabaseParamCls("DiaChi", bd.DiaChi),
                        new DatabaseParamCls("NamSinh", Common.convertDateFormat(bd.NamSinh, "yyyy-MM-dd")),
                        new DatabaseParamCls("SoDienThoai", bd.SoDienThoai)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool SuaBanDoc(MemberDb bd)
        {
            try
            {
                String sql = "UPDATE [BanDoc]"
                  + " SET [HoTen] = @HoTen"
                  + " ,[Email] = @Email"
                  + " ,[DiaChi] = @DiaChi"
                  + " ,[NamSinh] = @NamSinh"
                  + " ,[SoDienThoai] = @SoDienThoai"
                  + " WHERE ID = @ID";
                DatabaseParamCls[] newVariable = null;

                newVariable = new DatabaseParamCls[]{
                                        new DatabaseParamCls("HoTen", bd.HoTen),
                                        new DatabaseParamCls("Email", bd.Email),
                                        new DatabaseParamCls("DiaChi", bd.DiaChi),
                                        new DatabaseParamCls("NamSinh", Common.convertDateFormat(bd.NamSinh, "yyyy-MM-dd")),
                                        new DatabaseParamCls("SoDienThoai", bd.SoDienThoai),
                                        new DatabaseParamCls("ID", bd.ID)
                                    };
                dt = dpro.GetRecordSet(sql, newVariable);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool XoaBanDoc(int id)
        {
            try
            {
                String sql = "delete from BanDoc where id = @id";
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

        public DataTable GetAllBanDoc()
        {
            try
            {
                String sql = "select *  from BanDoc ORDER BY ID DESC";
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
                p = Common.convertParamLike(p);
                String sql = "select * from BanDoc bd"
                    + " where bd.ID like @param1 "
                    + " or bd.HoTen like @param2 "
                    + " or bd.DiaChi like @param3 "
                    + " ORDER BY ID DESC";
                dt = dpro.GetRecordSet(sql,
                   new DatabaseParamCls[]{
                        new DatabaseParamCls("param1", p),
                        new DatabaseParamCls("param2", p),
                        new DatabaseParamCls("param3", p)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
    }
}
