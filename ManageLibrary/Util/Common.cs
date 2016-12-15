using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageLibrary.UserControls;
using System.Web.UI;
using System.Windows.Forms;

namespace ManageLibrary.Util
{
    class Common
    {
        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            UTF8Encoding encoder = new UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }
        public static string convertDateFormat(DateTime date, string formatDate)
        {
            try
            {
                return date.Year+"-"+date.Month+"-"+date.Day;
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        public static string convertParamLike(string param){
            if (String.IsNullOrWhiteSpace(param))
            {
                return "%%";
            }
            else
            {
                return "%" + param + "%";
            }
        }
        public static DateTime addDay(int day)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(day);
            return answer;
        }

        public static void hidenParentForm(System.Windows.Forms.UserControl uc)
        {
            Form parentForm = (uc.ParentForm as Form);
            if (parentForm != null) { 
                parentForm.Hide(); // formDialog cha di
            }
        }

        public static void showParentForm(System.Windows.Forms.UserControl uc)
        {
            Form parentForm = (uc.ParentForm as Form);
            if (parentForm != null)
            {
                parentForm.Show(); //show formDialog cha hien thi len
            }
        }

        public static void disposeParentForm(System.Windows.Forms.UserControl uc)
        {
            Form parentForm = (uc.ParentForm as Form);
            if (parentForm != null) { 
                parentForm.Dispose(); // giai phong formDialog
            }
        }
    }
}
