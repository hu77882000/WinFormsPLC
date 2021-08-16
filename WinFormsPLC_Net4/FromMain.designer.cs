
namespace WinFormsPLC_Net4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtIp = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new Sunny.UI.UITextBox();
            this.btnopen = new Sunny.UI.UIButton();
            this.hslLanternSimple1 = new HslControls.HslLanternSimple();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup4 = new Sunny.UI.UICheckBoxGroup();
            this.cbStop = new Sunny.UI.UIComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStationCom = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cmbParity = new Sunny.UI.UIComboboxEx();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtdatabit = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.cbBaudRate = new Sunny.UI.UIComboboxEx();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbmCom = new Sunny.UI.UIComboboxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStation = new Sunny.UI.UITextBox();
            this.uiComboboxEx1 = new Sunny.UI.UIComboboxEx();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiCheckBoxGroup3 = new Sunny.UI.UICheckBoxGroup();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup5 = new Sunny.UI.UICheckBoxGroup();
            this.txtIp1 = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPort2 = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStation2 = new Sunny.UI.UITextBox();
            this.timeSend = new System.Windows.Forms.Timer(this.components);
            this.uiCheckBoxGroup16 = new Sunny.UI.UICheckBoxGroup();
            this.cbStop2 = new Sunny.UI.UIComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStationCom2 = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.cmbParity2 = new Sunny.UI.UIComboboxEx();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtdatabit2 = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.cbBaudRate2 = new Sunny.UI.UIComboboxEx();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.cbmCom2 = new Sunny.UI.UIComboboxEx();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.uiCheckBoxGroup6 = new Sunny.UI.UICheckBoxGroup();
            this.txtRegisterAddress4 = new Sunny.UI.UITextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegisterAddress3 = new Sunny.UI.UITextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegisterAddress2 = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegisterAddress = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiCheckBoxGroup2 = new Sunny.UI.UICheckBoxGroup();
            this.uiCheckBox4 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.btnCycleReceive = new Sunny.UI.UIButton();
            this.btnReceive = new Sunny.UI.UIButton();
            this.btnComplete = new Sunny.UI.UIButton();
            this.btnTrigger = new Sunny.UI.UIButton();
            this.btnStateWriting = new Sunny.UI.UIButton();
            this.btnEnable = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup7 = new Sunny.UI.UICheckBoxGroup();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtSecond = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.txtSend = new Sunny.UI.UITextBox();
            this.btnCycleSend = new Sunny.UI.UIButton();
            this.btnSend = new Sunny.UI.UIButton();
            this.uiCheckBoxGroup4.SuspendLayout();
            this.uiCheckBoxGroup3.SuspendLayout();
            this.uiCheckBoxGroup5.SuspendLayout();
            this.uiCheckBoxGroup16.SuspendLayout();
            this.uiCheckBoxGroup6.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.uiCheckBoxGroup2.SuspendLayout();
            this.uiCheckBoxGroup7.SuspendLayout();
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
            this.txtIp.Text = "192.168.27.5";
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
            this.txtPort.DoubleValue = 32769D;
            this.txtPort.FillColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPort.IntValue = 32769;
            this.txtPort.Location = new System.Drawing.Point(498, 31);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.Maximum = 2147483647D;
            this.txtPort.Minimum = -2147483648D;
            this.txtPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 29);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "32769";
            this.txtPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnopen
            // 
            this.btnopen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnopen.Location = new System.Drawing.Point(897, 157);
            this.btnopen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(100, 35);
            this.btnopen.TabIndex = 4;
            this.btnopen.Text = "打开连接";
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // hslLanternSimple1
            // 
            this.hslLanternSimple1.LanternBackground = System.Drawing.Color.Red;
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
            this.btnClose.Location = new System.Drawing.Point(897, 238);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭连接";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiCheckBoxGroup4
            // 
            this.uiCheckBoxGroup4.Controls.Add(this.cbStop);
            this.uiCheckBoxGroup4.Controls.Add(this.label6);
            this.uiCheckBoxGroup4.Controls.Add(this.txtStationCom);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel6);
            this.uiCheckBoxGroup4.Controls.Add(this.cmbParity);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel5);
            this.uiCheckBoxGroup4.Controls.Add(this.txtdatabit);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel4);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup4.Controls.Add(this.cbBaudRate);
            this.uiCheckBoxGroup4.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup4.Controls.Add(this.cbmCom);
            this.uiCheckBoxGroup4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup4.Location = new System.Drawing.Point(9, 131);
            this.uiCheckBoxGroup4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup4.Name = "uiCheckBoxGroup4";
            this.uiCheckBoxGroup4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup4.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup4.SelectedIndexes")));
            this.uiCheckBoxGroup4.Size = new System.Drawing.Size(881, 75);
            this.uiCheckBoxGroup4.TabIndex = 6;
            this.uiCheckBoxGroup4.Text = "扫码枪配置①";
            this.uiCheckBoxGroup4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStop
            // 
            this.cbStop.DataSource = null;
            this.cbStop.FillColor = System.Drawing.Color.White;
            this.cbStop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbStop.Items.AddRange(new object[] {
            "1,",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(497, 30);
            this.cbStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStop.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStop.Name = "cbStop";
            this.cbStop.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStop.Size = new System.Drawing.Size(63, 29);
            this.cbStop.TabIndex = 16;
            this.cbStop.Text = "1";
            this.cbStop.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            "无",
            "奇数",
            "偶数"});
            this.cmbParity.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbParity.Location = new System.Drawing.Point(631, 32);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(68, 30);
            this.cmbParity.TabIndex = 8;
            this.cmbParity.Text = "无";
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
            this.txtdatabit.DoubleValue = 8D;
            this.txtdatabit.FillColor = System.Drawing.Color.White;
            this.txtdatabit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtdatabit.IntValue = 8;
            this.txtdatabit.Location = new System.Drawing.Point(372, 30);
            this.txtdatabit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatabit.Maximum = 2147483647D;
            this.txtdatabit.Minimum = -2147483648D;
            this.txtdatabit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtdatabit.Name = "txtdatabit";
            this.txtdatabit.Size = new System.Drawing.Size(48, 33);
            this.txtdatabit.TabIndex = 5;
            this.txtdatabit.Text = "8";
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
            // cbBaudRate
            // 
            this.cbBaudRate.BackColor = System.Drawing.Color.White;
            this.cbBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBaudRate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbBaudRate.Location = new System.Drawing.Point(217, 32);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(87, 30);
            this.cbBaudRate.TabIndex = 2;
            this.cbBaudRate.Text = "115200";
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
            this.cbmCom.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbmCom.Location = new System.Drawing.Point(69, 32);
            this.cbmCom.Name = "cbmCom";
            this.cbmCom.Size = new System.Drawing.Size(77, 30);
            this.cbmCom.TabIndex = 0;
            this.cbmCom.Text = "com1";
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
            this.uiCheckBoxGroup3.Size = new System.Drawing.Size(877, 76);
            this.uiCheckBoxGroup3.TabIndex = 17;
            this.uiCheckBoxGroup3.Text = "PLC配置";
            this.uiCheckBoxGroup3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(897, 86);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 23;
            this.uiButton2.Text = "关闭";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiCheckBoxGroup5
            // 
            this.uiCheckBoxGroup5.Controls.Add(this.txtIp1);
            this.uiCheckBoxGroup5.Controls.Add(this.label7);
            this.uiCheckBoxGroup5.Controls.Add(this.txtPort2);
            this.uiCheckBoxGroup5.Controls.Add(this.label8);
            this.uiCheckBoxGroup5.Controls.Add(this.label9);
            this.uiCheckBoxGroup5.Controls.Add(this.txtStation2);
            this.uiCheckBoxGroup5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup5.Location = new System.Drawing.Point(9, 293);
            this.uiCheckBoxGroup5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup5.Name = "uiCheckBoxGroup5";
            this.uiCheckBoxGroup5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup5.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup5.SelectedIndexes")));
            this.uiCheckBoxGroup5.Size = new System.Drawing.Size(998, 76);
            this.uiCheckBoxGroup5.TabIndex = 18;
            this.uiCheckBoxGroup5.Text = "印码机配置";
            this.uiCheckBoxGroup5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIp1
            // 
            this.txtIp1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIp1.FillColor = System.Drawing.Color.White;
            this.txtIp1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtIp1.Location = new System.Drawing.Point(155, 31);
            this.txtIp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIp1.Maximum = 2147483647D;
            this.txtIp1.Minimum = -2147483648D;
            this.txtIp1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(171, 29);
            this.txtIp1.TabIndex = 0;
            this.txtIp1.Text = "192.168.27.19";
            this.txtIp1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(53, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "IP地址：";
            // 
            // txtPort2
            // 
            this.txtPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort2.DoubleValue = 9094D;
            this.txtPort2.FillColor = System.Drawing.Color.White;
            this.txtPort2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPort2.IntValue = 9094;
            this.txtPort2.Location = new System.Drawing.Point(498, 31);
            this.txtPort2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort2.Maximum = 2147483647D;
            this.txtPort2.Minimum = -2147483648D;
            this.txtPort2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(87, 29);
            this.txtPort2.TabIndex = 2;
            this.txtPort2.Text = "9094";
            this.txtPort2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(657, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "站号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(418, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "端口：";
            // 
            // txtStation2
            // 
            this.txtStation2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStation2.DoubleValue = 238D;
            this.txtStation2.FillColor = System.Drawing.Color.White;
            this.txtStation2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStation2.IntValue = 238;
            this.txtStation2.Location = new System.Drawing.Point(716, 31);
            this.txtStation2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStation2.Maximum = 2147483647D;
            this.txtStation2.Minimum = -2147483648D;
            this.txtStation2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtStation2.Name = "txtStation2";
            this.txtStation2.Size = new System.Drawing.Size(74, 29);
            this.txtStation2.TabIndex = 12;
            this.txtStation2.Text = "238";
            this.txtStation2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeSend
            // 
            this.timeSend.Tick += new System.EventHandler(this.timeSend_Tick);
            // 
            // uiCheckBoxGroup16
            // 
            this.uiCheckBoxGroup16.Controls.Add(this.cbStop2);
            this.uiCheckBoxGroup16.Controls.Add(this.label13);
            this.uiCheckBoxGroup16.Controls.Add(this.txtStationCom2);
            this.uiCheckBoxGroup16.Controls.Add(this.uiLabel8);
            this.uiCheckBoxGroup16.Controls.Add(this.cmbParity2);
            this.uiCheckBoxGroup16.Controls.Add(this.uiLabel9);
            this.uiCheckBoxGroup16.Controls.Add(this.txtdatabit2);
            this.uiCheckBoxGroup16.Controls.Add(this.uiLabel10);
            this.uiCheckBoxGroup16.Controls.Add(this.uiLabel11);
            this.uiCheckBoxGroup16.Controls.Add(this.cbBaudRate2);
            this.uiCheckBoxGroup16.Controls.Add(this.uiLabel12);
            this.uiCheckBoxGroup16.Controls.Add(this.cbmCom2);
            this.uiCheckBoxGroup16.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup16.Location = new System.Drawing.Point(9, 213);
            this.uiCheckBoxGroup16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup16.Name = "uiCheckBoxGroup16";
            this.uiCheckBoxGroup16.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup16.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup16.SelectedIndexes")));
            this.uiCheckBoxGroup16.Size = new System.Drawing.Size(881, 75);
            this.uiCheckBoxGroup16.TabIndex = 17;
            this.uiCheckBoxGroup16.Text = "扫码枪配置②";
            this.uiCheckBoxGroup16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStop2
            // 
            this.cbStop2.DataSource = null;
            this.cbStop2.FillColor = System.Drawing.Color.White;
            this.cbStop2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbStop2.Items.AddRange(new object[] {
            "1,",
            "1.5",
            "2"});
            this.cbStop2.Location = new System.Drawing.Point(497, 30);
            this.cbStop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStop2.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStop2.Name = "cbStop2";
            this.cbStop2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStop2.Size = new System.Drawing.Size(63, 29);
            this.cbStop2.TabIndex = 16;
            this.cbStop2.Text = "1";
            this.cbStop2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(714, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "站号";
            // 
            // txtStationCom2
            // 
            this.txtStationCom2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStationCom2.DoubleValue = 238D;
            this.txtStationCom2.FillColor = System.Drawing.Color.White;
            this.txtStationCom2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStationCom2.IntValue = 238;
            this.txtStationCom2.Location = new System.Drawing.Point(769, 32);
            this.txtStationCom2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStationCom2.Maximum = 2147483647D;
            this.txtStationCom2.Minimum = -2147483648D;
            this.txtStationCom2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtStationCom2.Name = "txtStationCom2";
            this.txtStationCom2.Size = new System.Drawing.Size(60, 29);
            this.txtStationCom2.TabIndex = 14;
            this.txtStationCom2.Text = "238";
            this.txtStationCom2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(566, 35);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(59, 23);
            this.uiLabel8.TabIndex = 9;
            this.uiLabel8.Text = "奇偶数";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbParity2
            // 
            this.cmbParity2.BackColor = System.Drawing.Color.White;
            this.cmbParity2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParity2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbParity2.FormattingEnabled = true;
            this.cmbParity2.Items.AddRange(new object[] {
            "无",
            "奇数",
            "偶数"});
            this.cmbParity2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbParity2.Location = new System.Drawing.Point(631, 32);
            this.cmbParity2.Name = "cmbParity2";
            this.cmbParity2.Size = new System.Drawing.Size(68, 30);
            this.cmbParity2.TabIndex = 8;
            this.cmbParity2.Text = "无";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(436, 34);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(59, 23);
            this.uiLabel9.TabIndex = 6;
            this.uiLabel9.Text = "停止位";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdatabit2
            // 
            this.txtdatabit2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdatabit2.DoubleValue = 8D;
            this.txtdatabit2.FillColor = System.Drawing.Color.White;
            this.txtdatabit2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtdatabit2.IntValue = 8;
            this.txtdatabit2.Location = new System.Drawing.Point(372, 30);
            this.txtdatabit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatabit2.Maximum = 2147483647D;
            this.txtdatabit2.Minimum = -2147483648D;
            this.txtdatabit2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtdatabit2.Name = "txtdatabit2";
            this.txtdatabit2.Size = new System.Drawing.Size(48, 33);
            this.txtdatabit2.TabIndex = 5;
            this.txtdatabit2.Text = "8";
            this.txtdatabit2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(310, 34);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(59, 23);
            this.uiLabel10.TabIndex = 4;
            this.uiLabel10.Text = "数据位";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(152, 37);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(59, 23);
            this.uiLabel11.TabIndex = 3;
            this.uiLabel11.Text = "波特率";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBaudRate2
            // 
            this.cbBaudRate2.BackColor = System.Drawing.Color.White;
            this.cbBaudRate2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBaudRate2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbBaudRate2.FormattingEnabled = true;
            this.cbBaudRate2.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbBaudRate2.Location = new System.Drawing.Point(217, 32);
            this.cbBaudRate2.Name = "cbBaudRate2";
            this.cbBaudRate2.Size = new System.Drawing.Size(87, 30);
            this.cbBaudRate2.TabIndex = 2;
            this.cbBaudRate2.Text = "115200";
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(4, 33);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(59, 23);
            this.uiLabel12.TabIndex = 1;
            this.uiLabel12.Text = "com口";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbmCom2
            // 
            this.cbmCom2.BackColor = System.Drawing.Color.White;
            this.cbmCom2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmCom2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbmCom2.FormattingEnabled = true;
            this.cbmCom2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbmCom2.Location = new System.Drawing.Point(69, 32);
            this.cbmCom2.Name = "cbmCom2";
            this.cbmCom2.Size = new System.Drawing.Size(77, 30);
            this.cbmCom2.TabIndex = 0;
            this.cbmCom2.Text = "com1";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // uiCheckBoxGroup6
            // 
            this.uiCheckBoxGroup6.Controls.Add(this.txtRegisterAddress4);
            this.uiCheckBoxGroup6.Controls.Add(this.label12);
            this.uiCheckBoxGroup6.Controls.Add(this.txtRegisterAddress3);
            this.uiCheckBoxGroup6.Controls.Add(this.label11);
            this.uiCheckBoxGroup6.Controls.Add(this.txtRegisterAddress2);
            this.uiCheckBoxGroup6.Controls.Add(this.label10);
            this.uiCheckBoxGroup6.Controls.Add(this.txtRegisterAddress);
            this.uiCheckBoxGroup6.Controls.Add(this.label4);
            this.uiCheckBoxGroup6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup6.Location = new System.Drawing.Point(9, 376);
            this.uiCheckBoxGroup6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup6.Name = "uiCheckBoxGroup6";
            this.uiCheckBoxGroup6.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup6.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup6.SelectedIndexes")));
            this.uiCheckBoxGroup6.Size = new System.Drawing.Size(998, 89);
            this.uiCheckBoxGroup6.TabIndex = 19;
            this.uiCheckBoxGroup6.Text = "寄存器地址配置";
            this.uiCheckBoxGroup6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegisterAddress4
            // 
            this.txtRegisterAddress4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterAddress4.FillColor = System.Drawing.Color.White;
            this.txtRegisterAddress4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRegisterAddress4.Location = new System.Drawing.Point(889, 27);
            this.txtRegisterAddress4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegisterAddress4.Maximum = 2147483647D;
            this.txtRegisterAddress4.Minimum = -2147483648D;
            this.txtRegisterAddress4.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegisterAddress4.Name = "txtRegisterAddress4";
            this.txtRegisterAddress4.Size = new System.Drawing.Size(84, 51);
            this.txtRegisterAddress4.TabIndex = 37;
            this.txtRegisterAddress4.Text = "D32316";
            this.txtRegisterAddress4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(742, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "寄存器地址④：";
            // 
            // txtRegisterAddress3
            // 
            this.txtRegisterAddress3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterAddress3.FillColor = System.Drawing.Color.White;
            this.txtRegisterAddress3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRegisterAddress3.Location = new System.Drawing.Point(635, 29);
            this.txtRegisterAddress3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegisterAddress3.Maximum = 2147483647D;
            this.txtRegisterAddress3.Minimum = -2147483648D;
            this.txtRegisterAddress3.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegisterAddress3.Name = "txtRegisterAddress3";
            this.txtRegisterAddress3.Size = new System.Drawing.Size(84, 51);
            this.txtRegisterAddress3.TabIndex = 35;
            this.txtRegisterAddress3.Text = "D32312";
            this.txtRegisterAddress3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(490, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "寄存器地址③：";
            // 
            // txtRegisterAddress2
            // 
            this.txtRegisterAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterAddress2.FillColor = System.Drawing.Color.White;
            this.txtRegisterAddress2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRegisterAddress2.Location = new System.Drawing.Point(391, 29);
            this.txtRegisterAddress2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegisterAddress2.Maximum = 2147483647D;
            this.txtRegisterAddress2.Minimum = -2147483648D;
            this.txtRegisterAddress2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegisterAddress2.Name = "txtRegisterAddress2";
            this.txtRegisterAddress2.Size = new System.Drawing.Size(84, 51);
            this.txtRegisterAddress2.TabIndex = 33;
            this.txtRegisterAddress2.Text = "D32314";
            this.txtRegisterAddress2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(247, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "寄存器地址②：";
            // 
            // txtRegisterAddress
            // 
            this.txtRegisterAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterAddress.FillColor = System.Drawing.Color.White;
            this.txtRegisterAddress.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRegisterAddress.Location = new System.Drawing.Point(156, 29);
            this.txtRegisterAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegisterAddress.Maximum = 2147483647D;
            this.txtRegisterAddress.Minimum = -2147483648D;
            this.txtRegisterAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRegisterAddress.Name = "txtRegisterAddress";
            this.txtRegisterAddress.Size = new System.Drawing.Size(84, 51);
            this.txtRegisterAddress.TabIndex = 31;
            this.txtRegisterAddress.Text = "D32310";
            this.txtRegisterAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "寄存器地址①：";
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.uiCheckBoxGroup2);
            this.uiCheckBoxGroup1.Controls.Add(this.btnComplete);
            this.uiCheckBoxGroup1.Controls.Add(this.btnTrigger);
            this.uiCheckBoxGroup1.Controls.Add(this.btnStateWriting);
            this.uiCheckBoxGroup1.Controls.Add(this.btnEnable);
            this.uiCheckBoxGroup1.Controls.Add(this.uiCheckBoxGroup7);
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(9, 471);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(998, 355);
            this.uiCheckBoxGroup1.TabIndex = 24;
            this.uiCheckBoxGroup1.Text = "功能区";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiCheckBoxGroup2
            // 
            this.uiCheckBoxGroup2.Controls.Add(this.uiCheckBox4);
            this.uiCheckBoxGroup2.Controls.Add(this.uiCheckBox3);
            this.uiCheckBoxGroup2.Controls.Add(this.txtReceive);
            this.uiCheckBoxGroup2.Controls.Add(this.uiButton1);
            this.uiCheckBoxGroup2.Controls.Add(this.btnCycleReceive);
            this.uiCheckBoxGroup2.Controls.Add(this.btnReceive);
            this.uiCheckBoxGroup2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup2.Location = new System.Drawing.Point(435, 27);
            this.uiCheckBoxGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup2.Name = "uiCheckBoxGroup2";
            this.uiCheckBoxGroup2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup2.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup2.SelectedIndexes")));
            this.uiCheckBoxGroup2.Size = new System.Drawing.Size(438, 315);
            this.uiCheckBoxGroup2.TabIndex = 23;
            this.uiCheckBoxGroup2.Text = "接收区";
            this.uiCheckBoxGroup2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiCheckBox4
            // 
            this.uiCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox4.Location = new System.Drawing.Point(648, 212);
            this.uiCheckBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox4.Name = "uiCheckBox4";
            this.uiCheckBox4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox4.Size = new System.Drawing.Size(135, 29);
            this.uiCheckBox4.TabIndex = 20;
            this.uiCheckBox4.Text = "是否显示时间";
            this.uiCheckBox4.UseDoubleClick = true;
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox3.Location = new System.Drawing.Point(563, 212);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox3.Size = new System.Drawing.Size(159, 29);
            this.uiCheckBox3.TabIndex = 19;
            this.uiCheckBox3.Text = "是否显示发送数据";
            this.uiCheckBox3.UseDoubleClick = true;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(15, 28);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceive.Size = new System.Drawing.Size(411, 222);
            this.txtReceive.TabIndex = 5;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(275, 263);
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
            this.btnCycleReceive.Location = new System.Drawing.Point(152, 263);
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
            this.btnReceive.Location = new System.Drawing.Point(32, 263);
            this.btnReceive.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(100, 35);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "接收";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnComplete.Location = new System.Drawing.Point(891, 277);
            this.btnComplete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(100, 35);
            this.btnComplete.TabIndex = 28;
            this.btnComplete.Text = "设备动作完成";
            this.btnComplete.Click += new System.EventHandler(this.Test_click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrigger.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTrigger.Location = new System.Drawing.Point(891, 196);
            this.btnTrigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(100, 35);
            this.btnTrigger.TabIndex = 27;
            this.btnTrigger.Text = "设备触发";
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnStateWriting
            // 
            this.btnStateWriting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStateWriting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnStateWriting.Location = new System.Drawing.Point(891, 122);
            this.btnStateWriting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStateWriting.Name = "btnStateWriting";
            this.btnStateWriting.Size = new System.Drawing.Size(100, 35);
            this.btnStateWriting.TabIndex = 26;
            this.btnStateWriting.Text = "设备状态写入";
            this.btnStateWriting.Click += new System.EventHandler(this.btnStateWriting_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnable.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnEnable.Location = new System.Drawing.Point(891, 42);
            this.btnEnable.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(100, 35);
            this.btnEnable.TabIndex = 25;
            this.btnEnable.Text = "设备启用";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_ClickAsync);
            // 
            // uiCheckBoxGroup7
            // 
            this.uiCheckBoxGroup7.Controls.Add(this.uiLabel7);
            this.uiCheckBoxGroup7.Controls.Add(this.txtSecond);
            this.uiCheckBoxGroup7.Controls.Add(this.uiTextBox2);
            this.uiCheckBoxGroup7.Controls.Add(this.uiCheckBox2);
            this.uiCheckBoxGroup7.Controls.Add(this.uiTextBox1);
            this.uiCheckBoxGroup7.Controls.Add(this.uiCheckBox1);
            this.uiCheckBoxGroup7.Controls.Add(this.txtSend);
            this.uiCheckBoxGroup7.Controls.Add(this.btnCycleSend);
            this.uiCheckBoxGroup7.Controls.Add(this.btnSend);
            this.uiCheckBoxGroup7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBoxGroup7.Location = new System.Drawing.Point(7, 27);
            this.uiCheckBoxGroup7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup7.Name = "uiCheckBoxGroup7";
            this.uiCheckBoxGroup7.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup7.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup7.SelectedIndexes")));
            this.uiCheckBoxGroup7.Size = new System.Drawing.Size(420, 315);
            this.uiCheckBoxGroup7.TabIndex = 24;
            this.uiCheckBoxGroup7.Text = "发送区";
            this.uiCheckBoxGroup7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(117, 233);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(46, 23);
            this.uiLabel7.TabIndex = 20;
            this.uiLabel7.Text = "毫秒";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSecond
            // 
            this.txtSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecond.FillColor = System.Drawing.Color.White;
            this.txtSecond.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSecond.Location = new System.Drawing.Point(11, 230);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecond.Maximum = 2147483647D;
            this.txtSecond.Minimum = -2147483648D;
            this.txtSecond.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(88, 29);
            this.txtSecond.TabIndex = 19;
            this.txtSecond.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.DoubleValue = 1D;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox2.IntValue = 1;
            this.uiTextBox2.Location = new System.Drawing.Point(110, 192);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Size = new System.Drawing.Size(33, 29);
            this.uiTextBox2.TabIndex = 3;
            this.uiTextBox2.Text = "01";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox2.Location = new System.Drawing.Point(150, 192);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(186, 29);
            this.uiCheckBox2.TabIndex = 18;
            this.uiCheckBox2.Text = "是否自动计算校验码";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(69, 192);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(33, 29);
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.Text = "A0";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox1.Location = new System.Drawing.Point(206, 233);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(186, 29);
            this.uiCheckBox1.TabIndex = 11;
            this.uiCheckBox1.Text = "是否显示二进制通信";
            this.uiCheckBox1.UseDoubleClick = true;
            // 
            // txtSend
            // 
            this.txtSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.DoubleValue = 2D;
            this.txtSend.FillColor = System.Drawing.Color.White;
            this.txtSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSend.IntValue = 2;
            this.txtSend.Location = new System.Drawing.Point(8, 32);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSend.Maximum = 2147483647D;
            this.txtSend.Minimum = -2147483648D;
            this.txtSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(399, 152);
            this.txtSend.TabIndex = 10;
            this.txtSend.Text = "2";
            this.txtSend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCycleSend
            // 
            this.btnCycleSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCycleSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCycleSend.Location = new System.Drawing.Point(178, 267);
            this.btnCycleSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCycleSend.Name = "btnCycleSend";
            this.btnCycleSend.Size = new System.Drawing.Size(214, 35);
            this.btnCycleSend.TabIndex = 4;
            this.btnCycleSend.Text = "循环发送";
            this.btnCycleSend.Click += new System.EventHandler(this.btnCycleSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSend.Location = new System.Drawing.Point(11, 267);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(152, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 834);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Controls.Add(this.uiCheckBoxGroup6);
            this.Controls.Add(this.uiCheckBoxGroup16);
            this.Controls.Add(this.uiCheckBoxGroup5);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiCheckBoxGroup4);
            this.Controls.Add(this.uiCheckBoxGroup3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiComboboxEx1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslLanternSimple1);
            this.Controls.Add(this.btnopen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.Text = "【PLC】松下【Panasonic】管理工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.uiCheckBoxGroup4.ResumeLayout(false);
            this.uiCheckBoxGroup4.PerformLayout();
            this.uiCheckBoxGroup3.ResumeLayout(false);
            this.uiCheckBoxGroup3.PerformLayout();
            this.uiCheckBoxGroup5.ResumeLayout(false);
            this.uiCheckBoxGroup5.PerformLayout();
            this.uiCheckBoxGroup16.ResumeLayout(false);
            this.uiCheckBoxGroup16.PerformLayout();
            this.uiCheckBoxGroup6.ResumeLayout(false);
            this.uiCheckBoxGroup6.PerformLayout();
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup2.ResumeLayout(false);
            this.uiCheckBoxGroup2.PerformLayout();
            this.uiCheckBoxGroup7.ResumeLayout(false);
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
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtStation;
        private Sunny.UI.UIComboboxEx uiComboboxEx1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup3;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup4;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtStationCom;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboboxEx cmbParity;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtdatabit;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboboxEx cbBaudRate;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboboxEx cbmCom;
        private System.IO.Ports.SerialPort serialPort;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup5;
        private Sunny.UI.UITextBox txtIp1;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtPort2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UITextBox txtStation2;
        private System.Windows.Forms.Timer timeSend;
        private Sunny.UI.UIComboBox cbStop;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup16;
        private Sunny.UI.UIComboBox cbStop2;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UITextBox txtStationCom2;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboboxEx cmbParity2;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtdatabit2;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIComboboxEx cbBaudRate2;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIComboboxEx cbmCom2;
        private System.IO.Ports.SerialPort serialPort1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup6;
        private Sunny.UI.UITextBox txtRegisterAddress4;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox txtRegisterAddress3;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UITextBox txtRegisterAddress2;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox txtRegisterAddress;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup2;
        private Sunny.UI.UICheckBox uiCheckBox4;
        private Sunny.UI.UICheckBox uiCheckBox3;
        private System.Windows.Forms.TextBox txtReceive;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btnCycleReceive;
        private Sunny.UI.UIButton btnReceive;
        private Sunny.UI.UIButton btnComplete;
        private Sunny.UI.UIButton btnTrigger;
        private Sunny.UI.UIButton btnStateWriting;
        private Sunny.UI.UIButton btnEnable;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup7;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtSecond;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UITextBox txtSend;
        private Sunny.UI.UIButton btnCycleSend;
        private Sunny.UI.UIButton btnSend;
    }
}

