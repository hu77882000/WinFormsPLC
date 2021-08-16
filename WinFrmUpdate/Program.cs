using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmUpdate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                string serverIP = ConfigurationManager.AppSettings["ServerIP"];
                int serverPort = int.Parse(ConfigurationManager.AppSettings["ServerPort"]);
                string callBackExeName = ConfigurationManager.AppSettings["CallbackExeName"];
                string title = ConfigurationManager.AppSettings["Title"];
                int VersionCode = int.Parse(ConfigurationManager.AppSettings ["Version"]);

                MainForm form = new MainForm(serverIP, serverPort, callBackExeName, title, VersionCode);

                Application.Run(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
