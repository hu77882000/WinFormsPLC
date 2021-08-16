using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC_Net4
{
    public static class SqliteHelper
    {
        // 连接字符串
        private static string connStr = "Data Source=" + Directory.GetCurrentDirectory() + "\\DB\\PLCDB.sqlite;Version=3;";

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
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS PT_OrederInfo( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(100) ,Creater varchar(100),CreateDate date, Isdelete varchar(2), note text ) ;" + //输入SQL语句  订单号 信息
                    "CREATE TABLE IF NOT EXISTS OrderNumberManagement( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(100) ,Creater varchar(100),CreateDate date, Isdelete varchar(2)) ;" + // 订单编号管理
                    "CREATE TABLE IF NOT EXISTS PT_Term ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50), Creater varchar(100),CreateDate date, Isdelete varchar(2),CommunicationTypes varchar(50),TermBrand varchar(50), TermModel varchar(50)) ;" +  //输入SQL语句   设备信息
                    "CREATE TABLE IF NOT EXISTS PT_CommunicationTypes( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate date, Isdelete varchar(2)) ;" + //   通讯类型
                    "CREATE TABLE IF NOT EXISTS PT_IPAddress( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate date, Isdelete varchar(2), IP varchar(30),port varchar(6), StandNo int ,RegisterPosition varchar(10),TermId varchar(50),Location int ) ;" +  //IP 地址管理 
                    "CREATE TABLE IF NOT EXISTS PT_RS232Address( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50) ,Creater varchar(100),CreateDate date, Isdelete varchar(2), BaudRate int, StopBit int, Parity varchar(4), StandNo int,TermId varchar(50),Location int) ;" + //RS232 地址管理
                    " CREATE TABLE IF NOT EXISTS PT_485Address( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate date, Isdelete varchar(2),TermId varchar(50),Location int) ;" +//485地址管理
                    "CREATE TABLE IF NOT EXISTS PT_User ( id varchar(50) PRIMARY KEY,ItemCode varchar(100),ItemName varchar(50),Creater varchar(100),CreateDate date, Isdelete varchar(2))";
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
