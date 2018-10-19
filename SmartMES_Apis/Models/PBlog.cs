using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PBlog
    {
        public int LogIdt { get; set; }
        public string LogPosition { get; set; }
        public string LogText { get; set; }
        public DateTime? LogTime { get; set; }
        public string Remarks { get; set; }
        public string LogType { get; set; }
    }
}
