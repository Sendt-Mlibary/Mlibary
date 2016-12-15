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
    class TheLoaiDAL
    {
        SqlDataProvider dpro;
        DataTable dt;
        public TheLoaiDAL() {
            dpro = new SqlDataProvider();
        }

        public TheLoaiSachDb getTheLoaiById(int ID)
        {
            try
            {
                String sql = "Select * from TheLoaiSach tl where tl.id = @ID ";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[] {
                        new DatabaseParamCls("ID", ID)});
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    TheLoaiSachDb tl = new TheLoaiSachDb();
                    tl.ID = Convert.ToInt16(item["id"].ToString());
                    tl.TheLoaiSach = item["TenTheLoai"].ToString();
                    return tl;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public bool ThemTheLoai(TheLoaiSachDb tl)
        {
            try
            {
                String sql = "INSERT INTO [TheLoaiSach]([TenTheLoai]) "
                    + " VALUES(@TenTheLoai)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenTheLoai", tl.TheLoaiSach),
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool SuaTheLoai(TheLoaiSachDb tl)
        {
            try
            {
                String sql = "UPDATE [TheLoaiSach] "
                          + " SET [TenTheLoai] = @TenTheLoai "
                          + " WHERE TheLoai.ID = @ID";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TheLoaiSach", tl.TheLoaiSach),
                        new DatabaseParamCls("ID", tl.ID)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool XoaTheLoai(int id)
        {
            try
            {
                String sql = "delete from TheLoaiSach where id = @id";
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

        public DataTable GetAllTheLoai()
        {
            try
            {
                String sql = "select *  from TheLoaiSach ORDER BY ID DESC";
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
                String sql = "select *  from TheLoaiSach tl"
                    + " where tl.TheLoaiSach like @param1 "
                    + " ORDER BY ID DESC";
                dt = dpro.GetRecordSet(sql,
                   new DatabaseParamCls[]{
                        new DatabaseParamCls("param1", p),
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
