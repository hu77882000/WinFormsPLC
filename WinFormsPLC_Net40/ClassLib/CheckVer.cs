using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Services.Description;

namespace WinFormsPLC_Net40
{
    class CheckVer
    {
        public string GetServiceVer()
        {
            WebReference.WebService updateService = new WebReference.WebService();
            string ver = updateService.getver();
            return ver;
        }
    }
}
