using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Panasonic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using log4net;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace WinFormsPLC_Net4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region  声明变量
        private PanasonicMewtocolOverTcp panasonicMewtocol = null;
        public IReadWriteNet readWriteNet;    //api接口读写
        public MethodInfo readByteMethod = null;
        public MethodInfo writeByteMethod = null;

        private Socket socketCore = null;
        private bool connectSuccess = false;
        private byte[] buffer = new byte[2048];
        private bool isbool = true;
        Thread thread = null;
        #endregion

        #region 窗体加载事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //添加串口项目  
                foreach (string s in SerialPort.GetPortNames())
                {
                    //获取有多少个COM口  
                    cbmCom.Items.Add(s);
                    cbmCom2.Items.Add(s);
                }
                //串口设置默认选择项  
                //设置cbSerial的默认选项  
                cbmCom.SelectedIndex = 0;
                serialPort.BaudRate = 9600;

                cbmCom2.SelectedIndex = 1;
                serialPort1.BaudRate = 9600;

                //这个类中不检查跨线程的调用是否合法
                /*.NET2.0以后加强了安全机制，不允许在WinForm中直接跨线程访问控件的属性*/
                Control.CheckForIllegalCrossThreadCalls = false;

                serialPort.DataReceived += new SerialDataReceivedEventHandler(SP_ReadData_DataReceived);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SP_ReadData_DataReceived1);

                //发送和接收格式默认是字符串
                #region 初始化配置
                SettingControls(1);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化配置信息加载失败，TCP/串口加载失败");
                Console.WriteLine("错误信息输出 ：" + ex.Message);
                LogHelper.Error("错误信息输出 ：" + ex.Message);
                SettingControls(-1);
            }

        }
        #endregion

        #region 打开TCP 连接 按钮事件
        /// <summary>
        /// 打开第一个TCP连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnopen_Click(object sender, EventArgs e)
        {

            #region 打开第一个TCP  和第二个TCP
            /*            LogHelper.Info("打开TCP连接");
                        if (!int.TryParse(txtPort.Text, out int port)) //强制转换为32位 有符号的
                        {
                            MessageBox.Show(ClassUtils.PortInputWrong);
                            return;
                        }
                        if (!byte.TryParse(txtStation.Text, out byte station)) //强制转换为32位 有符号的
                        {
                            MessageBox.Show(ClassUtils.StationInputWrong);
                            return;
                        }
                        panasonicMewtocol?.ConnectClose(); //检测是否已打开连接，否则关闭
                        panasonicMewtocol = new PanasonicMewtocolOverTcp(station);    // 实例化一个松下的遍历
                        panasonicMewtocol.IpAddress = txtIp.Text; //IP赋值
                        panasonicMewtocol.Port = port; //端口赋值
                        try
                        {
                            OperateResult connect = panasonicMewtocol.ConnectServer(); //打开服务连接
                            SetReadWriteNet(panasonicMewtocol, txtRegisterAddress.Text);//端口监听

                            #region  打开第二个TCP连接
                            // SocketOpen();
                            #endregion

                            if (connect.IsSuccess) //判断是 显示控件 可编辑
                            {
                                LogHelper.Info("已打开TCP连接");
                                #region   打开串口
                                LogHelper.Info("打开第一个RS232连接");
                                btnSwitch();
                                LogHelper.Info("打开第二个RS232连接");
                               // btnSwitchtwo();
                                #endregion
                            }
                            else
                            {
                                MessageBox.Show(ClassUtils.NetworkFault);//提示错误信息
                                LogHelper.Error(ClassUtils.NetworkFault);//提示错误信息
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("TCP连接异常，检查后重新连接");
                            LogHelper.Error(ex.Message);//提示错误信息
                            Console.WriteLine(ex.Message);
                        }*/
            #endregion

            LogHelper.Info("打开第一个RS232连接");
            btnSwitch();
            LogHelper.Info("打开第二个RS232连接");
            btnSwitchtwo();


            #region   注释段
            /*                panasonicMewtocol1?.Close();
                            panasonicMewtocol1 = new PanasonicMewtocol(station);
                            try
                            {
                                panasonicMewtocol1.SerialPortInni(sp =>
                                {
                                    sp.PortName = cbmCom.Text;
                                    sp.BaudRate = baudRate;
                                    sp.DataBits = dataBits;
                                    sp.StopBits = stopBits == 0 ? StopBits.None : (stopBits == 1 ? StopBits.One : StopBits.Two);
                                    sp.Parity = cmbParity.SelectedIndex == 0 ? Parity.None : (cmbParity.SelectedIndex == 1 ? Parity.Odd : Parity.Even);
                                });
                                panasonicMewtocol1.Open();
                                if (panasonicMewtocol1.IsOpen())
                                {
                                    #region 控件显示 隐藏
                                    txtIp.Enabled = false;
                                    txtPort.Enabled = false;
                                    txtStation.Enabled = false;
                                    txtRegisterAddress.Enabled = false;
                                    btnopen.Enabled = false;
                                    this.hslLanternSimple1.LanternBackground = Color.LimeGreen;
                                    this.btnClose.Enabled = true;
                                    uiCheckBoxGroup1.Enabled = true;
                                    uiCheckBoxGroup2.Enabled = true;
                                    txtSend.Enabled = true;
                                    btnCycleSend.Enabled = true;
                                    btnCycleReceive.Enabled = true;
                                    txtReceive.Enabled = true;
                                    btnReceive.Enabled = true;
                                    #endregion
                                    //发送区
                                    //接收区
                                }
                                else
                                {
                                    MessageBox.Show(SerialPort.GetPortNames() + "连接失败");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }*/

            //// 实例化对象，指定PLC的ip地址和端口号
            //MelsecMcNet melsecMc = new MelsecMcNet(this.txtIp.Text, Convert.ToInt32 (this.txtPort.Text));

            //// 连接对象
            //OperateResult connect = melsecMc.ConnectServer();
            //if (!connect.IsSuccess)
            //{
            //    MessageBox.Show("打开失败:" + connect.Message);
            //    return;
            //}
            //// 举例读取D100的值
            //short D100 = melsecMc.ReadInt16("D100").Content;

            //// 实际上所有的读写都是返回是否成功的标记的，在实际的开发中，需要严格的判定，怎么判定呢？如下的代码
            //OperateResult<short> readD100 = melsecMc.ReadInt16("D100");
            //if (readD100.IsSuccess)
            //{
            //    // 读取成功，这时候获取Content才是正确的值
            //    short value = readD100.Content;
            //}
            //else
            //{
            //    // 读取失败，如果仍然坚持去获取Content的值，就为0
            //}
            //// 读写是否成功的情况，应用于几乎所有的读写代码，只要看清楚返回的数据类型即可

            //melsecMc.ConnectClose();
            #endregion
        }
        #endregion

        #region 串口监听
        /// <summary>
        /// 串口监听
        /// </summary>
        /// <param name="readWrite"></param>
        /// <param name="address"></param>
        /// <param name="isAsync"></param>
        /// <param name="strLength"></param>
        public void SetReadWriteNet(IReadWriteNet readWrite, string address, bool isAsync = false, int strLength = 10)
        {
            if (string.IsNullOrEmpty(txtRegisterAddress.Text))
                txtRegisterAddress.Text = address;
            if (string.IsNullOrEmpty(txtRegisterAddress.Text))
                txtRegisterAddress.Text = address;
            readWriteNet = readWrite;
            Type type = readWrite.GetType();
            readByteMethod = type.GetMethod("ReadByte", new Type[] { typeof(string) });

            try
            {
                writeByteMethod = type.GetMethod("Write", new Type[] { typeof(string), typeof(byte) });
            }
            catch
            {

            }
        }
        #endregion

        #region  串口 接收数据 并在界面上显示  (只比对数据  )  ①
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SP_ReadData_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 接收数据
            List<byte> buffer = new List<byte>();
            byte[] data = new byte[1024];
            while (true)
            {
                System.Threading.Thread.Sleep(20);
                if (serialPort.BytesToRead < 1)
                {
                    break;
                }

                int recCount = serialPort.Read(data, 0, Math.Min(serialPort.BytesToRead, data.Length));

                byte[] buffer2 = new byte[recCount];
                Array.Copy(data, 0, buffer2, 0, recCount);
                buffer.AddRange(buffer2);
            }

            if (buffer.Count == 0) return;

            Invoke(new Action(() =>
            {
                string receiveStr = Encoding.ASCII.GetString(buffer.ToArray());
                RcvMessage(serialPort1.PortName, receiveStr); //数据输出并打印

                Write(receiveStr.Trim());

                // DataComparisonAsync(receiveStr.Trim()); //数据比对
                // txtReceive.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") +"]"+ Encoding.ASCII.GetString(buffer.ToArray()) + Environment.NewLine);
                RcvMessage(serialPort.PortName, receiveStr); //数据输出并打印

            }));
        }

        #endregion

        #region  串口 接收数据 并在界面上显示  (只比对数据  )  ②
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SP_ReadData_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            // 接收数据
            List<byte> buffer = new List<byte>();
            byte[] data = new byte[1024];
            while (true)
            {
                System.Threading.Thread.Sleep(20);
                if (serialPort1.BytesToRead < 1)
                {
                    break;
                }

                int recCount = serialPort1.Read(data, 0, Math.Min(serialPort1.BytesToRead, data.Length));

                byte[] buffer2 = new byte[recCount];
                Array.Copy(data, 0, buffer2, 0, recCount);
                buffer.AddRange(buffer2);
            }

            if (buffer.Count == 0) return;

            Invoke(new Action(() =>
            {
                string receiveStr = Encoding.ASCII.GetString(buffer.ToArray());
                RcvMessage(serialPort1.PortName, receiveStr); //数据输出并打印

                //Write(receiveStr.Trim());

                DataComparisonAsync(receiveStr.Trim()); //数据比对

                // txtReceive.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") +"]"+ Encoding.ASCII.GetString(buffer.ToArray()) + Environment.NewLine);
                RcvMessage(serialPort1.PortName, receiveStr); //数据输出并打印

            }));
        }
        #endregion

        #region 关闭连接按钮
        /// <summary>
        ///  关闭连接按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // 关闭当前连接
            panasonicMewtocol.ConnectClose(); //断开TCP连接
            serialPort.Close(); //断开com连接
            serialPort1.Close(); //断开com连接
            SettingControls(-1);//
        }
        #endregion

        #region 清空按钮
        /// <summary>
        ///   清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.txtReceive.Text = "";
        }
        #endregion

        #region 发送按钮
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_ClickAsync(object sender, EventArgs e)
        {
            string strSend = txtSend.Text;
            try
            {
                //如果以16进制形式发送，将16进制数转换为byte数组进行发送
                byte[] byteBuffer = HexToByte(strSend);
                serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                SendMessage(serialPort.PortName, ByteToHex(byteBuffer));
            }
            catch (Exception ex)
            {
                MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.Error("16进制数的格式或长度不正确，请检查格式后重新发送。" + ex.Message);
            }
        }
        #endregion

        #region 获取收到按钮信息
        /// <summary>
        /// 获取收到按钮信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceive_Click(object sender, EventArgs e)
        {
            MonitoringAsync();
        }
        #endregion

        #region  监听 获取PLC返回值 并打开指定设备
        /// <summary>
        /// 监听文件区域
        /// </summary>
        private  void MonitoringAsync()
        {
            OperateResult<int> read = readWriteNet.ReadInt32(txtRegisterAddress3.Text);
            ClassUtils.ReadResultRender(read, txtRegisterAddress3.Text, txtReceive);
            string receive1 = ClassUtils.ReadResultRender(read, txtRegisterAddress3.Text).Trim();  //[16:51:44] [D32312] 0
            int start = receive1.LastIndexOf("[");
            int end = receive1.LastIndexOf("]");
            string date = receive1.Substring(start + 1, end - start - 1);
            if (date == txtRegisterAddress3.Text)
            {
                int drindex = receive1.LastIndexOf("]");
                HelpToolClass.Plc_Address = Convert.ToInt32(receive1.Substring(drindex + 1, receive1.Length - drindex - 1)); //截取出来的参数
                HelpToolClass.Plc_Address_Binary = Convert.ToString(HelpToolClass.Plc_Address, 2); //将十进制转换为二进制
                HelpToolClass.Plc_Address_Binary_Index= HelpToolClass.Plc_Address_Binary.Substring(HelpToolClass.Plc_Address_Binary.Length - 2,1); //截取 倒序第二位（下标为1的）
                // 0000 0000 0000 0010  或者 0000 0000 0000 0011
                if (Convert.ToInt32(HelpToolClass.Plc_Address_Binary_Index) == 1)
                {
                    HelpToolClass.Plc_Address_Return = Conversion_Changes(HelpToolClass.Plc_Address, 14, "0"); //设置plc的状态
                    Console.WriteLine(HelpToolClass.Plc_Address_Return);
                    OperateResult write =  readWriteNet.Write(txtRegisterAddress2.Text, HelpToolClass.Plc_Address_Return); //修改到工作中的状态
                    RS232SerialPortSend(serialPort1);//打开com2  对比数据
                }
                else
                {
                    Console.WriteLine("未取到正确数值");
                }
            }
        }
        #endregion

        #region  开启串口指令 
        /// <summary>
        ///  打开串口
        /// </summary>
        /// <param name="serialPort"></param>
        private void RS232SerialPortSend(SerialPort serialPort)
        {
            //打开扫描仪
            string strSend = PortEquipmentEnumer.SCANNER_OPEN;
            try
            {
                //如果以16进制形式发送，将16进制数转换为byte数组进行发送
                byte[] byteBuffer = HexToByte(strSend);
                serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                SendMessage(serialPort.PortName, ByteToHex(byteBuffer));
            }
            catch (Exception ex)
            {
                MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.Error("16进制数的格式或长度不正确，请检查格式后重新发送" + ex.Message);
            }
        }
        #endregion

        #region RS232发送  未使用
        /// <summary>
        /// RS232发送
        /// </summary>
        /// <param name="txtSends">端口发送的内容</param>
        private void SerialPortSend(SerialPort serialPort)
        {
            string txtSends = "16 54 0D";
            // 发送数据
            byte[] send = null;
            //是否选择勾选二进制发送
            if (uiCheckBox1.Checked)
            {
                send = HslCommunication.BasicFramework.SoftBasic.HexStringToBytes(txtSends);
                LogHelper.Info("RS232发送数据" + send);
            }
            else
            {
                send = Encoding.ASCII.GetBytes(txtSends.Replace("\\n", "\r\n"));
                LogHelper.Info("RS232发送数据" + send);
            }
            //判断是否选择计算校验码
            if (uiCheckBox2.Checked)
            {
                try
                {
                    send = HslCommunication.Serial.SoftCRC16.CRC16(send, Convert.ToByte(uiTextBox1.Text, 16), Convert.ToByte(uiTextBox2.Text, 16));
                }
                catch
                {
                    MessageBox.Show("CRC校验码输入失败！");
                    return;
                }
            }
            //判断是否需要显示已发送数据
            if (uiCheckBox3.Checked)
            {
                // 判断是否显示发送时间
                if (uiCheckBox4.Checked)
                {
                    txtReceive.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "][发]   " + HslCommunication.BasicFramework.SoftBasic.ByteToHexString(send, ' ') + Environment.NewLine);
                }
                else
                {
                    txtReceive.AppendText(HslCommunication.BasicFramework.SoftBasic.ByteToHexString(send, ' ') + Environment.NewLine);
                }
            }
            serialPort?.Write(send, 0, send.Length);

        }
        #endregion

        #region 关闭按钮
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 打开第二个TCP连接
        /// <summary>
        /// 打开第二地址
        /// </summary>
        private void SocketOpen()
        {
            // 连接服务器
            try
            {
                socketCore?.Close();
                socketCore = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                connectSuccess = false;
                new System.Threading.Thread(() =>
                {
                    System.Threading.Thread.Sleep(2000);
                    if (!connectSuccess) socketCore?.Close();
                }).Start();
                socketCore.Connect(System.Net.IPAddress.Parse(HslCommunication.Core.HslHelper.GetIpAddressFromInput(txtIp1.Text)), int.Parse(txtPort2.Text));
                connectSuccess = true;

                socketCore.BeginReceive(buffer, 0, 2048, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socketCore);

                MessageBox.Show(HslCommunication.StringResources.Language.ConnectServerSuccess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(HslCommunication.StringResources.Language.ConnectedFailed + Environment.NewLine + ex.Message);
            }
        }
        #endregion

        # region TCP 接收参数 并输出
        /// <summary>
        /// 接收参数
        /// </summary>
        /// <param name="bar"></param>
        private void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                int length = socketCore.EndReceive(ar);
                socketCore.BeginReceive(buffer, 0, 2048, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socketCore);

                if (length == 0) return;

                byte[] data = new byte[length];
                Array.Copy(buffer, 0, data, 0, length);
                Invoke(new Action(() =>
                {
                    string msg = string.Empty;
                    if (uiCheckBox1.Checked)
                    {
                        msg = HslCommunication.BasicFramework.SoftBasic.ByteToHexString(data, ' ');
                    }
                    else
                    {
                        msg = Encoding.ASCII.GetString(data);
                    }
                    if (uiCheckBox4.Checked)
                    {
                        txtReceive.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "][收]   " + msg + Environment.NewLine);
                    }
                    else
                    {
                        txtReceive.AppendText("][收]   " + msg + Environment.NewLine);
                    }
                }));
            }
            catch (ObjectDisposedException)
            {

            }
            catch
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("服务器断开连接。");
                }));
            }
        }
        #endregion

        #region  TCP发送数据
        /// <summary>
        /// TCP发送数据
        /// </summary>
        /// <param name="txtSends"></param>
        public void btnSendPort(string txtSends)
        {
            LogHelper.Info("TCP发送数据");
            // 发送数据
            byte[] send = null;
            //是否选择勾选二进制发送
            if (uiCheckBox1.Checked)
            {
                send = HslCommunication.BasicFramework.SoftBasic.HexStringToBytes(txtSends);
                LogHelper.Info("TCP发送数据" + send);
            }
            else
            {
                send = Encoding.ASCII.GetBytes(txtSends.Replace("\\n", "\r\n"));
                LogHelper.Info("TCP发送数据" + send);
            }
            //判断是否选择计算校验码
            if (uiCheckBox2.Checked)
            {
                try
                {
                    send = HslCommunication.Serial.SoftCRC16.CRC16(send, Convert.ToByte(uiTextBox1.Text, 16), Convert.ToByte(uiTextBox2.Text, 16));
                }
                catch
                {
                    MessageBox.Show("CRC校验码输入失败！");
                    return;
                }
            }
            //判断是否需要显示已发送数据
            if (uiCheckBox3.Checked)
            {
                // 判断是否显示发送时间
                if (uiCheckBox4.Checked)
                {
                    txtReceive.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "][发]   " + HslCommunication.BasicFramework.SoftBasic.ByteToHexString(send, ' ') + Environment.NewLine);
                }
                else
                {
                    txtReceive.AppendText(HslCommunication.BasicFramework.SoftBasic.ByteToHexString(send, ' ') + Environment.NewLine);
                }
            }
            try
            {
                socketCore?.Send(send, 0, send.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                HslCommunication.BasicFramework.SoftBasic.ShowExceptionMessage(ex);
            }
        }

        #endregion

        #region 文件写入 
        /// <summary>
        /// 文件读写
        /// </summary>
        /// <param name="txt">写入信息</param>
        public void Write(string txt)
        {
            string txtname = Directory.GetCurrentDirectory() + "\\" + "BarCodeThan" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "BarCodeThan.txt";
            try
            {
                //创建文件 并打开文件流
                FileStream fs = null;
                if (File.Exists(txtname))
                {
                    fs = new FileStream(txtname, FileMode.Append);
                }
                else
                {
                    fs = new FileStream(txtname, FileMode.Create);
                }
                //获得字节数组
                byte[] data = Encoding.Default.GetBytes(txt + Environment.NewLine);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("文件写入失败");
                LogHelper.Error(ex.Message);
            }
            
        }

        #endregion

        #region  循环发送
        /// <summary>
        /// 循环发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCycleSend_Click(object sender, EventArgs e)
        {
            LogHelper.Info("循环发送");
            timeSend.Enabled = true;
            string strSend = txtSend.Text;
            try
            {
                //如果以16进制形式发送，将16进制数转换为byte数组进行发送
                byte[] byteBuffer = HexToByte(strSend);
                serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                SendMessage(serialPort.PortName, ByteToHex(byteBuffer));
            }
            catch (Exception )
            {
                MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region HEX转换   
        /// <summary>
        /// HEX转换
        /// </summary>
        /// <param name="hex">从16进制转换成utf编码的字符串</param>
        /// <param name="charset">编码,如"utf-8","gb2312"</param>
        /// <returns></returns>
        public static string UnHex(string hex, string charset)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            hex = hex.Replace(",", "");
            hex = hex.Replace("\n", "");
            hex = hex.Replace("\\", "");
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
                throw new ArgumentException("十六进制不是一个有效的数字!", "hex");
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message.
                    throw new ArgumentException("Hex不是一个有效的十六进制数!", "hex");
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetString(bytes);
        }

        #endregion

        #region  设备启用   按钮事件     跟plc发送参数
        /// <summary>
        /// 设备启用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private  void btnEnable_ClickAsync(object sender, EventArgs e)
        {
            RS232SerialPortSend(serialPort);//打开com    扫码存档的扫描仪

            /*            if (int.TryParse(txtSend.Text, out int value))
                       {
                            //发送指令给PLC (设备启动)  16位二进制 最大值 65535    11111111111111
                            OperateResult write = await readWriteNet.WriteAsync(txtRegisterAddress.Text, value);
 
                              #region  雕刻机控制
                            //  SerialPortSend(PortEquipmentEnumer.SCANNER_OPEN);//开启扫描仪
                            //               Thread.Sleep(1000);
                             //               btnSendPort(PLCEnumer.LASER_MACHINE_OPEN);//激光器开始启动
                             //               Thread.Sleep(1000);
                               //             btnSendPort(PLCEnumer.SETFILE);//调整文件版本号
                                //            Thread.Sleep(1000);
                                //            btnSendPort(PLCEnumer.SHADING_VALVE_OPEN);//打开激光阀
                                //            Thread.Sleep(1000);
                                  #endregion
                            ///把状态改成 准备中
                            
                            write = await readWriteNet.WriteAsync(txtRegisterAddress2.Text, value); //修改plc地址 修改状态   值改为1

                            //轮询(计时器开启) ==>(多线程)
                            isbool = false;
                            thread = new Thread(TimeThreadStart);
                            thread.IsBackground = true;
                            thread.Start();
                        }*/

            isbool = false;
            thread = new Thread(TimeThreadStart);
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion

        #region 多线程启动  间隔1000ms
        /// <summary>
        ///  多线程启动
        /// </summary>
        private void TimeThreadStart()
        {
            while (!isbool)
            {
                LogHelper.Info("多线程循环开始");
                RunTime();
                Thread.Sleep(10);
            }
        }

        #endregion

        #region timeSend_Tick 定时器Timer
        /// <summary>
        /// 定时发送的定时器Timer
        /// </summary>
        private void timeSend_Tick(object sender, EventArgs e)
        {
            //转换时间间隔
            string strSecond = txtSecond.Text;

            try
            {
                //Interval的单位是ms
                int isecond = int.Parse(strSecond) * 1;
                timeSend.Interval = isecond;

                if (timeSend.Enabled == true)
                {
                    //如果timeSend空间是可用状态，用按钮的PerformClick()方法生成按钮的点击事件。
                    btnCycleSend.PerformClick();
                }
            }
            catch (Exception ex)
            {
                //若出现异常，就将Timer控件状态设为不可用，然后抛出异常提示
                timeSend.Enabled = false;
                MessageBox.Show("设置的时间间隔格式错误!\n" + ex.Message, "异常提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 定义委托 使用委托
        private delegate void RunTimeDelegate();
        private void RunTime()
        {
            //MonitoringAsync();//监听文件

            RS232SerialPortSend(serialPort);
            Thread.Sleep(100);
            RS232SerialPortSend(serialPort1);
        }
        #endregion

        #region  激光机状态下发
        /// <summary>
        /// 状态触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrigger_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            btnSendPort(PLCEnumer.LASER_ALARM);//激光机状态请求
            Thread.Sleep(1000);
            btnSendPort(PLCEnumer.LETTERING_TRIGGER);//印字触发
            Thread.Sleep(1000);
            btnSendPort(PLCEnumer.PRINTING_READY);//印字触发
            Thread.Sleep(1000);
        }
        #endregion

        #region 状态 推送按钮  暂未使用
        /// <summary>
        /// 状态推送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComplete_Click(object sender, EventArgs e)
        {
            Progressive_Judgment(16);
        }
        #endregion

        #region 状态控件
        /// <summary>
        /// 定义控件状态
        /// </summary>
        /// <param name="canUse"></param>
        private void SettingControls(int canUse)
        {
            if (canUse == 0)
            {
                #region 控件显示 隐藏
                txtIp.Enabled = false;
                txtPort.Enabled = false;
                txtStation.Enabled = false;
                txtRegisterAddress.Enabled = false;
                btnopen.Enabled = false;
                this.hslLanternSimple1.LanternBackground = Color.LimeGreen;
                this.btnClose.Enabled = true;
                uiCheckBoxGroup1.Enabled = true;
                uiCheckBoxGroup2.Enabled = true;
                txtSend.Enabled = true;
                btnCycleSend.Enabled = true;
                btnCycleReceive.Enabled = true;
                txtReceive.Enabled = true;
                btnReceive.Enabled = true;
                cbmCom.Enabled = false;
                cbBaudRate.Enabled = false;
                txtdatabit.Enabled = false;
                cbStop.Enabled = false;
                cmbParity.Enabled = false;
                txtStationCom.Enabled = false;
                txtIp1.Enabled = false;
                txtPort2.Enabled = false;
                txtStation2.Enabled = false;
                #endregion
            }
            else if (canUse == 1)
            {

                this.hslLanternSimple1.LanternBackground = Color.Red;  //断开未连接是红色
                this.btnClose.Enabled = false;
                uiCheckBoxGroup1.Enabled = false;
                uiCheckBoxGroup2.Enabled = false;
                txtSend.Enabled = false;
                btnCycleSend.Enabled = false;
                btnCycleReceive.Enabled = false;
                txtReceive.Enabled = false;
                btnReceive.Enabled = false;
                uiCheckBox1.Checked = true;
                uiCheckBox3.Checked = true;
                uiCheckBox4.Checked = true;
                uiCheckBox1.Checked = true;
                uiCheckBox3.Checked = true;
                uiCheckBox4.Checked = true;
                cbmCom.Enabled = true;
                cbBaudRate.Enabled = true;
                txtdatabit.Enabled = true;
                cbStop.Enabled = true;
                cmbParity.Enabled = true;
                txtStationCom.Enabled = true;
            }
            else
            {
                uiButton2.Enabled = true;
                uiComboboxEx1.Enabled = false;
                btnopen.Enabled = false;
                this.hslLanternSimple1.LanternBackground = Color.Red;
                this.btnClose.Enabled = false;
                uiCheckBoxGroup1.Enabled = false;
                uiCheckBoxGroup2.Enabled = false;
                txtRegisterAddress2.Enabled = false;
                txtRegisterAddress.Enabled = false;
                txtRegisterAddress3.Enabled = false;
                txtRegisterAddress4.Enabled = false;
                uiCheckBoxGroup4.Enabled = false;
                uiCheckBoxGroup16.Enabled = false;
                uiCheckBoxGroup5.Enabled = false;
                uiCheckBoxGroup3.Enabled = false;
            }
        }
        #endregion

        #region Method ByteToHex and HexToByte Byte字节数组、Hex16进制和字符串之间转换的方法

        //byte字节数组转16进制
        private string ByteToHex(byte[] comByte)
        {
            StringBuilder builder = new StringBuilder(comByte.Length * 3);

            foreach (byte data in comByte)
            {
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            }
            return builder.ToString().ToUpper();
        }

        //16进制转字节数组
        private byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");
            msg = msg.Replace("0x", "");
            msg = msg.Replace("0X", "");

            byte[] comBuffer = new byte[msg.Length / 2];

            for (int i = 0; i < msg.Length; i += 2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            }
            return comBuffer;
        }

        //字符串转字节型数组
        private byte[] StringToByte(string msgtxt)
        {
            return System.Text.Encoding.UTF8.GetBytes(msgtxt);
        }

        //字节型数组转字符串
        private string ByteToString(byte[] buffer)
        {
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
        #endregion

        #region 日志记录，在richtextbox中显示不同颜色文字的方法

        /// <summary>
        /// 事件委托
        /// </summary>
        /// <param name="color">颜色值</param>
        /// <param name="text">文本内容</param>
        public delegate void LogAppendDelegate(Color color, string text);

        //追加显示文本
        public void LogAppend(Color color, string msg)
        {
            txtReceive.ForeColor = color;
            txtReceive.AppendText(msg);
            txtReceive.AppendText("\n");
        }

        //显示错误信息
        public void LogError(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtReceive.Invoke(lad, Color.Red, DateTime.Now.ToString("HH:mm:ss ") + msg + Environment.NewLine);
            LogHelper.Error("错误信息" + DateTime.Now.ToString("HH:mm:ss ") + msg);
        }

        //显示警告信息
        public void LogWarning(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtReceive.Invoke(lad, Color.Violet, DateTime.Now.ToString("HH:mm:ss ") + msg + Environment.NewLine);
            LogHelper.Debug("输出信息" + DateTime.Now.ToString("HH:mm:ss ") + msg);
        }

        //显示信息
        public void LogMessage(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtReceive.Invoke(lad, Color.Black, DateTime.Now.ToString("HH:mm:ss ") + msg + Environment.NewLine);
            LogHelper.Info("输出信息" + DateTime.Now.ToString("HH:mm:ss ") + "[发]" + msg);
        }
        //发送信息的设置
        public void SendMessage(string portName, string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtReceive.Invoke(lad, Color.Black, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "[" + portName + "]" + msg + Environment.NewLine);
            LogHelper.Info("输出信息" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "[发]" + msg);
        }
        //接收信息的设置
        public void RcvMessage(string portName, string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtReceive.Invoke(lad, Color.Blue, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "[" + portName + "]" + msg + Environment.NewLine);
            LogHelper.Info("接收信息" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "[收]" + msg);
        }
        #endregion

        #region btnSwitch_Click 打开/关闭串口按钮  第一个com 口
        /// <summary>
        /// 打开/关闭串口的按钮事件
        /// </summary>
        private void btnSwitch()
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    //设置串口号
                    string serialName = cbmCom.SelectedItem.ToString();
                    serialPort.PortName = serialName;

                    //对串口参数进行设置
                    string strBaudRate = cbBaudRate.Text;
                    string strDateBits = txtdatabit.Text;
                    string strStopBits = cbStop.Text;

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    //设置波特率
                    serialPort.BaudRate = iBaudRate;
                    //设置数据位
                    serialPort.DataBits = iDateBits;
                    //设置停止位
                    switch (cbStop.Text)
                    {
                        case "1": serialPort.StopBits = StopBits.One; break;
                        case "1.5": serialPort.StopBits = StopBits.OnePointFive; break;
                        case "2": serialPort.StopBits = StopBits.Two; break;
                        default:
                            MessageBox.Show("停止位参数不正确", "异常提示信息",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    //设置校验位
                    switch (cmbParity.Text)
                    {
                        case "无": serialPort.Parity = Parity.None; break;
                        case "奇数": serialPort.Parity = Parity.Odd; break;
                        case "偶数": serialPort.Parity = Parity.Even; break;
                        default:
                            MessageBox.Show("校验位参数不正确！", "异常提示信息",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    //如果串口为打开状态，就先关闭一下来初始化串口
                    if (serialPort.IsOpen == true)
                    {
                        serialPort.Close();
                    }

                    //设置必要的控件为不可用状态
                    SettingControls(0);

                    //打开串口
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "异常提示信息",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LogHelper.Error(ex.Message);
                    timeSend.Enabled = false;

                    //设置必要的控件为可用状态
                    SettingControls(1);
                    return;
                }
            }
            else
            {
                SettingControls(1);

                //关闭串口
                serialPort.Close();
                LogHelper.Info("关闭串口");
                //关闭计时器Timer
                timeSend.Enabled = false;
            }
        }
        #endregion

        #region btnSwitch_Click 打开/关闭串口按钮  第二个com 口
        /// <summary>
        /// 打开/关闭串口的按钮事件
        /// </summary>
        private void btnSwitchtwo()
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    //设置串口号
                    string serialName = cbmCom2.SelectedItem.ToString();
                    serialPort1.PortName = serialName;

                    //对串口参数进行设置
                    string strBaudRate = cbBaudRate2.Text;
                    string strDateBits = txtdatabit2.Text;
                    string strStopBits = cbStop2.Text;

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    //设置波特率
                    serialPort1.BaudRate = iBaudRate;
                    //设置数据位
                    serialPort1.DataBits = iDateBits;
                    //设置停止位
                    switch (cbStop2.Text)
                    {
                        case "1": serialPort1.StopBits = StopBits.One; break;
                        case "1.5": serialPort1.StopBits = StopBits.OnePointFive; break;
                        case "2": serialPort1.StopBits = StopBits.Two; break;
                        default:
                            MessageBox.Show("停止位参数不正确", "异常提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    //设置校验位
                    switch (cmbParity2.Text)
                    {
                        case "无": serialPort1.Parity = Parity.None; break;
                        case "奇数": serialPort1.Parity = Parity.Odd; break;
                        case "偶数": serialPort1.Parity = Parity.Even; break;
                        default:
                            MessageBox.Show("校验位参数不正确！", "异常提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    //如果串口为打开状态，就先关闭一下来初始化串口
                    if (serialPort1.IsOpen == true)
                    {
                        serialPort1.Close();
                    }

                    //设置必要的控件为不可用状态
                    SettingControls(0);

                    //打开串口
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "异常提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LogHelper.Error(ex.Message);
                    timeSend.Enabled = false;

                    //设置必要的控件为可用状态
                    SettingControls(1);
                    return;
                }
            }
            else
            {
                SettingControls(1);

                //关闭串口
                serialPort1.Close();
                LogHelper.Info("关闭串口");
                //关闭计时器Timer
                timeSend.Enabled = false;
            }
        }
        #endregion

        #region sp1_DataReceived 对接收的数据进行处理的方法 并执行数据比对    未使用
        /// <summary>
        /// 对接收的数据进行处理的方法
        /// </summary>
        public void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /* if (serialPort.IsOpen)
             {
                 //BytestoRead:sp1接收的字符个数
                 byte[] receiveBytes = new byte[serialPort.BytesToRead];

                 serialPort.Read(receiveBytes, 0, receiveBytes.Length);
                 serialPort.DiscardInBuffer();

                 //rdRcvStr:"接收字符串"单选按钮
                 if (uiCheckBox1.Checked)
                 {
                     string receiveStr = ByteToString(receiveBytes);
                     RcvMessage(receiveStr); //数据输出并打印

                     Write(receiveStr.Trim());

                     DataComparisonAsync(receiveStr.Trim()); //数据比对
                 }
                 else
                 {
                     try
                     {
                         string strRcv = ByteToHex(receiveBytes);
                         RcvMessage(strRcv);
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message, "异常提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         txtSend.Text = "";
                     }
                 }
             }
             else
             {
                 MessageBox.Show("请打开某个串口", "信息提示",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
             }*/
        }

        #endregion

        #region  数据比对
        /// <summary>
        /// 数据比对
        /// </summary>
        /// <param name="msg">带入参数</param>
        private  void DataComparisonAsync(string msg)
        {
            #region
            /*            //编码处理转换
                        // string msg1 = UnHex(msg, "UTF-8");
                        //数据比对
                        string line;
                        StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "BarCodeThan.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                            if (line != msg.Trim())
                            {
                                Console.WriteLine("写入成功");
                            }
                            else
                            {
                                /////// 写入有问题  会导致程序假死


                                //返回PLC地址状态正常
                                //OperateResult write = await  readWriteNet.WriteAsync(txtRegisterAddress2.Text, 3);
                                // ClassUtils.WriteResultRender(write, txtRegisterAddress4.Text);
                                break;
                            }
                        }
                        file.Close();*/
            #endregion
            LogHelper.Info("数据比对开始-------");
            string FilePath = Directory.GetCurrentDirectory() + "\\" + "BarCodeThan" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "BarCodeThan.txt";
            List<string> list = ReadFileToList(FilePath);
            bool isbool = list.Contains(msg);
            if (isbool)
            {
                Console.WriteLine("【" + msg + "】比对成功");
                LogHelper.Info("【" + msg + "】比对成功");

                int content = Conversion_Changes(HelpToolClass.Plc_Address, 13, "1"); //设置plc的状态
                Console.WriteLine(content);
                OperateResult write =  readWriteNet.Write(txtRegisterAddress4.Text, content);
            }
            else
            {
                Console.WriteLine("【" + msg + "】该数据不存在");
                LogHelper.Info("【" + msg + "】该数据不存在");
            }
            LogHelper.Info("数据比对结束-------");
        }
        #endregion

        #region 逐行读取文件到泛型数组
        /// <summary>
        /// 逐行读取文件到泛型数组
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        private List<string> ReadFileToList(string FilePath)
        {
            List<string> list = new List<string>();
            //新建文件流
            FileStream fsRead=null;
            //用FileStream文件流打开文件
            try
            {
                fsRead = new FileStream(FilePath, FileMode.Open);
                //"GB2312"用于显示中文字符，写其他的，中文会显示乱码
                StreamReader reader = new StreamReader(fsRead, UnicodeEncoding.GetEncoding("GB2312"));
                string search;
                while ((search = reader.ReadLine()) != null)
                {
                    list.Add(search);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("文件不存在或打开失败");
            }
            fsRead.Close();
            return list;
        }
        #endregion

        #region  进制转换   待细节完善
        /// <summary>
        ///  进制转换
        /// </summary>
        /// <param name="jundg">十进制</param>
        /// <returns></returns>
        public int Progressive_Judgment(int jundg)
        {
            int Strlenght = 16;
            //这就需要补齐位数了PadLeft(int a,cha b),其中a为总共多少位，b为用什么补齐 ( 当然还有PadRight()补齐右侧)
            string Strlenghts = Convert.ToString(jundg, 2).PadLeft(Strlenght, '0');
            Console.WriteLine(Strlenghts);
            string[] items = new string[Strlenghts.Length];
            string[] item1 = new string[Strlenghts.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = Strlenghts[i].ToString();
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位：" + (jundg >> i & 0x01));
                //  if ((jundg >> i & 0x01) ==1 & i==1)
                ///Console.WriteLine(i >> jundg & 0x01);
                switch (i)
                {
                    case 15:   //代表  PLC
                        if ((jundg >> 0 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 14:  //代表扫码仪 录入
                        if ((jundg >> 1 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 13:  //代表 扫码仪比对值

                        if ((jundg >> 2 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 12:  //代表xx
                        if ((jundg >> 3 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 11:  //代表xx
                        if ((jundg >> 4 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 10:  //代表xx
                        if ((jundg >> 5 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 9: //代表xx
                        if ((jundg >> 6 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 8:  //代表xx
                        if ((jundg >> 7 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 7:  //代表xx
                        if ((jundg >> 8 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 6:  //代表xx
                        if ((jundg >> 9 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 5:  //代表xx
                        if ((jundg >> 10 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 4: //代表xx
                        if ((jundg >> 11 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 3:  //代表xx
                        if ((jundg >> 12 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 2:  //代表xx
                        if ((jundg >> 13 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 1:  //代表xx
                        if ((jundg >> 14 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                    case 0:  //代表xx
                        if ((jundg >> 15 & 0x01) == 1)
                        {
                            item1[i] = "1";
                        }
                        else
                        {
                            item1[i] = "0";
                        }
                        break;
                }
            }
            for (int i = 0; i < item1.Length; i++)
            {
                Console.WriteLine("item1: 第" + (i + 1) + "位：" + item1[i]);
            }
            return 0;
        }

        #endregion

        private void Test_click(object sender, EventArgs e)
        {

            RS232SerialPortSend(serialPort);
            Thread.Sleep(200);
            RS232SerialPortSend(serialPort1);

        }

        #region 进制转换并修改指定位置的状态 
        /// <summary>
        ///  进制转换并修改指定位置的状态  转换为状态1
        /// </summary>
        /// <param name="msg">接收回来的参数</param>
        /// <param name="index">指定的下标</param>
        /// /// <param name="status">修改的参数值</param>
        /// <returns>十进制输出</returns>
        public int Conversion_Changes(int msg, int index, string status)
        {
            int Format_Base;
            int Strlenght = 16;//二进制长度
            //这就需要补齐位数了PadLeft(int a,cha b),其中a为总共多少位，b为用什么补齐 ( 当然还有PadRight()补齐右侧)
            string Strlenghts = Convert.ToString(msg, 2).PadLeft(Strlenght, '0');
            Strlenghts = Strlenghts.Remove(index, 1);//删除当前位置的字符
            string content = new StringBuilder(Strlenghts).Insert(index, status).ToString(); //插入字符
            Format_Base = Convert.ToInt32(content, 2); //转换为十进制输出
            return Format_Base;
        }
        #endregion

        private void btnStateWriting_Click(object sender, EventArgs e)
        {
           
        }
    }
}
