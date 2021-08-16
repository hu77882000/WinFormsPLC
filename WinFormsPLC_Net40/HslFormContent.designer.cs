
namespace WinFormsPLC_Net40
{
    partial class HslFormContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HslFormContent));
            this.cmsTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.BtnClose = new Sunny.UI.UIButton();
            this.BtnOpen = new Sunny.UI.UIButton();
            this.btnLoading = new Sunny.UI.UIButton();
            this.pnlTest = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsTest.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsTest
            // 
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置参数ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.查看信息ToolStripMenuItem});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(125, 70);
            this.cmsTest.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTest_Opening);
            // 
            // 设置参数ToolStripMenuItem
            // 
            this.设置参数ToolStripMenuItem.Name = "设置参数ToolStripMenuItem";
            this.设置参数ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置参数ToolStripMenuItem.Text = "设置参数";
            this.设置参数ToolStripMenuItem.Click += new System.EventHandler(this.设置参数ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 查看信息ToolStripMenuItem
            // 
            this.查看信息ToolStripMenuItem.Name = "查看信息ToolStripMenuItem";
            this.查看信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看信息ToolStripMenuItem.Text = "删除";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(819, 509);
            this.dockPanel1.TabIndex = 1;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.BtnClose);
            this.uiCheckBoxGroup1.Controls.Add(this.BtnOpen);
            this.uiCheckBoxGroup1.Controls.Add(this.btnLoading);
            this.uiCheckBoxGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(0, 0);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(819, 38);
            this.uiCheckBoxGroup1.TabIndex = 69;
            this.uiCheckBoxGroup1.Text = "功能区";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BtnClose.Location = new System.Drawing.Point(340, 23);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "启用设备";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BtnOpen.Location = new System.Drawing.Point(203, 23);
            this.BtnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(100, 35);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "启用设备";
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnLoading
            // 
            this.btnLoading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoading.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLoading.Location = new System.Drawing.Point(65, 23);
            this.btnLoading.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(100, 35);
            this.btnLoading.TabIndex = 0;
            this.btnLoading.Text = "加载设备";
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // pnlTest
            // 
            this.pnlTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTest.Location = new System.Drawing.Point(0, 38);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(819, 471);
            this.pnlTest.TabIndex = 70;
            // 
            // HslFormContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(819, 509);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "HslFormContent";
            this.Text = "设备管理";
            this.Load += new System.EventHandler(this.HslFormContent_Load);
            this.cmsTest.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsTest;
        private System.Windows.Forms.ToolStripMenuItem 设置参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看信息ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private System.Windows.Forms.FlowLayoutPanel pnlTest;
        private Sunny.UI.UIButton btnLoading;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnOpen;
    }
}