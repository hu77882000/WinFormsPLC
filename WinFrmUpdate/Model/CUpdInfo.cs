namespace WinFrmUpdate
{
    /// <summary>
    /// 下载信息类
    /// </summary>
    public class CUpdInfo
    {

        public CUpdInfo()
        {
            appdownloadurl = "";
            instructions = "";
            versionName = "";
            versionCode = 0;
            upgradetype = 0;

        }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string appdownloadurl { get; set; }
        /// <summary>
        /// 更新说明
        /// </summary>
        public string instructions { get; set; }
        /// <summary>
        /// 版本名称
        /// </summary>
        public string versionName { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public int versionCode { get; set; }
        /// <summary>
        /// 更新类型  0-普通更新 1-强制更新
        /// </summary>
        public int upgradetype { get; set; }
    }
}
