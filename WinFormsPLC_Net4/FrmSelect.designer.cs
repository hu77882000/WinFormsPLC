
namespace WinFormsPLC_Net4
{
    partial class FrmSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelect));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清理订单信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取订单信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取订单编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiImageButton2 = new Sunny.UI.UIImageButton();
            this.uiImageButton3 = new Sunny.UI.UIImageButton();
            this.uiImageButton4 = new Sunny.UI.UIImageButton();
            this.uiImageButton5 = new Sunny.UI.UIImageButton();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton5)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            this.cmsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(1010, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thread:0  Lock:0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.数据库操作ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 数据库操作ToolStripMenuItem
            // 
            this.数据库操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化数据库ToolStripMenuItem,
            this.清理订单信息表ToolStripMenuItem,
            this.获取订单信息ToolStripMenuItem,
            this.获取订单编码ToolStripMenuItem});
            this.数据库操作ToolStripMenuItem.Name = "数据库操作ToolStripMenuItem";
            this.数据库操作ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据库操作ToolStripMenuItem.Text = "数据库操作";
            // 
            // 初始化数据库ToolStripMenuItem
            // 
            this.初始化数据库ToolStripMenuItem.Name = "初始化数据库ToolStripMenuItem";
            this.初始化数据库ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.初始化数据库ToolStripMenuItem.Text = "初始化数据库";
            this.初始化数据库ToolStripMenuItem.Click += new System.EventHandler(this.初始化数据库ToolStripMenuItem_Click);
            // 
            // 清理订单信息表ToolStripMenuItem
            // 
            this.清理订单信息表ToolStripMenuItem.Name = "清理订单信息表ToolStripMenuItem";
            this.清理订单信息表ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.清理订单信息表ToolStripMenuItem.Text = "清理订单信息表";
            // 
            // 获取订单信息ToolStripMenuItem
            // 
            this.获取订单信息ToolStripMenuItem.Name = "获取订单信息ToolStripMenuItem";
            this.获取订单信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.获取订单信息ToolStripMenuItem.Text = "获取订单信息";
            // 
            // 获取订单编码ToolStripMenuItem
            // 
            this.获取订单编码ToolStripMenuItem.Name = "获取订单编码ToolStripMenuItem";
            this.获取订单编码ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.获取订单编码ToolStripMenuItem.Text = "获取订单编码";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本更新ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 版本更新ToolStripMenuItem
            // 
            this.版本更新ToolStripMenuItem.Name = "版本更新ToolStripMenuItem";
            this.版本更新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.版本更新ToolStripMenuItem.Text = "版本更新";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(203, 869);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(746, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "登录信息：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel2.Text = "登录时间";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 831);
            this.treeView1.TabIndex = 43;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton1.Location = new System.Drawing.Point(3, 66);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(194, 84);
            this.uiImageButton1.TabIndex = 44;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "添加设备";
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // uiImageButton2
            // 
            this.uiImageButton2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton2.Location = new System.Drawing.Point(3, 199);
            this.uiImageButton2.Name = "uiImageButton2";
            this.uiImageButton2.Size = new System.Drawing.Size(194, 84);
            this.uiImageButton2.TabIndex = 45;
            this.uiImageButton2.TabStop = false;
            this.uiImageButton2.Text = "设备管理";
            this.uiImageButton2.Click += new System.EventHandler(this.uiImageButton2_Click);
            // 
            // uiImageButton3
            // 
            this.uiImageButton3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton3.Location = new System.Drawing.Point(3, 330);
            this.uiImageButton3.Name = "uiImageButton3";
            this.uiImageButton3.Size = new System.Drawing.Size(194, 84);
            this.uiImageButton3.TabIndex = 46;
            this.uiImageButton3.TabStop = false;
            this.uiImageButton3.Text = "设备监控";
            this.uiImageButton3.Click += new System.EventHandler(this.uiImageButton3_Click);
            // 
            // uiImageButton4
            // 
            this.uiImageButton4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiImageButton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton4.Location = new System.Drawing.Point(3, 461);
            this.uiImageButton4.Name = "uiImageButton4";
            this.uiImageButton4.Size = new System.Drawing.Size(194, 84);
            this.uiImageButton4.TabIndex = 47;
            this.uiImageButton4.TabStop = false;
            this.uiImageButton4.Text = "调试";
            this.uiImageButton4.Click += new System.EventHandler(this.uiImageButton4_Click);
            // 
            // uiImageButton5
            // 
            this.uiImageButton5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiImageButton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton5.Location = new System.Drawing.Point(3, 589);
            this.uiImageButton5.Name = "uiImageButton5";
            this.uiImageButton5.Size = new System.Drawing.Size(194, 84);
            this.uiImageButton5.TabIndex = 48;
            this.uiImageButton5.TabStop = false;
            this.uiImageButton5.Text = "关于";
            this.uiImageButton5.Click += new System.EventHandler(this.uiImageButton5_Click);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiImageButton5);
            this.uiTitlePanel1.Controls.Add(this.uiImageButton4);
            this.uiTitlePanel1.Controls.Add(this.uiImageButton3);
            this.uiTitlePanel1.Controls.Add(this.uiImageButton2);
            this.uiTitlePanel1.Controls.Add(this.uiImageButton1);
            this.uiTitlePanel1.Controls.Add(this.treeView1);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 25);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(203, 866);
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 41;
            this.uiTitlePanel1.Text = "菜单";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            // 
            // cmsTest
            // 
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置参数ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.查看信息ToolStripMenuItem});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(125, 70);
            // 
            // 设置参数ToolStripMenuItem
            // 
            this.设置参数ToolStripMenuItem.Name = "设置参数ToolStripMenuItem";
            this.设置参数ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置参数ToolStripMenuItem.Text = "设置参数";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 查看信息ToolStripMenuItem
            // 
            this.查看信息ToolStripMenuItem.Name = "查看信息ToolStripMenuItem";
            this.查看信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看信息ToolStripMenuItem.Text = "删除";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(203, 25);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1016, 844);
            this.dockPanel1.TabIndex = 61;
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 891);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmSelect_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton5)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.cmsTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TreeView treeView1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton uiImageButton2;
        private Sunny.UI.UIImageButton uiImageButton3;
        private Sunny.UI.UIImageButton uiImageButton4;
        private Sunny.UI.UIImageButton uiImageButton5;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cmsTest;
        private System.Windows.Forms.ToolStripMenuItem 设置参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看信息ToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem 版本更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 数据库操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初始化数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清理订单信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取订单信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取订单编码ToolStripMenuItem;
    }
}