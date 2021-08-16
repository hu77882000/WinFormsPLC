using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmUpdate
{
    public partial class MainForm : Form
    {
        private string callBackExeName;   //自动升级完成后，要启动的exe的名称。
        private string callBackPath = ""; //自动升级完成后，要启动的exe的完整路径。        
        private bool startAppAfterClose = false; //关闭升级窗体前，是否启动应用程序。
        private int VersionCode = 0;



        public MainForm(string serverIP, int serverPort, string _callBackExeName, string title, int oldversioncode)
        {
            InitializeComponent();

            this.VersionCode = oldversioncode;
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            this.callBackExeName = dir.Parent.FullName + "\\" + _callBackExeName;
            
            this.callBackPath = dir.Parent.FullName + "\\";

            this.Text = title;

            Updater updater = new Updater(serverIP, serverPort, progressBar1, label1);
            try
            {
                updater.SetBaseParam(callBackPath, callBackExeName, VersionCode);
                updater.GetUpdaterInfo();
            }
            catch (Exception e)
            {
                this.label1.Text = e.Message;
            }

        }


    }
}
