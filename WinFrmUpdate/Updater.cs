using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFrmUpdate
{
    public class Updater
    {
        //原应用程序路径
        private string _appDirPath;
        //原应用程序文件名
        private string _appFileName;
        //原程序版本号
        private int _oldversioncode;

        //检测版本信息
        CUpdInfo info = new CUpdInfo();

        //下载文件名
        private string _downfilename="update.zip";
        //检测升级地址
        private string _checkurl = "";

        private WebClient _client;

        private ProgressBar _progressBar;
        private Label _lbltext;


        public Updater(string serverIp, int serverPort, ProgressBar pb, Label lbl)
        {
            _progressBar = pb;
            _lbltext = lbl;

            _checkurl=$"http://{serverIp}:{serverPort}/apk/upgradestd.txt";
        }

        /// <summary>
        /// 设置基本参数
        /// </summary>
        /// <param name="apppath"></param>
        /// <param name="appfile"></param>
        /// <param name="oldversioncode"></param>
        public void SetBaseParam(string apppath,string appfile,int oldversioncode)
        {
            _appFileName = appfile;
            _appDirPath = apppath;
            _oldversioncode = oldversioncode;
        }

        /// <summary>
        /// 下载升级文件
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public void DownLoadUpGrade(string url)
        {
            _client = new WebClient();
            if (_client.IsBusy)
            {
                _client.CancelAsync();
            }
            _client.DownloadProgressChanged +=
                new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
            _client.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);

            //开始下载
            _client.DownloadFileAsync(new Uri(url), _downfilename);
        }

        /// <summary>
        /// 下载进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
            _lbltext.Text = $"正在下载文件,完成进度{e.BytesReceived}/{e.TotalBytesToReceive}";
        }


        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _lbltext.Text = "下载被取消!";
            }
            else
            {
                _lbltext.Text = "下载完成!";
                try
                {
                    UpdaterOver.StartOver(_downfilename, _appDirPath, info.versionCode, _appFileName);
                }
                catch (Exception ex)
                {
                    _lbltext.Text = ex.Message;
                }
            }
        }

        /// <summary>
        /// 检测升级信息
        /// </summary>
        /// <param name="geturl"></param>
        /// <param name="downurl"></param>
        /// <returns></returns>
        public void GetUpdaterInfo()
        {
            info = new CUpdInfo();
        
            _client = new WebClient();
            string json = _client.DownloadString(_checkurl);
            info = SerializationHelper.Deserialize<CUpdInfo>(json, 0);

            if (info.versionCode > _oldversioncode)
            {
                DownLoadUpGrade(info.appdownloadurl);
            }
            else
            {
                _lbltext.Text = "当前为最新版本,无需升级!";
                //等待500毫秒后直接启动原程序
                Thread.Sleep(500);
                UpdaterOver.StartApp(_appFileName);
            }


        }


    }
}
