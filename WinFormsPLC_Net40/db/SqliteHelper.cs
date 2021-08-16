using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsPLC_Net40
{


    public static class SqliteHelper
    {
        // 连接字符串
        public static string connStr = "Data Source=" + Directory.GetCurrentDirectory() + "\\DB\\PLCDB.sqlite;Version=3;";

        #region 创建数据库
        /// <summary>
        /// 创建数据库
        /// </summary>
        public static void Create()
        {
            SQLiteConnection cn = new SQLiteConnection(connStr);
            //按照路径创建数据库文件
            cn.Open();
            cn.Close();
        }

        #endregion

        #region  创建数据库表 数据库初始化
        /// <summary>
        ///创建数据库表
        /// </summary>
        public static void CreateTable()
        {
            SQLiteConnection cn = new SQLiteConnection(connStr);//建立数据库连接
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();//打开数据库
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;//把 SQLiteCommand的 Connection和SQLiteConnection 联系起来
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS PT_OrederInfo( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(100) ,Creater varchar(100),CreateDate datetime, Isdelete varchar(2), note text ) ;" + //订单号 信息
                    "CREATE TABLE IF NOT EXISTS OrderNumberManagement( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(100) ,Creater varchar(100),CreateDate datetime, Isdelete varchar(2)) ;" + // 订单编号管理
                    "CREATE TABLE IF NOT EXISTS PT_Term ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50), Creater varchar(100),CreateDate datetime, Isdelete varchar(2),CommunicationTypes varchar(50),TermBrand varchar(50), TermModel varchar(50)) ;" +  //  设备信息
                    "CREATE TABLE IF NOT EXISTS PT_CommunicationTypes( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate datetime, Isdelete varchar(2)) ;" + //   通讯类型
                    "CREATE TABLE IF NOT EXISTS PT_IPAddress( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate datetime, Isdelete varchar(2), IP varchar(30),port varchar(6), StandNo int ,RegisterPosition varchar(10),TermId varchar(50),Location int ) ;" +  //IP 地址管理 
                    "CREATE TABLE IF NOT EXISTS PT_RS232Address( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50) ,Creater varchar(100),CreateDate datetime, Isdelete varchar(2), BaudRate int, StopBit int, Parity varchar(4), StandNo int,TermId varchar(50),Location int) ;" + //RS232 地址管理
                    " CREATE TABLE IF NOT EXISTS PT_485Address( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate datetime, Isdelete varchar(2),TermId varchar(50),Location int) ;" +//485地址管理
                    "CREATE TABLE IF NOT EXISTS PT_User ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate datetime, Isdelete varchar(2),password varchar(200));" +//用户表
                    "CREATE TABLE IF NOT EXISTS PT_BarCode ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate date, Isdelete varchar(2));" + //条码表
                    "CREATE TABLE IF NOT EXISTS Equipment_Directive ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate datetime, Isdelete varchar(2), DeviceType varchar(50), PerformName varchar(50),PerformContent varchar(200),PerformReturn varchar(100), PerformOrder int,PerformEnable INT);" +//设备指令表
                    "CREATE TABLE IF NOT EXISTS Perform_Type ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(100),Creater varchar(100),CreateDate datetime, Isdelete varchar(2))";//指令类型表
                cmd.ExecuteNonQuery();//调用此方法运行
            }
            cn.Close();
        }
        #endregion

        #region 遍历查询表结构 
        /// <summary>
        /// 查询表结构
        /// </summary>
        public static void TableStructure()
        {
            //连接到数据库文件，使用PRAGMA命令准备
            SQLiteConnection cn = new SQLiteConnection(connStr);
            cn.Open();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "PRAGMA table_info('t1')";

            /*            //方法一：用DataAdapter和DataTable类，调用方法为using System.Data
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        foreach (DataRow r in table.Rows)
                        {
                            Console.WriteLine($"{r["cid"]},{r["name"]},{r["type"]},{r["notnull"]},{r["dflt_value"]},{r["pk"]} ");
                        }
                        Console.WriteLine();*/

            //方法二：用DataReader，这个效率高些
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader[i]},");
                }
                Console.WriteLine();
            }
            reader.Close();

        }

        /// <summary>
        /// 遍历查询表结构
        /// </summary>
        public static void QueryAllTableInfo()
        {
            SQLiteConnection cn = new SQLiteConnection(connStr);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE TYPE='table' ";
                SQLiteDataReader sr = cmd.ExecuteReader();
                List<string> tables = new List<string>();
                while (sr.Read())
                {
                    tables.Add(sr.GetString(0));
                }
                //datareader 必须要先关闭，否则 commandText 不能赋值
                sr.Close();
                foreach (var a in tables)
                {
                    cmd.CommandText = $"PRAGMA TABLE_INFO({a})";
                    sr = cmd.ExecuteReader();
                    while (sr.Read())
                    {
                        Console.WriteLine($"{sr[0]} {sr[1]} {sr[2]} {sr[3]}");
                    }
                    sr.Close();
                }
            }
            cn.Close();
        }

        #endregion

        #region 删除数据库表
        /// <summary>
        /// 删除数据库表
        /// </summary>
        public static void DeleteTable()
        {
            SQLiteConnection cn = new SQLiteConnection(connStr);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DROP TABLE IF EXISTS t1";
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }
        #endregion

        #region  删除数据库
        /// <summary>
        /// 删除数据库
        /// </summary>
        public static void Delete()
        {
            try
            {
                if (System.IO.File.Exists(Directory.GetCurrentDirectory() + "\\DB\\PLCDB.sqlite"))
                {
                    System.IO.File.Delete(Directory.GetCurrentDirectory() + "\\DB\\PLCDB.sqlite");
                    Log("删除成功");
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

        }

        #endregion

        #region  查询数据

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns>DataTable</returns>
        public static DataTable SelectDB(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connStr);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(SQL, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                //关闭连接，释放资源
                conn.Close();
                conn.Dispose();
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return dt;
            }
            return dt;
        }
        #endregion



        #region 增删改数据
        /// <summary>
        /// 增删改数据
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns>bool类型</returns>
        public static bool OperationDB(string SQL)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connStr);
                conn.Open();
                string Sql = string.Format(SQL);
                SQLiteCommand insertData = new SQLiteCommand(Sql, conn);
                insertData.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return false;
            }
            return true;
        }

        #endregion

        /// <summary>
        /// 返回数据是否存在
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int sqlQuery(string sql)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(connStr);
                conn.Open();
                string Sql = string.Format(sql);
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = Sql;
                command.Connection = conn;
                SQLiteDataReader reader = command.ExecuteReader();
                int result = 0;
                while (reader.Read())
                {
                    result = 1;
                }
                conn.Close();
                return result;
            }
            catch (System.Exception ex)
            {
                Log(ex.Message);
            }
            return 0;
        }

        public static object ExecuteScalar( string commandText, params object[] paramList)
        {
            SQLiteConnection cn = new SQLiteConnection(connStr);
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = commandText;
            AttachParameters(cmd, commandText, paramList);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            cn.Close();

            return result;
        }

        private static SQLiteParameterCollection AttachParameters(SQLiteCommand cmd, string commandText, params object[] paramList)
        {
            if (paramList == null || paramList.Length == 0) return null;

            SQLiteParameterCollection coll = cmd.Parameters;
            string parmString = commandText.Substring(commandText.IndexOf("@"));
            // pre-process the string so always at least 1 space after a comma.
            parmString = parmString.Replace(",", " ,");
            // get the named parameters into a match collection
            string pattern = @"(@)\S*(.*?)\b";
            Regex ex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection mc = ex.Matches(parmString);
            string[] paramNames = new string[mc.Count];
            int i = 0;
            foreach (Match m in mc)
            {
                paramNames[i] = m.Value;
                i++;
            }

            // now let's type the parameters
            int j = 0;
            Type t = null;
            foreach (object o in paramList)
            {
                t = o.GetType();

                SQLiteParameter parm = new SQLiteParameter();
                switch (t.ToString())
                {

                    case ("DBNull"):
                    case ("Char"):
                    case ("SByte"):
                    case ("UInt16"):
                    case ("UInt32"):
                    case ("UInt64"):
                        throw new SystemException("Invalid data type");


                    case ("System.String"):
                        parm.DbType = DbType.String;
                        parm.ParameterName = paramNames[j];
                        parm.Value = (string)paramList[j];
                        coll.Add(parm);
                        break;

                    case ("System.Byte[]"):
                        parm.DbType = DbType.Binary;
                        parm.ParameterName = paramNames[j];
                        parm.Value = (byte[])paramList[j];
                        coll.Add(parm);
                        break;

                    case ("System.Int32"):
                        parm.DbType = DbType.Int32;
                        parm.ParameterName = paramNames[j];
                        parm.Value = (int)paramList[j];
                        coll.Add(parm);
                        break;

                    case ("System.Boolean"):
                        parm.DbType = DbType.Boolean;
                        parm.ParameterName = paramNames[j];
                        parm.Value = (bool)paramList[j];
                        coll.Add(parm);
                        break;

                    case ("System.DateTime"):
                        parm.DbType = DbType.DateTime;
                        parm.ParameterName = paramNames[j];
                        parm.Value = Convert.ToDateTime(paramList[j]);
                        coll.Add(parm);
                        break;

                    case ("System.Double"):
                        parm.DbType = DbType.Double;
                        parm.ParameterName = paramNames[j];
                        parm.Value = Convert.ToDouble(paramList[j]);
                        coll.Add(parm);
                        break;

                    case ("System.Decimal"):
                        parm.DbType = DbType.Decimal;
                        parm.ParameterName = paramNames[j];
                        parm.Value = Convert.ToDecimal(paramList[j]);
                        break;

                    case ("System.Guid"):
                        parm.DbType = DbType.Guid;
                        parm.ParameterName = paramNames[j];
                        parm.Value = (System.Guid)(paramList[j]);
                        break;

                    case ("System.Object"):

                        parm.DbType = DbType.Object;
                        parm.ParameterName = paramNames[j];
                        parm.Value = paramList[j];
                        coll.Add(parm);
                        break;

                    default:
                        throw new SystemException("Value is of unknown data type");

                } // end switch

                j++;
            }
            return coll;
        }


        /// <summary>
        /// 从SQL语句和对象[]参数值数组执行数据集的快捷方法
        /// </summary>
        /// <param name="connectionString">SQLite Connection string</param>
        /// <param name="commandText">SQL Statement with embedded "@param" style parameter names</param>
        /// <param name="paramList">object[] array of parameter values</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string connectionString, string commandText, object[] paramList)
        {
            SQLiteConnection cn = new SQLiteConnection(connectionString);
            SQLiteCommand cmd = cn.CreateCommand();


            cmd.CommandText = commandText;
            if (paramList != null)
            {
                AttachParameters(cmd, commandText, paramList);
            }
            DataSet ds = new DataSet();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            cn.Close();
            return ds;
        }
        /// <summary>
        /// 从SQL语句和对象[]参数值数组执行数据集的快捷方法
        /// </summary>
        /// <param name="cn">Connection.</param>
        /// <param name="commandText">Command text.</param>
        /// <param name="paramList">Param list.</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(SQLiteConnection cn, string commandText, object[] paramList)
        {

            SQLiteCommand cmd = cn.CreateCommand();


            cmd.CommandText = commandText;
            if (paramList != null)
            {
                AttachParameters(cmd, commandText, paramList);
            }
            DataSet ds = new DataSet();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            cn.Close();
            return ds;
        }
        /// <summary>
        /// Executes the dataset from a populated Command object.
        /// </summary>
        /// <param name="cmd">Fully populated SQLiteCommand</param>
        /// <returns>DataSet</returns>
        public static DataSet ExecuteDataset(SQLiteCommand cmd)
        {
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
            cmd.Connection.Close();
            cmd.Dispose();
            return ds;
        }



        #region  本类log

        /// <summary>
        /// 本类log
        /// </summary>
        /// <param name="s"></param>
        static void Log(string s)
        {
            Console.WriteLine("class SqLiteHelper:::" + s);
        }
        #endregion
    }

}
