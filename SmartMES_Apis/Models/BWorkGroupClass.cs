using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BWorkGroupClass
    {
        public int Cid { get; set; }
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public string GroupCode { get; set; }
        public int? DayStart { get; set; }
        public string TimeStart { get; set; }
        public int? DayEnd { get; set; }
        public string TimeEnd { get; set; }
    }
}
