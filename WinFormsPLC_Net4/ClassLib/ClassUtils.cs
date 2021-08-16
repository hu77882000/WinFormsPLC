using HslCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPLC_Net4
{
    class ClassUtils
    {
        /// <summary>
        /// 统一的读取结果的数据解析，显示
        /// </summary>
        /// <typeparam name="T">类型对象</typeparam>
        /// <param name="result">读取的结果值</param>
        /// <param name="address">地址信息</param>
        /// <param name="textBox">输入的控件</param>
        public static void ReadResultRender<T>(OperateResult<T> result, string address, TextBox textBox)
        {
            if (result.IsSuccess)
            {
                if (result.Content is Array)
                {
                    textBox.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {HslCommunication.BasicFramework.SoftBasic.ArrayFormat(result.Content)}{Environment.NewLine}");
                }
                else
                {
                    textBox.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {result.Content}{Environment.NewLine}");
                }
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败的 {Environment.NewLine} 原因：{result.ToMessageShowString()}");
            }
        }

        public static string  ReadResultRender<T>(OperateResult<T> result, string address)
        {
            string str = null;
            if (result.IsSuccess)
            {
                if (result.Content is Array)
                {
                   str =  DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {HslCommunication.BasicFramework.SoftBasic.ArrayFormat(result.Content)}{Environment.NewLine}";
                }
                else
                {
                    str = DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] {result.Content}{Environment.NewLine}";
                }
            }
            else
            {
                str =DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败的 {Environment.NewLine} 原因：{result.ToMessageShowString()}";
            }
            return str;
        }

        /// <summary>
        /// 统一的数据写入的结果显示
        /// </summary>
        /// <param name="result">写入的结果信息</param>
        /// <param name="address">地址信息</param>
        public static void WriteResultRender(OperateResult result, string address)
        {
            if (result.IsSuccess)
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入成功");
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败的 {Environment.NewLine} 原因：{result.ToMessageShowString()}");
            }
        }

        /// <summary>
        /// 统一的数据写入的结果显示
        /// </summary>
        /// <param name="result">写入的结果信息</param>
        /// <param name="address">地址信息</param>
        public static void WriteResultRender(OperateResult result)
        {
            if (result.IsSuccess)
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"Success");
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"失败的 {Environment.NewLine} 原因：{result.ToMessageShowString()}");
            }
        }

        /// <summary>
        /// 统一的数据写入的结果显示
        /// </summary>
        /// <param name="result">写入的结果信息</param>
        /// <param name="address">地址信息</param>
        public static void WriteResultRender(Func<OperateResult> write, string address)
        {
            try
            {
                OperateResult result = write();
                if (result.IsSuccess)
                {
                    MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入成功！");
                }
                else
                {
                    MessageBox.Show(DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败 {Environment.NewLine} 原因：{result.ToMessageShowString()}");
                }
            }
            catch (Exception ex)
            {
                // 主要是为了捕获写入的值不正确的情况
                MessageBox.Show("用于写入的数据不一致: " + ex.Message);
            }
        }

        public static void BulkReadRenderResult(HslCommunication.Core.IReadWriteNet readWrite, TextBox addTextBox, TextBox lengthTextBox, TextBox resultTextBox)
        {
            try
            {
                OperateResult<byte[]> read = readWrite.Read(addTextBox.Text, ushort.Parse(lengthTextBox.Text));
                if (read.IsSuccess)
                {
                    resultTextBox.Text = "结果：" + HslCommunication.BasicFramework.SoftBasic.ByteToHexString(read.Content);
                }
                else
                {
                    MessageBox.Show("读取失败：" + read.ToMessageShowString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取失败：" + ex.Message);
            }
        }

        public static readonly string IpAddressInputWrong = "IP地址输入错误";
        public static readonly string PortInputWrong = "端口输入错误";
        public static readonly string SlotInputWrong = "Slot 输入错误";
        public static readonly string BaudRateInputWrong = "波特率输入错误";
        public static readonly string DataBitsInputWrong = "数据位输入错误";
        public static readonly string StopBitInputWrong = "停止位输入错误";
        public static readonly string StationInputWrong = "PLC输入错误";
        public static readonly string NetworkFault = "无法连接，请检查配置信息";
    }
}
