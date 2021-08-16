using HslCommunication.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WinFormsPLC_Net40
{
    public partial class FrmSelect : Form
    {
        public FrmSelect(string str)
        {
            InitializeComponent();
            toolStripStatusLabel4.Text = str;  //登录时 传入登录名
        }

        #region  声明变量
        private TabPage tbOne = null;
        private TabPage tbTwo = null;
        private TabPage tbThree = null;
        private TabPage tbFour = null;
        //private TabPage tbFive = null;
        const int CLOSE_SIZE = 12;
        #endregion

        #region 菜单栏 添加功能
        /// <summary>
        /// 添加窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            if (ErgodicModiForm("tbone", MainTabControl))
            {
                tbOne = new TabPage("添加功能");
                tbOne.Name = "tbone";
                MainTabControl.Controls.Add(tbOne);
                FrmAddIPEquipment hslForm = new FrmAddIPEquipment();
                hslForm.TopLevel = false;
                hslForm.BackColor = Color.Black;
                hslForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                hslForm.FormBorderStyle = FormBorderStyle.None;
                hslForm.Show();
                tbOne.Controls.Add(hslForm);
            }
            MainTabControl.SelectedTab = tbOne;
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
            if (ErgodicModiForm("tbtwo", MainTabControl))
            {
                tbTwo = new TabPage("设备监控");
                tbTwo.Name = "tbtwo";
                MainTabControl.Controls.Add(tbTwo);
                FormCurveMonitor hslForm = new FormCurveMonitor();
                hslForm.TopLevel = false;
                hslForm.BackColor = Color.Black;
               
                hslForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                hslForm.FormBorderStyle = FormBorderStyle.None;
                hslForm.Show();
                tbTwo.Controls.Add(hslForm);
            }
            MainTabControl.SelectedTab = tbTwo;
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
            if (ErgodicModiForm("tbDebug", MainTabControl))
            {
                tbThree = new TabPage("设备调试");
                tbThree.Name = "tbDebug";
                MainTabControl.Controls.Add(tbThree);
                FrmMain hslForm = new FrmMain();
                hslForm.TopLevel = false;
                hslForm.BackColor = Color.Black;
                hslForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                hslForm.FormBorderStyle = FormBorderStyle.None;
                hslForm.Show();
                tbThree.Controls.Add(hslForm);
            }
            MainTabControl.SelectedTab = tbThree;
        }
        #endregion

        #region  窗体加载事件
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel2.Text = "登录时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss");

            //this.MainTabControl.TabPages.Clear();  //清除TabControl 容器中标签
            this.MainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Padding = new System.Drawing.Point(CLOSE_SIZE, CLOSE_SIZE / 2);
            this.MainTabControl.DrawItem += new DrawItemEventHandler(this.MainTabControl_DrawItem);
            this.MainTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseDown);

