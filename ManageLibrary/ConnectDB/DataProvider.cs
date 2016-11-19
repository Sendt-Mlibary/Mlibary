using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ManageLibrary.ConnectDB
{
   
    public abstract class DataProvider
    {
        // Methods

        public abstract void saveLog(string uid, string action);
        public abstract bool ExecuteNonQuery(string commamdText);
        public abstract bool ExecuteNonQuery(string commandText, CommandType commandType);
        public abstract bool ExecuteNonQuery(string commandText, DatabaseParamCls[] commandParameters);
        public abstract bool ExecuteNonQuery(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType);

        public abstract bool ExecuteDeleteQuery(string tableName, string KeyField, string KeyValue);
        public abstract bool ExecuteInsertQuery(string TableName, DatabaseParamCls[] commandParameters);
        public abstract bool ExecuteUpdateQuery(string tableName, string KeyField, string KeyValue, DatabaseParamCls[] commandParameters);

        public abstract DataTable GetRecordSet(string commandText);
        public abstract DataTable GetRecordSet(string commandText, CommandType commandType);
        public abstract DataTable GetRecordSet(string commandText, DatabaseParamCls[] commandParameters);
        public abstract DataTable GetRecordSet(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType);

        public abstract DataSet GetRecordSetByDataSet(string commandText);
        public abstract DataSet GetRecordSetByDataSet(string commandText, CommandType commandType);
        public abstract DataSet GetRecordSetByDataSet(string commandText, DatabaseParamCls[] commandParameters);
        public abstract DataSet GetRecordSetByDataSet(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType);
    }
    public class LHLog
    {
        private string sFormat;
        private string sTime;
        private string path = "";
        public LHLog()
        {
            sFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " --- ";

            sTime = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
        }
        public void Error(Exception ex)
        {
            // log.Error(ex);
            //ErrorLog(ex.Message, ex.StackTrace);
        }

        public void Error(string message)
        {
            //  log.Error(message);

            //ErrorLog(message, "");
        }
    }

    public class SqlDataProvider : DataProvider
    {
        // Fields
        LHLog log;
        private string _ConnectionString;

        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
        /// <summary>
        /// Hàm lấy chuỗi kết nối từ tập tin cấu hình App.config; thuộc tính appSetting với 4 trường: Server, Database, Username, Password;
        /// Hoặc lấy từ chuỗi kết nối connectString với tên là 'connect1'    
        /// </summary>        
        /// <returns>Chuỗi kết nối</returns>

        public string getConnectString()
        {
            return ConfigurationManager.ConnectionStrings["connect1"].ConnectionString;
        }
        /// <summary>
        /// Hàm lấy chuỗi kết nối từ tập tin cấu hình App.config; thuộc tính appSetting với 4 trường: Server, Database, Username, Password;
        /// </summary> 
        /// <param name="Server">Tên máy chủ</param>
        /// <param name="Database">Tên cơ sở dữ liệu</param>
        /// <param name="Username">Tên đăng nhập</param>
        /// <param name="Password">Mật khẩu</param>
        /// <returns>Chuỗi kết nối</returns> 

        public string getConnectString(string Server, string Database, string Username, string Password)
        {
            return "Server=" + Server + ";Database=" + Database + ";uid=" + Username + ";pwd=" + Password + ";";
        }
        // Methods
        /// <summary>
        /// Hàm lấy chuỗi kết nối từ tập tin cấu hình App.config; với thẻ connectString và cung cấp tên.
        /// </summary> 
        /// <param name="connectionStringName">Tên của chuỗi kết nối trong thuộc tính 'name' của tập tin App.config</param>
        /// <returns>Chuỗi kết nối</returns>

        public SqlDataProvider(string connectionStringName)
        {
            log = new LHLog();
            this._ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
        /// <summary>
        /// Tự động lấy cấu hình kết nối từ tập tin App.config, khi add thêm hai tab: connectString với tên là 'connect1' hoặc AppSetting với 4 tham số: Server, Database, Username, Password
        /// </summary>        
        public SqlDataProvider()
        {
            log = new LHLog();
            this._ConnectionString = getConnectString();

        }

        private void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (commandParameters != null)
            {
                foreach (SqlParameter parameter in commandParameters)
                {
                    if (parameter != null)
                    {
                        if (((parameter.Direction == ParameterDirection.InputOutput) || (parameter.Direction == ParameterDirection.Input)) && (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parameter);
                    }
                }
            }

        }

        private SqlParameter ConvertFromDataParam(DatabaseParamCls mycommandParameters)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.DbType = mycommandParameters.DbType;
            parameter.Direction = mycommandParameters.Direction;
            parameter.IsNullable = mycommandParameters.IsNullable;
            parameter.ParameterName = this.CorrectParam(mycommandParameters.ParameterName);
            parameter.Size = mycommandParameters.Size;
            parameter.SqlDbType = mycommandParameters.SqlFieldType;
            parameter.Value = mycommandParameters.Value;
            return parameter;
        }

        private SqlParameter[] ConvertFromDataParam(DatabaseParamCls[] mycommandParameters)
        {
            SqlParameter[] parameterArray = null;
            try
            {
                parameterArray = new SqlParameter[mycommandParameters.Length];
            }
            catch
            {
                return null;
            }
            for (int i = 0; i < mycommandParameters.Length; i++)
            {
                parameterArray[i] = this.ConvertFromDataParam(mycommandParameters[i]);
            }
            return parameterArray;
        }

        public string CorrectMsg(string Msg)
        {
            string str = Msg.ToLower();
            if (str.IndexOf("unique index") != -1)
            {
                return "Dữ liệu đã tồn tại hoặc chúng có rằng buộc với nhau.";
            }
            if (str.IndexOf("reference constraint") != -1)
            {
                return "Dữ liệu bạn xóa, sửa tồn tại trong mối rằng buộc, bạn không thể xóa, sửa được. Ví dụ nếu khách hàng đã phát sinh giao dịch và có hóa đơn thì bạn không thể xóa khách hàng, nếu muốn xóa khách hàng bạn cần xóa hóa đơn trước.";
            }
            if (str.IndexOf("duplicate key") != -1)
            {
                return "Dữ liệu đã có hoặc dữ liệu rằng buộc với nhau.";
            }
            if (str.IndexOf("check constraint") != -1)
            {
                return "Dữ liệu không hợp lệ. Ví dụ bạn đang cố gắng nhập số lượng lớn hơn số cho phép hoặc câu lệnh chứa chứa kí tự đặc biệt như ?'~@[];//.";
            }
            return Msg;
        }

        private string CorrectParam(string myParam)
        {
            string str = myParam;
            if (str.StartsWith("@"))
            {
                return str;
            }
            return ("@" + str);
        }
        /// <summary>
        /// Thực thi câu lệnh truy vấn thao tác với cơ sở dữ liệu    
        /// </summary> 
        /// <param name="commandText">Câu lệnh sql</param>      
        /// <returns>Trả về một bảng dữ liệu bị ảnh hưởng</returns>            
        public override bool ExecuteNonQuery(string commandText)
        {
            DataTable dataTable = new DataTable();
            dataTable =  this.GetRecordSet(commandText, CommandType.Text);
            if (dataTable.Rows.Count >= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Thực thi câu lệnh truy vấn thao tác với cơ sở dữ liệu 
        /// </summary>   
        /// <param name="commandText">Câu lệnh sql</param>
        /// <param name="commandType">Kiểu của câu lệnh truy vấn: text hay procedure</param>       
        /// <returns>Trả về một bảng dữ liệu bị ảnh hưởng</returns>        

        public override bool ExecuteNonQuery(string commandText, CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlCommand selectCommand = connection.CreateCommand();
            selectCommand.CommandText = commandText;
            selectCommand.CommandType = commandType;
            new SqlDataAdapter(selectCommand).Fill(dataTable);
            connection.Close();
            if (dataTable.Rows.Count >= 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Thực thi câu lệnh truy vấn thao tác với cơ sở dữ liệu 
        ///</summary>
        /// <param name="commandText">Câu lệnh sql</param>
        /// <param name="commandParameters">Tham số của câu lệnh sql</param>       
        /// <returns>Trả về một bảng dữ liệu bị ảnh hưởng</returns>      
        public override bool ExecuteNonQuery(string commandText, DatabaseParamCls[] commandParameters)
        {
            DataTable dataTable = new DataTable();
             dataTable = this.GetRecordSet(commandText, commandParameters, CommandType.Text);
             if (dataTable.Rows.Count >= 0)
                 return true;
             else
                 return false;
        }
        /// <summary>
        /// Thực thi câu lệnh truy vấn thao tác với cơ sở dữ liệu 
        /// </summary>  
        /// <param name="commandText">Câu lệnh sql</param>
        /// <param name="commandParameters">Tham số của câu lệnh sql</param>   
        /// <param name="commandType">Kiểu của câu lệnh truy vấn: text hay procedure</param>    
        /// <returns>Trả về một bảng dữ liệu bị ảnh hưởng</returns>        
        public override bool ExecuteNonQuery(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            SqlCommand command = connection.CreateCommand();
            bool mustCloseConnection = false;
            SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
            this.PrepareCommand(command, connection, null, commandType, commandText, parameterArray, out mustCloseConnection);
            new SqlDataAdapter(command).Fill(dataTable);
            command.Parameters.Clear();
            if (mustCloseConnection)
            {
                connection.Close();
            }
            if (dataTable.Rows.Count >= 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Thực thi câu lệnh xóa dữ liệu trong cơ sở dữ liệu
        /// </summary>
        /// <param name="tableName">tên bảng dữ liệu</param>
        /// <param name="KeyField">tên trường khóa chính</param>
        /// <param name="KeyValue">Giá trị cần so sánh với khóa</param>
        /// <returns>Trả về kiểu true - nếu dữ liệu được xóa và ngược lại</returns>
        public override bool ExecuteDeleteQuery(string tableName, string KeyField, string KeyValue)
        {
            bool flag = false ;
            try
            {
                flag = this.GenDelete(tableName, KeyField, KeyValue);
            }
            catch (Exception exception)
            {
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
                //throw new Exception(this.CorrectMsg(msg));
            }
            return flag;
        }
        /// <summary>
        /// Thực thi câu lệnh thêm dữ liệu trong cơ sở dữ liệu
        /// </summary>
        /// <param name="tableName">tên bảng dữ liệu</param>
        /// <param name="commandParameters">Mảng các tham số truyền vào</param>        
        /// <returns>Trả về kiểu true - nếu dữ liệu được thêm và ngược lại</returns>
        public override bool ExecuteInsertQuery(string tableName, DatabaseParamCls[] commandParameters)
        {
            try
            {
                SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
                this.GenInsert(tableName, parameterArray);
                return true;
            }
            catch (Exception exception)
            {
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
                return false;
            }
           
        }
        /// <summary>
        /// Thực thi câu lệnh cập nhật dữ liệu trong cơ sở dữ liệu
        /// </summary>
        /// <param name="tableName">tên bảng dữ liệu</param>       
        /// <param name="KeyField">tên trường khóa chính</param>
        /// <param name="KeyValue">Giá trị cần so sánh với khóa</param>
        /// <param name="commandParameters">Mảng các tham số truyền vào</param>    
        /// <returns>Trả về kiểu true - nếu dữ liệu được cập nhật và ngược lại</returns>
        public override bool ExecuteUpdateQuery(string tableName, string KeyField, string KeyValue, DatabaseParamCls[] commandParameters)
        {
            bool flag = false;
            try
            {
                SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
                flag = this.GenUpdate(tableName, KeyField, KeyValue, parameterArray);
            }
            catch (Exception exception)
            {
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            return flag;
        }

        private bool GenDelete(string tableName, string KeyField, string KeyValue)
        {
            bool flag = false ;
            string str = "Delete From [" + tableName + "] Where [" + KeyField + "] = @KeyField";
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = str;
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@KeyField", SqlDbType.NVarChar).Value = KeyValue;
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                flag = true;
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
            }
            return flag;
        }

        private void GenInsert(string tableName, SqlParameter[] commandParameters)
        {
            string commandText = this.GenStringInsert(tableName, commandParameters);
            bool mustCloseConnection = false;
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            this.PrepareCommand(command, connection, transaction, CommandType.Text, commandText, commandParameters, out mustCloseConnection);
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                command.Parameters.Clear();
                transaction.Dispose();
                connection.Close();
            }
        }

        private string GenStringInsert(string tableName, SqlParameter[] commandParameters)
        {
            string str = "Insert Into [" + tableName + "](";
            string str2 = " Values (";
            if (commandParameters == null)
            {
                commandParameters = new SqlParameter[0];
            }
            for (int i = 0; i < commandParameters.Length; i++)
            {
                string parameterName = commandParameters[i].ParameterName;
                if (!parameterName.Contains("@"))
                {
                    str = str + "[" + parameterName + "]";
                    str2 = str2 + "@" + parameterName;
                }
                else
                {
                    str2 = str2 + parameterName;
                    str = str + "[" + parameterName.Replace("@", string.Empty) + "]";
                }
                if (i < (commandParameters.Length - 1))
                {
                    str = str + ",";
                    str2 = str2 + ",";
                }
            }
            str = str + ")";
            str2 = str2 + ")";
            return (str + str2);
        }

        private string GenStringUpdate(string tableName, string KeyField, string KeyValue, SqlParameter[] commandParameters)
        {
            string str = "Update [" + tableName + "] Set ";
            for (int i = 0; i < commandParameters.Length; i++)
            {
                string parameterName = commandParameters[i].ParameterName;
                str = str + "[" + parameterName.Replace("@", string.Empty);
                if (!parameterName.Contains("@"))
                {
                    str = str + "]=@" + parameterName;
                }
                else
                {
                    str = str + "]=" + parameterName;
                }
                if (i < (commandParameters.Length - 1))
                {
                    str = str + ",";
                }
            }
            return (str + " Where [" + KeyField + "]=@KeyField");
        }

        private bool GenUpdate(string tableName, string KeyField, string KeyValue, SqlParameter[] commandParameters)
        {
            bool flag = false;
            string commandText = this.GenStringUpdate(tableName, KeyField, KeyValue, commandParameters);
            bool mustCloseConnection = false;
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            this.PrepareCommand(command, connection, transaction, CommandType.Text, commandText, commandParameters, out mustCloseConnection);
            try
            {
                command.Parameters.Add("@KeyField", SqlDbType.NVarChar).Value = KeyValue;
                command.ExecuteNonQuery();
                transaction.Commit();
                flag = true;
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                command.Parameters.Clear();
                transaction.Dispose();
                connection.Close();
            }
            return flag;
        }


        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <returns>DataTable - Số bản ghi bị ảnh hưởng bởi cậu lệnh</returns>
        public override DataTable GetRecordSet(string commandText)
        {
            return this.GetRecordSet(commandText, CommandType.Text);
        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandType">Kiểu của chuỗi câu lệnh truy vấn</param>
        /// <returns>DataTable -Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataTable GetRecordSet(string commandText, CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlCommand selectCommand = connection.CreateCommand();
            selectCommand.CommandText = commandText;
            selectCommand.CommandType = commandType;
            SqlTransaction transaction = connection.BeginTransaction();
            selectCommand.Transaction = transaction;
            try
            {
                new SqlDataAdapter(selectCommand).Fill(dataTable);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                selectCommand.Parameters.Clear();
                connection.Close();
            }
            return dataTable;

        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandParameters">Mảng các tham số truyền tương ứng cần truyền vào</param>
        /// <returns>DataTable -Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataTable GetRecordSet(string commandText, DatabaseParamCls[] commandParameters)
        {
            return this.GetRecordSet(commandText, commandParameters, CommandType.Text);
        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandParameters">Mảng các tham số truyền tương ứng cần truyền vào</param>
        /// <param name="commandType">Kiểu của chuỗi câu lệnh truy vấn</param>
        /// <returns>DataTable - Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataTable GetRecordSet(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            SqlCommand command = connection.CreateCommand();
            bool mustCloseConnection = false;
            SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
            SqlTransaction transaction = null;
            this.PrepareCommand(command, connection, transaction, commandType, commandText, parameterArray, out mustCloseConnection);
            transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                new SqlDataAdapter(command).Fill(dataTable);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
            
           
            return dataTable;

        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <returns>DataSet - Số bản ghi bị ảnh hưởng bởi cậu lệnh</returns>
        public override DataSet GetRecordSetByDataSet(string commandText)
        {
            return this.GetRecordSetByDataSet(commandText, CommandType.Text);
        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandType">Kiểu của chuỗi câu lệnh truy vấn</param>
        /// <returns>DataSet -Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataSet GetRecordSetByDataSet(string commandText, CommandType commandType)
        {
            DataSet dataSet = new DataSet();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlCommand selectCommand = connection.CreateCommand();
            selectCommand.CommandText = commandText;
            selectCommand.CommandType = commandType;
            SqlTransaction transaction = connection.BeginTransaction();
            selectCommand.Transaction = transaction;
            try
            {
                new SqlDataAdapter(selectCommand).Fill(dataSet);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                selectCommand.Parameters.Clear();
                connection.Close();
            }
            return dataSet;
        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandParameters">Mảng các tham số truyền tương ứng cần truyền vào</param>
        /// <returns>DataSet -Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataSet GetRecordSetByDataSet(string commandText, DatabaseParamCls[] commandParameters)
        {
            DataSet dataSet = new DataSet();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            SqlCommand command = connection.CreateCommand();
            bool mustCloseConnection = false;
            SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
            this.PrepareCommand(command, connection, null, CommandType.Text, commandText, parameterArray, out mustCloseConnection);
            SqlTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                new SqlDataAdapter(command).Fill(dataSet);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
           
            return dataSet;
        }
        /// <summary>
        /// Lấy các bản ghi từ cơ sở dữ liệu
        /// </summary>
        /// <param name="commandText">Chuỗi câu lệnh truy vấn Sql</param>
        /// <param name="commandParameters">Mảng các tham số truyền tương ứng cần truyền vào</param>
        /// <param name="commandType">Kiểu của chuỗi câu lệnh truy vấn</param>
        /// <returns>DataSet - Một bảng với số bản ghi ảnh hưởng bởi cậu lệnh</returns>
        public override DataSet GetRecordSetByDataSet(string commandText, DatabaseParamCls[] commandParameters, CommandType commandType)
        {
            DataSet dataSet = new DataSet();
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            SqlCommand command = connection.CreateCommand();
            bool mustCloseConnection = false;
            SqlParameter[] parameterArray = this.ConvertFromDataParam(commandParameters);
            this.PrepareCommand(command, connection, null, commandType, commandText, parameterArray, out mustCloseConnection);
            SqlTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                new SqlDataAdapter(command).Fill(dataSet);
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                string msg = exception.Message.ToString();
                msg = CorrectMsg(msg);
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(exception);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
           
            return dataSet;
        }
        public override void saveLog(string uid, string action)
        {
            string sql = "prd_Log_insert";
            SqlConnection connection = new SqlConnection(this._ConnectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd = connection.CreateCommand();            
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = transaction;
            try
            {
                cmd.Parameters.Add("@uid", SqlDbType.BigInt).Value = uid;
                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = action;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();               
                log.Error(exception);
            }
            finally
            {
                cmd.Parameters.Clear();
                transaction.Dispose();
                connection.Close();
            }
        }
        protected SqlConnection GetSqlConnection()
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection(this._ConnectionString);
            }
            catch
            {
                throw new Exception("SqlConnection");
            }
            return connection;
        }

        private void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if ((commandText == null) || (commandText.Length == 0))
            {
                throw new ArgumentNullException("commandText");
            }
            if (connection.State != ConnectionState.Open)
            {
                mustCloseConnection = true;
                connection.Open();
            }
            else
            {
                mustCloseConnection = false;
            }
            command.Connection = connection;
            command.CommandText = commandText;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            command.CommandType = commandType;
            if (commandParameters != null)
            {
                this.AttachParameters(command, commandParameters);
            }
        }
    }
    public sealed class DatabaseParamCls : DbParameter, IDbDataParameter, IDataParameter
    {
        // Fields
        [CompilerGenerated]
        private DbType _DbType;
        [CompilerGenerated]
        private SqlDbType _SqlDbType;
        [CompilerGenerated]
        private ParameterDirection _Direction;
        [CompilerGenerated]
        private bool _IsNullable;
        [CompilerGenerated]
        private string _ParameterName;
        [CompilerGenerated]
        private int _Size;
        [CompilerGenerated]
        private string _SourceColumn;
        [CompilerGenerated]
        private bool _SourceColumnNullMapping;
        [CompilerGenerated]
        private DataRowVersion _SourceVersion;
        [CompilerGenerated]
        private object _Value;
        private bool allow;

        // Methods
        public DatabaseParamCls()
        {
            this.allow = true;
            this.DbType = DbType.String;
        }

        public DatabaseParamCls(string paramName, object paramValue)
        {
            this.allow = true;
            this.ParameterName = paramName;
            this.Value = paramValue;
            this.DbType = DbType.String;
        }
        public DatabaseParamCls(string paramName, SqlDbType paramType, object paramValue)
        {
            this.allow = true;
            this.ParameterName = paramName;
            this.Value = paramValue;
            this.DbType = DbType.String;
            this.SqlFieldType = paramType;
        }

        public DatabaseParamCls(string paramName, DbType paramType, object paramValue)
        {
            this.allow = true;
            this.ParameterName = paramName;
            this.DbType = paramType;
            this.Value = paramValue;
        }

        public override void ResetDbType()
        {
            this.DbType = DbType.String;
        }

        // Properties
        public bool Allow
        {
            get
            {
                return this.allow;
            }
            set
            {
                this.allow = value;
            }
        }

        public override DbType DbType
        {
            [CompilerGenerated]
            get
            {
                return this._DbType;
            }
            [CompilerGenerated]
            set
            {
                this._DbType = value;
            }
        }
        public override ParameterDirection Direction
        {
            [CompilerGenerated]
            get
            {
                return this._Direction;
            }
            [CompilerGenerated]
            set
            {
                this._Direction = value;
            }
        }

        public string FieldName
        {
            get
            {
                return this._ParameterName;
            }
            set
            {
                _ParameterName = value;
            }
        }

        public override bool IsNullable
        {
            [CompilerGenerated]
            get
            {
                return this._IsNullable;
            }
            [CompilerGenerated]
            set
            {
                this._IsNullable = value;
            }
        }

        public override string ParameterName
        {
            [CompilerGenerated]
            get
            {
                return this._ParameterName;
            }
            [CompilerGenerated]
            set
            {
                this._ParameterName = value;
            }
        }

        public override int Size
        {
            [CompilerGenerated]
            get
            {
                return this._Size;
            }
            [CompilerGenerated]
            set
            {
                this._Size = value;
            }
        }

        public override string SourceColumn
        {
            [CompilerGenerated]
            get
            {
                return this._SourceColumn;
            }
            [CompilerGenerated]
            set
            {
                this._SourceColumn = value;
            }
        }

        public override bool SourceColumnNullMapping
        {
            [CompilerGenerated]
            get
            {
                return this._SourceColumnNullMapping;
            }
            [CompilerGenerated]
            set
            {
                this._SourceColumnNullMapping = value;
            }
        }

        public override DataRowVersion SourceVersion
        {
            [CompilerGenerated]
            get
            {
                return this._SourceVersion;
            }
            [CompilerGenerated]
            set
            {
                this._SourceVersion = value;
            }
        }

        public SqlDbType SqlFieldType
        {
            get
            {
                switch (this.DbType)
                {
                    case DbType.AnsiString:
                        return SqlDbType.VarChar;

                    case DbType.Binary:
                        return SqlDbType.Binary;

                    case DbType.Byte:
                        return SqlDbType.TinyInt;

                    case DbType.Boolean:
                        return SqlDbType.Bit;

                    case DbType.Currency:
                        return SqlDbType.Money;

                    case DbType.Date:
                        return SqlDbType.Date;

                    case DbType.DateTime:
                        return SqlDbType.DateTime;

                    case DbType.Decimal:
                        return SqlDbType.Decimal;

                    case DbType.Double:
                        return SqlDbType.Float;

                    case DbType.Guid:
                        return SqlDbType.UniqueIdentifier;

                    case DbType.Int16:
                        return SqlDbType.SmallInt;

                    case DbType.Int32:
                        return SqlDbType.Int;

                    case DbType.Int64:
                        return SqlDbType.BigInt;

                    case DbType.Object:
                        return SqlDbType.Variant;

                    case DbType.String:
                        return SqlDbType.NVarChar;

                    case DbType.Time:
                        return SqlDbType.Time;

                    case DbType.AnsiStringFixedLength:
                        return SqlDbType.Char;

                    case DbType.StringFixedLength:
                        return SqlDbType.NChar;

                    case DbType.Xml:
                        return SqlDbType.Xml;

                    case DbType.DateTime2:
                        return SqlDbType.DateTime2;
                    default:
                        return SqlDbType.NVarChar;
                }
                
            }
            set
            {
                this._SqlDbType = value;
            }
        }

        public override object Value
        {
            [CompilerGenerated]
            get
            {
                return this._Value;
            }
            [CompilerGenerated]
            set
            {
                this._Value = value;
            }
        }
    }
}
