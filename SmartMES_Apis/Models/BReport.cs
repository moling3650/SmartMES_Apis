using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BReport
    {
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public int QueryType { get; set; }
        public string QuerySql { get; set; }
    }
}