/*            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();*/
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
            if (ErgodicModiForm("tbContent", MainTabControl))
            {
                tbFour = new TabPage("设备管理");
                tbFour.Name = "tbContent";
                MainTabControl.Controls.Add(tbFour);
                HslFormContent hslForm = new HslFormContent();
                hslForm.TopLevel = false;
                hslForm.Width = 640;
                hslForm.BackColor = Color.White;
                hslForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                hslForm.FormBorderStyle = FormBorderStyle.None;
                hslForm.Show();
                tbFour.Controls.Add(hslForm);
            }
            MainTabControl.SelectedTab = tbFour;
        }

        #endregion

        #region 设备管理
        private void uiImageButton5_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("设备管理");
            MainTabControl.TabPages.Add(tp);

            HslFormContent tb = new HslFormContent();
            tb.Dock = DockStyle.Fill;
            tb.TopLevel = false;
            tp.Controls.Add(tb);
        }
        #endregion

        #region 初始化数据库
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
        #endregion

        #region  TabControl窗体绘画

        /// <summary>
        /// TabControl窗体绘画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle tabRect = this.MainTabControl.GetTabRect(e.Index);
                e.Graphics.DrawString(this.MainTabControl.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, (float)(tabRect.X + 2), (float)(tabRect.Y + 2));
                using (Pen pen = new Pen(Color.Red))
                {
                    tabRect.Offset(tabRect.Width - 0x12, 2);
                    tabRect.Width = 15;
                    tabRect.Height = 15;
                    e.Graphics.DrawRectangle(pen, tabRect);
                }
                Color color = (e.State == DrawItemState.Selected) ? Color.Red : Color.Red;
                using (Brush brush = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(brush, tabRect);
                }
                using (Pen pen2 = new Pen(Color.White))
                {
                    Point point = new Point(tabRect.X + 3, tabRect.Y + 3);
                    Point point2 = new Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);
                    e.Graphics.DrawLine(pen2, point, point2);
                    Point point3 = new Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);
                    Point point4 = new Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);
                    e.Graphics.DrawLine(pen2, point3, point4);
                    Point point5 = new Point(tabRect.X - 50, 4);
                }
                e.Graphics.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region  TabControl 关闭单击事件
        /// <summary>
        /// TabControl 关闭单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                Rectangle tabRect = this.MainTabControl.GetTabRect(this.MainTabControl.SelectedIndex);
                tabRect.Offset(tabRect.Width - 0x12, 2);
                tabRect.Width = 15;
                tabRect.Height = 15;
                if ((((x > tabRect.X) && (x < tabRect.Right)) && (y > tabRect.Y)) && (y < tabRect.Bottom))
                {
                    this.MainTabControl.TabPages.Remove(this.MainTabControl.SelectedTab);
                }
            }
        }

        #endregion

        #region 判断窗体是否重复
        /// <summary>
        ///  判断窗体是否重复
        /// </summary>
        /// <param name="MainTabControlKey">选项卡的键值</param>
        /// <param name="objTabControl">是否添加到TabControl</param>
        /// <returns></returns>
        private Boolean ErgodicModiForm(string MainTabControlKey, TabControl objTabControl)
        {
            foreach (Control con in objTabControl.Controls)
            {
                TabPage tab = (TabPage)con;
                if (tab.Name == MainTabControlKey)
                {
                    return false;//存在
                }
            }
            return true;//不存在
        }
        #endregion

        #region 版本更新
        private void 版本更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Db.path = AppDomain.CurrentDomain.BaseDirectory + "Update.ini";
            CheckVer checkver = new CheckVer();
            string serivceVer = checkver.GetServiceVer();
            string clientVer = Db.getver();
            if (clientVer != serivceVer)
            {
                DialogResult dialogResult = MessageBox.Show("有新版本，是否更新？", "升级", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Process.Start("Update.exe");
                    Db.IniWriteValue("update", "version", serivceVer);  //修改为服务器版本号 .inf 文件 内容
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("当前版本已经是最新");
            }
        }
        #endregion

        #region  窗体每一次加载完后显示事件
        private void FrmSelect_Shown(object sender, EventArgs e)
        {
            /*  if (Public_Class_Method.IsCanConnect("http://192.168.153.3:8080/WebService.asmx"))
              {
                  try
                  {
                      Db.path = AppDomain.CurrentDomain.BaseDirectory + "Update.ini";  //地址赋值
                      CheckVer checkver = new CheckVer();
                      string serivceVer = checkver.GetServiceVer();
                      string clientVer = Db.getver();
                      if (clientVer != serivceVer)
                      {
                          DialogResult dialogResult = MessageBox.Show("有新版本，是否更新？", "升级", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                          if (dialogResult == DialogResult.OK)
                          {
                              Process.Start("Update.exe");
                              Db.IniWriteValue("update", "version", serivceVer);  //修改为服务器版本号 .inf 文件 内容
                          }
                          else
                          {
                          }
                      }
                  }
                  catch (System.Exception ex)
                  {
                      MessageBox.Show("网络无法连接:" + ex.Message);
                  }
              }
              else
              {
                  MessageBox.Show("网络连接异常，系统无法检测更新");
              }*/
            try
            {
                Process cur = Process.GetCurrentProcess();
                curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
            }
            catch
            {

            }


        }
        #endregion

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }
        private System.Windows.Forms.Timer timer;
        private PerformanceCounter curpcp = null;
        private const int MB_DIV = 1024 * 1024;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (curpcp != null)
            {
                string RamInfo = (curpcp.NextValue() / MB_DIV).ToString("F1") + "MB";
                label2.Text = "使用内存: " + RamInfo;
            }
            label1.Text = $"当前线程数:{Process.GetCurrentProcess().Threads.Count}  锁:{SimpleHybirdLock.SimpleHybirdLockCount}  等待:{SimpleHybirdLock.SimpleHybirdLockWaitCount}";
        }
    }
}
