
namespace WinFormsPLC
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtIp = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new Sunny.UI.UITextBox();
            this.btnopen = new Sunny.UI.UIButton();
            this.hslLanternSimple1 = new HslControls.HslLanternSimple();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegisterAddress = new Sunny.UI.UITextBox();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.txtSend = new Sunny.UI.UITextBox();
            this.btnCycleSend = new Sunny.UI.UIButton();
            this.btnSend = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.uiCheckBoxGroup4 = new Sunny.UI.UICheckBoxGroup();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStationCom = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cmbParity = new Sunny.UI.UIComboboxEx();
            this.txtTopbit = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtdatabit = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.cmbBT = new Sunny.UI.UIComboboxEx();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbmCom = new Sunny.UI.UIComboboxEx();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.btnCycleReceive = new Sunny.UI.UIButton();
            this.btnReceive = new Sunny.UI.UIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStation = new Sunny.UI.UITextBox();
            this.uiComboboxEx1 = new Sunny.UI.UIComboboxEx();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiCheckBoxGroup3 = new Sunny.UI.UICheckBoxGroup();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.uiCheckBoxGroup2.SuspendLayout();
            this.uiCheckBoxGroup4.SuspendLayout();
            this.uiCheckBoxGroup3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIp.FillColor = System.Drawing.Color.White;
            this.txtIp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtIp.Location = new System.Drawing.Point(155, 31);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIp.Maximum = 2147483647D;
            this.txtIp.Minimum = -2147483648D;
            this.txtIp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(171, 29);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "192.168.0.0";
            this.txtIp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(418, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口：";
            // 
            // txtPort
            // 
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.FillColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPort.Location = new System.Drawing.Point(498, 31);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.Maximum = 2147483647D;
            this.txtPort.Minimum = -2147483648D;
            this.txtPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 29);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "00";
            this.txtPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnopen
            // 
            this.btnopen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnopen.Location = new System.Drawing.Point(569, 151);
            this.btnopen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 35);
            this.btnopen.TabIndex = 4;
            this.btnopen.Text = "打开连接";
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // hslLanternSimple1
            // 
            this.hslLanternSimple1.Location = new System.Drawing.Point(808, 12);
            this.hslLanternSimple1.Name = "hslLanternSimple1";
            this.hslLanternSimple1.Size = new System.Drawing.Size(39, 35);
            this.hslLanternSimple1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(729, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "状态：";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.Location = new System.Drawing.Point(733, 151);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭连接";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "寄存器地址：";
            // 
            // txtRegisterAddress
            // 
            this.txtRegisterAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterAddress.FillColor = System.Drawing.Color.White;
            this.txtRegisterAddress.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRegisterAddress.Location = new System.Drawing.Point(154, 140);
            this.txtRegisterAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegisterAddress.Maximum = 2147483647D;
            this.txtRegisterAddress.Minimum = -2147483648D;
            this.txtRegisterAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegisterAddress.Name = "txtRegisterAddress";
            this.txtRegisterAddress.Size = new System.Drawing.Size(295, 51);
            this.txtRegisterAddress.TabIndex = 9;
            this.txtRegisterAddress.Text = "D100";
            this.txtRegisterAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.txtSend);
            this.uiCheckBoxGroup1.Controls.Add(this.btnCycleSend);
            this.uiCheckBoxGroup1.Controls.Add(this.btnSend);
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(13, 197);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(851, 180);
            this.uiCheckBoxGroup1.TabIndex = 11;
            this.uiCheckBoxGroup1.Text = "发送区";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSend
            // 
            this.txtSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.FillColor = System.Drawing.Color.White;
            this.txtSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSend.Location = new System.Drawing.Point(8, 32);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSend.Maximum = 2147483647D;
            this.txtSend.Minimum = -2147483648D;
            this.txtSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(826, 98);
            this.txtSend.TabIndex = 10;
            this.txtSend.Text = "d100";
            this.txtSend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCycleSend
            // 
            this.btnCycleSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCycleSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCycleSend.Location = new System.Drawing.Point(207, 138);
            this.btnCycleSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCycleSend.Name = "btnCycleSend";
            this.btnCycleSend.Size = new System.Drawing.Size(100, 35);
            this.btnCycleSend.TabIndex = 4;
            this.btnCycleSend.Text = "循环发送";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSend.Location = new System.Drawing.Point(67, 138);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.Controls.Add(this.txtReceive);
            this.uiCheckBoxGroup2.Controls.Add(this.uiButton1);
            this.uiCheckBoxGroup2.Controls.Add(this.btnCycleReceive);
            this.uiCheckBoxGroup2.Controls.Add(this.btnReceive);
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(13, 405);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(851, 392);
            this.uiCheckBoxGroup2.TabIndex = 11;
            this.uiCheckBoxGroup2.Text = "接收区";
            this.uiCheckBoxGroup2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiCheckBoxGroup4
            // 
            this.uiCheckBoxGroup4.Controls.Add(this.label6);
            this.uiCheckBoxGroup4.Controls.Add(this.txtStationCom);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel6);
            this.uiCheckBoxGroup4.Controls.Add(this.cmbParity);
            this.uiCheckBoxGroup4.Controls.Add(this.txtTopbit);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel5);
            this.uiCheckBoxGroup4.Controls.Add(this.txtdatabit);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel4);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup4.Controls.Add(this.cmbBT);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup4.Controls.Add(this.cbmCom);
            this.uiCheckBoxGroup4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup4.Location = new System.Drawing.Point(9, 54);
            this.uiCheckBoxGroup4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup4.Name = "uiCheckBoxGroup4";
            this.uiCheckBoxGroup4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup4.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup4.SelectedIndexes")));
            this.uiCheckBoxGroup4.Size = new System.Drawing.Size(855, 75);
            this.uiCheckBoxGroup4.TabIndex = 6;
            this.uiCheckBoxGroup4.Text = "RS232配置";
            this.uiCheckBoxGroup4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(714, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "站号";
            // 
            // txtStationCom
            // 
            this.txtStationCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStationCom.DoubleValue = 238D;
            this.txtStationCom.FillColor = System.Drawing.Color.White;
            this.txtStationCom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStationCom.IntValue = 238;
            this.txtStationCom.Location = new System.Drawing.Point(769, 32);
            this.txtStationCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStationCom.Maximum = 2147483647D;
            this.txtStationCom.Minimum = -2147483648D;
            this.txtStationCom.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtStationCom.Name = "txtStationCom";
            this.txtStationCom.Size = new System.Drawing.Size(60, 29);
            this.txtStationCom.TabIndex = 14;
            this.txtStationCom.Text = "238";
            this.txtStationCom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(566, 35);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(59, 23);
            this.uiLabel6.TabIndex = 9;
            this.uiLabel6.Text = "奇偶数";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbParity
            // 
            this.cmbParity.BackColor = System.Drawing.Color.White;
            this.cmbParity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParity.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "奇数",
            "偶数",
            " 无"});
            this.cmbParity.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbParity.Location = new System.Drawing.Point(631, 32);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(68, 30);
            this.cmbParity.TabIndex = 8;
            this.cmbParity.Text = "无";
            // 
            // txtTopbit
            // 
            this.txtTopbit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTopbit.DoubleValue = 1D;
            this.txtTopbit.FillColor = System.Drawing.Color.White;
            this.txtTopbit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtTopbit.IntValue = 1;
            this.txtTopbit.Location = new System.Drawing.Point(498, 30);
            this.txtTopbit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTopbit.Maximum = 2147483647D;
            this.txtTopbit.Minimum = -2147483648D;
            this.txtTopbit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTopbit.Name = "txtTopbit";
            this.txtTopbit.Size = new System.Drawing.Size(48, 33);
            this.txtTopbit.TabIndex = 7;
            this.txtTopbit.Text = "1";
            this.txtTopbit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(436, 34);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(59, 23);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "停止位";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdatabit
            // 
            this.txtdatabit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdatabit.DoubleValue = 1D;
            this.txtdatabit.FillColor = System.Drawing.Color.White;
            this.txtdatabit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtdatabit.IntValue = 1;
            this.txtdatabit.Location = new System.Drawing.Point(372, 30);
            this.txtdatabit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatabit.Maximum = 2147483647D;
            this.txtdatabit.Minimum = -2147483648D;
            this.txtdatabit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtdatabit.Name = "txtdatabit";
            this.txtdatabit.Size = new System.Drawing.Size(48, 33);
            this.txtdatabit.TabIndex = 5;
            this.txtdatabit.Text = "1";
            this.txtdatabit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(310, 34);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(59, 23);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "数据位";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(152, 37);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(59, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "波特率";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBT
            // 
            this.cmbBT.BackColor = System.Drawing.Color.White;
            this.cmbBT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBT.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbBT.FormattingEnabled = true;
            this.cmbBT.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cmbBT.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbBT.Location = new System.Drawing.Point(217, 32);
            this.cmbBT.Name = "cmbBT";
            this.cmbBT.Size = new System.Drawing.Size(68, 30);
            this.cmbBT.TabIndex = 2;
            this.cmbBT.Text = "9600";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(4, 33);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(59, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "com口";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbmCom
            // 
            this.cbmCom.BackColor = System.Drawing.Color.White;
            this.cbmCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmCom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbmCom.FormattingEnabled = true;
            this.cbmCom.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3",
            "com4",
            "com5",
            "com6",
            "com7",
            "com8",
            "com9",
            "com10",
            "com11",
            "com12",
            "com13",
            "com14",
            "com15",
            "com16",
            "com17",
            "com18"});
            this.cbmCom.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbmCom.Location = new System.Drawing.Point(69, 32);
            this.cbmCom.Name = "cbmCom";
            this.cbmCom.Size = new System.Drawing.Size(77, 30);
            this.cbmCom.TabIndex = 0;
            this.cbmCom.Text = "com1";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(7, 33);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceive.Size = new System.Drawing.Size(827, 309);
            this.txtReceive.TabIndex = 5;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(382, 351);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "清空接收区";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // btnCycleReceive
            // 
            this.btnCycleReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCycleReceive.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCycleReceive.Location = new System.Drawing.Point(222, 351);
            this.btnCycleReceive.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCycleReceive.Name = "btnCycleReceive";
            this.btnCycleReceive.Size = new System.Drawing.Size(100, 35);
            this.btnCycleReceive.TabIndex = 4;
            this.btnCycleReceive.Text = "循环接收";
            // 
            // btnReceive
            // 
            this.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceive.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReceive.Location = new System.Drawing.Point(45, 351);
            this.btnReceive.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(100, 35);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "接收";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(657, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "站号";
            // 
            // txtStation
            // 
            this.txtStation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStation.DoubleValue = 238D;
            this.txtStation.FillColor = System.Drawing.Color.White;
            this.txtStation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStation.IntValue = 238;
            this.txtStation.Location = new System.Drawing.Point(716, 31);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStation.Maximum = 2147483647D;
            this.txtStation.Minimum = -2147483648D;
            this.txtStation.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(74, 29);
            this.txtStation.TabIndex = 12;
            this.txtStation.Text = "238";
            this.txtStation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboboxEx1
            // 
            this.uiComboboxEx1.BackColor = System.Drawing.Color.White;
            this.uiComboboxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uiComboboxEx1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboboxEx1.FormattingEnabled = true;
            this.uiComboboxEx1.Items.AddRange(new object[] {
            "TCP/IP",
            "RS232"});
            this.uiComboboxEx1.Location = new System.Drawing.Point(128, 17);
            this.uiComboboxEx1.Name = "uiComboboxEx1";
            this.uiComboboxEx1.Size = new System.Drawing.Size(150, 30);
            this.uiComboboxEx1.TabIndex = 14;
            this.uiComboboxEx1.Text = "TCP/IP";
            this.uiComboboxEx1.SelectedIndexChanged += new System.EventHandler(this.uiComboboxEx1_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(28, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "连接方式";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBoxGroup3
            // 
            this.uiCheckBoxGroup3.Controls.Add(this.txtIp);
            this.uiCheckBoxGroup3.Controls.Add(this.label1);
            this.uiCheckBoxGroup3.Controls.Add(this.txtPort);
            this.uiCheckBoxGroup3.Controls.Add(this.label5);
            this.uiCheckBoxGroup3.Controls.Add(this.label2);
            this.uiCheckBoxGroup3.Controls.Add(this.txtStation);
            this.uiCheckBoxGroup3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup3.Location = new System.Drawing.Point(13, 50);
            this.uiCheckBoxGroup3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup3.Name = "uiCheckBoxGroup3";
            this.uiCheckBoxGroup3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup3.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup3.SelectedIndexes")));
            this.uiCheckBoxGroup3.Size = new System.Drawing.Size(851, 76);
            this.uiCheckBoxGroup3.TabIndex = 17;
            this.uiCheckBoxGroup3.Text = "IP配置";
            this.uiCheckBoxGroup3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 812);
            this.Controls.Add(this.uiCheckBoxGroup4);
            this.Controls.Add(this.uiCheckBoxGroup3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiComboboxEx1);
            this.Controls.Add(this.uiCheckBoxGroup2);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Controls.Add(this.txtRegisterAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslLanternSimple1);
            this.Controls.Add(this.btnopen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.Text = "【PLC】松下【Panasonic】管理工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup2.ResumeLayout(false);
            this.uiCheckBoxGroup2.PerformLayout();
            this.uiCheckBoxGroup4.ResumeLayout(false);
            this.uiCheckBoxGroup4.PerformLayout();
            this.uiCheckBoxGroup3.ResumeLayout(false);
            this.uiCheckBoxGroup3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtPort;
        private Sunny.UI.UIButton btnopen;
        private HslControls.HslLanternSimple hslLanternSimple1;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UITextBox txtRegisterAddress;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UITextBox txtSend;
        private Sunny.UI.UIButton btnSend;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup2;
        private Sunny.UI.UIButton btnReceive;
        private Sunny.UI.UIButton btnCycleSend;
        private Sunny.UI.UIButton btnCycleReceive;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtStation;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.TextBox txtReceive;
        private Sunny.UI.UIComboboxEx uiComboboxEx1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup3;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup4;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtStationCom;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboboxEx cmbParity;
        private Sunny.UI.UITextBox txtTopbit;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtdatabit;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboboxEx cmbBT;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboboxEx cbmCom;
    }
}

