using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPLC_Net40
{
    public static class Public_Class_Method
    {
        public static bool IsCanConnect(string url)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            bool CanCn = true;   //设成可以连接； 
            try
            {
                req = (HttpWebRequest)WebRequest.Create(url);
                res = (HttpWebResponse)req.GetResponse();
            }
            catch (Exception)
            {
                CanCn = false;   //无法连接 
            }
            finally
            {
                if (res != null)
                {
                    res.Close();
                }
            }
            return CanCn;
        }
    }
}
