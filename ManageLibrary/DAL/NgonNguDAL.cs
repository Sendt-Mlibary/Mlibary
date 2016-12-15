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
    class NgonNguDAL
    {
        SqlDataProvider dpro;
        DataTable dt;

        public NgonNguDAL() {
            dpro = new SqlDataProvider();
        }

        public NgonNguSachDb getNgonNguById(int ID)
        {
            try
            {
                String sql = "Select * from NgonNguSach nn where nn.id = @ID ";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[] {
                        new DatabaseParamCls("ID", ID)});
                if (dt.Rows.Count >= 0)
                {
                    var item = dt.Rows[0];
                    NgonNguSachDb nn = new NgonNguSachDb();
                    nn.ID = Convert.ToInt16(item["id"].ToString());
                    nn.TenNgonNguSach = item["TenNgonNguSach"].ToString();
                    return nn;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public bool ThemNgonNgu(NgonNguSachDb nn)
        {
            try
            {
                String sql = "INSERT INTO [NgonNguSach]([TenNgonNguSach]) "
                    + " VALUES(@TenNgonNguSach)";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenNgonNguSach", nn.TenNgonNguSach),
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool SuaNgonNgu(NgonNguSachDb nn)
        {
            try
            {
                String sql = "UPDATE [NgonNguSach] "
                          + " SET [TenNgonNguSach] = @TenNgonNguSach "
                          + " WHERE TheLoai.ID = @ID";
                dt = dpro.GetRecordSet(sql,
                    new DatabaseParamCls[]{
                        new DatabaseParamCls("TenNgonNguSach", nn.TenNgonNguSach),
                        new DatabaseParamCls("ID", nn.ID)
                    });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }


        public bool XoaNgonNgu(int id)
        {
            try
            {
                String sql = "delete from NgonNguSach where id = @id";
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


        public DataTable GetAllNgonNgu()
        {
            try
            {
                String sql = "select *  from NgonNguSach ORDER BY ID DESC";
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
                String sql = "select *  from NgonNguSach nn"
                    + " where tl.TenNgonNguSach like @param1 "
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
