using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC_Net4
{
    /// <summary>
    /// 端口设备命令列表
    /// </summary>
    public class PortEquipmentEnumer
    {
        /// <summary>
        /// 开启扫描仪
        /// </summary>
        public const string SCANNER_OPEN = "16 54 0D";

        /// <summary>
        /// 关闭扫描仪
        /// </summary>
        public const string SCANNER_CLOSE = "16 55 0D";
    }
}
