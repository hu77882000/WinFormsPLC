using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFrmUpdate
{
    /// <summary>
    /// 使用DotNetZip进行压缩和解压
    /// </summary>
    public class ZipHelper
    {
        /// <summary>
        /// 压缩单个文件
        /// </summary>
        /// <param name="zipfile"></param>
        /// <param name="srcfile"></param>
        /// <param name="destpath"></param>
        public static void ZipFile(string zipfile, string srcfile, string destpath = "")
        {
            using (ZipFile zip = new ZipFile())
            {
                if (destpath == "")
                {
                    //把srcfile放到根目录
                    zip.AddFile(srcfile);
                }
                else
                {
                    //把srcfile放到destpath文件夹下
                    zip.AddFile(srcfile, destpath);
                }

                //把zip档案保存为zipfile
                zip.Save(zipfile);
            }


        }


        /// <summary>
        /// 压缩多个文件
        /// </summary>
        /// <param name="zipfile"></param>
        /// <param name="srcfile"></param>
        /// <param name="destpath"></param>
        public static void ZipFiles(string zipfile, List<string> lstsrc, string destpath = "")
        {
            if (lstsrc.Count > 0)
            {
                using (ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    foreach (string file in lstsrc)
                    {
                        if (destpath == "")
                        {
                            //把srcfile放到根目录
                            zip.AddFile(file);
                        }
                        else
                        {
                            //把srcfile放到destpath文件夹下
                            zip.AddFile(file, destpath);
                        }
                    }
                    //把zip档案保存为zipfile
                    zip.Save(zipfile);
                }
            }

        }

        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="zipfile"></param>
        /// <param name="destpath"></param>
        public static void UnZip(string zipfile, string destpath)
        {
            using (ZipFile zip = new ZipFile(zipfile, System.Text.Encoding.UTF8))
            {
                zip.ExtractAll(destpath, ExtractExistingFileAction.OverwriteSilently);
            }
        }


        public static void UnZipFile(string zipfile, string destpath, bool overWrite)
        {
            ReadOptions options = new ReadOptions();
            options.Encoding = Encoding.Default;//设置编码，解决解压文件时中文乱码
            //设置编码，解决解压文件时中文乱码
            using (ZipFile zip = Ionic.Zip.ZipFile.Read(zipfile, options))
            {
                foreach (var entry in zip)
                {
                    entry.Extract(destpath, overWrite
                        ? ExtractExistingFileAction.OverwriteSilently
                        : ExtractExistingFileAction.DoNotOverwrite);
                }
            }
        }
    }
}
