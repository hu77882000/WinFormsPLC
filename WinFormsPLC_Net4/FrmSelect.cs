using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinFormsPLC_Net4
{
    public partial class FrmSelect : Form
    {
        public FrmSelect(string str)
        {
            InitializeComponent();
            toolStripStatusLabel4.Text = str;  //登录时 传入登录名
        }
        #region 菜单栏 添加功能
        /// <summary>
        /// 添加窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            dockPanel1.Controls.Clear();
           //pnlTest.Controls.Clear();
            ///将窗体设置成子窗体
            FrmAddIPEquipment sub = new FrmAddIPEquipment(); //new 对象
            sub.TopLevel = false;  //取消窗体的置顶模式
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件

            sub.FormBorderStyle = FormBorderStyle.None;//取消边框
            dockPanel1.Controls.Add(sub);//将窗体添加至右侧容器中
            sub.Show();//显示窗体    
        }

        #endregion

        #region 菜单栏  设备监控
        /// <summary>
        ///  设备监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            dockPanel1.Controls.Clear();
            ///将窗体设置成子窗体
            FrmMonitoring sub = new FrmMonitoring(); //new 对象
            sub.TopLevel = false;  //取消窗体的置顶模式
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件

            sub.FormBorderStyle = FormBorderStyle.None;//取消边框
            dockPanel1.Controls.Add(sub);//将窗体添加至右侧容器中
            sub.Show();//显示窗体

        }
        #endregion

        #region 菜单栏  调试功能
        /// <summary>
        /// 调试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiImageButton4_Click(object sender, EventArgs e)
        {
            dockPanel1.Controls.Clear();
            ///将窗体设置成子窗体
            FrmMain sub = new FrmMain(); //new 对象
            sub.TopLevel = false;  //取消窗体的置顶模式
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件

            sub.FormBorderStyle = FormBorderStyle.None;//取消边框
            dockPanel1.Controls.Add(sub);//将窗体添加至右侧容器中
            sub.Show();//显示窗体
        }
        #endregion

        #region  窗体加载事件
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel2.Text = "登录时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss");
            /* uiImageListBox1.Visible = false;
             uiImageListBox2.Visible = false;
             uiImageListBox3.Visible = false;
             uiImageListBox4.Visible = false;
             uiImageListBox5.Visible = false;
             uiImageListBox6.Visible = false;
             uiImageListBox7.Visible = false;
             uiImageListBox8.Visible = false;
             uiImageListBox9.Visible = false;
             uiImageListBox10.Visible = false;
             uiImageListBox11.Visible = false;
             uiImageListBox12.Visible = false;
             uiImageListBox13.Visible = false;
             uiImageListBox14.Visible = false;
             uiImageListBox15.Visible = false;
             uiImageListBox16.Visible = false;
             uiImageListBox17.Visible = false;
             uiImageListBox18.Visible = false;
             uiImageListBox19.Visible = false;
             uiImageListBox20.Visible = false;
             uiImageListBox21.Visible = false;
             uiImageListBox22.Visible = false;
             uiImageListBox23.Visible = false;
             uiImageListBox24.Visible = false;
             uiImageListBox2.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;
             uiImageListBox1.Visible = false;*/
        }

        #endregion

        #region  菜单栏  设备管理
        /// <summary>
        /// 设备配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiImageButton2_Click(object sender, EventArgs e)
        {
           // dockPanel1.Controls.Clear();
            ///将窗体设置成子窗体
            HslFormContent sub = new HslFormContent(); //new 对象
            sub.TopLevel = false;  //取消窗体的置顶模式
            sub.Dock = DockStyle.Fill;//把子窗体设置为控件

            sub.FormBorderStyle = FormBorderStyle.None;//取消边框
            dockPanel1.Controls.Add(sub);//将窗体添加至右侧容器中
            sub.Show();//显示窗体
        }

        #endregion

        private void uiImageButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void 初始化数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqliteHelper.Delete();
            bool dbExist = File.Exists("DB" + "\\" + "PLCDB.sqlite");    //通过File.Exists函数判断数据库文件是否已经存在
            if (dbExist == false) //如果不存在，就创建
            {
                SqliteHelper.Create();
            }
            SqliteHelper.CreateTable();
        }
    }
}
