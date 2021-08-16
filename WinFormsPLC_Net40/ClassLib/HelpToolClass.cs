using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC_Net40
{
    public static class HelpToolClass
    {
        /// <summary>
        /// plc设置后返回的处理结果
        /// </summary>
        public static int Plc_Address_Return { get; set; }
        /// <summary>
        /// plc地址返回参数
        /// 十进制
        /// </summary>
        public static int Plc_Address { get; set; }
       /// <summary>
       /// 转换后的下标
       /// </summary>
        public static string Plc_Address_Binary { get; set; }
        /// <summary>
        /// 根据下标获取到参数
        /// </summary>
        public static string Plc_Address_Binary_Index { get; set; }
    }
}
