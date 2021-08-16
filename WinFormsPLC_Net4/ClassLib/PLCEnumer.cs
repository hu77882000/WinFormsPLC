using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC_Net4
{
 public  class PLCEnumer
    {

        ///<summary>
        ///激光器开始启动
        ///LSR  STX  LSR S (数据)
        /// </summary>
        public const string LASER_MACHINE_OPEN= "02 4C 53 52 53 31 0D";

        ///<summary>
        ///印字文件列设定MCS：STX MCS S （要设置的行数+印字内容数据） 0D
        /// </summary>
        public const string SETFILE = "02 4D 43 53 53 30 32 30 31 32 33 30 31 32 33 30 31 32 33 0D";

        ///<summary>
        ///遮光阀打开（关闭）
        ///设定SHT：STX SHT S(数据) 0D
        /// </summary>
        public const string SHADING_VALVE_OPEN = "02 53 48 54 53 31 0D";

        ///<summary>
        ///激光机状态请求(报警)读取STS  STX STS R 0D   
        ///返回02 53 54 53 41 30 32 30 30 30 0D
        /// </summary>
        public const string LASER_ALARM = "02 53 54 53 52 0D";

        ///<summary>
        ///印字触发MRK: STX MRK S(数据) 0D   
        ///返回  06 30 30 0D  正常  ACK 00 CR"
        /// </summary>
        public const string LETTERING_TRIGGER = "02 4D 52 4B 53 31 0D" ;


        ///<summary>
        ///印字就绪MKM: STX MRM R(数据) 0D     
        ///返回02 4D 4B 4D 41 31 0D（0表示中断，1表示再开）
        /// </summary>
        public const string PRINTING_READY = " 02 4D 4B 4D 52 0D";
    }
}
