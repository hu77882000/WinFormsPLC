using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WinFrmUpdate
{
    public class UpdaterOver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zipfile"></param>
        /// <param name="destpath"></param>
        public static void StartOver(string zipfile, string destpath, int versioncode, string appfile)
        {
            //解压文件到指定目录
            ZipHelper.UnZipFile(zipfile, destpath, true);
            //成功后修改本地版本信息
            UpdateVersion(versioncode);
            //重新启动源程序 
            if (appfile != "")
            {
                StartApp(appfile);
            }
        }

        /// <summary>
        /// 启动新程序
        /// </summary>
        /// <param name="filename"></param>
        public static void StartApp(string filename)
        {
            ProcessStartInfo info = new ProcessStartInfo();

            info.FileName = filename;
            info.Arguments = "";
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process pro = Process.Start(info);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// 修改更新完后的版本号信息
        ///  </summary>
        /// <param name="newVersionCode"></param>
        private static void UpdateVersion(int newVersionCode)
        {
            //获取Configuration对象
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //修改版本号
            config.AppSettings.Settings["Version"].Value = newVersionCode.ToString();
            //一定要记得保存，写不带参数的config.Save()也可以
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
