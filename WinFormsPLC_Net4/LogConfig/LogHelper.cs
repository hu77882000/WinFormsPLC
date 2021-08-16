using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsPLC_Net4
{
    /// <summary>
    /// 日志配置输出
    /// </summary>
    public static class LogHelper
    {
        private static readonly log4net.ILog logInfo = log4net.LogManager.GetLogger("InfoLog");
        private static readonly log4net.ILog logError = log4net.LogManager.GetLogger("Error");
        private static readonly log4net.ILog logDebug = log4net.LogManager.GetLogger("DebugLog");
        /// <summary>
        /// 普通日志
        /// </summary>
        /// <param name="message">日志内容</param>
        public static void Info(string message)
        {
            if (logInfo.IsInfoEnabled)
            {
                logInfo.Info(message);
            }
        }
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Error(string message)
        {
            if (logError.IsErrorEnabled)
            {
                logError.Error(message);
            }
        }

        /// <summary>
        /// 调试日志
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Debug(string message)
        {
            if (logDebug.IsErrorEnabled)
            {
                logDebug.Debug(message);
            }
        }
    }
}
