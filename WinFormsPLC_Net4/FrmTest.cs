using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsPLC_Net4
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        public void DataLoad() //自定义数据绑定方法
        {
            string connStr = "Data Source=" + Directory.GetCurrentDirectory() + "\\DB\\PLCDB.sqlite;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connStr);
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from PT_Term ";
            conn.Open();
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine(reader.FieldCount);
                Console.WriteLine(reader.Depth);
                Console.WriteLine(reader.HasRows);
                Console.WriteLine(reader.IsClosed);
                Console.WriteLine(reader.RecordsAffected);
                Console.WriteLine(reader.VisibleFieldCount);
                while (reader.Read())
                {
                    Console.WriteLine(reader["ItemCode"]);
                    Console.WriteLine(reader["ItemName"]);
                    label1.Text = reader["ItemCode"].ToString();
                    label2.Text = reader["ItemName"].ToString();
                    pictureBox1.Image = imageList1.Images[0];
                }
            }
            conn.Close();

            /*            string sql = "select * from PT_Term";
                        DataTable dt = SqliteHelper.SelectDB(sql);
                        foreach (DataRow item in dt.Rows)
                        {
                            label1.Text = item["itemName"].ToString();
                            pictureBox1.Image = imageList1.Images[0];

                        }*/
        }

    }
}
