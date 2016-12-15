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
    class NganhHocDAL
    {
        SqlDataProvider dpro;
        DataTable dt;
        public NganhHocDAL() {
            dpro = new SqlDataProvider();
        }

        public NganhHocDb getNganhHocById(int ID)
        {
            try
            {
                String sql = "Select * from NganhHoc nh where nh.id = @ID ";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[] {
                        new DatabaseParamCls("ID", ID)});
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    NganhHocDb nh = new NganhHocDb();
                    nh.ID = Convert.ToInt16(item["id"].ToString());
                    nh.TenNganhHoc = item["TenNganhHoc"].ToString();
                    return nh;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public bool ThemNganhHoc(NganhHocDb nh)
        {
            try
            {
                String sql = "INSERT INTO [NganhHoc]([TenNganhHoc]) "
                    + " VALUES(@TenNganhHoc)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenNganhHoc", nh.TenNganhHoc),
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool SuaNganhHoc(NganhHocDb nh)
        {
            try
            {
                String sql = "UPDATE [NganhHoc] "
                          + " SET [TenNganhHoc] = @TenNganhHoc "
                          + " WHERE NganhHoc.ID = @ID";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenNganhHoc", nh.TenNganhHoc),
                        new DatabaseParamCls("ID", nh.ID)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool XoaNganhHoc(int id)
        {
            try
            {
                String sql = "delete from NganhHoc where id = @id";
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

        public DataTable GetAllNganhHoc()
        {
            try
            {
                String sql = "select *  from NganhHoc ORDER BY ID DESC";
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
                String sql = "select *  from NganhHoc nh"
                    + " where nh.TenNganhHoc like @param1 "
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
