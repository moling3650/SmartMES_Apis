using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BSubReport
    {
        public int Uid { get; set; }
        public string ReportCode { get; set; }
        public string BtnText { get; set; }
        public string Sql { get; set; }
        public string Description { get; set; }
    }
}
