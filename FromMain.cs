using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Panasonic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPLC
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private PanasonicMewtocolOverTcp panasonicMewtocol = null;
        private PanasonicMewtocol panasonicMewtocol1 = null;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.hslLanternSimple1.LanternBackground = Color.Red;
            this.btnClose.Enabled = false;
            uiCheckBoxGroup1.Enabled = false;
            uiCheckBoxGroup2.Enabled = false;
            txtSend.Enabled = false;
            btnCycleSend.Enabled = false;
            btnCycleReceive.Enabled = false;
            txtReceive.Enabled = false;
            btnReceive.Enabled = false;
            uiCheckBoxGroup4.Visible = false;
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (uiComboboxEx1.Text == "TCP/IP")
            {
                if (!int.TryParse(txtPort.Text, out int port))
                {
                    MessageBox.Show(ClassUtils.PortInputWrong);
                    return;
                }
                if (!byte.TryParse(txtStation.Text, out byte station))
                {
                    MessageBox.Show(ClassUtils.StationInputWrong);
                    return;
                }

                panasonicMewtocol?.ConnectClose();
                panasonicMewtocol = new PanasonicMewtocolOverTcp(station);
                panasonicMewtocol.IpAddress = txtIp.Text;
                panasonicMewtocol.Port = port;
                try
                {
                    OperateResult connect = panasonicMewtocol.ConnectServer();
                    if (connect.IsSuccess)
                    {
                        #region  控件显示隐藏
                        this.hslLanternSimple1.LanternBackground = Color.LimeGreen;
                        uiCheckBoxGroup1.Enabled = true;
                        uiCheckBoxGroup2.Enabled = true;
                        txtSend.Enabled = true;
                        btnCycleSend.Enabled = true;
                        btnCycleReceive.Enabled = true;
                        txtReceive.Enabled = true;
                        btnReceive.Enabled = true;
                        btnClose.Enabled = true;
                        btnopen.Enabled = false;
                        txtIp.Enabled = false;
                        txtPort.Enabled = false;
                        txtStation.Enabled = false;
                        txtRegisterAddress.Enabled = false;
                        #endregion
                        //发送区
                        //接收区
                    }
                    else
                    {
                        MessageBox.Show(ClassUtils.NetworkFault);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (!int.TryParse(cmbBT.Text, out int baudRate))
                {
                    MessageBox.Show(ClassUtils.BaudRateInputWrong);
                    return;
                }
                if (!int.TryParse(txtdatabit.Text, out int dataBits))
                {
                    MessageBox.Show(ClassUtils.DataBitsInputWrong);
                    return;
                }
                if (!int.TryParse(txtTopbit.Text, out int stopBits))
                {
                    MessageBox.Show(ClassUtils.StopBitInputWrong);
                    return;
                }
                if (!byte.TryParse(txtStationCom.Text, out byte station))
                {
                    MessageBox.Show(ClassUtils.StationInputWrong);
                    return;
                }

                panasonicMewtocol1?.Close();
                panasonicMewtocol1 = new PanasonicMewtocol(station);
                try
                {
                    panasonicMewtocol1.SerialPortInni(sp =>
                    {
                        sp.PortName = cbmCom.Text;
                        sp.BaudRate = baudRate;
                        sp.DataBits = dataBits;
                        sp.StopBits = stopBits == 0 ? System.IO.Ports.StopBits.None : (stopBits == 1 ? System.IO.Ports.StopBits.One : System.IO.Ports.StopBits.Two);
                        sp.Parity = cmbParity.SelectedIndex == 0 ? System.IO.Ports.Parity.None : (cmbParity.SelectedIndex == 1 ? System.IO.Ports.Parity.Odd : System.IO.Ports.Parity.Even);
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
                        MessageBox.Show(SerialPort.GetPortNames()+ "连接失败");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #region 注释段
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
        /// <summary>
        ///  关闭连接按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // 关闭当前连接
            panasonicMewtocol.ConnectClose();
            panasonicMewtocol1.Close();

            txtIp.Enabled = true;
            txtPort.Enabled = true;
            txtStation.Enabled = true;
            txtRegisterAddress.Enabled = true;
            btnopen.Enabled = true;
            this.hslLanternSimple1.LanternBackground = Color.Red;
            this.btnClose.Enabled = false;
            uiCheckBoxGroup1.Enabled = false;
            uiCheckBoxGroup2.Enabled = false;
            txtSend.Enabled = false;
            btnCycleSend.Enabled = false;
            btnCycleReceive.Enabled = false;
            txtReceive.Enabled = false;
            btnReceive.Enabled = false;
        }

        /******** 清空***************/
        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.txtReceive.Text = "";
        }
        private IReadWriteNet readWriteNet;
        private async void btnSend_ClickAsync(object sender, EventArgs e)
        {
            OperateResult write = await readWriteNet.WriteAsync(txtSend.Text, txtReceive.Text);
            ClassUtils.WriteResultRender(write, txtSend.Text);
        }

        private async void btnReceive_Click(object sender, EventArgs e)
        {
            ClassUtils.ReadResultRender(await readWriteNet.ReadStringAsync(txtRegisterAddress.Text, 10), txtRegisterAddress.Text, txtReceive);
        }

        private void uiComboboxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboboxEx1.Text == "RS232")
            {
                uiCheckBoxGroup4.Visible = true;
                uiCheckBoxGroup3.Visible = false;
                cbmCom.DataSource = SerialPort.GetPortNames();//获取当前可使用的 SerialPort
            }
            else
            {
                uiCheckBoxGroup4.Visible = false;
                uiCheckBoxGroup3.Visible = true;
            }

        }
    }
}
