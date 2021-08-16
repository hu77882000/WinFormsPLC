using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsPLC_Net40.Model
{
  public  class Equipment_Directive
    {
        public string Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Creater { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isdelete { get; set; }
        public string DeviceType { get; set; }
        public string PerformName { get; set; }
        public string PerformContent { get; set; }
        public string PerformReturn { get; set; }
        public string PerformOrder { get; set; }
        public string PerformEnable { get; set; }
    }
}
