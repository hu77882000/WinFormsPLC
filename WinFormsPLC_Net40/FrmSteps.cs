using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WinFormsPLC_Net40.Steps;

namespace WinFormsPLC_Net40
{
    public partial class FrmSteps : Form
    {
        public FrmSteps()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        #region  声明变量
        private TabPage tbOne;
        private TabPage tbTwo;
        private TabPage tbThree = null;
        private TabPage tbFour = null;
        private TabPage tbFive = null;
        private TabPage tbSix = null;
        //private TabPage tbSeven = null;
        const int CLOSE_SIZE = 12;
        #endregion
        private void FrmSteps_Load(object sender, EventArgs e)
        {
            TreeNode roowNode = new TreeNode();
            roowNode.Name = "Node0";
            roowNode.Text = "常规";
            TreeNode node1 = new TreeNode();
            node1.Name = "Node1";
            node1.Text = "步骤";
            TreeNode node2 = new TreeNode();
            node2.Name = "Node2";
            node2.Text = "计划";
            node2.Tag = typeof(FrmPlan);
            TreeNode node3 = new TreeNode();
            node3.Name = "Node3";
            node3.Text = "警告";
            node3.Tag = typeof(FrmWarn);
            TreeNode node4 = new TreeNode();
            node4.Name = "Node4";
            node4.Text = "通知";
            node4.Tag = typeof(FrmNotice);
            TreeNode node5 = new TreeNode();
            node5.Name = "Node5";
            node5.Text = "目标";
            node5.Tag = typeof(FrmTarget);
            this.treeView1.ImageList = imageList1;
            this.treeView1.ImageIndex = 0;
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Nodes.Add(roowNode);
            this.treeView1.Nodes.Add(node1);
            this.treeView1.Nodes.Add(node2);
            this.treeView1.Nodes.Add(node3);
            this.treeView1.Nodes.Add(node4);
            this.treeView1.Nodes.Add(node5);
            this.treeView1.ExpandAll();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.ToString() == "常规")
            {
                tabPage = tbOne;
                TreeNoteTabControls("tbNode0", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmConventional");
                tbOne = tabPage;
            }

            else if (e.Node.Text.ToString() == "步骤")
            {
                tabPage = tbTwo;
                TreeNoteTabControls("tbNode1", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmStep");
                tbTwo = tabPage;
            }
            else if (e.Node.Text.ToString() == "计划")
            {
                tabPage = tbThree;
                TreeNoteTabControls("tbNode2", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmPlan");
                tbThree = tabPage;
            }
            else if (e.Node.Text.ToString() == "警告")
            {
                tabPage = tbFour;
                TreeNoteTabControls("tbNode3", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmWarn");
                tbFour = tabPage;
            }
            else if (e.Node.Text.ToString() == "通知")
            {
                tabPage = tbFive;
                TreeNoteTabControls("tbNode4", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmNotice");
                tbFive = tabPage;
            }
            else if (e.Node.Text.ToString() == "目标")
            {
                tabPage = tbSix;
                TreeNoteTabControls("tbNode5", e.Node.Text.ToString(), "WinFormsPLC_Net40.Steps.FrmTarget");
                tbSix = tabPage;
            }
        }
        #region  treeeView控制窗体赋值

        private TabPage tabPage;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabName">tab名字</param>
        /// <param name="tabHead">tab标题</param>
        /// <param name="Formname">窗体名</param>
        private void TreeNoteTabControls(string tabName,string tabHead, String Formname)
        {
            if (ErgodicModiForm(tabName, MainTabControl))
            {
                tabPage = new TabPage(tabHead);
                tabPage.Name = tabName;
                MainTabControl.Controls.Add(tabPage);
                Assembly assembly = Assembly.GetExecutingAssembly();//实例化窗体
                Form frmc = assembly.CreateInstance(Formname) as Form;
                frmc.TopLevel = false;
                frmc.BackColor = Color.White;
                frmc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                frmc.FormBorderStyle = FormBorderStyle.None;
                frmc.Show();
                tabPage.Controls.Add(frmc);
            }
            MainTabControl.SelectedTab = tabPage;
        }
        #endregion

        #region  TabControl窗体绘画 事件        
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

        #region    TabControl  关闭单击事件
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
    }
}
