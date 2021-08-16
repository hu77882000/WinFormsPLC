using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC
{
   public  class HexadecimalConversion
    {
        /// <summary>
        /// 转换为二进制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToErJin(int value)
        {
            int temp = 0;
            int shang = 1;
            int yushu;
            while (shang != 0)
            {
                shang = (int)value / 2;
                yushu = value % 2;
                value = shang;
                temp += yushu;
                if (shang != 0)
                {
                    temp = temp * 10;
                }
            }
            //最后将 temp 倒序
            string tempStr = temp.ToString();
            int tempLength = tempStr.Length;
            string resultStr = string.Empty;
            for (int i = 0; i < tempLength; i++)
            {
                resultStr = tempStr[i] + resultStr;
            }
            return int.Parse(resultStr);
        }

        /// <summary>
        /// 转换为十进制（主要算法：个位数 * 2的零次方 + 十位数 * 2的一次方 + 百位数 * 2的二次方 + ...）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToShijin2(int value)
        {
            int temp = 0;
            int shang = value;
            int yushu;
            int mark = 0;
            while (shang != 0)
            {
                yushu = shang % 10;
                shang = shang / 10;
                temp += yushu * (int)Math.Pow(2, mark);
                mark++;
            }
            return temp;
        }

        /// <summary>
        /// 二进制转十进制的另一种方法（主要算法：1110111 = 1 * 2~6 + 1 * 2~5 + 1 * 2~4 + 0 * 2~3 + 1 * 2~2 + 1 * 2~1 + 1 * 2~0）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToShijin(int value)
        {
            string strValue = value.ToString();
            int valueLength = strValue.Length;
            int result = 0;
            for (int i = 0; i < valueLength; i++)
            {
                result += int.Parse(strValue[i].ToString()) * (int)Math.Pow(2, valueLength - 1 - i);
            }
            return result;
        }
    }
}
